using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Login;
using Login.Models;
using System;
using System.IO;
using System.Linq;
using System.Text;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

public class DocPdfService
{
    public static List<TraCuuC12Models> ExtractToExcel(byte[] pdfData, int thang, int nam)
    {
        //using var content = new MultipartFormDataContent();
        //content.Add(new ByteArrayContent(pdfData), "file", "file.pdf");

        double[] colCoords = { 30, 86, 235, 302, 369, 436, 503, 573 };
        double gapTolerance = 2.0;
        double colMatchTol = 8.0;
        double startY_Page1 = 571.0;
        double endY_PageN = 683.0;
        double yTol = 2.0;
        double yMergeTol = 10.0;
        string[] noiDung =
        {
            "Kỳ trước mang sang",
            "Số lao động",
            "Phải đóng",
            "Thừa",
            "Thiếu",
            "Thiếu lãi",
            "Phát sinh trong kỳ",
            "Số lao động",
            "Tăng",
            "Giảm",
            "Quỹ lương",
            "Tăng",
            "Giảm",
            "Phải đóng",
            "Tăng",
            "Giảm",
            "Điều chỉnh phải đóng kỳ trước",
            "Tăng",
            "Trong đó: năm trước",
            "Giảm",
            "Trong đó: năm trước",
            "Điều chỉnh",
            "Lãi",
            "Số tiền tính lãi",
            "Tỷ lệ tính lãi",
            "Tổng tiền lãi",
            "Số tiền đã nộp trong kỳ",
            "+ UNC số 04261, Ngày 29/07/2025",
            "Phân bổ tiền đóng",
            "Phải đóng",
            "Tiền lãi",
            "Chuyển kỳ sau",
            "Số lao động",
            "Phải đóng",
            "Thừa",
            "Thiếu",
            "Thiếu lãi"
        };
        

        using var doc = PdfDocument.Open(pdfData);
        List<TraCuuC12Models> list = new List<TraCuuC12Models>();
        int outRow = 1;
        int pageNo = 1;
        int tmp = 0;
        foreach (var page in doc.GetPages())
        {
            var wordsAll = page.GetWords().ToList();
            if (!wordsAll.Any()) { pageNo++; continue; }

            double topLimit = (pageNo == 1) ? startY_Page1 : double.MaxValue;
            double bottomLimit = (pageNo == 1) ? double.MinValue : endY_PageN;

            var words = wordsAll
                .Where(w => w.BoundingBox.Top <= topLimit && w.BoundingBox.Bottom >= bottomLimit)
                .ToList();

            if (!words.Any()) { pageNo++; continue; }

            // Gom thành dòng theo Y
            var lines = new List<(double y, List<Word> words)>();
            foreach (var w in words)
            {
                double yCenter = (w.BoundingBox.Top + w.BoundingBox.Bottom) / 2.0;
                var g = lines.FirstOrDefault(x => Math.Abs(x.y - yCenter) <= yTol);
                if (g.words != null)
                    g.words.Add(w);
                else
                    lines.Add((yCenter, new List<Word> { w }));
            }

            // Sắp xếp từ trên xuống
            var orderedLines = lines.OrderByDescending(l => l.y).ToList();

            for (int i = 0; i < orderedLines.Count; i++)
            {
                var baseLine = orderedLines[i];
                var mergedRow = ExtractRow(baseLine.words, colCoords, gapTolerance, colMatchTol);

                int j = i + 1;

                while (j < orderedLines.Count && (baseLine.y - orderedLines[j].y) <= yMergeTol)
                {
                    var nextLine = orderedLines[j];
                    var nextRow = ExtractRow(nextLine.words, colCoords, gapTolerance, colMatchTol);

                    // Merge từng cột
                    for (int c = 0; c < mergedRow.Length; c++)
                    {
                        if (string.IsNullOrWhiteSpace(mergedRow[c]) && !string.IsNullOrWhiteSpace(nextRow[c]))
                            mergedRow[c] = nextRow[c];
                        else if (!string.IsNullOrWhiteSpace(mergedRow[c]) && !string.IsNullOrWhiteSpace(nextRow[c]))
                            mergedRow[c] = (mergedRow[c] + " " + nextRow[c]).Trim();
                    }

                    // Cập nhật lại baseLine.y để so sánh tiếp với dòng sau
                    baseLine = nextLine;
                    j++;
                }

                // Bỏ qua các dòng đã merge
                i = j - 1;

                // Ghi ra Excel
                bool any = mergedRow.Any(x => !string.IsNullOrWhiteSpace(x));
                if (any)
                {
                    var item = new TraCuuC12Models
                    {
                        STT = mergedRow.ElementAtOrDefault(0),
                        NoiDung = noiDung[tmp],
                        BHXH_OD_TS = mergedRow.ElementAtOrDefault(2),
                        BHXH_HTTT = mergedRow.ElementAtOrDefault(3),
                        BHYT = mergedRow.ElementAtOrDefault(4),
                        BHTN = mergedRow.ElementAtOrDefault(5),
                        BHTNLD_BNN = mergedRow.ElementAtOrDefault(6),
                        Cong = mergedRow.ElementAtOrDefault(7),
                        Date = new DateTime(nam, thang, 1),
                        userName = AppState.UserName,
                        Level = tmp
                    };
                    list.Add(item);

                    
                    tmp++;
                }
            }

            pageNo++;
        }
        

        return list;
    }

    private static string[] ExtractRow(List<Word> lineWords, double[] colCoords, double gapTolerance, double colMatchTol)
    {
        var rowData = new string[colCoords.Length];
        var words = lineWords.OrderBy(w => w.BoundingBox.Left).ToList();

        // Ghép các word gần nhau
        var phrases = new List<(double xLeft, double xRight, string text)>();
        string curText = null;
        double curLeft = 0, curRight = 0;

        foreach (var w in words)
        {
            double wLeft = w.BoundingBox.Left;
            double wRight = w.BoundingBox.Right;
            string wText = (w.Text ?? "").Trim();

            if (string.IsNullOrEmpty(wText)) continue;

            if (curText == null)
            {
                curText = wText;
                curLeft = wLeft;
                curRight = wRight;
            }
            else
            {
                if (wLeft - curRight <= gapTolerance)
                {
                    curText += " " + wText;
                    curRight = wRight;
                }
                else
                {
                    phrases.Add((curLeft, curRight, curText));
                    curText = wText;
                    curLeft = wLeft;
                    curRight = wRight;
                }
            }
        }
        if (curText != null)
            phrases.Add((curLeft, curRight, curText));

        // Map phrases vào cột
        foreach (var p in phrases)
        {
            double center = (p.xLeft + p.xRight) / 2.0;
            double right = p.xRight;
            bool mapped = false;

            if (Math.Abs(center - colCoords[0]) <= colMatchTol)
            {
                rowData[0] = AppendSafe(rowData[0], p.text);
                mapped = true;
            }
            else
            {
                for (int ci = 1; ci < colCoords.Length; ci++)
                {
                    if (Math.Abs(right - colCoords[ci]) <= colMatchTol)
                    {
                        rowData[ci] = AppendSafe(rowData[ci], p.text);
                        mapped = true;
                        break;
                    }
                }
            }
        }

        return rowData;
    }


    static string AppendSafe(string prev, string next)
    {
        if (string.IsNullOrWhiteSpace(prev)) return next;
        return prev + " " + next;
    }
    public static string ExtractTableFixedByY(string path)
    {
        var sb = new StringBuilder();
        using var doc = PdfDocument.Open(path);

        int pageNum = 1;

        foreach (var page in doc.GetPages())
        {
            var words = page.GetWords().ToList();
            if (!words.Any()) continue;

            double topLimit = double.MaxValue;
            double bottomLimit = double.MinValue;

            // --- cấu hình vùng đọc theo trang ---
            if (pageNum == 1)
            {
                // trang 1: bắt đầu từ hàng "A" (Y2 ≈ 571)
                topLimit = 571.0;
                bottomLimit = 0; // đến hết trang
            }
            else
            {
                // các trang sau: bắt đầu từ đầu trang, kết thúc ở "Thiếu lãi" (Y1 ≈ 683)
                topLimit = 9999; // đầu trang
                bottomLimit = 683.0;
            }

            // --- lọc word trong vùng bảng ---
            var tableWords = words
                .Where(w => w.BoundingBox.Top <= topLimit && w.BoundingBox.Bottom >= bottomLimit)
                .ToList();

            // --- gom dòng theo Y ---
            double yTol = 2.0;
            var lineGroups = new List<(double y, List<UglyToad.PdfPig.Content.Word> list)>();

            foreach (var w in tableWords)
            {
                double yCenter = (w.BoundingBox.Top + w.BoundingBox.Bottom) / 2.0;
                var group = lineGroups.FirstOrDefault(g => Math.Abs(g.y - yCenter) <= yTol);

                if (group.list != null)
                    group.list.Add(w);
                else
                    lineGroups.Add((yCenter, new List<UglyToad.PdfPig.Content.Word> { w }));
            }

            // --- xuất ra text ---
            foreach (var g in lineGroups.OrderByDescending(g => g.y))
            {
                var lineWords = g.list.OrderBy(w => w.BoundingBox.Left)
                                      .Select(w => w.Text);
                sb.AppendLine(string.Join(" ", lineWords));
            }

            sb.AppendLine($"---- END PAGE {pageNum} ----\n");
            pageNum++;
        }

        return sb.ToString();
    }
    public static string DumpPdfTextWithCoordinates(string pdfPath, string outputPath = null)
    {
        var sb = new StringBuilder();

        using var document = PdfDocument.Open(pdfPath);
        int pageNumber = 1;

        foreach (var page in document.GetPages())
        {
            sb.AppendLine($"--- PAGE {pageNumber} ---");
            var words = page.GetWords().ToList();

            foreach (var word in words.OrderByDescending(w => w.BoundingBox.Top))
            {
                sb.AppendLine(
                    $"{word.Text,-20} | " +
                    $"X1: {word.BoundingBox.Left,6:F1} | " +
                    $"X2: {word.BoundingBox.Right,6:F1} | " +
                    $"Y1: {word.BoundingBox.Bottom,6:F1} | " +
                    $"Y2: {word.BoundingBox.Top,6:F1}"
                );
            }

            sb.AppendLine();
            pageNumber++;
        }

        // Nếu có truyền outputPath thì ghi ra file
        if (!string.IsNullOrEmpty(outputPath))
        {
            File.WriteAllText(outputPath, sb.ToString(), Encoding.UTF8);
        }

        return sb.ToString();
    }
}

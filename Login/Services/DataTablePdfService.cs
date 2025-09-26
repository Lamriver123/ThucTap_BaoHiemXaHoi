using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Login.Services
{
    public class DataTablePdfService
    {
        private readonly HttpClient _httpClient;

        public DataTablePdfService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5001")
            };
        }

        public async Task<List<TraCuuC12Models>> ExtractTableAsync(byte[] pdfData)
        {
            using var content = new MultipartFormDataContent();
            content.Add(new ByteArrayContent(pdfData), "file", "file.pdf");

            var response = await _httpClient.PostAsync("/extract-table", content);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<List<List<string>>>();

            List<TraCuuC12Models> list = new List<TraCuuC12Models>();

            if (result != null && result.Count > 0)
            {
                // Nếu dòng đầu tiên là header thì bỏ qua
                for (int i = 1; i < result.Count; i++)
                {
                    var row = result[i];
                    TraCuuC12Models item = new TraCuuC12Models();

                    item.STT = row[0];

                    item.NoiDung = row[1];
                    
                    item.BHXH_OD_TS = row[2];

                    item.BHXH_HTTT = row[3];

                    item.BHYT = row[4];

                    item.BHTN = row[5];

                    item.BHTNLD_BNN = row[6];

                    item.Cong = row[7];

                    list.Add(item);
                }
            }

            return list;
        }

    }
}

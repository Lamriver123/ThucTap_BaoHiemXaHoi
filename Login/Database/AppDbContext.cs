using Login.Models;
using Login.Views.TraCuu;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Database
{
    internal class AppDbContext : DbContext
    {
        public DbSet<TraCuuC12Models> TraCuuC12 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-8RK3BU5;Database=thuc_tap;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        public bool CheckTraCuuC12Exists(DateTime date, string userName)
        {
            return TraCuuC12.Any(x =>
                x.Date.Year == date.Year &&
                x.Date.Month == date.Month &&
                x.userName == userName);
        }

        public void DeleteTraCuuC12ByMonth(DateTime date, string userName)
        {
            var data = TraCuuC12.Where(x =>
                x.Date.Year == date.Year &&
                x.Date.Month == date.Month &&
                x.userName == userName);

            if (!data.Any())
                return; // Không có dữ liệu để xóa

            TraCuuC12.RemoveRange(data);
            SaveChanges(); // Trả về số bản ghi bị xóa
        }
    }
}

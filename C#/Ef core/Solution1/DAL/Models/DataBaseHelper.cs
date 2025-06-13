using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DAL.Models
{
    public static class DatabaseHelper
    {
        public static string GetConnectionString()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("AppSetting.json", optional: true, reloadOnChange: true);
            string connectionString = builder.Build().GetConnectionString("EventDB");
            return connectionString;
        }
        //public static string GetConnectionString()
        //{
        //    var path = Directory.GetCurrentDirectory();
        //    Console.WriteLine("Current Directory: " + path);

        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(path)
        //        .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true);

        //    var config = builder.Build();
        //    string connStr = config.GetConnectionString("EventDB");

        //    Console.WriteLine("Connection String: " + connStr);

        //    return connStr;
        //}

    }
}

using PlugDFe.Infra.Database;
using System;

namespace PlugDFe.Infra.Repositories
{
    public abstract class Repository
    {
        protected DatabaseConnection DatabaseConnection { get; set; }
        protected string SQL { get; set; }

        public Repository(DatabaseConnection databaseConnection)
        {
            DatabaseConnection = databaseConnection;
            SQL = "";
        }

        public string FormatFullDate(DateTime date)
        {
            string formatedDate = $"{date.Year.ToString("0000")}" +
                "-" +
                $"{date.Month.ToString("00")}" +
                "-" +
                $"{date.Day.ToString("00")}" +
                " " +
                $"{date.Hour.ToString("00")}" +
                ":" +
                $"{date.Minute.ToString("00")}" +
                ":" +
                $"{date.Second.ToString("00")}";

            return formatedDate;
        }

        public string FormatShortDate(DateTime date)
        {
            string formatedDate = $"{date.Year.ToString("0000")}-{date.Month.ToString("00")}-{date.Day.ToString("00")}";

            return formatedDate;
        }
    }
}

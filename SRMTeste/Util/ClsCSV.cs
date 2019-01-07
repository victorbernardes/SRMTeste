using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace SRMTeste.Util
{
    public static class ClsCSV
    {
        public static DataTable LerCSV(string caminho)
        {
            StreamReader sr = new StreamReader(caminho);
            string[] headers = sr.ReadLine().Split(';');
            DataTable dt = new DataTable();
            foreach (string header in headers)
            {
                dt.Columns.Add(header);
            }
            while (!sr.EndOfStream)
            {
                string[] rows = sr.ReadLine().Split(';');
                DataRow dr = dt.NewRow();
                for (int i = 0; i < headers.Length; i++)
                {
                    dr[i] = rows[i];
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}


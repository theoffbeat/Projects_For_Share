using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;

namespace DownloadEquties
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable() { TableName = "Stock Data" };
            dt.Clear();

            dt.Columns.Add("Date");
            dt.Columns.Add("Open");
            dt.Columns.Add("High");
            dt.Columns.Add("Low");
            dt.Columns.Add("Close");
            dt.Columns.Add("Volume");
            
            Download();

            string path = Path.Combine(Directory.GetCurrentDirectory(), "\\temp.json");
            string json = File.ReadAllText(path);

            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            var jss = new JavaScriptSerializer();
            dict = jss.Deserialize<Dictionary<string, dynamic>>(json);

            List<string> times = new List<string>();

            foreach (KeyValuePair<string, dynamic> item in dict["Time Series (1min)"])
            {
                times.Add(item.Key);
            }

            List<float> openList = new List<float>();
            List<string> highList = new List<string>();
            List<string> lowList = new List<string>();
            List<string> closeList = new List<string>();
            List<string> volumeList = new List<string>();

            for (int i = 0; i < times.Count; i++)
            {
                foreach (KeyValuePair<string, dynamic> item in dict["Time Series (1min)"][times[i]])
                {
                    if (item.Key == "1. open")
                    {
                        string temp = item.Value;
                        float hold = float.Parse(temp);
                        openList.Add(hold);

                    }

                    if (item.Key == "2. high")
                    {
                        highList.Add(item.Value);
                    }

                    if (item.Key == "3. low")
                    {
                        lowList.Add(item.Value);
                    }

                    if (item.Key == "4. close")
                    {
                        closeList.Add(item.Value);
                    }

                    if (item.Key == "5. volume")
                    {
                        volumeList.Add(item.Value);
                    }
                }
            }

            DataRow timeRow;
            for (int i = 0; i < times.Count; i++)
            {
                timeRow = dt.NewRow();
                timeRow["Date"] = times[i];
                timeRow["Open"] = openList[i];
                timeRow["High"] = highList[i];
                timeRow["Low"] = lowList[i];
                timeRow["Close"] = closeList[i];
                timeRow["Volume"] = volumeList[i];

                dt.Rows.Add(timeRow);
            }

            dt.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\\dataTable.xml");


            //Sorting
            DataView dv = dt.DefaultView;
            dv.Sort = "Close desc";
            DataTable sorted = dv.ToTable();

            sorted.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\\dataTableSorted.xml");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        public static string SelectStock()
        {
            Console.WriteLine("Enter in stock:");
            string stock = Console.ReadLine();
            StringBuilder sb =
                new StringBuilder("https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol=");
            sb.Append(stock.ToUpper());
            sb.Append("&interval=1min&apikey=API_KEY");
            return sb.ToString();
        }

        public static string Download()
        {
            StreamWriter myStreamWriter;

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "\\temp.json");

            string jsonData;

            using (var webClient = new System.Net.WebClient())
            {
                jsonData = webClient.DownloadString(SelectStock());
                myStreamWriter = new StreamWriter(path);
                myStreamWriter.WriteLine(jsonData);
            }

            myStreamWriter.Flush();
            myStreamWriter.Close();

            jsonData = File.ReadAllText(path);

            return jsonData;
        }
    }
}

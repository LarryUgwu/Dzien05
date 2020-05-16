using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StooqParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now.AddMonths(-1);
            dtStop.Value = DateTime.Now;
            chrData.Series.Clear();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            //https://stooq.pl/q/d/l/?s=cdr&d1=20200501&d2=20200515&i=d

            String ticker = tbPicker.Text.ToLower();
            String d1 = dtStart.Value.ToString("yyyyMMdd");
            String d2 = dtStop.Value.ToString("yyyyMMdd");
            String url = String.Format("https://stooq.pl/q/d/l/?s={0}&d1={1}&d2={2}&i=d",
                                                    ticker, d1, d2);

            dgvData.Columns.Clear();
            dgvData.Columns.Add("DATE", "Data");
            dgvData.Columns.Add("CLOSE", "Kurs zamknięcia");
            dgvData.Columns.Add("VOLUME", "Wolumen");

            dgvData.Columns[0].Width = 100;
            dgvData.Columns[1].Width = 200;
            dgvData.Columns[2].Width = 100;

            try
            {
                WebClient webClient = new WebClient();
                String s = webClient.DownloadString(url);
                string[] lines = s.Split('\n');

                for (int i = 1; i < lines.Length; i++)
                {
                    String line = lines[i];
                    string[] items = line.Trim().Split(',');
                    if(items.Length==6)
                    {
                        string[] row = new string[]
                        {
                            items[0], items[4], items[5]
                        };
                        dgvData.Rows.Add(row);
                    }

                }

            }catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}

using EasyHttp.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVE市场小精灵
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        public class FileListenerServer
        {
            private FileSystemWatcher _watcher;
            private Main main;
         
            public FileListenerServer()
            {
            }
            public FileListenerServer(string path, Main main)
            {

                try
                {

                    this._watcher = new FileSystemWatcher();
                    _watcher.Path = path;
                    _watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size | NotifyFilters.DirectoryName;
                    _watcher.IncludeSubdirectories = true;
                    _watcher.Created += new FileSystemEventHandler(FileWatcher_Created);
                    this._watcher.EnableRaisingEvents = true;

                }

                catch (Exception ex)
                {
                    MessageBox.Show("无法获取您的EVE缓存目录\r\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                main.groupBox2.Hide();
                this.main = main;
            }
            protected void FileWatcher_Created(object sender, FileSystemEventArgs e)
            {

                string[] names = e.Name.Split('-');
                main.lab_pos.Text = "您在" + names[0];
                main.lab_type.Text = "查看"+names[1];

                try
                {
                    main.groupBox2.Show();
                    string text = "";
                    using (FileStream fs = new FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        using (StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default))
                        {
                            text = sr.ReadToEnd();
                        }
                    }

                    Console.Write(e.FullPath);
                    string[] lines = text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    if (lines.Length < 2)
                    {
                        return;
                    }
                    int typeId = Convert.ToInt32(lines[1].Split(',')[2]);
                    double maxBuy = 0;
                    double minSell = 0;
                    for (int i = 1; i < lines.Length; i++)
                    {
                        if (!lines[i].Equals(String.Empty))
                        {
                            string[] line = lines[i].Split(',');
                            if (Convert.ToBoolean(line[7]))
                            {
                                // 收单
                                if (Convert.ToDouble(line[0]) > maxBuy)
                                {
                                    maxBuy = Convert.ToDouble(line[0]);
                                }
                            }
                            else
                            {
                                if (Convert.ToDouble(line[0]) < minSell || minSell == 0)
                                {
                                    minSell = Convert.ToDouble(line[0]);
                                }
                            }
                        }


                    }
                   
                    var http = new HttpClient();
                    var json = http.Get("https://www.ceve-market.org/tqapi/market/region/10000002/system/30000142/type/" + typeId + ".json").RawText;

                    JObject obj = (JObject)JsonConvert.DeserializeObject(json);
                    var jitaBuy = obj["buy"]["max"];
                    double jitaSell = Convert.ToDouble(obj["sell"]["min"]);
                    main.lab_l1.Text = names[0] + "收: " + string.Format("{0:N0}", maxBuy) + " ISK";
                    main.lab_l2.Text = names[0] + "卖: " + string.Format("{0:N0}", minSell) + " ISK";

                    if (minSell < jitaSell)
                    {
                        main.lab_l2.ForeColor = Color.Red;
                    }
                    else 
                    {
                        main.lab_l2.ForeColor = Color.Green;
                    }

                    main.lab_j1.Text = "吉他收: " + string.Format("{0:N0}", jitaBuy) + " ISK";
                    main.lab_j2.Text = "吉他卖: " + string.Format("{0:N0}", jitaSell) + " ISK";
                    main.lab_c1.Text = "差价: " + string.Format("{0:N0}", minSell - jitaSell) + " ISK";
                    main.lab_c2.Text = "差价: " + string.Format("{0:N0}", minSell / jitaSell * 100) + "%";
                    if (minSell < jitaSell)
                    {
                        // 本地比吉他便宜
                        main.lab_c1.ForeColor = Color.Red;
                        main.lab_c2.ForeColor = Color.Red;
                        

                    }
                    else 
                    {
                        main.lab_c1.ForeColor = Color.Green;
                        main.lab_c2.ForeColor = Color.Green;
                    }


                }
                catch (Exception ex) {
                    main.groupBox2.Hide();
                   
                }

            }
        }
  

        private void Main_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += "/EVE/logs/Marketlogs/";
            new FileListenerServer(path,this);
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}

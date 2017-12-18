using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JsonServicesTester
{



    public partial class FormJsonServiceTester : Form
    {
        public FormJsonServiceTester()
        {
            InitializeComponent();
        }


        private string selectedDirectory = Environment.CurrentDirectory;



        private void buttonGetJsonRequest_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            string appPath = GetBaseDirectory();


            openFileDialog1.RestoreDirectory = false;
            openFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog1.Title = "Please select JSON file";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    selectedDirectory = Path.GetDirectoryName(openFileDialog1.FileName);

                    textBoxJsonFileName.Text = openFileDialog1.FileName;
                    String textRequest = File.ReadAllText(openFileDialog1.FileName);
                    textRequest = textRequest.Replace("\t", "  ");
                    textRequest = textRequest.Replace("\n", "");
                    textBoxReguest.Text = JsonPrettify(textRequest);

                    string address = textBoxJsonFileName.Text + ".txt";

                    if (!File.Exists(address))
                    {
                        string fName = Path.GetFileName(textBoxJsonFileName.Text);
                        fName = fName.Substring(0, fName.Length - 5);
                        String[] f = fName.Split('_');
                        if (f.Count() >= 2)
                        {
                            fName = "/" + f[0] + "/" + f[1];
                        }

                        textBoxAddressLink.Text = fName;

                    }
                    else
                    {

                        textBoxAddressLink.Text = File.ReadAllText(address);


                    }
                    textBoxResponce.Text = "";
                    tabControl.SelectedTab = tabPageReguest;
                    /// textBoxReguest

                }
                catch (Exception ex)
                {
                    textBoxReguest.Text = ex.StackTrace;
                    tabControl.SelectedTab = tabPageResponce;

                }
            }
        }

        private static string GetBaseDirectory()
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);

            appPath = appPath.Replace(@"\bin\Debug", "") + @"\json\";
            return appPath;
        }

        private void FormBeproTest_Load(object sender, EventArgs e)
        {
            textBoxJsonFileName.Text = GetBaseDirectory();


            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            String baseAddress = appSettings[0];

            textBoxBaseAddress.Text = baseAddress;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            pictureBoxWait.Visible = false;
            buttonSendRequest.Text = "Send Request";

            tabControl.SelectedTab = tabPageResponce;
            textBoxResponce.Select(0, 0);
        }



        private void buttonSendRequest_Click(object sender, EventArgs e)
        {

            if (pictureBoxWait.Visible)
            {
                backgroundWorker1.CancelAsync();
                return;
            }

            int count = 0;

            int.TryParse(textBoxCount.Text, out count);

            if (count == 0) count = 1;

            textBoxCurrent.Text = "";

            isBasic_Autotication = checkBoxAuthorization.Checked;
            UserName_Authotication = textBoxUserName.Text;
            Password_Authontification = textBoxPassword.Text;


        SendReguests(count);
        }

        private void SendReguests(int count)
        {


            try
            {

                textBoxResponce.Text = "";
                SendParams sendParam = new SendParams()
                {
                    request = textBoxReguest.Text,
                    address = textBoxBaseAddress.Text + textBoxAddressLink.Text,
                    count = count,
                    responce = ""
                };


                backgroundWorker1.RunWorkerAsync(sendParam);
                pictureBoxWait.Visible = true;
                buttonSendRequest.Text = "Stop";
            }
            catch (Exception ex)
            {
                pictureBoxWait.Visible = true;
                buttonSendRequest.Text = "Send Request";
                textBoxResponce.Text = ex.StackTrace;
                tabControl.SelectedTab = tabPageResponce;
            }

        }

        public static string JsonPrettify(string json)
        {

            try
            {
                dynamic parsedJson = JsonConvert.DeserializeObject(json);
                return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);

            }
            catch (Exception ex)
            {
                return json;
            }
            return json;
        }


        private bool isBasic_Autotication { get; set; }
        private string UserName_Authotication { get; set; }  
        private string Password_Authontification { get; set;  }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


            SendParams sendParam = (SendParams)(e.Argument);
            string json = null;
            bool isError = false;

            for (int j = 0; j < sendParam.count; j++)
            {

                if (backgroundWorker1.CancellationPending)
                {
                    break;
                }

                try
                {


                    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(sendParam.address);
                    request.ContinueTimeout = 88000;
                    request.ContentType = "application/json; charset=utf-8";
                    request.Accept = "application/json, text/javascript, */*";
                    request.Method = "POST";
                    if (!isBasic_Autotication)
                    {
                        request.Credentials = CredentialCache.DefaultNetworkCredentials;
                    } else
                    {
                        String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(UserName_Authotication + ":" + Password_Authontification));
                        request.Headers.Add("Authorization", "Basic " + encoded);
                      //  request.Credentials = new NetworkCredential(UserName_Authotication, Password_Authontification);
                    }

                    using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
                    {
                        writer.Write(sendParam.request);
                    }

                    if (backgroundWorker1.CancellationPending)
                    {
                        break;
                    }

                    WebResponse response = request.GetResponse();
                    Stream stream = response.GetResponseStream();
                    json = "";

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        while (!reader.EndOfStream)
                        {
                            json += reader.ReadLine();
                        }
                    }

                    WorkReport report1 = new WorkReport
                    {
                        id = j + 1,
                        Report = json
                    };

                    backgroundWorker1.ReportProgress(j, report1);

                    sendParam.responce = json;


                }
                catch (Exception ex)
                {
                    sendParam.responce = ex.Message;
                    isError = true;
                    json = ex.Message;
                }
                backgroundWorker1.ReportProgress(j, json);
            }


            if (isError)
            {
                e.Result = sendParam.responce;
            }
            else
            {

                WorkReport report = new WorkReport
                {
                    id = sendParam.count,
                    Report = json
                };
                e.Result = report;
            }

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // QueryStaticTables  
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
            {
                WorkReport report = e.UserState as WorkReport;
                if (report != null)
                {
                    String json = JsonPrettify(report.Report);
                    textBoxResponce.Text = JsonPrettify(json);
                    textBoxCurrent.Text = report.id.ToString();
                } else
                {
                    String error = e.UserState as String;
                    textBoxResponce.Text = error;
                }
                tabControl.SelectedTab = tabPageResponce;
              
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            String newFileName = textBoxAddressLink.Text.Replace('/', '_') + "_V1.json";


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            string appPath = GetBaseDirectory();


            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = newFileName;
            saveFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string name = saveFileDialog1.FileName;

                File.WriteAllText(name, textBoxReguest.Text);


            }
        }

        private void checkBoxAuthorization_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;

                textBoxUserName.Enabled = chk.Checked;
                textBoxPassword.Enabled = chk.Checked;

        }
    }
}

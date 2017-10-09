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
            Stream myStream = null;
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
                        fName = "/" + fName.Replace("_", "/");
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

            }
            return json;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


            SendParams sendParam = (SendParams)(e.Argument);
            string json = null ;

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
                    request.Credentials = CredentialCache.DefaultNetworkCredentials;

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
                        id = j+1,
                        Report = json
                    };

                    backgroundWorker1.ReportProgress(j, report1);

                    sendParam.responce = json;


                }
                catch (Exception ex)
                {
                    sendParam.responce = ex.Message;
                }
                backgroundWorker1.ReportProgress(j, json);
            }

            WorkReport report = new WorkReport
            {
                id = sendParam.count,
                Report = json
            };

            e.Result = report;

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
                    tabControl.SelectedTab = tabPageResponce;
                    textBoxCurrent.Text = report.id.ToString();
                }
            }
        }
    }
}

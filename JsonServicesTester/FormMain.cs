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


namespace BeproDB_Test
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

            openFileDialog1.InitialDirectory = selectedDirectory;
            openFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog1.Title = "Please select JSON file";
            openFileDialog1.FilterIndex = 2;
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

            appPath = appPath.Replace(@"\bin\Debug","") + @"\json\";
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
            SendParams sendParam = (SendParams)(e.Result);

            pictureBoxWait.Visible = false;
            buttonSendRequest.Enabled = true;
            textBoxResponce.Text = JsonPrettify(sendParam.responce);
            tabControl.SelectedTab = tabPageResponce;
            textBoxResponce.Select(0, 0);
        }

        private void buttonSendRequest_Click(object sender, EventArgs e)
        {
            try
            {

                textBoxResponce.Text = "";
                SendParams sendParam = new SendParams()
                {
                    request = textBoxReguest.Text,
                    address = textBoxBaseAddress.Text + textBoxAddressLink.Text,
                    responce = ""
                };

                backgroundWorker1.RunWorkerAsync(sendParam);
                pictureBoxWait.Visible = true;
                buttonSendRequest.Enabled = false;
            } catch ( Exception ex)
            {
                pictureBoxWait.Visible = true;
                buttonSendRequest.Enabled = false;
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
     
            } catch ( Exception ex)
            {

            }
            return json;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


            SendParams sendParam = (SendParams)(e.Argument);


            try
            {


                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(sendParam.address);
                request.ContinueTimeout = 88000;
                request.ContentType = "application/json; charset=utf-8";
                request.Accept = "application/json, text/javascript, */*";
                request.Method = "POST";
                using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
                {
                    writer.Write(sendParam.request);
                }

                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                string json = "";

                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        json += reader.ReadLine();
                    }
                }

                sendParam.responce = json;


            } catch ( Exception ex)
            {
                sendParam.responce = ex.Message;
            }

            e.Result = sendParam;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // QueryStaticTables  
        }
    }
}

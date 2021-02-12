using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace EthernetTest
{
    public partial class Form1 : Form
    {
        static string init;
        static string folderPath = "";
        static string absFilePath;
        static string raw_date;
        string connectStatusPort1 = string.Empty;
        string connectStatusPort2 = string.Empty;


        [STAThread]
        public static void Main()
        {
            //begin application
            Application.EnableVisualStyles();
            Application.Run(new Form1());
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
        }

        public Form1()
        {
            InitializeComponent();
            raw_date = DateTime.Now.ToString()+"/r/n";
            connectButton1.Enabled = false;
            connectButton2.Enabled = false;
        }

        //redundant code
        private void connectButton1_Click(object sender, EventArgs e)
        {
            string s = "192.168.1.120";
            string output = Ping(s);
            ethernetOn1.Text = "";
            connectStatusPort1 = "";
            if (output.Length > 60)
            {
                ethernetOn1.Text = "Ethernet is connected";
                ethernetOn1.ForeColor = System.Drawing.Color.ForestGreen;
            }
            else if (output == "DestinationHostUnreachable" || output == "TimedOut")
            {
                output = "Address: " + s + "\r\nError: " + output;
                ethernetOn1.Text = "Ethernet is not connected";
                ethernetOn1.ForeColor = System.Drawing.Color.Red;
            }
            connectStatusPort1 = output;
            init += "Port 1: "+output+"\r\n";
        }

        private void connectButton2_Click(object sender, EventArgs e)
        {
            string s = "192.168.1.122";
            string output = Ping(s);
            ethernetOn2.Text = "";
            connectStatusPort2 = "";
            if (output.Length > 60)
            {
                ethernetOn2.Text = "Ethernet is connected";
                ethernetOn2.ForeColor = System.Drawing.Color.ForestGreen;
            }
            else if (output == "DestinationHostUnreachable" || output == "TimedOut")
            {
                output = "Address: " + s + "\r\nError: " + output;
                ethernetOn2.Text = "Ethernet is not connected";
                ethernetOn2.ForeColor = System.Drawing.Color.Red;
            }
            connectStatusPort2 = output;
            init += "Port 2: " + output + "\r\n";
        }

        private void checkIfWifiConnected(Button b)
        {
           string s = string.Empty;
           foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up)
                {
                    Console.WriteLine(ni.NetworkInterfaceType.ToString());
                    s = Regex.Replace(ni.NetworkInterfaceType.ToString(), @"[\d-]", string.Empty);
                    switch (s)
                    {
                        case "Wireless":
                            label1.Text = "Please disable your wifi.";
                            b.Enabled = false;
                            break;
                        case "Ethernet":
                            label1.Text = "Ethernet is connected";
                            b.Enabled = true;
                            continue;
                        default:
                            break;
                    }
                }
            }
        }

        //ping the ip address provided through the ethernet port
        private string Ping(string input)
        {
            Ping pingSender = new Ping();
            //check for invalid input
            if (input.Count(c => c == '.') != 3)
            {
                if (input == null || input == "")
                {
                    return ("Error: No IP address provided.");
                }
                return ("Error: An invalid IP was entered.");
            }
            try
            {
                IPAddress address = IPAddress.Parse(input);
                PingReply reply = pingSender.Send(address, 5);
                if (reply.Status == IPStatus.Success)
                {
                    string addr = "Address: " + reply.Address.ToString();
                    string rtt = "RoundTrip time: " + reply.RoundtripTime;
                    string ttl = "Time to live: " + reply.Options.Ttl;
                    string bs = "Buffer size: " + reply.Buffer.Length;
                    return addr + "\r\n" + rtt + "\r\n" + ttl  + "\r\n" + bs + "\r\n";
                }
                else
                {
                    return reply.Status.ToString();
                }
            }
            catch (Exception e)
            {
                if (e is PingException)
                {
                    return ("Error: Please re-enter IP");
                }
                else if (e is FormatException || e is ArgumentException)
                {
                    return ("Error: An invalid IP was entered.");
                }
                throw;
            }
        }

        //uncomment to add message after log
        static private void OnProcessExit(object sender, EventArgs e)
        {
            if (folderPath != "")
            {
                using (StreamWriter file = new StreamWriter(absFilePath))
                {
                    file.WriteLine(init);
                    file.WriteLine("Test Terminated: " + DateTime.Now.ToString());
                    file.Dispose();
                }
            }
           
        }

        static private void InitPath()
        {
            //grab the system date to create log
            string raw_date = DateTime.Now.ToString();
            string filename = "log_" + raw_date.Replace(" ", "_").Replace(":", ".").Replace("/", ".") + ".txt";
            init += "Device: " + Environment.MachineName + "\r\nTest Initialized: " + raw_date + "\r\n";
            absFilePath = Path.Combine(folderPath, filename);
        }

        private void changeDir_Click(object sender, EventArgs e)
        {
            DialogResult fileBrowse = folderBrowserDialog1.ShowDialog();
            if (fileBrowse == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
                currentDir.Text = folderPath;
                InitPath();
                changeDir.Text = "Change";
                changeDir.Update();
                //uncomment below to test wifi
                connectButton1.Enabled = true;
                connectButton2.Enabled = true;
            }
        }

        private void ipInputField1_Click(object sender, EventArgs e)
        {
            checkIfWifiConnected(connectButton1);
        }

        private void ipInputField2_Click(object sender, EventArgs e)
        {
            checkIfWifiConnected(connectButton2);
        }
    }
}
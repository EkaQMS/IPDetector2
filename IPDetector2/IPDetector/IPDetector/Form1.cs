using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace IPDetector
{
       
    public partial class Form1 : Form
    {
        Graphics drawArea;
        struct nodes
        {
            public String ipAddress;
            public String hostNamse;
            public String status;
        }
        //string[] JSonArray;
        public void MyJson(string[] JSonArray)
        {

        }      
        public Form1()
        {
            InitializeComponent();
            drawArea = MapBox.CreateGraphics();
            Control.CheckForIllegalCrossThreadCalls = false;
            SubnetBox.MaxLength = 11;         }

        Thread myThread = null;

        public void scan (string subnet)
        {
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            Pen blackPen = new Pen(Color.Black);
            Font myFont = new Font("Arial", 10);
            Ping ping;
            PingReply reply;
            IPAddress address;
            IPHostEntry host;
            nodes[] myNode = new nodes[254];
            MapBox.Visible = false;
            MapBox.Visible = true;
            int coor = 0;
            int j = 0;
            int totalNodes = 0;
            for (int i = 1; i <= 255; i++)
            {
                if (i <= 255)
                    label1.Text = "Checking " + SubnetBox.Text + "." + i;
                else
                {
                    StopButton.Enabled = true;
                StartButton.Enabled = false;
                SubnetBox.Enabled = false;
                SubnetBox.Text = "";
                label1.Text = "Finished";
               }
                string subnetn = "." + i.ToString();
                ping = new Ping();
                reply = ping.Send(subnet + subnetn, 10);
                if (i == 1)
                {
                    drawArea.FillEllipse(greenBrush, 150, 85, 25, 25);
                    drawArea.DrawString(subnet + "." + i.ToString(), myFont,Brushes.Black,new Point(125,90));
                }
                else
                {
                    if(reply.Status == IPStatus.Success)
                    {
                        try
                        {
                            j += 1;
                            address = IPAddress.Parse(subnet + subnetn);
                            host = Dns.GetHostEntry(address);
                            IPBox.AppendText(subnet + "\t" + subnetn + "\t" + host.HostName.ToString() + "\n");
                            Form1 form1 = new Form1();
                            myNode[j].ipAddress = subnet + subnetn;
                            myNode[j].hostNamse = host.HostName.ToLower();
                            myNode[j].status = "UP";
                                drawArea.DrawLine(blackPen, 160, 95, 30 + coor, 60 + coor);
                                drawArea.FillEllipse(greenBrush, 150, 85, 25, 25);
                                drawArea.DrawString("192.168.1.1", myFont, Brushes.Black, new Point(125, 90));
                                drawArea.FillEllipse(greenBrush, 20 + coor, 50 + coor, 25, 25);
                                drawArea.DrawString(subnet + "." + i.ToString(), myFont, Brushes.Black, new Point(20+coor, 50+coor));
                            coor += 30;
                        }
                        catch
                        {
                        }


                    }
                }
            }
            StartButton.Enabled = true;
            StopButton.Enabled = false;
            SubnetBox.Enabled = true;
            AboutApps.Enabled = true;
            SubnetBox.Text = "";
            label1.Text = "Finished";
            myThread.Abort();
        }
        private bool check()
        {
            if (SubnetBox.Text == "")
            {
                MessageBox.Show("Please input a valid first 9 digits of an IP");
                SubnetBox.Text = "";
                SubnetBox.Focus();
                return false;
            }
            else
                return true;
            return false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            if (check())
            {
                myThread = new Thread(() => scan(SubnetBox.Text));
                myThread.Start();
                
                if (myThread.IsAlive)
                {
                    StopButton.Enabled = true;
                    StartButton.Enabled = false;
                    SubnetBox.Enabled = false;
                    AboutApps.Enabled = false;
                }
            }
                    }

        private void StopButton_Click(object sender, EventArgs e)
        {
            myThread.Abort();
            StartButton.Enabled = true;
            StopButton.Enabled = false;
            SubnetBox.Enabled = true;
            AboutApps.Enabled = true;
            SubnetBox.Text = "";
            label1.Text = "Stopped";
        }

        private void SubnetBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IPBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AboutApps_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace IPDetector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            SubnetBox.MaxLength = 11;         }

        Thread myTherad = null;

        public void scan (string subnet)
        {
            Ping ping;
            PingReply reply;
            IPAddress address;
            IPHostEntry host;

            for (int i = 250; i < 255; i++)
            {
                try
                {
                    string subnetn = "." + i.ToString();
                    ping = new Ping();
                    reply = ping.Send(subnet + subnetn);

                    if (reply.Status == IPStatus.Success)
                    {
                        try
                        {
                            address = IPAddress.Parse(subnet + subnetn);
                            host = Dns.GetHostEntry(address);

                            IPBox.AppendText(subnet + "\t" + subnetn + "\t" + host.HostName.ToString() + "\t" + "UP\n");
                        }
                        catch
                        {
                        }
                    }
                    if (i < 254)
                        label1.Text = "Checking " + SubnetBox.Text + "." + i;
                    else
                    {
                        StopButton.Enabled = true;
                        StartButton.Enabled = false;
                        SubnetBox.Enabled = false;
                        SubnetBox.Text = "";
                        label1.Text = "Finished";
                    }
                }
                catch
                {

                }
                                    
            }
        }
        private bool check()
        {
            //check if subnet box empty
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
                myTherad = new Thread(() => scan(SubnetBox.Text));
                myTherad.Start();

                if (myTherad.IsAlive)
                {
                    StopButton.Enabled = true;
                    StartButton.Enabled = false;
                    SubnetBox.Enabled = false;
                }
            }
                    }

        private void StopButton_Click(object sender, EventArgs e)
        {
            //  myTherad.Suspend();
            myTherad.Abort();
            StartButton.Enabled = true;
            StopButton.Enabled = false;
            SubnetBox.Enabled = true;
            SubnetBox.Text = "";
            label1.Text = "Stopped";
        }
    }
}

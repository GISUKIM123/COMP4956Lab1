using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lab1_CSharp_version
{

    /// <summary>
    /// Name:       Lab 01
    /// Purpose:    Multithreads run based on user interface 
    /// Author:     Gisu Kim a00959494
    /// Date:       2017-10-10
    /// Updated by: 2017-10-10
    /// Based On:   Lab01
    /// What the superviosr should know: N/A
    /// </summary>
    public partial class Form1 : Form
    {
        public int numberOfThread, numberOfProcess, time;
        public List<Thread> threads;
        public List<RichTextBox> textboxs;
        public DateTime elapsedTime;
        /// <summary>
        /// Basic constructor
        /// </summary> 
        public Form1()
        {
            InitializeComponent();
            textboxs = new List<RichTextBox>();
            threads = new List<Thread>();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Creating a dialog with user interface and display it
        /// </summary> 
        /// <param name="sender">base class</param>
        /// <param name="e">Event arguments</param>
        private void startThreadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 thread_dialog = new Lab1_CSharp_version.Form2();
            thread_dialog.form1 = this;
            DialogResult dr = thread_dialog.ShowDialog(this);
        }

        /// <summary>
        /// Setup a number of textboxs and size and locate these in right place
        /// </summary> 
        public async Task SetupTextbox()
        {
            if (numberOfThread != 1)
            {
                for (int i = 0; i < numberOfThread; i++)
                {
                    RichTextBox textbox = new RichTextBox();
                    textbox.Multiline = true;
                    textbox.WordWrap = false;
                    textbox.Name = "richTextbox" + i;
                    textbox.Location = new Point((this.Width / numberOfThread)*i, 40);
                    textbox.Width = this.Width / numberOfThread;
                    textbox.Height = this.Height;
                    textbox.ScrollBars = RichTextBoxScrollBars.Vertical;
                    textbox.Visible = true;
                    textboxs.Add(textbox);
                    this.Controls.Add(textbox);
                }
            }
            else
            {
                RichTextBox textbox = new RichTextBox();
                textbox.Multiline = true;
                textbox.WordWrap = false;
                textbox.Visible = true;
                textbox.Location = new Point(0, 40);
                textbox.Width = this.Width;
                textbox.Height = this.Height;
                textbox.ScrollBars = RichTextBoxScrollBars.Vertical;
                this.Controls.Add(textbox);
                textboxs.Add(textbox);
            }
        }

        private object CountNumber(object i)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Creating a number of threads and run these with a thread function
        /// </summary> 
        public void CreateThread()
        {
            setupTimer();
            textboxs[0].AppendText("Thread started at " + DateTime.Now.ToString("hh:mm:ss"));
            if (numberOfThread != 1)
            {
                for (int i = 0; i < numberOfThread - 1; i++)
                {
                    int index = i;
                    Thread thread = new Thread(() => this.CountNumber(index));
                    thread.Start();
                }
            }
            else
            {
                //there is only one thread.
                Thread mainThread = Thread.CurrentThread;
            }
        }

        /// <summary>
        /// Setup a timer and start to count
        /// </summary> 
        public void setupTimer()
        {
            elapsedTime = DateTime.Now.AddMilliseconds(time * 1000);
            timer.Interval = time * 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(stopTimer);
        }

        /// <summary>
        /// triggered by EventHandler when time is out, stopping a timer
        /// </summary> 
        /// <param name="sender">base class</param>
        /// <param name="e">Event arguments</param>
        public void stopTimer(object sender, EventArgs e)
        {
            textboxs[0].AppendText( "\r\nThread ended at " + DateTime.Now.ToString("hh:mm:ss"));
            timer.Stop();
        }
        /// <summary>
        /// thread function, each thread run and start to count a number till timer is elapsed
        /// </summary> 
        /// <param name="index">determining in which textbox will be displayed</param>
        public void CountNumber(int index)
        {
            int counter = 0;
            if (numberOfThread != 1)
            {
                while (elapsedTime >= DateTime.Now)
                {
                    if (InvokeRequired)
                    {
                        Invoke(new MethodInvoker(delegate
                        {
                            this.textboxs[index + 1].AppendText(counter++ + " \r\n");
                            this.textboxs[index + 1].Focus();
                            this.textboxs[index + 1].ScrollToCaret();
                        }));
                    }
                }
            }
        }
    }
}

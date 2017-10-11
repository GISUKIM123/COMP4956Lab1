using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_CSharp_version
{
    public partial class Form2 : Form
    {
        public Form1 form1;
        /// <summary>
        /// Basic constructor
        /// </summary> 
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// exit a dialog
        /// </summary> 
        /// <param name="sender">base class</param>
        /// <param name="e">Event arguments</param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Rendering textboxs in right places and createing and running threads when a user press a button
        /// </summary> 
        /// <param name="sender">base class</param>
        /// <param name="e">Event arguments</param>
        private void button1_Click(object sender, EventArgs e)
        {
            form1.numberOfThread = (int) numberOfThreads.Value;
            form1.time = (int) time.Value;
            form1.textboxs.Clear();
            form1.threads.Clear();
            form1.SetupTextbox();
            form1.CreateThread();
            this.Close();
        }
    }
}

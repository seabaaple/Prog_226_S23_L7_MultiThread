using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Prog_226_S23_L7_MultiThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        } // Form1()

        async void LongTask()
        {
            DisplayToRTB("LongTask Started");

            await Task.Delay(4000);

            DisplayToRTB("LongTask Ended");

        }

        void LongProcess()
        {
            DisplayToRTB("LongProcess Started");

            //some code that takes long execution time 
            Thread.Sleep(4000); // hold execution for 4 seconds

            DisplayToRTB("LongProcessEnded");
        } // LongProcess

        void ShortProcess()
        {
            DisplayToRTB("ShortProcess Started");

            //do something here

            DisplayToRTB("ShortProcess Completed");
        } // ShortProcess()

        public void DisplayToRTB(string message)
        {
            rtbDisplay.Text += message;
            rtbDisplay.Text += "\n";
        } // DisplayToRTB

        private void btnExample1_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            DisplayToRTB("Start of Example");
            LongProcess();
            ShortProcess();
            DisplayToRTB("End of Example");

            sw.Stop();

            DisplayToRTB("-------------------" + sw.Elapsed.TotalSeconds.ToString());
        }

        private void btnAsync_Click(object sender, EventArgs e)
        {
            LongTask();
            ShortProcess();
        }
    } // class

} // namespace

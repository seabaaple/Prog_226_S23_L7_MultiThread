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

            // Two new topics
            // Returning a value async
            // Callback
            

        } // Form1()



        // ---------------- Returning Values - Start

        // A callback is when a method is called after another event finishes
        private async void btnCallBack_Click(object sender, EventArgs e)
        {
            //Task<int> task = Task.Run(async () =>
            //{
            //    DisplayToRTB("Task is running");
            //    await Task.Delay(3000);
            //    DisplayToRTB("Task is is finished");

            //    return 5000;
            //});

            //// The argument passed in, represents the value that is returned from the instanced Task
            //// you can get the result with the .Result property
            //await task.ContinueWith( returnedValueFromTask =>
            //{
            //    DisplayToRTB("Continue is running");
            //    int sum = returnedValueFromTask.Result + returnedValueFromTask.Result;
            //    DisplayToRTB("Continue is finished");
            //    DisplayToRTB(sum.ToString());
            //});

            // Super summed up callback
            Task doubleSum = Task.Run(async () => // Created a task
            {
                DisplayToRTB("Start Run");
                await Task.Delay(3000); // I delayed the task by 3 seconds
                return 2.5; // I returned a value of 2.5
            }).ContinueWith(async t => // I added a CALLBACK with .ContinueWith() directly to my original Task
            {
                DisplayToRTB("Start Sum");
                await Task.Delay(3000);
                DisplayToRTB( (t.Result * t.Result).ToString());// I squared the result and returned it
            });


            //int number = await task;

            //DisplayToRTB(number.ToString());
        }

        private async void btnReturnValue_Click(object sender, EventArgs e)
        {
            DisplayToRTB("Before we call our async method");
            // use await to let your async method return a specific type
            double sum = await AddNumbers(5, 5);

            DisplayToRTB("After we call");

            DisplayToRTB(sum.ToString());
        }

        // Make this async
        // It will return a Task<double>
        public async Task<double> AddNumbers(double number1, double number2)
        {
            Stopwatch sw = new Stopwatch();
            int sum = 0;

            sw.Start();
            await Task.Run(() =>
            {
                for (int i = 0; i < 5000000; i++)
                {
                    Random rand = new Random();
                    int randomNum1 = rand.Next(0, 2000);
                    Random rand2 = new Random(randomNum1);
                    int randomNum2 = rand.Next(0, randomNum1);
                    Random rand3 = new Random(randomNum2);
                    int randomNum3 = rand.Next(0, randomNum2);

                    sum += randomNum1;

                }
                DisplayToRTB("The for loop just stopped running");
            });
            sw.Stop();
            DisplayToRTB(sw.ElapsedMilliseconds.ToString());

            return sum;
        }



        public async void CallBackExample()
        {
            Task<int> call = Task.Run(async () =>
            {
                await Task.Delay(3000);
                return 10;
            });

            await call.ContinueWith(t =>
            {
                DisplayToRTB(t.Result + t.Result + "");
            });
        }


        public async Task<double> PerformMath(double num1, double num2)
        {

            await Task.Delay(5000);

            return num1 + num2;
        }

        public async void ExampleAsyncReturn()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            double value = await PerformMath(1, 2);
            sw.Stop();

            DisplayToRTB($"Time Elapsed: {sw.Elapsed.TotalSeconds} : Result: {value}");
        }

        // ----------------- Returning Values - End

        public void DisplayToRTB(string message)
        {
            rtbDisplay.Text += message + "\n";
        } // DisplayToRtb

        public void LongProcess()
        {
            DisplayToRTB("Long Process Started");

            // This is locking up the Main thread that the GUI is on
            Thread.Sleep(6000); // 1 thousand milliseconds equals 1 second

            DisplayToRTB("Long Process Ended");


        } // LongProcess

        // Create another method for ShortProcess()
        public void ShortProcess()
        {
            DisplayToRTB("Short Process Started");
            DisplayToRTB("Short Process Ended");
        } // ShortProcess()

        private void btnExample1_Click(object sender, EventArgs e)
        {
            ShortProcess();
            LongProcess();
            
        }

        // Build our async methods
        // async - method modifier - Tells the computer that a method runs in a special way
        // await
        // Tasks
        public async void LongAsync(int number)
        {
            DisplayToRTB($"LongAsync started : Thread {number}");

            // Replace Thread.Sleep with the async version
            
            await Task.Delay(4000);
            
            DisplayToRTB($"LongAsync Ended : Thread {number}");

        } // LongAsync

        private void btnAsync_Click(object sender, EventArgs e)
        {
            LongAsync(1);
            ShortProcess();
        } // btnAsync_Click

        private void btnMultiThread_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                LongAsync(i);
            }
        } // btnMultiThread_Click

        private void btnStopWatch_Click(object sender, EventArgs e)
        {
            LoopAsync();
        } // btnStopWatch_Click

        public void StopwatchExample()
        {
            Stopwatch sw = new Stopwatch();
            // Start my stopwatch
            sw.Start(); // Starts the stop watch

            int multiplier = 10 * 10 * 10 * 10 * 10 * 10;
            for (int i = 0; i < 100 * multiplier; i++)
            {
                Random rand = new Random();
                int randomNum1 = rand.Next(0, 1000000);
                Random rand2 = new Random(randomNum1);
                int randomNum2 = rand.Next(0, randomNum1);
                Random rand3 = new Random(randomNum2);
                int randomNum3 = rand.Next(0, randomNum2);

            }


            // Stop my stopwatch
            sw.Stop(); // Stops the stop watch

            DisplayToRTB(sw.ElapsedMilliseconds.ToString());
        } // Stopwatch Example

        public async void LoopAsync()
        {
            Stopwatch sw = new Stopwatch();
            // Start my stopwatch
            sw.Start(); // Starts the stop watch

            int multiplier = 10 * 10 * 10 * 10 * 10;

            await Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    Random rand = new Random();
                    int randomNum1 = rand.Next(0, 1000000);
                    Random rand2 = new Random(randomNum1);
                    int randomNum2 = rand.Next(0, randomNum1);
                    Random rand3 = new Random(randomNum2);
                    int randomNum3 = rand.Next(0, randomNum2);

                }
                DisplayToRTB("The for loop just stopped running");
            });

            // Stop my stopwatch
            sw.Stop(); // Stops the stop watch

            DisplayToRTB(sw.ElapsedMilliseconds.ToString());
        } // LoopAsync

        Action<int> loop = (s) =>
        {
            for (int i = 0; i < 100 * s; i++)
            {
                Random rand = new Random();
                int randomNum1 = rand.Next(0, 1000000);
                Random rand2 = new Random(randomNum1);
                int randomNum2 = rand.Next(0, randomNum1);
                Random rand3 = new Random(randomNum2);
                int randomNum3 = rand.Next(0, randomNum2);

            }
        };

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbDisplay.Text = "";
        }



        // Stopwatch : What is it and why is it so important
        // Stopwatch Object
        // stopwatch.Start()
        // stopwatch.Stop()
        // stopwatch.Elapsed.Milliseconds

        // -------------------


        //async void LongTask()
        //{
        //    DisplayToRTB("LongTask Started");

        //    await Task.Delay(4000);

        //    DisplayToRTB("LongTask Ended");

        //}

        //void LongProcess()
        //{
        //    DisplayToRTB("LongProcess Started");

        //    //some code that takes long execution time 
        //    Thread.Sleep(4000); // hold execution for 4 seconds

        //    DisplayToRTB("LongProcessEnded");
        //} // LongProcess

        //void ShortProcess()
        //{
        //    DisplayToRTB("ShortProcess Started");

        //    //do something here

        //    DisplayToRTB("ShortProcess Completed");
        //} // ShortProcess()



        //public void DisplayToRTB(string message)
        //{
        //    rtbDisplay.Text += message;
        //    rtbDisplay.Text += "\n";
        //} // DisplayToRTB

        //private void btnExample1_Click(object sender, EventArgs e)
        //{
        //    Stopwatch sw = new Stopwatch();

        //    sw.Start();

        //    DisplayToRTB("Start of Example");
        //    LongProcess();
        //    ShortProcess();
        //    DisplayToRTB("End of Example");

        //    sw.Stop();

        //    DisplayToRTB("-------------------" + sw.Elapsed.TotalSeconds.ToString());
        //}

        //private void btnAsync_Click(object sender, EventArgs e)
        //{
        //    LongTask();
        //    ShortProcess();
        //}
    } // class

} // namespace

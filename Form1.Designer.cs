namespace Prog_226_S23_L7_MultiThread
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btnExample1 = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.btnMultiThread = new System.Windows.Forms.Button();
            this.btnStopWatch = new System.Windows.Forms.Button();
            this.btnReturnValue = new System.Windows.Forms.Button();
            this.btnCallBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(466, 72);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(444, 411);
            this.rtbDisplay.TabIndex = 0;
            this.rtbDisplay.Text = "";
            // 
            // btnExample1
            // 
            this.btnExample1.Location = new System.Drawing.Point(70, 116);
            this.btnExample1.Name = "btnExample1";
            this.btnExample1.Size = new System.Drawing.Size(238, 48);
            this.btnExample1.TabIndex = 1;
            this.btnExample1.Text = "Run ( Sync )";
            this.btnExample1.UseVisualStyleBackColor = true;
            this.btnExample1.Click += new System.EventHandler(this.btnExample1_Click);
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(70, 221);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(238, 48);
            this.btnAsync.TabIndex = 2;
            this.btnAsync.Text = "Run ( ASync )";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // btnMultiThread
            // 
            this.btnMultiThread.Location = new System.Drawing.Point(70, 327);
            this.btnMultiThread.Name = "btnMultiThread";
            this.btnMultiThread.Size = new System.Drawing.Size(238, 48);
            this.btnMultiThread.TabIndex = 3;
            this.btnMultiThread.Text = "Run ( Multiple )";
            this.btnMultiThread.UseVisualStyleBackColor = true;
            this.btnMultiThread.Click += new System.EventHandler(this.btnMultiThread_Click);
            // 
            // btnStopWatch
            // 
            this.btnStopWatch.Location = new System.Drawing.Point(70, 435);
            this.btnStopWatch.Name = "btnStopWatch";
            this.btnStopWatch.Size = new System.Drawing.Size(238, 48);
            this.btnStopWatch.TabIndex = 4;
            this.btnStopWatch.Text = "Stopwatch Example";
            this.btnStopWatch.UseVisualStyleBackColor = true;
            this.btnStopWatch.Click += new System.EventHandler(this.btnStopWatch_Click);
            // 
            // btnReturnValue
            // 
            this.btnReturnValue.Location = new System.Drawing.Point(1019, 95);
            this.btnReturnValue.Name = "btnReturnValue";
            this.btnReturnValue.Size = new System.Drawing.Size(181, 51);
            this.btnReturnValue.TabIndex = 5;
            this.btnReturnValue.Text = "Return Value";
            this.btnReturnValue.UseVisualStyleBackColor = true;
            this.btnReturnValue.Click += new System.EventHandler(this.btnReturnValue_Click);
            // 
            // btnCallBack
            // 
            this.btnCallBack.Location = new System.Drawing.Point(1019, 186);
            this.btnCallBack.Name = "btnCallBack";
            this.btnCallBack.Size = new System.Drawing.Size(181, 51);
            this.btnCallBack.TabIndex = 6;
            this.btnCallBack.Text = "Callback";
            this.btnCallBack.UseVisualStyleBackColor = true;
            this.btnCallBack.Click += new System.EventHandler(this.btnCallBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 567);
            this.Controls.Add(this.btnCallBack);
            this.Controls.Add(this.btnReturnValue);
            this.Controls.Add(this.btnStopWatch);
            this.Controls.Add(this.btnMultiThread);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnExample1);
            this.Controls.Add(this.rtbDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnExample1;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Button btnMultiThread;
        private System.Windows.Forms.Button btnStopWatch;
        private System.Windows.Forms.Button btnReturnValue;
        private System.Windows.Forms.Button btnCallBack;
    }
}


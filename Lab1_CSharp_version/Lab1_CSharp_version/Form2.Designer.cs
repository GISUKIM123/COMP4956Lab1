namespace Lab1_CSharp_version
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfThreads = new System.Windows.Forms.NumericUpDown();
            this.time = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Threads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time to run (sec)";
            // 
            // numberOfThreads
            // 
            this.numberOfThreads.Location = new System.Drawing.Point(431, 104);
            this.numberOfThreads.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numberOfThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfThreads.Name = "numberOfThreads";
            this.numberOfThreads.Size = new System.Drawing.Size(120, 31);
            this.numberOfThreads.TabIndex = 2;
            this.numberOfThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(431, 243);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(120, 31);
            this.time.TabIndex = 3;
            this.time.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.numberOfThreads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberOfThreads;
        private System.Windows.Forms.NumericUpDown time;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
namespace AntiAFK
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            btnStart = new Button();
            btnStop = new Button();
            lblUserInput = new Label();
            lblUserInputHelper = new Label();
            statusBarMessage = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            statusBarTimer = new ToolStripStatusLabel();
            usrInput = new NumericUpDown();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usrInput).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(43, 113);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(145, 62);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_ClickAsync;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStop.Location = new Point(192, 113);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(145, 62);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += BtnStop_Click;
            // 
            // lblUserInput
            // 
            lblUserInput.AutoSize = true;
            lblUserInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserInput.Location = new Point(43, 23);
            lblUserInput.Name = "lblUserInput";
            lblUserInput.Size = new Size(294, 21);
            lblUserInput.TabIndex = 5;
            lblUserInput.Text = "How often (in minutes) should we move?";
            // 
            // lblUserInputHelper
            // 
            lblUserInputHelper.AutoSize = true;
            lblUserInputHelper.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserInputHelper.Location = new Point(102, 67);
            lblUserInputHelper.Name = "lblUserInputHelper";
            lblUserInputHelper.Size = new Size(154, 20);
            lblUserInputHelper.TabIndex = 6;
            lblUserInputHelper.Text = "Enter a number (1-19)";
            // 
            // statusBarMessage
            // 
            statusBarMessage.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            statusBarMessage.Name = "statusBarMessage";
            statusBarMessage.Padding = new Padding(20, 0, 0, 0);
            statusBarMessage.Size = new Size(155, 21);
            statusBarMessage.Text = "Click Start to begin";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusBarMessage, statusBarTimer });
            statusStrip1.Location = new Point(0, 201);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(376, 26);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += StatusStrip1_ItemClicked;
            // 
            // statusBarTimer
            // 
            statusBarTimer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusBarTimer.Margin = new Padding(30, 3, 0, 2);
            statusBarTimer.Name = "statusBarTimer";
            statusBarTimer.Size = new Size(65, 21);
            statusBarTimer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // usrInput
            // 
            usrInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usrInput.Location = new Point(43, 64);
            usrInput.Maximum = new decimal(new int[] { 19, 0, 0, 0 });
            usrInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            usrInput.Name = "usrInput";
            usrInput.Size = new Size(42, 29);
            usrInput.TabIndex = 7;
            usrInput.TextAlign = HorizontalAlignment.Center;
            usrInput.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 227);
            Controls.Add(usrInput);
            Controls.Add(lblUserInputHelper);
            Controls.Add(lblUserInput);
            Controls.Add(statusStrip1);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "App";
            Text = "Anti-AFK";
            Load += App_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usrInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Label lblUserInput;
        private Label lblUserInputHelper;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusBarMessage;
        private NumericUpDown usrInput;
        private ToolStripStatusLabel statusBarTimer;
        private System.Windows.Forms.Timer timer1;
    }
}
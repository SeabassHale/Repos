namespace AlarmApplication
{
    partial class Form1
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
            dateTimePicker1=new DateTimePicker();
            btnStart=new Button();
            btnStop=new Button();
            lblStatus=new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format=DateTimePickerFormat.Time;
            dateTimePicker1.Location=new Point(45, 12);
            dateTimePicker1.Name="dateTimePicker1";
            dateTimePicker1.Size=new Size(101, 23);
            dateTimePicker1.TabIndex=0;
            // 
            // btnStart
            // 
            btnStart.Location=new Point(12, 64);
            btnStart.Name="btnStart";
            btnStart.Size=new Size(75, 23);
            btnStart.TabIndex=1;
            btnStart.Text="Start";
            btnStart.UseVisualStyleBackColor=true;
            btnStart.Click+=btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location=new Point(102, 64);
            btnStop.Name="btnStop";
            btnStop.Size=new Size(75, 23);
            btnStop.TabIndex=2;
            btnStop.Text="Stop";
            btnStop.UseVisualStyleBackColor=true;
            btnStop.Click+=btnStop_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize=true;
            lblStatus.Location=new Point(75, 38);
            lblStatus.Name="lblStatus";
            lblStatus.Size=new Size(39, 15);
            lblStatus.TabIndex=3;
            lblStatus.Text="Status";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(197, 99);
            Controls.Add(lblStatus);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(dateTimePicker1);
            FormBorderStyle=FormBorderStyle.FixedDialog;
            Name="Form1";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Alarm";
            Load+=Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button btnStart;
        private Button btnStop;
        private Label lblStatus;
    }
}
using System.Text;

namespace Test
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Text.ASCIIEncoding asciiEncoding1 = new System.Text.ASCIIEncoding();
            System.Text.DecoderReplacementFallback decoderReplacementFallback1 = new System.Text.DecoderReplacementFallback();
            System.Text.EncoderReplacementFallback encoderReplacementFallback1 = new System.Text.EncoderReplacementFallback();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.radarPanel = new System.Windows.Forms.Panel();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.distance = new System.Windows.Forms.Label();
            this.rangeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.currentRange = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radarPanel
            // 
            this.radarPanel.BackColor = System.Drawing.Color.Black;
            this.radarPanel.Location = new System.Drawing.Point(95, 12);
            this.radarPanel.Name = "radarPanel";
            this.radarPanel.Size = new System.Drawing.Size(932, 493);
            this.radarPanel.TabIndex = 0;
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 500000;
            this.serialPort.DataBits = 8;
            this.serialPort.DiscardNull = false;
            this.serialPort.DtrEnable = false;
            this.serialPort.Encoding = asciiEncoding1;
            this.serialPort.Handshake = System.IO.Ports.Handshake.None;
            this.serialPort.NewLine = "\n";
            this.serialPort.Parity = System.IO.Ports.Parity.None;
            this.serialPort.ParityReplace = ((byte)(63));
            this.serialPort.PortName = "COM3";
            this.serialPort.ReadBufferSize = 4096;
            this.serialPort.ReadTimeout = -1;
            this.serialPort.ReceivedBytesThreshold = 1;
            this.serialPort.RtsEnable = false;
            this.serialPort.StopBits = System.IO.Ports.StopBits.One;
            this.serialPort.WriteBufferSize = 2048;
            this.serialPort.WriteTimeout = -1;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // distance
            // 
            this.distance.Font = new System.Drawing.Font("맑은 고딕 Semilight", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.distance.Location = new System.Drawing.Point(95, 588);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(320, 71);
            this.distance.TabIndex = 1;
            this.distance.Text = "연결 중..";
            this.distance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.distance.UseWaitCursor = true;
            this.distance.Click += new System.EventHandler(this.distance_Click);
            // 
            // rangeComboBox
            // 
            this.rangeComboBox.Font = new System.Drawing.Font("맑은 고딕 Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rangeComboBox.FormattingEnabled = true;
            this.rangeComboBox.Items.AddRange(new object[] {
            "20",
            "40",
            "60",
            "80",
            "100",
            "120",
            "140"});
            this.rangeComboBox.Location = new System.Drawing.Point(803, 589);
            this.rangeComboBox.Name = "rangeComboBox";
            this.rangeComboBox.Size = new System.Drawing.Size(190, 45);
            this.rangeComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(582, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "현재 범위";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(833, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "범위 선택";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(117, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "거리";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(862, 640);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "선택";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // currentRange
            // 
            this.currentRange.AutoSize = true;
            this.currentRange.Font = new System.Drawing.Font("맑은 고딕", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentRange.Location = new System.Drawing.Point(601, 588);
            this.currentRange.Name = "currentRange";
            this.currentRange.Size = new System.Drawing.Size(90, 72);
            this.currentRange.TabIndex = 7;
            this.currentRange.Text = "20";
            this.currentRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(306, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "각도";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 730);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentRange);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rangeComboBox);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.radarPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "하야세 유우카 카와이 ><";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel radarPanel;
        private System.IO.Ports.SerialPort serialPort;
        private Label distance;
        private Graphics graphic;
        private ComboBox rangeComboBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label currentRange;
        private int range;
        private Label label1;
    }
}
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // radarPanel
            // 
            this.radarPanel.BackColor = System.Drawing.Color.Black;
            this.radarPanel.Location = new System.Drawing.Point(95, 12);
            this.radarPanel.Name = "radarPanel";
            this.radarPanel.Size = new System.Drawing.Size(800, 500);
            this.radarPanel.TabIndex = 0;
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 9600;
            this.serialPort.DataBits = 8;
            this.serialPort.DiscardNull = false;
            this.serialPort.DtrEnable = false;
            this.serialPort.Encoding = asciiEncoding1;
            this.serialPort.Handshake = System.IO.Ports.Handshake.None;
            this.serialPort.NewLine = "\n";
            this.serialPort.Parity = System.IO.Ports.Parity.None;
            this.serialPort.ParityReplace = ((byte)(63));
            this.serialPort.PortName = "COM5";
            this.serialPort.ReadBufferSize = 4096;
            this.serialPort.ReadTimeout = -1;
            this.serialPort.ReceivedBytesThreshold = 1;
            this.serialPort.RtsEnable = false;
            this.serialPort.StopBits = System.IO.Ports.StopBits.One;
            this.serialPort.WriteBufferSize = 2048;
            this.serialPort.WriteTimeout = -1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕 Semilight", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(194, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "연결 중...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.Location = new System.Drawing.Point(594, 522);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(198, 66);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radarPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "하야세 유우카 카와이 ><";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.serialPort.DataReceived += DataReceived;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel radarPanel;
        private System.IO.Ports.SerialPort serialPort;
        private Label label1;
        private PictureBox pictureBox;
        private Graphics graphic;
    }
}
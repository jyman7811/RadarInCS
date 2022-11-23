using System.Security.Cryptography.X509Certificates;

namespace Test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            serialPort.Open();
            graphic = radarPanel.CreateGraphics();
            Brush brush = new SolidBrush(Color.DarkGreen);
            Brush emptyBrush = new SolidBrush(Color.Black);

            void shit(object sender, PaintEventArgs e)
            {
                graphic.FillPie(brush, 0, 0, 1000, 1000, -160, 140);
                graphic.FillPie(emptyBrush, 26, 12, 950, 950, -160, 140);
            }

            this.Paint += new PaintEventHandler(shit);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string[] data = serialPort.ReadLine().Split(',');

            label1.Text = data[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
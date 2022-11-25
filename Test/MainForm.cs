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

            void shit(object sender, PaintEventArgs e)
            {
                graphic.DrawPie(new Pen(Color.Green, 10), 0, 0, radarPanel.Width, radarPanel.Height * 2, -160, 140);
            }

            this.Paint += new PaintEventHandler(shit);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(WorkBitch);
            thread.Start();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (rangeComboBox.SelectedIndex == -1)
            {
                return;
            }

            currentRange.Text = rangeComboBox.Items[rangeComboBox.SelectedIndex].ToString();

            serialPort.WriteLine("a," + rangeComboBox.Items[rangeComboBox.SelectedIndex].ToString());

        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string[] data = serialPort.ReadLine().Split(',');

            distance.Text = $"{data[0]}cm {data[1]}¡Æ";
        }

        private void WorkBitch()
        {
            while (true)
            {
                try
                {
                    serialPort.WriteLine("WORK");
                    Thread.Sleep(300);
                }
                catch (System.InvalidOperationException)
                {
                    break;
                }
            }
        }

        private void distance_Click(object sender, EventArgs e)
        {

        }
    }
}
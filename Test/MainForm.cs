namespace Test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            serialPort.Open();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();

            label1.Text = data;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
using ExaminationBL;

namespace WinFormsApp1
{
    public partial class GetPassedNumbers : Form
    {
        IExaminationProcessor examinationProcessor;
        public GetPassedNumbers()
        {
            examinationProcessor = new ExaminationProcessor();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = examinationProcessor.GetPassedCount(richTextBox1.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
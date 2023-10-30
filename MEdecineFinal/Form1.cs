namespace MEdecineFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoPacients ip = new InfoPacients();
            ip.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UvolnenieVrachey iv = new UvolnenieVrachey();
            iv.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewPatient np = new NewPatient();
            np.ShowDialog();
        }
    }
}
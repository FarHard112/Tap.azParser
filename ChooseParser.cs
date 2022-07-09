namespace TapazParser
{
    public partial class ChooseParser : Form
    {
        public ChooseParser()
        {
            InitializeComponent();
        }

        private void btnTapaz_Click(object sender, EventArgs e)
        {
            Form1 tapazform = new Form1();
            tapazform.Show();
            this.Hide();
        }

        private void btnLalafo_Click(object sender, EventArgs e)
        {
            LalafoParser lalafoParser = new LalafoParser();
            lalafoParser.Show();
            this.Hide();
        }
    }
}
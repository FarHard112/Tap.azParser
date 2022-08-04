using TapazParser.Turbo.az.Abstract;

namespace TapazParser.Turbo.az
{
    public partial class Turbo : Form
    {
        private readonly ITurboAz _turboAz;
        private static int counter = 0;

        public Turbo(ITurboAz turboAz)
        {
            _turboAz = turboAz;
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            Task.Run((() =>
            {
                TextBox.CheckForIllegalCrossThreadCalls = false;
                var collectedLinks = _turboAz.CollectAdds(Int32.Parse(txtSiteLink.Text));
                foreach (var link in collectedLinks)
                {
                    var collectedUsers = _turboAz.CollectNameAndNumber(link);
                    if (collectedUsers != null)
                    {
                        txtAuthor.AppendText(Environment.NewLine + collectedUsers.Name + "," + "994" + collectedUsers.Number);
                        txtAuthor.Text = string.Join(Environment.NewLine,
                            txtAuthor.Lines.Distinct());
                        counter++;
                        lblNeedToParse.Text = counter.ToString();
                    }
                }
            }));
        }

        private void btnSaveNumbers_Click(object sender, EventArgs e)
        {
            if (txtAuthor.Text.Length > 0)
            {
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    sfd.FilterIndex = 2;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, txtAuthor.Text);
                    }
                }
            }
            else MessageBox.Show("Nothing to save please wait for numbers !");
        }
    }
}
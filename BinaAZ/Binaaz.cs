using TapazParser.BinaAZ.Abstract;

namespace TapazParser.BinaAZ
{
    public partial class Binaaz : Form
    {
        private readonly IBinaaz _binaaz;
        private static List<string> CollectedLinks = new List<string>();
        private static int wantedAddNumber = 0;
        private static int currentAddNumber = 1;
        private static int processCounter = 0;

        public Binaaz(IBinaaz binaaz)
        {
            _binaaz = binaaz;
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            wantedAddNumber = Convert.ToInt32(txtAddCount.Text);

            Task.Run((() =>
            {
                while (currentAddNumber < wantedAddNumber)
                {
                    var list = _binaaz.CollectAdds(currentAddNumber);
                    if (list != null)
                    {
                        CollectedLinks.AddRange(list.Distinct().Where(x => !x.Contains("view")));
                        currentAddNumber++;
                    }
                }
                foreach (var add in CollectedLinks)
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls=false;
                    var model = _binaaz.CollectNumberAndName(add);
                    if (model != null)
                    {
                        txtAuthor.AppendText(Environment.NewLine + model.Name + "," + "994" + model.Number);
                        txtAuthor.Text = string.Join(Environment.NewLine,
                            txtAuthor.Lines.Distinct());
                        processCounter++;
                        lblNeedToParse.Text = processCounter.ToString();
                    }
                }
            }));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
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
using TapazParser.BinaAZ;
using WhatsappBusiness.CloudApi;
using WhatsappBusiness.CloudApi.Configurations;

namespace TapazParser
{
    public partial class ChooseParser : Form
    {
        private readonly Form1 _tapaz;
        private readonly Binaaz _binaaz;

        public ChooseParser(Form1 tapaz, Binaaz binaaz)
        {
            _tapaz = tapaz;
            _binaaz = binaaz;
            InitializeComponent();
        }

        private void btnTapaz_Click(object sender, EventArgs e)
        {
            _tapaz.Show();
            this.Hide();
        }

        private void btnLalafo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            WhatsAppBusinessCloudApiConfig config = new WhatsAppBusinessCloudApiConfig()
            {
                AccessToken = "",
                WhatsAppBusinessPhoneNumberId = "",
                WhatsAppBusinessId = "",
                WhatsAppBusinessAccountId = "",
            };

            WhatsAppBusinessClient client = new WhatsAppBusinessClient(config);
        }

        private void btnBinaAZ_Click(object sender, EventArgs e)
        {
            _binaaz.Show();
            this.Hide();
        }
    }
}
using TapazParser.BinaAZ;
using WhatsappBusiness.CloudApi;
using WhatsappBusiness.CloudApi.Configurations;

namespace TapazParser
{
    public partial class ChooseParser : Form
    {
        private readonly Form1 _tapaz;
        private readonly Binaaz _binaaz;
        private readonly Turbo.az.Turbo _turboAz;

        public ChooseParser(Form1 tapaz, Binaaz binaaz, Turbo.az.Turbo turboAZ)
        {
            _tapaz = tapaz;
            _binaaz = binaaz;
            _turboAz = turboAZ;
            InitializeComponent();
        }

        private void btnTapaz_Click(object sender, EventArgs e)
        {
            _tapaz.Show();
            this.Hide();
        }

        private void btnLalafo_Click(object sender, EventArgs e)
        {
            _turboAz.Show();
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
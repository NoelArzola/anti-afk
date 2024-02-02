using static AntiAFK.Program;
namespace AntiAFK
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private async void BtnStop_Click(object sender, EventArgs e)
        {
            DisableButton(btnStop);
            StopMessage(statusBarMessage);
            await AddDelay(1000);
            keepAlive = false;
            EnableButton(btnStart);
            ResetTimer(statusBarTimer);
            ResetMessage(statusBarMessage);
        }

        private async void BtnStart_ClickAsync(object sender, EventArgs e)
        {
            DisableButton(btnStart);
            await StartMessage(statusBarMessage);
            keepAlive = true;
            EnableButton(btnStop);
            RunningMessage(statusBarMessage);
            StartTimer(statusBarTimer);
            _ = SimulateKeystrokes(usrInput.Value);
        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
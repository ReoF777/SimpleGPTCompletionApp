namespace SimpleGPTCompletionApp
{
    public partial class SimpeGPTForm : Form
    {
        private GPTController _gptController;
        public SimpeGPTForm () {
            InitializeComponent();

            _gptController = new();
        }

        private async void GenerateBtn_Click (object sender, EventArgs e) {
            GenerateBtn.Enabled = false;

            string baseData = BaseInput.Text;
            string name = SpeakerName.Text;
            string restrict = RestrictInput.Text;
            string? result = null;

            await Task.Run(() =>
            {
                result = _gptController.GenerateTalk(baseData, restrict, name);
            });

            if (result != null) {
                ResultOutput.Text = result;
            }
            else
            {
                MessageBox.Show("トーク生成に失敗しました。");
            }

            GenerateBtn.Enabled = true;
        }
    }
}

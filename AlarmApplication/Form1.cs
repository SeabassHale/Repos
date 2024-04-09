using System.Media;

namespace AlarmApplication
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        delegate void UpdateLable(Label lbl, string value);

        void UpdateDataLable(Label lbl, string value)
        {
            lbl.Text = value;
        }


        private void Timer_Elapsed(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
            if (currentTime.Hour == userTime.Hour &&  currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                try
                {
                    UpdateLable upd = UpdateDataLable;
                    if (lblStatus.InvokeRequired)
                        Invoke(upd, lblStatus, "Stop");
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"C:\Windows\Media\Alarm01.wav";
                    player.PlayLooping();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            lblStatus.Text = "Running...";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblStatus.Text = "Stop";
        }

    }
}
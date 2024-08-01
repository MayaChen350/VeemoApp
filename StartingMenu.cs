namespace VeemoApp;

public partial class VeemoApp : System.Windows.Forms.Form
{
    /// <summary>
    /// Managae the frequency.
    /// </summary>
    Random random;

    public VeemoApp()
    {
        InitializeComponent();

        random = new Random();
    }

    /// <summary>
    /// Start the timer. Also makes the app invisible.
    /// </summary>
    private void startButton_Click(object sender, EventArgs e)
    {
        timer.Start();
        this.Visible = false;
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        // Display a "Veemo!" message every minute with the frequency chosen.
        if (random.Next(
            (int)(100 / frequencyOption.Value))
            == 0)
        {
            MessageBox.Show("Veemo!", "Veemo", MessageBoxButtons.OK);
        }
    }
}

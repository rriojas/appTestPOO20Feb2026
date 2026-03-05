using System.Xml.Serialization;

namespace appTestPOO20Feb2026
{
  public partial class Form1 : Form
  {
    private System.Windows.Forms.Timer timer;
    private PictureBox pictureBox1;

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      pictureBox1 = new PictureBox();
      pictureBox1.Image = Image.FromFile("pic.png");
      pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      pictureBox1.Size = new Size(200, 200);
      int formWidth = this.ClientSize.Width;
      int formHeight = this.ClientSize.Height;
      Point centerPoint = new Point((formWidth - pictureBox1.Width) / 2, (formHeight - pictureBox1.Height) / 2);
      pictureBox1.Location = centerPoint;
      this.Controls.Add(pictureBox1);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      //Start a timer to move the picture box
      timer = new System.Windows.Forms.Timer();
            timer.Interval = 1; // Set the interval to 30 milliseconds
            timer.Tick += Timer_Tick;
            timer.Start();
    }
    private void Timer_Tick(object sender, EventArgs e)
    {
      if (pictureBox1 != null)
      {
        // Move the picture box to the left
        pictureBox1.Left -= 2;
        // If the picture box goes beyond the form's width, reset its position
        if (pictureBox1.Left < -pictureBox1.Width)
        {
          pictureBox1.Left = this.ClientSize.Width; // Start from the right  again
        }
      }
    }
  }
}

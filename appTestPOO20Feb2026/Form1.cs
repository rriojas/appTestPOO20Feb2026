namespace appTestPOO20Feb2026
{
  public partial class Form1 : Form
  {

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      PictureBox pictureBox1 = new PictureBox();
      pictureBox1.Image = Image.FromFile("pic.png");
      pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      pictureBox1.Size = new Size(200, 200);
      pictureBox1.Location = new Point(100, 100);
      this.Controls.Add(pictureBox1);
    }
  }
}

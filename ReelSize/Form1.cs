using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReelSize
{
    public partial class ReelSize : Form
    {

        public ReelSize()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }





        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(selectedImagePath);
                textBox3.Text = $"Width: {pictureBox1.Image.Width}px, Height: {pictureBox1.Image.Height}px";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Check if the TextBox contains any non-digit characters
            if (textBox1.Text.Any(c => !char.IsDigit(c)))
            {
                // Clear the TextBox
                textBox1.Text = string.Empty;

                // Display an error message
                MessageBox.Show("No letters allowed. Please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Check if the pressed key is a digit or a control key (e.g., Backspace)


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Check if the TextBox contains any non-digit characters
            if (textBox2.Text.Any(c => !char.IsDigit(c)))
            {
                // Clear the TextBox
                textBox2.Text = string.Empty;

                // Display an error message
                MessageBox.Show("No letters allowed. Please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter dimensions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please upload an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int height;
            int width;

            if (!int.TryParse(textBox1.Text, out height) || !int.TryParse(textBox2.Text, out width))
            {
                MessageBox.Show("Please enter valid dimensions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pictureBox1.Image = ResizeImage(pictureBox1.Image, width, height);

            // Update the TextBox with the current dimensions
            textBox3.Text = $"Width: {pictureBox1.Image.Width}px, Height: {pictureBox1.Image.Height}px";
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.DrawImage(image, 0, 0, width, height);
            }

            // Update the TextBox with the new dimensions
            textBox3.Text = $"Width: {width}px, Height: {height}px";

            return resizedImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPEG Image (*.jpg)|*.jpg|PNG Image (*.png)|*.png";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(saveFileDialog.FileName).ToLower();
                    ImageFormat imageFormat = ImageFormat.Jpeg;

                    if (fileExtension == ".png")
                    {
                        imageFormat = ImageFormat.Png;
                    }

                    pictureBox1.Image.Save(saveFileDialog.FileName, imageFormat);
                }
            }
            else
            {
                MessageBox.Show("Please upload a file before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void ReelSize_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
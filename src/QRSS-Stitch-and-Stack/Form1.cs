using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRSS_Stitch_and_Stack
{
    public partial class Form1 : Form
    {
        private ImageStacker stacker = new ImageStacker();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string defImageFolder = @"C:\Users\scott\Documents\temp\tx";
            if (System.IO.Directory.Exists(defImageFolder))
                addFolder(defImageFolder);
        }

        private void addFolder(string imageFolder, string match = "*.jpg")
        {
            string[] imagePaths = System.IO.Directory.GetFiles(imageFolder, match);
            addImages(imagePaths);
        }

        private void addImages(string[] imagePaths)
        {
            stacker.Clear();
            stacker.Add(imagePaths);

            lbImages.Items.Clear();
            foreach (string filename in imagePaths)
                lbImages.Items.Add(System.IO.Path.GetFileName(filename));
            lbImages.SetSelected(0, true);
            gbDisplay.Enabled = true;
            UpdateResultImage();
        }

        private void BtnLoadImages_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Multiselect = true;
            diag.Filter = "JPG Files (*.jpg, *.jpeg)|*.jpg;*.jpeg";
            diag.Filter += "|BMP Files (*.bmp)|*.bmp;*.bmp";
            diag.Filter += "|PNG Files (*.png)|*.png;*.png";
            diag.Filter += "|TIF files (*.tif, *.tiff)|*.tif;*.tiff";
            diag.Filter += "|All files (*.*)|*.*";
            if (diag.ShowDialog() == DialogResult.OK)
            {
                if (diag.FileNames.Length == 1)
                {
                    MessageBox.Show("It looks like you only slected one image.\n\n" +
                        "Use CTRL-click or SHIFT-click to select multiple files\n" +
                        "in the file selection dialog window next time.", "ERROR");
                }
                else
                {
                    addImages(diag.FileNames);
                }
            }
        }

        private void LbImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbSingle.Checked)
                UpdateResultImage();
        }

        private void UpdateResultImage()
        {
            gbResult.Text = "processing result...";
            gbResult.Enabled = false;

            if (rbSingle.Checked)
            {
                pbResult.Image = stacker.GetResultSingle(lbImages.SelectedIndex);
                gbResult.Text = $"Single Image ({lbImages.SelectedItem})";
            }
            else if (rbStackMax.Checked)
            {
                pbResult.Image = stacker.GetResultStackMax();
                gbResult.Text = $"Maximum-Projection Stack ({lbImages.Items.Count} images)";
            }
            else if (rbStackMean.Checked)
            {
                pbResult.Image = stacker.GetResultStackMean();
                gbResult.Text = $"Mean Value Stack ({lbImages.Items.Count} images)";
            }
            else
            {
                throw new NotImplementedException();
            }

            gbResult.Enabled = true;
        }

        private void RbSingle_Click(object sender, EventArgs e)
        {
            UpdateResultImage();
            lbImages.Enabled = true;
        }

        private void RbStitch_Click(object sender, EventArgs e)
        {
            UpdateResultImage();
            lbImages.Enabled = false;
        }

        private void RbStackMax_Click(object sender, EventArgs e)
        {
            UpdateResultImage();
            lbImages.Enabled = false;
        }

        private void RbStackMean_Click(object sender, EventArgs e)
        {
            UpdateResultImage();
            lbImages.Enabled = false;
        }

        private void BtnSaveResult_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "stack.jpg";
            savefile.Filter = "JPG Files (*.jpg)|*.jpg;*.jpeg";
            savefile.Filter += "|PNG Files (*.png)|*.png";
            savefile.Filter += "|BMP Files (*.bmp)|*.bmp";
            savefile.Filter += "|All files (*.*)|*.*";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                string saveFilePath = savefile.FileName;
                pbResult.Image.Save(saveFilePath);
            }
        }
    }
}

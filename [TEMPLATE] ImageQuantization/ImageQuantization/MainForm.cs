using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace ImageQuantization
{
    public partial class MainForm :MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        RGBPixel[,] ImageMatrix;
        Graph g;
        private void metroButton1_Click(object sender, EventArgs e)
        {
             g = new Graph();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the browsed image and display it
                string OpenedFilePath = openFileDialog1.FileName;
                ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);
                ImageOperations.DisplayImage(ImageMatrix, pictureBox1);
                txtWidth.Text = ImageOperations.GetWidth(ImageMatrix).ToString();
                txtHeight.Text = ImageOperations.GetHeight(ImageMatrix).ToString();
                g.Find_Distinct_colors(ImageMatrix);
                DistinctColors.Text = g.Distinct.Count.ToString();
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            //  Graph g = new Graph();
            g = new Graph();
            g.Costruct_MST(ImageMatrix);
         //   DistinctColors.Text = g.Distinct.Count.ToString();
            g.Clustering(int.Parse(Clusters.Text.ToString()), ref ImageMatrix);
            ImageOperations.DisplayImage(ImageMatrix, pictureBox2);
           // pictureBox2.Image.Save("D:\\Islamic\\[TEMPLATE] ImageQuantization\\My.bmp", ImageFormat.Bmp);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
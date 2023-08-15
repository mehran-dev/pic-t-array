using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pic_To_Array
{
    public partial class Form1 : Form
    {
        byte[] byteArrayIn;
        string myPicPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert2Arr_Click(object sender, EventArgs e)
        {
            img1.Image = null;
            byte[] arrImg = SerializeImage();
            byteArrayIn = arrImg;
            for (int i = 0; i < 1; i++)
            {
                //MessageBox.Show(arrImg[i].ToString());
            }
            wrr();
        }




        private void btnLoad_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.ShowDialog();

            if (true)
            {
                img1.Image = new Bitmap(fd.FileName);

            }
            //MessageBox.Show((fd.FileName).ToString());

            myPicPath = fd.FileName;

        }







        public byte[] SerializeImage()
        {
            MemoryStream m;
            // string PicPath //@"C:\Users\xxx\Desktop\DeskTop\picture\b0a99e0175df49c5a1bfca62787458e617024780-480p__32025.mp4_snapshot_09.27_[2019.10.13_22.25.15].jpg";
            string PicPath = myPicPath.ToString();//@"C:\Users\xxx\Desktop\DeskTop\picture\b0a99e0175df49c5a1bfca62787458e617024780-480p__32025.mp4_snapshot_09.27_[2019.10.13_22.25.15].jpg";

            byte[] imageBytes;
            using (Image image = Image.FromFile(PicPath))
            {

                using (m = new MemoryStream())
                {

                    image.Save(m, image.RawFormat);
                    imageBytes = new byte[m.Length];
                    //Very Important    
                    imageBytes = m.ToArray();

                }//end using
            }//end using

            return imageBytes;
        }//SerializeImage

        private void btnConvert2Img_Click(object sender, EventArgs e)
        {


            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                img1.Image = Image.FromStream(mStream);
            }
        }

        //
        private void wrr()
        {
            StreamWriter wr = new StreamWriter(@"D:/txtWRpic.txt");
            for (int i = 0; i < byteArrayIn.Length; i++)
            {
                wr.Write(byteArrayIn[i].ToString());
                wr.Write("\n");
            }
            wr.Close();
        }

        private void btntxt2pic_Click(object sender, EventArgs e)
        {
            StreamReader srr = new StreamReader(@"D:/txtWRpic.txt");
            var path = @"D:/txtWRpic.txt";

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            int i = 0;
            foreach (string line in lines)
            {

            }

            byte[] readedarr = new byte[lines.Length];


            for (int j = 0; j < lines.Length; j++)
            {
                readedarr[j] = Convert.ToByte(lines[j]);

            }

            using (MemoryStream mStream = new MemoryStream(readedarr))
            {
                img1.Image = Image.FromStream(mStream);
            }
            srr.Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARRAre
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;
       // &New Refugee Registration
//RefugeeRegistration refugee = new RefugeeRegistration();
            //refugee.MdiParent = this;
           // refugee.Show();
        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
           
            
        }

        

      

       

       

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

      

        private void barStaticItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefugeeRegistration refugee = new RefugeeRegistration();
            refugee.MdiParent = this;
            refugee.Show();
        }

        private void barStaticItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barStaticItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Search datafrm = new Search();
            datafrm.MdiParent = this;
            datafrm.Show();
           
        }

        private void barStaticItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            whodevelop me = new whodevelop();
            me.Show();

        }

        private void barStaticItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barStaticItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            whodevelop me = new whodevelop();
            me.MdiParent = this;
            me.Show();
        }

        private void barStaticItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm5 datafrm = new XtraForm5();
            datafrm.MdiParent = this;
            datafrm.Show();
        }

       /* private void DetectFaces()
        {
            Image<Gray, byte> grayframe = ImageFrame.Convert<Gray, byte>();

            //Assign user-defined Values to parameter variables:
            MinNeighbors = int.Parse(comboBoxMinNeigh.Text);  // the 3rd parameter
            WindowsSize = int.Parse(textBoxWinSiz.Text);   // the 5th parameter
            ScaleIncreaseRate = Double.Parse(comboBoxScIncRte.Text); //the 2nd parameter

            //detect faces from the gray-scale image and store into an array of type 'var',i.e 'MCvAvgComp[]'
            var faces = grayframe.DetectHaarCascade(haar, ScaleIncreaseRate, MinNeighbors,
                                    HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                    new Size(WindowsSize, WindowsSize))[0];
            if (faces.Length > 0)
            {
                MessageBox.Show("Total Faces Detected: " + faces.Length.ToString());
                Bitmap BmpInput = grayframe.ToBitmap();
                Bitmap ExtractedFace;   //empty
                Graphics FaceCanvas;
                ExtFaces = new Bitmap[faces.Length];
                faceNo = 0;

                //draw a green rectangle on each detected face in image
                foreach (var face in faces)
                {
                    ImageFrame.Draw(face.rect, new Bgr(Color.Green), 3);

                    //set the size of the empty box(ExtractedFace) which will later contain the detected face
                    ExtractedFace = new Bitmap(face.rect.Width, face.rect.Height);

                    //set empty image as FaceCanvas, for painting
                    FaceCanvas = Graphics.FromImage(ExtractedFace);

                    FaceCanvas.DrawImage(BmpInput, 0, 0, face.rect, GraphicsUnit.Pixel);

                    ExtFaces[faceNo] = ExtractedFace;
                    faceNo++;
                }

                pbExtractedFaces.Image = ExtFaces[0];

                //Display the detected faces in imagebox
                CamImageBox.Image = ImageFrame;

                btnNext.Enabled = true;
                btnPrev.Enabled = true;
            }
        }*/



    }
}

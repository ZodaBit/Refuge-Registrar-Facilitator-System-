using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace ARRAre
{
    public partial class RefugeeRegistration : DevExpress.XtraEditors.XtraForm
    {

        //declaring global variables
        private Capture capture;        //takes images from camera as image frames
        private bool captureInProgress; // checks if capture is executing

        public RefugeeRegistration()
        {
            InitializeComponent();
        }

        RefugeeDB _db = new RefugeeDB();
        int MaxRow = 0;
        int inc = 0;

        private void ProcessFrame(object sender, EventArgs arg)
        {  try
       
               { 
            Image<Bgr, Byte> ImageFrame = capture.QueryFrame();  //line 1
            pictureEdit1.Image = ImageFrame.ToBitmap();
               }
            catch(Exception err)
        {
                 
        }
            //CamImageBox.Image = ImageFrame;        //line 2
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            #region if capture is not created, create it now
            if (capture == null)
            {
                try
                {
                    capture = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);

                }
            }
            #endregion

            if (capture != null)
            {
                if (captureInProgress)
                {  //if camera is getting frames then stop the capture and set button Text
                    // "Start" for resuming capture

                    button1.Text = "Start!"; //
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    //if camera is NOT getting frames then start the capture and set button
                    // Text to "Stop" for pausing capture
                    button1.Text = "Stop";
                    Application.Idle += ProcessFrame;
                }

                captureInProgress = !captureInProgress;
            }
        }

       


        private void ReleaseData()
        {
            if (capture != null)
                capture.Dispose();
        }


        private void SavetoolStripButton1_Click(object sender, EventArgs e)
        {
            bool inserted;
            inserted = _db.InsertRefugees(filetextbox.Text, ractiontextbox.Text, campcombobox.Text, firstnametextbox.Text, familytypecombobox.Text, middlenametextbox.Text, lastnametextbox.Text, mothernametextbox.Text, sexcombobox.Text, Convert.ToInt32(agetextbox.Text), dobdateedittext.Text, placeofbtextobx.Text, religioncombobox.Text, tribecombobox.Text, martialcombobox.Text, Convert.ToInt32(familysizetextbox.Text), formerocccomboboxedit.Text, skilltextbox.Text, nationalitytextbox.Text, citytextbox.Text, subcitytextbox.Text, zonetextbox.Text, weredatextbox.Text, kebeletextbox.Text, housenumtextbox.Text, phonenumtextobx.Text, reasonofurcombobox.Text, remarktextbox.Text, regnametextbox.Text, regdatedatetext.Text,ConvertImageToBytes(pictureEdit1.Image));
              if(inserted==true)
              {
                  XtraMessageBox.Show("Saved Successfully");
                  Clear();
              }
              else
              {
                  XtraMessageBox.Show("Note Saved Successfully");
              }
        }
//clear data from the text field
     public void Clear()
        {
            Idtextbox.Clear();
            filetextbox.Clear();
            ractiontextbox.Clear();
            campcombobox.Text="";
            firstnametextbox.Clear();
            familytypecombobox.Text = "";
            middlenametextbox.Clear();
            lastnametextbox.Clear();
            mothernametextbox.Clear();
            sexcombobox.Text="";
            agetextbox.Clear(); 
            dobdateedittext.Text=""; 
            placeofbtextobx.Clear();
            religioncombobox.Text ="";
            tribecombobox.Text ="";
            martialcombobox.Text ="";
            familysizetextbox.Clear(); 
            formerocccomboboxedit.Text=""; 
            skilltextbox.Clear();
            nationalitytextbox.Clear(); 
            citytextbox.Clear();
            subcitytextbox.Clear();
            zonetextbox.Clear();
            weredatextbox.Clear();
            kebeletextbox.Clear();
            housenumtextbox.Clear();
            reasonofurcombobox.Text="";
            phonenumtextobx.Clear();
            remarktextbox.Clear();
            regnametextbox.Clear();
            regdatedatetext.Text = "";
            
        }

public void NavigateRecords()
        {
            DataRow datarow = _db.GetAllReffugee().Tables["AllReffugee"].Rows[inc];
            Idtextbox.Text = datarow.ItemArray.GetValue(0).ToString();
            filetextbox.Text = datarow.ItemArray.GetValue(1).ToString();
            ractiontextbox.Text = datarow.ItemArray.GetValue(2).ToString();
            campcombobox.Text = datarow.ItemArray.GetValue(3).ToString();
            firstnametextbox.Text = datarow.ItemArray.GetValue(4).ToString();
            familytypecombobox.Text = datarow.ItemArray.GetValue(5).ToString();
            middlenametextbox.Text = datarow.ItemArray.GetValue(6).ToString();
            lastnametextbox.Text = datarow.ItemArray.GetValue(7).ToString();
            mothernametextbox.Text = datarow.ItemArray.GetValue(8).ToString();
            sexcombobox.Text = datarow.ItemArray.GetValue(9).ToString();
            agetextbox.Text = datarow.ItemArray.GetValue(10).ToString();
            dobdateedittext.Text = datarow.ItemArray.GetValue(11).ToString();
            placeofbtextobx.Text = datarow.ItemArray.GetValue(12).ToString();
            religioncombobox.Text = datarow.ItemArray.GetValue(13).ToString();
            tribecombobox.Text = datarow.ItemArray.GetValue(14).ToString();
            martialcombobox.Text = datarow.ItemArray.GetValue(15).ToString();
            familysizetextbox.Text = datarow.ItemArray.GetValue(16).ToString();
            formerocccomboboxedit.Text = datarow.ItemArray.GetValue(17).ToString();
            skilltextbox.Text = datarow.ItemArray.GetValue(18).ToString();
            nationalitytextbox.Text = datarow.ItemArray.GetValue(19).ToString();
            citytextbox.Text = datarow.ItemArray.GetValue(20).ToString();
            subcitytextbox.Text = datarow.ItemArray.GetValue(21).ToString();
            zonetextbox.Text = datarow.ItemArray.GetValue(22).ToString();
            weredatextbox.Text = datarow.ItemArray.GetValue(23).ToString();
            kebeletextbox.Text = datarow.ItemArray.GetValue(24).ToString();
            housenumtextbox.Text = datarow.ItemArray.GetValue(25).ToString();
            reasonofurcombobox.Text = datarow.ItemArray.GetValue(26).ToString();
            phonenumtextobx.Text = datarow.ItemArray.GetValue(27).ToString();
            remarktextbox.Text = datarow.ItemArray.GetValue(28).ToString();
            regnametextbox.Text = datarow.ItemArray.GetValue(29).ToString();
            regdatedatetext.Text = datarow.ItemArray.GetValue(30).ToString();
           pictureEdit1.Image = ReadImageDb();
        }
//method for converting image into bytes 
       private byte[] ConvertImageToBytes(Image InputImage)
        {
            InputImage.Save(@"D:\MyPic.jpg");
            Bitmap bmpimg = new Bitmap(InputImage);
            MemoryStream ms = new MemoryStream();

            bmpimg.Save(ms, ImageFormat.Jpeg);
            byte[] ImgAsBytes = ms.ToArray();

            return ImgAsBytes;
           
        }
//buttun to browze image from the hard drive
       private void simpleButton1_Click(object sender, EventArgs e)
       {
           if(ImgFileDialog.ShowDialog()==DialogResult.OK)
           {
               pictureEdit1.Image = Image.FromFile(ImgFileDialog.FileName);
           }
       }

       private void RefugeeRegistration_Load(object sender, EventArgs e)
       {

          // NavigateRecords();
           MaxRow = _db.GetAllReffugee().Tables["AllReffugee"].Rows.Count;
       }
    
//Read Image from the database

        private Image ReadImageDb()
      {
           Image fetchedimg;
           byte[] fetchedimgbytes=(byte[])_db.GetAllReffugee().Tables["AllReffugee"].Rows[inc]["rfImage"];
           MemoryStream ms = new MemoryStream(fetchedimgbytes);
           fetchedimg = Image.FromStream(ms);

            return fetchedimg; 
       }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            if(inc!=MaxRow-1)
            {
                inc++;
                NavigateRecords();
            }
            else
            {
                XtraMessageBox.Show("No More Records");
            }
        }

        private void Prevbtn_Click(object sender, EventArgs e)
        {
            if(inc >0 )
            {
                inc--;
                NavigateRecords();
            }
          else
            {
                XtraMessageBox.Show("You Are at The First Record");
            }
        }

        private void Lastbtn_Click(object sender, EventArgs e)
        {
            if(inc!=MaxRow-1)
            {
                inc = MaxRow - 1;
                NavigateRecords();
            }
            
        }

        private void firstbtn_Click(object sender, EventArgs e)
        {
            if(inc!=0)
            {
                inc = 0;
                NavigateRecords();
            }
        }

        private void filetextbox_MouseClick(object sender, MouseEventArgs e)
        {
            inc = 0;
            DataRow datarow = _db.GetReffugeebyId(Convert.ToString(Idtextbox.Text)).Tables["AllReffugee"].Rows[inc];
            Idtextbox.Text = datarow.ItemArray.GetValue(0).ToString();
            filetextbox.Text = datarow.ItemArray.GetValue(1).ToString();
            ractiontextbox.Text = datarow.ItemArray.GetValue(2).ToString();
            campcombobox.Text = datarow.ItemArray.GetValue(3).ToString();
            firstnametextbox.Text = datarow.ItemArray.GetValue(4).ToString();
            familytypecombobox.Text = datarow.ItemArray.GetValue(5).ToString();
            middlenametextbox.Text = datarow.ItemArray.GetValue(6).ToString();
            lastnametextbox.Text = datarow.ItemArray.GetValue(7).ToString();
            mothernametextbox.Text = datarow.ItemArray.GetValue(8).ToString();
            sexcombobox.Text = datarow.ItemArray.GetValue(9).ToString();
            agetextbox.Text = datarow.ItemArray.GetValue(10).ToString();
            dobdateedittext.Text = datarow.ItemArray.GetValue(11).ToString();
            placeofbtextobx.Text = datarow.ItemArray.GetValue(12).ToString();
            religioncombobox.Text = datarow.ItemArray.GetValue(13).ToString();
            tribecombobox.Text = datarow.ItemArray.GetValue(14).ToString();
            martialcombobox.Text = datarow.ItemArray.GetValue(15).ToString();
            familysizetextbox.Text = datarow.ItemArray.GetValue(16).ToString();
            formerocccomboboxedit.Text = datarow.ItemArray.GetValue(17).ToString();
            skilltextbox.Text = datarow.ItemArray.GetValue(18).ToString();
            nationalitytextbox.Text = datarow.ItemArray.GetValue(19).ToString();
            citytextbox.Text = datarow.ItemArray.GetValue(20).ToString();
            subcitytextbox.Text = datarow.ItemArray.GetValue(21).ToString();
            zonetextbox.Text = datarow.ItemArray.GetValue(22).ToString();
            weredatextbox.Text = datarow.ItemArray.GetValue(23).ToString();
            kebeletextbox.Text = datarow.ItemArray.GetValue(24).ToString();
            housenumtextbox.Text = datarow.ItemArray.GetValue(25).ToString();
            reasonofurcombobox.Text = datarow.ItemArray.GetValue(26).ToString();
            phonenumtextobx.Text = datarow.ItemArray.GetValue(27).ToString();
            remarktextbox.Text = datarow.ItemArray.GetValue(28).ToString();
            regnametextbox.Text = datarow.ItemArray.GetValue(29).ToString();
            regdatedatetext.Text = datarow.ItemArray.GetValue(30).ToString();
            pictureEdit1.Image = ReadImageDbid();
            
        }

    //search image by id
        private Image ReadImageDbid()
        {
            Image fetchedimg;
            byte[] fetchedimgbytes = (byte[])_db.GetReffugeebyId(Convert.ToString(Idtextbox.Text)).Tables["AllReffugee"].Rows[inc]["rfImage"];
            MemoryStream ms = new MemoryStream(fetchedimgbytes);
            fetchedimg = Image.FromStream(ms);

            return fetchedimg;
        }

        private void CleartoolStripButton4_Click(object sender, EventArgs e)
        {
            Clear();
        }
//method used to update or edit information from the database
        private void EdittoolStripButton2_Click(object sender, EventArgs e)
        {
            bool inserted;
            inserted = _db.UpdateRefugee(Convert.ToString(Idtextbox.Text),filetextbox.Text, ractiontextbox.Text, campcombobox.Text, firstnametextbox.Text, familytypecombobox.Text, middlenametextbox.Text, lastnametextbox.Text, mothernametextbox.Text, sexcombobox.Text, Convert.ToInt32(agetextbox.Text), dobdateedittext.Text, placeofbtextobx.Text, religioncombobox.Text, tribecombobox.Text, martialcombobox.Text, Convert.ToInt32(familysizetextbox.Text), formerocccomboboxedit.Text, skilltextbox.Text, nationalitytextbox.Text, citytextbox.Text, subcitytextbox.Text, zonetextbox.Text, weredatextbox.Text, kebeletextbox.Text, housenumtextbox.Text, phonenumtextobx.Text, reasonofurcombobox.Text, remarktextbox.Text, regnametextbox.Text, regdatedatetext.Text, ConvertImageToBytes(pictureEdit1.Image));
            if (inserted == true)
            {
                XtraMessageBox.Show("Data Updated Successfully!!!!");
                Clear();
            }
            else
            {
                XtraMessageBox.Show("Data Update Faild!!!!");
            }
        }

        private void DelettoolStripButton3_Click(object sender, EventArgs e)
        {
            

        }

        private void filetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        

        

        

        
       
    }
}
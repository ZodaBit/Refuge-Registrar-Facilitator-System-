using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace ARRAre
{
    public partial class MyReport : DevExpress.XtraEditors.XtraForm
    {
        public MyReport()
        {
            InitializeComponent();
        }
        RefugeeDB _db = new RefugeeDB();
        int i;
        private void Searchbuttn_Click(object sender, EventArgs e)
        {
            i = 0;
            DataRow datarow = _db.GetReffugeebyRacionCArd(Convert.ToString(Searchtxtbox.Text)).Tables["AllReffugee"].Rows[i];
            fnamelabel.Text = datarow.ItemArray.GetValue(4).ToString();
           
            mnamelabel.Text = datarow.ItemArray.GetValue(6).ToString();
            lastnamelabel.Text=datarow.ItemArray.GetValue(7).ToString();
            mothernamelabel.Text=datarow.ItemArray.GetValue(8).ToString();
            sexlabel.Text=datarow.ItemArray.GetValue(9).ToString();
            doblable.Text=datarow.ItemArray.GetValue(11).ToString();
            placeofbirthlabel.Text=datarow.ItemArray.GetValue(12).ToString();
            tribelablel.Text=datarow.ItemArray.GetValue(14).ToString();
            martiallabel.Text=datarow.ItemArray.GetValue(15).ToString();
            formeroccupationlablel.Text=datarow.ItemArray.GetValue(17).ToString();
            remarklabel.Text=datarow.ItemArray.GetValue(28).ToString();
            Racioncardlable.Text=datarow.ItemArray.GetValue(2).ToString();
            filenumberlabel.Text=datarow.ItemArray.GetValue(1).ToString();
            //individualnumberlabel
            nationalitylabel.Text=datarow.ItemArray.GetValue(19).ToString();
            campnamelabel.Text=datarow.ItemArray.GetValue(3).ToString();
            resonofurbanlabel.Text = datarow.ItemArray.GetValue(26).ToString();
            religionlabel.Text=datarow.ItemArray.GetValue(13).ToString();
            familysizelabel.Text=datarow.ItemArray.GetValue(16).ToString();
            citylabel.Text=datarow.ItemArray.GetValue(20).ToString();
            subcitylabel.Text=datarow.ItemArray.GetValue(21).ToString();
            weredalabel.Text=datarow.ItemArray.GetValue(23).ToString();
            homenumberlabel.Text=datarow.ItemArray.GetValue(25).ToString();
            mobilelabel.Text=datarow.ItemArray.GetValue(27).ToString();
            pictureEdit1.Image = ReadimagefromDbusingrc();
            img1stname.Text = datarow.ItemArray.GetValue(4).ToString();
            readrow2();
           
        }
        private void readrow2()
        {
            
           
            i = 1;
            DataRow datarow= _db.GetReffugeebyRacionCArd(Convert.ToString(Searchtxtbox.Text)).Tables["AllReffugee"].Rows[i];
            f1.Text = datarow.ItemArray.GetValue(4).ToString();

            mi1.Text = datarow.ItemArray.GetValue(6).ToString();
            l1.Text = datarow.ItemArray.GetValue(7).ToString();
            mo1.Text = datarow.ItemArray.GetValue(8).ToString();
            sex1.Text = datarow.ItemArray.GetValue(9).ToString();
            dob1.Text = datarow.ItemArray.GetValue(11).ToString();
            p1.Text = datarow.ItemArray.GetValue(12).ToString();
            t1.Text = datarow.ItemArray.GetValue(14).ToString();
            r1.Text = datarow.ItemArray.GetValue(5).ToString();
            o1.Text = datarow.ItemArray.GetValue(17).ToString();
            //edu1.Text
             pictureEdit2.Image = ReadimagefromDbusingrc();
             fimg2name.Text = datarow.ItemArray.GetValue(4).ToString();
             readrow3();
        }
        private void readrow3()
        {
            i = 2;
            DataRow datarow = _db.GetReffugeebyRacionCArd(Convert.ToString(Searchtxtbox.Text)).Tables["AllReffugee"].Rows[i];
            f2.Text = datarow.ItemArray.GetValue(4).ToString();

            mi2.Text = datarow.ItemArray.GetValue(6).ToString();
            l2.Text = datarow.ItemArray.GetValue(7).ToString();
            mo2.Text = datarow.ItemArray.GetValue(8).ToString();
            sex2.Text = datarow.ItemArray.GetValue(9).ToString();
            dob2.Text = datarow.ItemArray.GetValue(11).ToString();
            p2.Text = datarow.ItemArray.GetValue(12).ToString();
            t2.Text = datarow.ItemArray.GetValue(14).ToString();
            r2.Text = datarow.ItemArray.GetValue(5).ToString();
            o2.Text = datarow.ItemArray.GetValue(17).ToString();
            //edu1.Text
            pictureEdit3.Image = ReadimagefromDbusingrc();
            fi2.Text = datarow.ItemArray.GetValue(4).ToString();
            readrow4();
        }
        private void readrow4()
        {
            i = 3;
            DataRow datarow = _db.GetReffugeebyRacionCArd(Convert.ToString(Searchtxtbox.Text)).Tables["AllReffugee"].Rows[i];
            f3.Text = datarow.ItemArray.GetValue(4).ToString();

            mi3.Text = datarow.ItemArray.GetValue(6).ToString();
            l3.Text = datarow.ItemArray.GetValue(7).ToString();
            mo3.Text = datarow.ItemArray.GetValue(8).ToString();
            sex3.Text = datarow.ItemArray.GetValue(9).ToString();
            dob3.Text = datarow.ItemArray.GetValue(11).ToString();
            p3.Text = datarow.ItemArray.GetValue(12).ToString();
            t3.Text = datarow.ItemArray.GetValue(14).ToString();
            r3.Text = datarow.ItemArray.GetValue(5).ToString();
            o3.Text = datarow.ItemArray.GetValue(17).ToString();
            //edu1.Text
            pictureEdit4.Image = ReadimagefromDbusingrc();
            fi3.Text = datarow.ItemArray.GetValue(4).ToString();
            readrow5();
        }

        private void readrow5()
        {
            i = 4;
            DataRow datarow = _db.GetReffugeebyRacionCArd(Convert.ToString(Searchtxtbox.Text)).Tables["AllReffugee"].Rows[i];
            f4.Text = datarow.ItemArray.GetValue(4).ToString();

            mi4.Text = datarow.ItemArray.GetValue(6).ToString();
            l4.Text = datarow.ItemArray.GetValue(7).ToString();
            mo4.Text = datarow.ItemArray.GetValue(8).ToString();
            sex4.Text = datarow.ItemArray.GetValue(9).ToString();
            dob4.Text = datarow.ItemArray.GetValue(11).ToString();
            p4.Text = datarow.ItemArray.GetValue(12).ToString();
            t4.Text = datarow.ItemArray.GetValue(14).ToString();
            r4.Text = datarow.ItemArray.GetValue(5).ToString();
            o4.Text = datarow.ItemArray.GetValue(17).ToString();
            //edu1.Text
            pictureEdit5.Image = ReadimagefromDbusingrc();
            fi4.Text = datarow.ItemArray.GetValue(4).ToString();
            readrow6();
        }


        private void readrow6()
        {
            i = 5;
            DataRow datarow = _db.GetReffugeebyRacionCArd(Convert.ToString(Searchtxtbox.Text)).Tables["AllReffugee"].Rows[i];
            f5.Text = datarow.ItemArray.GetValue(4).ToString();

            mi5.Text = datarow.ItemArray.GetValue(6).ToString();
            l5.Text = datarow.ItemArray.GetValue(7).ToString();
            mo5.Text = datarow.ItemArray.GetValue(8).ToString();
            sex5.Text = datarow.ItemArray.GetValue(9).ToString();
            dob5.Text = datarow.ItemArray.GetValue(11).ToString();
            p5.Text = datarow.ItemArray.GetValue(12).ToString();
            t5.Text = datarow.ItemArray.GetValue(14).ToString();
            r5.Text = datarow.ItemArray.GetValue(5).ToString();
            o5.Text = datarow.ItemArray.GetValue(17).ToString();
            //edu1.Text
            pictureEdit6.Image = ReadimagefromDbusingrc();
            fi5.Text = datarow.ItemArray.GetValue(4).ToString();
            readrow7();
        }

        private void readrow7()
        {
            i = 6;
            DataRow datarow = _db.GetReffugeebyRacionCArd(Convert.ToString(Searchtxtbox.Text)).Tables["AllReffugee"].Rows[i];
            f6.Text = datarow.ItemArray.GetValue(4).ToString();

            mi6.Text = datarow.ItemArray.GetValue(6).ToString();
            l6.Text = datarow.ItemArray.GetValue(7).ToString();
            mo6.Text = datarow.ItemArray.GetValue(8).ToString();
            sex6.Text = datarow.ItemArray.GetValue(9).ToString();
            dob6.Text = datarow.ItemArray.GetValue(11).ToString();
            p6.Text = datarow.ItemArray.GetValue(12).ToString();
            t6.Text = datarow.ItemArray.GetValue(14).ToString();
            r6.Text = datarow.ItemArray.GetValue(5).ToString();
            o6.Text = datarow.ItemArray.GetValue(17).ToString();
            //edu1.Text
            pictureEdit7.Image = ReadimagefromDbusingrc();
            fi6.Text = datarow.ItemArray.GetValue(4).ToString();
            readrow8();
        }

        private void readrow8()
        {
            i = 7;
            DataRow datarow = _db.GetReffugeebyRacionCArd(Convert.ToString(Searchtxtbox.Text)).Tables["AllReffugee"].Rows[i];
            f7.Text = datarow.ItemArray.GetValue(4).ToString();

            mi7.Text = datarow.ItemArray.GetValue(6).ToString();
            l7.Text = datarow.ItemArray.GetValue(7).ToString();
            mo7.Text = datarow.ItemArray.GetValue(8).ToString();
            sex7.Text = datarow.ItemArray.GetValue(9).ToString();
            dob7.Text = datarow.ItemArray.GetValue(11).ToString();
            p7.Text = datarow.ItemArray.GetValue(12).ToString();
            t7.Text = datarow.ItemArray.GetValue(14).ToString();
            r7.Text = datarow.ItemArray.GetValue(5).ToString();
            o7.Text = datarow.ItemArray.GetValue(17).ToString();
            //edu1.Text
            pictureEdit8.Image = ReadimagefromDbusingrc();
            fi7.Text = datarow.ItemArray.GetValue(4).ToString();
            readrow9();
        }

        private void readrow9()
        {
            i = 8;
            DataRow datarow = _db.GetReffugeebyRacionCArd(Convert.ToString(Searchtxtbox.Text)).Tables["AllReffugee"].Rows[i];
            f8.Text = datarow.ItemArray.GetValue(4).ToString();

            mi8.Text = datarow.ItemArray.GetValue(6).ToString();
            l8.Text = datarow.ItemArray.GetValue(7).ToString();
            mo8.Text = datarow.ItemArray.GetValue(8).ToString();
            sex8.Text = datarow.ItemArray.GetValue(9).ToString();
            dob8.Text = datarow.ItemArray.GetValue(11).ToString();
            p8.Text = datarow.ItemArray.GetValue(12).ToString();
            t8.Text = datarow.ItemArray.GetValue(14).ToString();
            r8.Text = datarow.ItemArray.GetValue(5).ToString();
            o8.Text = datarow.ItemArray.GetValue(17).ToString();
            //edu1.Text
            pictureEdit9.Image = ReadimagefromDbusingrc();
            fi8.Text = datarow.ItemArray.GetValue(4).ToString();
            readrow10();
        }

        private void readrow10()
        {
            i = 9;
            DataRow datarow = _db.GetReffugeebyRacionCArd(Convert.ToString(Searchtxtbox.Text)).Tables["AllReffugee"].Rows[i];
            f9.Text = datarow.ItemArray.GetValue(4).ToString();

            mi9.Text = datarow.ItemArray.GetValue(6).ToString();
            l9.Text = datarow.ItemArray.GetValue(7).ToString();
            mo9.Text = datarow.ItemArray.GetValue(8).ToString();
            sex9.Text = datarow.ItemArray.GetValue(9).ToString();
            dob9.Text = datarow.ItemArray.GetValue(11).ToString();
            p9.Text = datarow.ItemArray.GetValue(12).ToString();
            t9.Text = datarow.ItemArray.GetValue(14).ToString();
            r9.Text = datarow.ItemArray.GetValue(5).ToString();
            o9.Text = datarow.ItemArray.GetValue(17).ToString();
            //edu1.Text
            pictureEdit9.Image = ReadimagefromDbusingrc();
            fi9.Text = datarow.ItemArray.GetValue(4).ToString();
            readrow11();
        }

        private void readrow11()
        {
            i = 10;
            DataRow datarow = _db.GetReffugeebyRacionCArd(Convert.ToString(Searchtxtbox.Text)).Tables["AllReffugee"].Rows[i];
            f10.Text = datarow.ItemArray.GetValue(4).ToString();

            mi10.Text = datarow.ItemArray.GetValue(6).ToString();
            l10.Text = datarow.ItemArray.GetValue(7).ToString();
            mo10.Text = datarow.ItemArray.GetValue(8).ToString();
            sex10.Text = datarow.ItemArray.GetValue(9).ToString();
            dob10.Text = datarow.ItemArray.GetValue(11).ToString();
            p10.Text = datarow.ItemArray.GetValue(12).ToString();
            t10.Text = datarow.ItemArray.GetValue(14).ToString();
            r10.Text = datarow.ItemArray.GetValue(5).ToString();
            o10.Text = datarow.ItemArray.GetValue(17).ToString();
            //edu1.Text
            pictureEdit10.Image = ReadimagefromDbusingrc();
            fi10.Text = datarow.ItemArray.GetValue(4).ToString();
        }





        private Image ReadimagefromDbusingrc()
        {
            
            Image fetchedimg;
            byte[] fetchedimgbytes = (byte[])_db.GetReffugeebyRacionCArd(Convert.ToString(Searchtxtbox.Text)).Tables["AllReffugee"].Rows[i]["rfImage"];
            MemoryStream ms = new MemoryStream(fetchedimgbytes);
            fetchedimg = Image.FromStream(ms);

            return fetchedimg;
             
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void edu5_Click(object sender, EventArgs e)
        {

        }

        
    }
}
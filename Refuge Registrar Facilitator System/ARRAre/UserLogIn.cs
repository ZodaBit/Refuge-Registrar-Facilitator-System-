using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace ARRAre
{
    public partial class UserLogIn : SplashScreen
    {
        public UserLogIn()
        {
            InitializeComponent();
        }
        RefugeeDB _db = new RefugeeDB();
        int MaxRows;
        //public void logineed()
        //{
        //    try
        //    {
        //        if (uname.Text == "" || upassword.Text == "")
        //        {
        //            MessageBox.Show("please enetr user name & password");
        //        }
        //        else
        //        {
        //            conn.Open();
        //            SqlCommand scmd;
        //            SqlDataReader sdr;
        //            scmd = new SqlCommand("select UserName,Password,Userid from Useraccount where UserName=@Usernamee and Password=@Passworde", conn);

        //            scmd.Parameters.AddWithValue("@Usernamee", uname.Text);

        //            scmd.Parameters.AddWithValue("@Passworde", upassword.Text);
        //            sdr = scmd.ExecuteReader();
        //            while (sdr.Read())
        //            {
        //                labelControl3.Text = sdr["Userid"].ToString();
        //                labelControl4.Text = sdr["UserName"].ToString();
        //            }
        //            if (sdr.HasRows)
        //            {

        //                sdr.Close();
        //                clera();
        //                //  MessageBox.Show("Welcome you are succesfully log in", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                MainForm mf = new MainForm();
        //                mf.Show();
        //                this.Hide();
        //            }
        //            else
        //            {

        //                MessageBox.Show("Invalid Username or Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                clera();
        //            }
        //            conn.Close();

        //        }
        //    }
        //    catch (Exception gr)
        //    {
        //        MessageBox.Show(gr.Message.ToString());
        //    }
        //}

       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MaxRows = _db.LogUser(usernametextbox.Text, passwordtextbox.Text).Tables["LogUser"].Rows.Count;
            if(MaxRows!=0)
            {
                MDIParent1 ms = new MDIParent1();
                ms.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("wrong user name and  password");
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserLogIn_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
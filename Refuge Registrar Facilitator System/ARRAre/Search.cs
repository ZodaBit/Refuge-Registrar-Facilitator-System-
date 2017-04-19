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
using DevExpress.XtraReports.UI;

namespace ARRAre
{
    public partial class Search : DevExpress.XtraEditors.XtraForm
    {
        public Search()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MyReportDesigner px= new MyReportDesigner();
               // MyReportDesigner pxr =new  MyReportDesigner();
               
            px.Parameters["rfRCNO"].Value = textEdit1.Text;
            px.ShowPreview();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            
        }
    }
}
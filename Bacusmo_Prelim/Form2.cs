using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bacusmo_Prelim
{
    public partial class StudentInfo : Form
    {
        StudentDB stdDB = new StudentDB();
        public StudentInfo(StudentDB std)
        {
            InitializeComponent();
            this.stdDB = std;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }





        private void button1_Click(object sender, EventArgs e)
        {
            string id, lastname, firstname, middle, course, year;

            id = txb_ID.Text;
            firstname = txb_FN.Text;
            lastname = txb_LN.Text;
            middle = txb_MI.Text;
            course = cb_course.GetItemText(cb_course.SelectedItem);
            year = cb_year.GetItemText(cb_year.SelectedItem);

            stdDB.dgv_database.Rows.Add(id, lastname, firstname, middle, course, year);
        }

        private void txb_c_Click(object sender, EventArgs e)
        {
            txb_FN.Clear();
            txb_ID.Clear();
            txb_LN.Clear();
            txb_MI.Clear();
           
        }
    }
}

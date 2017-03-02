using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSortAssistant
{
    /// <summary>
    /// Apllication: A simple program for sorting assisting in the sorting of mail.
    /// Developer: Kalin Bowden.
    /// Date: 03.01.2017.
    /// Purpose: Uses provided inforamtion from an Access database spread to allow the user to search through the faculty to more easily sort USPS mail.
    /// </summary>
    public partial class Form1 : Form
    {
        // Class Level Varables.
        private Faculty faculty;
        private Faculty[] facultyArray = new Faculty[1000];
        private string value = "";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When this event fires it will sort thourgh the data in lex style.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxLastName_TextChanged(object sender, EventArgs e)
        {
            // Refresh and post results.
            Array.Clear(facultyArray, 0, facultyArray.Length - 1);
            lstBxResults.Items.Clear();
            value = txtBxLastName.Text;
            PostResults(value,"Name");

            // Disable other tetboxes.
            if (txtBxLastName.Text == "")
            {
                txtBxFirstName.Enabled = true;
                txtBxDept.Enabled = true;
            }
            else
            {
                txtBxFirstName.Enabled = false;
                txtBxDept.Enabled = false;
            }
        }

        /// <summary>
        /// When this event first it will search through the datas first names lex style.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// When this event first it will list all faculty that fall under that dept once "3" chars are entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxDept_TextChanged(object sender, EventArgs e)
        {
            //TODO.
        }

        /// <summary>
        /// This will disenable all other fields while text is curretnly in a field.
        /// </summary>
        public void ControlDataEntry()
        {
            //TODO.
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button will add a faculty member.", "Add", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button will edit a faculty member.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Provide basic help information.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        public void PostResults(string value, string column)
        {
            // Connect to DB.
            facultyArray = DataAdapter.Pull(value, column);
            
            // Add faculty to results.
            foreach (Faculty fac in facultyArray)
            {
                if (fac != null)
                {
                    lstBxResults.Items.Add(fac.ToString());
                }
            }// End of ForEach.
        }

    }// End of Class.
}// End of Solution.

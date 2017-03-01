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
    /// Purpose: Uses provided inforamtion in the form of Excel spread sheets to allow the user to search through the faculty to more easily sort USPS mail.
    /// </summary>
    public partial class Form1 : Form
    {
        // Class Level Varables.



        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When this event fires it will sort thourgh the datas last names lex style.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxLastName_TextChanged(object sender, EventArgs e)
        {

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

        }


        /// <summary>
        /// -STUB-
        /// TODO: Will search the data through the selected catagorey.
        /// </summary>
        /// <param name="dataCat"></param>
        public static void searchData(string dataCat, string value)
        {
            //TODO
        }
    }// End of Class.
}// End of Solution.

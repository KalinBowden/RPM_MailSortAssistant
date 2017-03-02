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
    /// Form: This form will allow the user to edit or add an faculty member to the excel worksheet.
    /// </summary>
    public partial class EditForm : Form
    {
        // Class Level Variables.
        public EditForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the use presses this button the data in the text boxes will be commited to memory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //TODO
        }

        /// <summary>
        /// When the user presses this button the data in the text boxes will not be commited to memoery and the form will exit back to form 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }// End of Class.
}// End of Solution.

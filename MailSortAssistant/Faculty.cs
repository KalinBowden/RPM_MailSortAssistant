using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSortAssistant
{
    /// <summary>
    /// Class: A class for creating objects that will hold OTC Faculty.
    /// Developer: Kalin Bowden.
    /// Date: 03.01.2017.
    /// </summary>
    class Faculty
    {
        // Class Level Varaibles.
        private string firstName;
        private string lastName;
        private string dept;
        private string note;
        private string name;

        /// <summary>
        /// Public constructor: Sets all values to defaults.
        /// Note: Forces the use of properties to set the object fields.
        /// </summary>
        public Faculty()
        {
            this.firstName = "Not Set";
            this.lastName = "Not Set";
            this.dept = "###";
            this.note = "-none-";
            this.name = "Not Set";
        }



        /// <summary>
        /// Set or get the first name of the faculty object..
        /// </summary>
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                // Check that a last name was set.
                if (value == "" || value == null)
                {
                    //TODO: Add warning.
                    this.firstName = "Not Set";
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        /// <summary>
        /// Set or get the last name of the faculty object.
        /// </summary>
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                // Check that a last name was set.
                if (value == "" || value == null)
                {
                    //TODO: Add warning.
                    this.lastName = "Not Set";
                }
                else
                {
                    lastName = value;
                }
            }
        }

        /// <summary>
        /// Set or get the department of the faculty object.
        /// </summary>
        public string Dept
        {
            get
            {
                return dept;
            }

            set
            {
                ////
                //if (value.Length > 3 || value.Length < 3)
                //{
                //    //TODO: add warning.
                //    dept = "###";
                //}
                //else
                //{
                //    dept = value;
                //}
                dept = value;
            }
        }

        /// <summary>
        /// Set or get the note of the employee;
        /// </summary>
        public string Note
        {
            get
            {
                return note;
            }

            set
            {
                // Check that a note was added.
                if (value == "" || value == null)
                {
                    //TODO: add warning.
                    note = "-none-";
                }
                else
                {
                    note = value;
                }
            }
        }

        /// <summary>
        /// Get or set the Faculty Name.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }



        /// <summary>
        /// Foramted ToString Method for returning values to the main form.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // Method level variables.
            string newString;

            // Format stirng.
            newString = string.Format("Name: {0,-40} Dept: {1}", this.name, this.dept);

            return newString;
        }

    }// End of Class.
}// End of solution.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAManagment
{
    public partial class frmLogin : Form
    {
        // connection to database
        private OleDbConnection myConn;

        public frmLogin()
        {
            InitializeComponent();
            // check if the file usr.log exist
            if (System.IO.File.Exists("TempData\\usr.log"))
            {
                // load the name of user (previosly written in txt file if a check box "remember me" has been checked
                LoadLogin();
                txtPassword.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // login admin password 1q2w
            // this variables will keep the user nick and password from database
            string userPasswordFromDatabase = null;

            /* If nick name is empty or passoword is long less than 1, show message
            * informing user about need to type login and password */
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || txtPassword.TextLength < 1)
            {
                MessageBox.Show("You didn't type in nick name or password");
            }
            // do, if nick and password is not empty
            else
            {                
                // create connection with database used the credentials written in connection string
                // "using" close and dispose the object to allow the resources to be used by other processes
                using (myConn = new OleDbConnection(dbConnection.dbConnect)) 
                {
                    try // try..catch will allow to catch unexpected errors and will allow for programmer to handle them safely
                    {
                        // open connection with database used the credentials written in connection string
                        myConn.Open();

                        // sql query send to database is written as string
                        // add one parameter to sql query to get data only one user with specific login
                        string sql = "SELECT * FROM users WHERE login=?;";

                        // create command using sql string and connection with database myConn
                        OleDbCommand myCmd = new OleDbCommand(sql, myConn);
                        // adding parameters to sql query
                        myCmd.Parameters.AddWithValue("login", txtLogin.Text);
                        // execute sql query
                        OleDbDataReader myDR = myCmd.ExecuteReader();

                        // read result
                        if (myDR.Read())
                        {
                            userPasswordFromDatabase = myDR["password"].ToString();
                        }

                        // compare if the typed password is equal with password from database
                        if (txtPassword.Text == userPasswordFromDatabase)
                        {
                            // save the user login in text file for next time if the user check remember me box
                            if (chbRememberMe.Checked)
                            {
                                SaveLogin(txtLogin.Text);
                            }
                            // clear text field
                            txtPassword.Text = "";
                            // open main form
                            new frmMain(userPasswordFromDatabase).ShowDialog();
                        }
                        else
                        {
                            // display the message
                            MessageBox.Show("Wrong password.");
                            // clear text field
                            txtPassword.Text = "";
                            // clear text field
                            txtLogin.Text = "";
                        }
                        
                    }
                    catch (OleDbException ex)
                    { 
                        // catch an error and holds all information in ex object
                        // display a message window to user
                        MessageBox.Show("Can not connect to database.");
                        // This is only for my information during the work, User will not see that.
                        // display the content of error message as text in console
                        Console.WriteLine(ex.ToString());
                        // display the error message in console
                        Console.WriteLine(ex.Message);
                    }
                }                
            }
        } // end of btnLogin_Click

        // this method will save user login for next time
        private void SaveLogin(string text)
        {
            string inputSaveData = text; // string which is going to be convert for ascii and hex
            string outputSaveData = null;
            // convert each character for ascii code            
            foreach (char c in inputSaveData)
            {
                int asciiCode = (int)c; //int asciiCode = (int)c+10;
                string hexValue = ConvertDecToHex(asciiCode);
                outputSaveData += hexValue + " ";
                // outputSaveData += String.Format("{0:X}", asciiCode); 
                /* might use this "format string" method above to convert number from dec to hex
                , but I wanted to create my method
                */
            }
            
            // create TempData folder if that folder does not exist
            if (!System.IO.Directory.Exists("TempData")) System.IO.Directory.CreateDirectory("TempData");
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("TempData\\usr.log"))
            {
                // write the string in the file
                writer.WriteLine(outputSaveData);
            }
        }

        // this method will convert any number from decimal to hexadecimal system
        private string ConvertDecToHex(int decimalNumber)
        {
            List<string> list = new List<string>();

            // the loop will coninue until the number is not 0
            while (decimalNumber != 0)
            {
                // modulo operation will keep remainder in integer variable
                int remainder = decimalNumber % 16;
                decimalNumber = (int)decimalNumber / 16;

                // if remainder is more than 9 assign the hex letter and add the hex number to list
                if (remainder > 9)
                {
                    switch (remainder)
                    {
                        case 10:
                            list.Add("A");
                            break;
                        case 11:
                            list.Add("B");
                            break;
                        case 12:
                            list.Add("C");
                            break;
                        case 13:
                            list.Add("D");
                            break;
                        case 14:
                            list.Add("E");
                            break;
                        case 15:
                            list.Add("F");
                            break;
                    }
                }
                else list.Add(remainder.ToString());
            }

            list.Reverse(); // reverse values in list collection

            string hexNumber = null;
            // make a hex number as a complete string
            foreach (string s in list)
            {
                hexNumber += s;
            }
            return hexNumber;
        }

        // load main variables like live, points and level, The player has possibility to start the game on level when he finished last time
        private void LoadLogin()
        {
            try
            {                
                // try to open the file with user login saved in text file    
                System.IO.StreamReader source = new System.IO.StreamReader("TempData\\usr.log");
                string line = source.ReadLine(); // read text line from selected file
                // close file
                source.Close();

                string[] hex = line.Split(' '); // split the string from file for seperate strings in array
                int[] numbers = new int[hex.Length - 1];

                for (int i = 0; i < hex.Length - 1; i++) // hex.length-1 because last char is white space in save file
                {
                    numbers[i] = ConvertHexToDec(hex[i]); // the numbers conversion from hexadecimal to decimal
                }

                // change ascii code for characters and add them to one string
                string tempString = null;
                for (int i = 0; i < numbers.Length; i++)
                {
                    char tempLetter = (char)numbers[i]; // casting int number for char
                    tempString = tempString + tempLetter.ToString();
                }
                // cutting variables values from string
                txtLogin.Text = tempString.Substring(0, tempString.Length);         
            }            
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message.ToString());
                Console.WriteLine("The usr.log file is wrong.");
            }
        }

        // this method convert any hex number ex. FF, 1A, 3C for integer number
        private int ConvertHexToDec(string p)
        {
            char[] characters = new char[p.Length];
            characters = p.ToCharArray(); // convert every letter or number from string to char array (each character seperately)
            int sum = 0;

            for (int j = 0; j < characters.Length; j++)
            {
                int number = 0;

                if (Char.IsLetter(characters[j])) // check if characters is letter
                {
                    switch (characters[j])
                    {
                        case 'A':
                            number = 10;
                            break;
                        case 'B':
                            number = 11;
                            break;
                        case 'C':
                            number = 12;
                            break;
                        case 'D':
                            number = 13;
                            break;
                        case 'E':
                            number = 14;
                            break;
                        case 'F':
                            number = 15;
                            break;
                    }
                }
                else number = (int)Char.GetNumericValue(characters[j]);
                /* sum of numbers multiply by 16 to increase power 0,1,2,3 etc. depend on position
                 * last number power to 0, before last power to 1, before before last power to 2
                 */
                sum += number * (int)Math.Pow(16, characters.Length - j - 1);
            }
            return sum;
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            // check if the file usr.log exist
            if (System.IO.File.Exists("TempData\\usr.log"))
            {
                // set focus on text field
                txtPassword.Focus();
            }
        }
    }
}

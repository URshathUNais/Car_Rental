using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.come_code
{
    internal class ComClass
    {
        //application close btn click fun
        public void appsCloseBtnFun()
        {
            Application.Exit();
        }

        //Form1 close btn click
        public void formCloseBtnFun(Form forName)
        {
            forName.Close();
        }

        //application min btn click fun
        public void appsMinBtnFun(Form forName)
        {
            forName.WindowState = FormWindowState.Minimized;
        }

        //application new form open btn witout close current form
        public void appsNewFormOpenBtnWithoutCirrentFormClose(Form forName)
        {
            forName.Show();
        }

        //application new form open btn with  close current form
        public void appsNewFormOpenBtnWithCurrentFormClose(Form forName, Form currentform)
        {
            forName.Show();
            currentform.Hide();
        }

        //Display form inside panel
        public void appsFormLoadInsidePanel(Form forName, Panel panelName)
        {
            //clear Constrols first
            panelName.Controls.Clear();

            //add controls
            forName.TopLevel = false;
            forName.AutoScroll = true;
            panelName.Controls.Add(forName);
            forName.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            forName.Dock = DockStyle.Fill;
            forName.Show();
        }

        //cpnvert strin to int
        public int convertStringToInt(string str)
        {
            int myRet = 0;

            try
            {
                if (str != "")
                {
                    myRet = int.Parse(str);
                }
                else
                {
                    myRet = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return myRet;
        }

        //convert string to int
        public DateTime convertStringToDateTime(string str)
        {
            DateTime myRet = new DateTime();

            try
            {
                //"2009-05-08 14:40:52,531"
                DateTime.TryParseExact(str, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out myRet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return myRet;
        }

        //check emptyBox
        public bool checkEmptyBoxFun(List<TextBox> List)
        {
            bool myRet = true;

            foreach (TextBox myBox in List)
            {
                if (myBox.Text.Equals(""))
                {
                    myBox.BackColor = Color.MediumVioletRed;
                    myRet = false;
                    break;
                }
                else
                {
                    myBox.BackColor = Color.White;
                }
            }
            return myRet;
        }

        //check emptyBox
        public bool checkEmptyBoxFun(List<DateTimePicker> List)
        {
            bool myRet = true;

            foreach (DateTimePicker myBox in List)
            {
                if (myBox.Text.Equals(""))
                {
                    myBox.BackColor = Color.MediumVioletRed;
                    myRet = false;
                    break;
                }
                else
                {
                    myBox.BackColor = Color.White;
                }
            }
            return myRet;
        }
        //clear textBox
        public void clearBoxFun(List<TextBox>list)
        {
            foreach(TextBox Box in list)
            {
                Box.Clear();
            }
        }

        //clear date time picker
        public void clearBoxFun(List<DateTimePicker>list)
        {
            foreach(DateTimePicker Box in list)
            {
                Box.Text = "";
            }
        }

        //get selected date Val
        public string getDataPickerDate(DateTimePicker box)
        {
            string myRet = "";
            myRet = box.Value.ToString("yyyy-MM-dd");
            return myRet;
        }

        //get selected time Val
        public string getDataPickerTime(DateTimePicker box)
        {
            string myRet = "";
            myRet = box.Value.ToString("HH:mm:ss");
            return myRet;
        }
    }
}

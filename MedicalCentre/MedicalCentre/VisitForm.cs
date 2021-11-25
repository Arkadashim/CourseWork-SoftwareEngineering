using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedicalCentre
{
    public partial class VisitForm : Form
    {
        public VisitForm()
        {
            InitializeComponent();
            DatetextBox.MaxLength = 10;
            DBcounter = 0;
            IncorrectPass.Text = "";
            IncorrectCost.Text = "";
            IncorrectService.Text = "";
        }
        private int DBcounter;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatetextBox_TextChanged(object sender, EventArgs e)
        {
            if (DatetextBox.Text.Length != 0) {
                bool check = false;
                if (DatetextBox.Text.EndsWith('.')) check = true;
                else
                {
                    foreach (char i in Numbers)
                    {
                        if (DatetextBox.Text.EndsWith(i))
                        {
                            check = true;
                            break;
                        }
                    }
                }
                if (!check)
                {
                    if (DatetextBox.Text.Length == 1) DatetextBox.Text = "";
                    else DatetextBox.Text = DatetextBox.Text.Remove(DatetextBox.Text.Length - 1);
                    DatetextBox.SelectionStart = DatetextBox.Text.Length;
                }
                else
                {
                    if (DBcounter < DatetextBox.Text.Length && (DatetextBox.Text.Length == 2 || DatetextBox.Text.Length == 5))
                    {
                        DatetextBox.Text += ".";
                        DatetextBox.SelectionStart = DatetextBox.Text.Length;
                    }
                    if (DBcounter > DatetextBox.Text.Length && DatetextBox.Text.EndsWith('.'))
                    {
                        //DatetextBox.Text = DatetextBox.Text.Remove(DatetextBox.Text.Length - 1);
                        //DatetextBox.SelectionStart = DatetextBox.Text.Length;
                    }
                    if (DBcounter < DatetextBox.Text.Length) DBcounter = DatetextBox.Text.Length + 1;
                    if (DBcounter > DatetextBox.Text.Length) DBcounter = DatetextBox.Text.Length - 1;
                }
            }
        }
        private char[] Numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private bool isCorrectService()
        {
            bool check;
            try
            {
                int s = Convert.ToInt32(CosttextBox.Text);
                check = true;
            }
            catch(System.FormatException)
            {
                check = false;
            }
            return check;
        }
        private Boolean isCorrectDate(String tempdate)
        {
            Boolean result = true;
            char[] Arr = tempdate.ToCharArray();
            if (Arr.Length != 10) result = false;
            else
            if (Arr[2] != '.' || Arr[5] != '.') result = false;
            else
                for (int i = 0; i <= Arr.Length - 1; i++)
                {
                    if (i == 2 || i == 5)
                    {

                    } else
                    for (int j = 0; j < Numbers.Length; j++)
                    {
                        result = false;
                        if (Arr[i] == Numbers[j])
                        {
                            result = true;
                            break;
                        }
                    }
                    if (!result) break;
                }
            if (result == true)
            {
                int day = (((int)tempdate[0] - 48) * 10) + ((int)tempdate[1] - 48);
                int month = (((int)tempdate[3] - 48) * 10) + ((int)tempdate[4] - 48);
                int year = (((int)tempdate[6] - 48) * 1000) + (((int)tempdate[7] - 48) * 100) + (((int)tempdate[8] - 48) * 10) + ((int)tempdate[9] - 48);
                if (month > 12 || month == 0 || day == 0 || day > 31) result = false;
                if (month == 2 && ((year % 4 != 0 && day > 28) || (year % 4 == 0 && day > 29 && year % 100 != 0))) result = false;
                if ((month == 4 || month == 6 || month == 9 || month == 11) && (day > 30)) result = false;
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isCorrectDate(DatetextBox.Text) && isCorrectService() && ServicetextBox.Text != "") 
            {
                MainForm mainF = this.Owner as MainForm;
                mainF.GetSelectPat().AddVisit(DatetextBox.Text, ServicetextBox.Text, Convert.ToInt32(CosttextBox.Text));
                mainF.RefreshVisitGrid(mainF.GetPatTable());
                mainF.RefreshPatientGrid(mainF.GetMCTable());
                mainF.setsaved(false);
                mainF.refreshTotalCost();
                this.Close();
            } else
            {
                if (!isCorrectDate(DatetextBox.Text)) IncorrectPass.Text = "Некорректный ввод даты"; else IncorrectPass.Text = "";
                if (!isCorrectService()) IncorrectCost.Text = "Некорректная стоимость"; else IncorrectCost.Text = "";
                if (ServicetextBox.Text == "") IncorrectService.Text = "Заполните поле"; else IncorrectService.Text = "";
            }
        }
    }
}

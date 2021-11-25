using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedicalCentre
{
    public partial class PatientInput : Form
    {
        public PatientInput()
        {
            InitializeComponent();
        }
        
        private void PatientNameInput_Click(object sender, EventArgs e)
        {
            PatientNameInput.Text = "";
            PatientNameInput.ForeColor = Color.Black;
        }

        private void PatientInput_Click(object sender, EventArgs e)
        {
            if (PatientNameInput.Text == "")
            {
                PatientNameInput.Text = "Введите имя пациента";
                PatientNameInput.ForeColor = Color.DarkGray;
            }
        }
        private bool correctname(string name)
        {
            bool check = true;
            char[] arr = name.ToCharArray();
            for (int i=0; i<arr.Length; i++)
            {
                int code = (int)arr[i];
                if ((code < 65 && code!=32 && code != 45) || (code > 90 && code < 97) || (code > 122 && code < 1040) || (code>1103)) check=false;
            }
            return check;
        }
        private void PatientInputButton_Click(object sender, EventArgs e)
        {
            MainForm mainF = this.Owner as MainForm;
            if (PatientNameInput.Text == "" || PatientNameInput.Text == "Введите имя пациента") MessageBox.Show(
                "Вы не ввели имя пациента", "Ошибка", MessageBoxButtons.OK);
            else if (mainF.GetMCCheckingName(PatientNameInput.Text) == false)
                MessageBox.Show("Пациент с таким именем уже существует", "Ошибка", MessageBoxButtons.OK);
            else if (!correctname(PatientNameInput.Text)) MessageBox.Show("Некорректные символы","Ошибка",MessageBoxButtons.OK);
            else
            {
                Patient temp = new Patient(PatientNameInput.Text);
                mainF.AdderForMC(temp);
                //mainF.AddPatInGrid(temp);
                mainF.RefreshPatientGrid(mainF.GetMCTable());
                mainF.setsaved(false);
                mainF.refreshTotalCost();
                Close();
            }
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        Point lPoint;
        private void UpperPanelInputForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lPoint.X;
                this.Top += e.Y - lPoint.Y;
            }
        }

        private void XButton_MouseDown(object sender, MouseEventArgs e)
        {
            lPoint = new Point(e.X, e.Y);
        }

        private void PatientInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) PatientInputButton_Click(sender, e);
        }
    }
}

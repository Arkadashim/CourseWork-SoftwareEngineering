using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalCentre
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            index = -1;
            saved = true;
        }
        private MedicalCentreCS MC;
        private int index;
        private bool saved;
        public bool setsaved(bool value) => saved = value; 
        private void MainForm_Load(object sender, EventArgs e)
        {
            MC = new MedicalCentreCS("MC № 42/12");
        }
        private void renewMC()
        {
            MC = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            MC = new MedicalCentreCS("MC № 42/12");
        }
        private void AddPatButton_Click(object sender, EventArgs e)
        {
            if (MC.GetPatQuant() < MC.GetN())
            {
                PatientInput patform = new PatientInput();
                patform.Owner = this;
                patform.ShowDialog();
            }
            else MessageBox.Show("Невозможно добавить нового пациента", "Ошибка", MessageBoxButtons.OK);
        }
        public Patient GetSelectPat()
        {
            return MC.GetPatientBySurname(PatientsGrid[0, index].ToolTipText);
        }
        public void AddVisitForPat(Patient pat, string name, string serv, int cost) => pat.AddVisit(name, serv, cost);
        public void AddPatInGrid(Patient temp)
        {
            string[] nextRow = new string[] { temp.GetSurname(), Convert.ToString(temp.GetTotalCost()) };
            PatientsGrid.Rows.Add(nextRow);
            PatientsGrid.ClearSelection();
        }
        public void refreshTotalCost()
        {
            MC.SetTotalCost(MC.CalculateTotalCost());
            TotalCostLabel.Text = "Суммарная стоимость услуг по медицинскому центру: " + Convert.ToString(MC.CalculateTotalCost());
        }
        public void RefreshPatientGrid(string [][] arr)
        {
            PatientsGrid.Rows.Clear();
            string [] nextrow;
            for (int i = 0; i < arr.Length; i++) if (arr[i] != null)
            {
                nextrow = new string[2];
                nextrow = arr[i];
                PatientsGrid.Rows.Add(nextrow);
                PatientsGrid.ClearSelection();
            }
        }
        public void RefreshVisitGrid(string [][] arr)
        {
            if (arr != null)
            {
                VisitsGrid.Rows.Clear();
                string[] nextrow;
                for (int i = 0; i < arr.Length; i++) if (arr[i]!=null)
                    {
                        nextrow = new string[3];
                        nextrow = arr[i];
                        VisitsGrid.Rows.Add(nextrow);
                    }
            }
        }
        public bool GetMCCheckingName(String name) => MC.CheckingSurname(name);
        public void AdderForMC(Patient adding) => MC.AddPatient(adding);
        public string[][] GetMCTable() => MC.GetMCTable();
        public string[][] GetPatTable() => GetSelectPat().GetPatTable();
        private void MainForm_Click(object sender, EventArgs e)
        {
            index = -1;
            PatientsGrid.ClearSelection();
            VisitsGrid.Rows.Clear();
            AboveVisitLabel.Text = "";
            
        }

        private void DeletePatButton_Click(object sender, EventArgs e)
        {
            MC.DelPatient();
            RefreshPatientGrid(MC.GetMCTable());
            refreshTotalCost();
            saved = false;
            if (MC.GetPatQuant() == 0)
            {
                VisitsGrid.Rows.Clear();
                AboveVisitLabel.Text = "";
            }
        }
        private void PatientsGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            Patient temppat = GetSelectPat();
            if (temppat.GetVisits() == 0) VisitsGrid.Rows.Clear();
            else RefreshVisitGrid(temppat.GetPatTable());
            AboveVisitLabel.Text = "Пациент: "+temppat.GetSurname();
        }
/*
 * РУССКИЕ ВПЕРЕД!
 * РУССКИЕ ВПЕРЕД!
 * 
 */
        private void AddVisButton_Click(object sender, EventArgs e)
        {
            try
            {
                Patient temppat;
                temppat = MC.GetPatientBySurname(PatientsGrid[0, index].ToolTipText);
                VisitForm visform = new VisitForm();
                visform.Owner = this;
                visform.ShowDialog();
            }
            catch (Exception) { MessageBox.Show("Не выбран пациент", "Ошибка", MessageBoxButtons.OK); }
        }
        private void DelVisButton_Click(object sender, EventArgs e)
        {
            try
            {
                Patient temp = MC.GetPatientBySurname(PatientsGrid[0, index].ToolTipText);
                if (temp.GetVisits() != 0) temp.DeleteVisit(VisitsGrid[0, visindex].ToolTipText);
                else PatientsGrid.Rows.Clear(); 
                refreshTotalCost(); 
                RefreshVisitGrid(temp.GetPatTable()); 
                RefreshPatientGrid(GetMCTable()); 
            }
            catch (Exception) { MessageBox.Show("Не выбрано посещение", "Ошибка", MessageBoxButtons.OK); }
        }
        private int visindex;
        private void VisitsGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            visindex = e.RowIndex;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (MC.GetPatQuant()==0)
            {
                MessageBox.Show("Нет структур для сохранения", "Ошибка", MessageBoxButtons.OK);
            } else
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine(MC.GetPatQuant());
                        for (int i = 0; i < MC.GetPatQuant(); i++)
                        {
                            {
                                Patient temp = MC.GetPatientBySurname(PatientsGrid[0, i].ToolTipText);
                                sw.WriteLine(temp.GetSurname());
                                sw.WriteLine(Convert.ToString(temp.GetVisits()));
                                if (temp.GetVisits() != 0)
                                {
                                    Visit tvis = temp.GetFirstVisit();
                                    for (int j = 0; j < temp.GetVisits(); j++)
                                    {
                                        sw.WriteLine(tvis.GetDate());
                                        sw.WriteLine(tvis.GetService());
                                        sw.WriteLine(Convert.ToString(tvis.GetCost()));

                                        tvis = tvis.GetNextV();
                                    }
                                }
                            }
                        }
                    }
                    saved = true;
                }
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (MC.GetPatQuant()!=0 && saved == false)
            {
                DialogResult result = 
                MessageBox.Show("Сохранить текущие структуры?", "Остались несохраненные изменения", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) SaveButton_Click(sender, e);
            }
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    renewMC();
                    string nextline;
                    using (StreamReader sw = new StreamReader(ofd.FileName))
                    {
                        int indexi = Convert.ToInt32(sw.ReadLine());
                        for (int i=0; i<indexi; i++)
                        {
                            nextline = sw.ReadLine();
                            Patient temppat = new Patient(nextline);
                            MC.AddPatient(temppat);
                            int indexj = Convert.ToInt32(sw.ReadLine());
                            for (int j = 0; j<indexj; j++)
                            {
                                string tempdate = sw.ReadLine();
                                string tempserv = sw.ReadLine();
                                int tempcost = Convert.ToInt32(sw.ReadLine());
                                temppat.AddVisit(tempdate, tempserv, tempcost);
                            }
                        }
                    }
                    RefreshPatientGrid(GetMCTable());
                    refreshTotalCost();
                } catch (Exception)
                {
                    MessageBox.Show("Неверная конфигурация файла","Ошибка", MessageBoxButtons.OK); 
                }
            }
        }
    }
}

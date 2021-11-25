using System;

public class MedicalCentreCS
{
	private String Name; // имя медицинского центра
	private Patient[] Patients; // массив объектов класса Patient
	private int Last, First, PatQuant; // Last - индекс последнего, First - индекс первого, PatQuant - колиечтво пациентов 
	private int TotalMCCost; // размер массива

	private const int N = 10;
	public MedicalCentreCS(String aName) // конструктор объекта
	{
		Name = aName;
		Patients = new Patient[N];
		Last = 0; First = 0; PatQuant = 0;
	}

	public String GetName() => this.Name; // функция получения имени
	public Patient[] GetPatients() => this.Patients;
	public int GetN() => N;
	public int GetPatQuant() => this.PatQuant;
	public int GetTotalCost() => this.TotalMCCost;
	public void SetTotalCost(int newTotalCost) => this.TotalMCCost = newTotalCost;
	public int CalculateTotalCost()
    {
		int result = 0;
		if (PatQuant != 0)
		{
			int i = First;
			do
			{
				result += Patients[i].GetTotalCost();
				i++;
				if (i == N) i = 0;
			}
			while (i != Last);
		}
		return result;
	}
	public Patient GetPatientBySurname(String surname)
		// функция, возвращающая объект класса Patient по совпадению его поля Surname с входной переменной типа String
    {
		int i = First;
		Patient result = null;
		do
		{
			if (i == N && Last != N-1) i = 0;
			if (Patients[i].GetSurname() == surname)
			{
				result = Patients[i];
				break;
			}
			i++;
		} while (i != Last);
		return result;
    }
	public Boolean AddPatient(Patient NewP)
    {
		if (PatQuant == N) return false;
		else
		{
			Patients[Last] = NewP;
			Last++; 
			PatQuant++;
			if (Last == N) Last = 0;
			return true;
		}
    }
	public Boolean CheckingSurname(String surname)
    {
		Boolean result = true;
		if (PatQuant == 0) return result;
		else
		{
			int i = First;
			do
			{
				if (surname == Patients[i].GetSurname())
				{
					result = false;
					break;
				}
				i++;
				if (i == N) i = 0;
			}
			while (i != Last);
		}
		return result;
	}
	public String OutputData()
		// функция, возвращающая строку с информацией о пациентах
    {
		String result = "";
		if (PatQuant == 0) result = "There are no patients.";
		else
		{
			int i = First;
			int number = 1;
			do
			{
				result = result + "Patient №" + number + " - " + Patients[i].GetSurname() + ":\n" + Patients[i].GetVisitInform();
				if (Patients[i].GetFirstVisit() != null) result = result + "Total price: " + Patients[i].GetTotalCost() + "\n";
				number++; i++;
				if (i == N) i = 0;
			}
			while (i != Last);
			result += "Total Cost in MC: " + GetTotalCost() + ".";
		}
		return result;
    }
	public Boolean DelPatient()
		// функция удаляет пациента из очереди, возвращая логическое значение в зависимости от успешности операции
    {
		if (PatQuant == 0) return false; else
        {
			Patients[First] = null;
			First++;
			if (First == N) First = 0;
			PatQuant--;
			return true;
        } 
    }
	public string [][] GetMCTable()
    {
        string[][] arr = new string[N][];
		for (int i=0; i<N; i++) if (Patients[i] != null)
        {
				arr[i] = new string[] { Patients[i].GetSurname(), Convert.ToString(Patients[i].GetTotalCost()) };
        }
		return arr;
    }
}

using System;

public class Patient
{
    private String Surname; // фамилия пациента
    private int Visits; // количество посещений
    private int TotalCost; // суммарная стоимость услуг
    private readonly Visit Head; // заголовочный элемент

    public Patient(String aSurname) // конструктор класса Patient
    {
        this.Surname = aSurname;
        this.Visits = 0;
        this.TotalCost = 0;
        this.Head = new Visit(null,null,0);
        this.Head.SetNextV(null);
    }

    public void SetSurname(String newSurname) => this.Surname = newSurname;
    public String GetSurname() => this.Surname;
    public void SetVisits(int newVisits) => this.Visits = newVisits;
    public int GetVisits() => this.Visits;
    public void SetTotalCost(int newTotalCost) => this.TotalCost = newTotalCost;
    public int GetTotalCost() => this.TotalCost;
    public Visit GetFirstVisit() => this.Head.GetNextV();
    public String GetVisitInform()
        // возвращает строку с информацией о приемах пациента
    {
        String result="";
        Visit Current = Head.GetNextV();
        if (Current != null)
            do
            {
                result = result + "Date: " + Current.GetDate() + " | Service: " + Current.GetService() + " | Cost: " + Current.GetCost() + "\n";
                Current = Current.GetNextV();
            } while (Current != Head.GetNextV());
        else result = "No visits!\n";
        return result;
    }
    public int CalculateTotalCost()
        // функция подсчета общей стоимости услуг для пациента
    {
        int result = 0;
        Visit Curr = Head.GetNextV();
        do
        {
            result += Curr.GetCost();
            Curr = Curr.GetNextV();
        } while (Curr != Head.GetNextV());
        return result;
   
    }
    public Boolean isDateEarlier(String firstD, String secondD)
        // вспомогательная функция для обеспечения упорядоченности списка, определяется, какая из двух дат раньше
    {
        Boolean result = false;
        char[] DateFirst = firstD.ToCharArray();
        char[] DateSecond = secondD.ToCharArray();
        int yearF = (((int)DateFirst[6] - 48) * 1000) + (((int)DateFirst[7] - 48)*100) + (((int)DateFirst[8] - 48)*10) + ((int)DateFirst[9] - 48);
        int yearS = (((int)DateSecond[6] - 48) * 1000) + (((int)DateSecond[7] - 48) * 100) + (((int)DateSecond[8] - 48) * 10) + ((int)DateSecond[9] - 48);
        if (yearF < yearS) result = true;
        else if (yearF == yearS)
        {
            int monthF = (((int)DateFirst[3] - 48) * 10) + ((int)DateFirst[4] - 48);
            int monthS = (((int)DateSecond[3] - 48) * 10) + ((int)DateSecond[4] - 48);
            if (monthF < monthS) result = true;
            else if (monthS == monthF)
            {
                int dayF = (((int)DateFirst[0] - 48) * 10) + ((int)DateFirst[1] - 48);
                int dayS = (((int)DateSecond[0] - 48) * 10) + ((int)DateSecond[1] - 48);
                if (dayF < dayS) result = true; 
            }
        }
        return result;
    }
    public Boolean CheckingDate(String date)
    {
        Boolean result = true;
        if (this.Head.GetNextV() != null)
        {
            Visit Curr = Head.GetNextV();
            do
            {
                if (date == Curr.GetDate())
                {
                    result = false;
                    break;
                }
                else Curr = Curr.GetNextV();
            } while (Curr != Head.GetNextV());
        }
        return result;
    } 
    public Visit GetVisitByDate(String date)
    {
        Boolean success = false;
        Visit Curr = Head.GetNextV();
        do
            if (Curr.GetDate() == date)
            {
                success = true;
                break;
            }
            else Curr = Curr.GetNextV();
        while (Curr != Head.GetNextV());
        if (success == false) return null; else return Curr;
    }
    public void AddVisit(String aDate, String aService, int aCost)
        // процедура добавления посещения
    {
        Visit Temp = new Visit(aDate,aService,aCost);
        if (Head.GetNextV() == null)
        {
            Temp.SetNextV(Temp);
            this.Head.SetNextV(Temp);
        } else {
            Visit Current = Head.GetNextV();
            Visit uCurrent = Current;
            Visit L = Head.GetNextV();
            while (L.GetNextV() != Head.GetNextV()) L = L.GetNextV();
            while (isDateEarlier(Temp.GetDate(), Current.GetDate()) == false && Current.GetNextV()!=Head.GetNextV())
            {
                uCurrent = Current;
                Current = Current.GetNextV();
            }
            if (Current == Head.GetNextV() && isDateEarlier(Temp.GetDate(), Current.GetDate()))
            {
                this.Head.SetNextV(Temp);
                L.SetNextV(Temp);
                Temp.SetNextV(Current);
            } else if (Current.GetNextV()==Head.GetNextV() && isDateEarlier(Temp.GetDate(), Current.GetDate()) == false)
            {
                Current.SetNextV(Temp);
                Temp.SetNextV(Head.GetNextV());
            } else
            {
                Temp.SetNextV(Current);
                uCurrent.SetNextV(Temp);
            }
        }
        this.Visits++;
        this.SetTotalCost(CalculateTotalCost());
        
    }
    public Boolean DeleteVisit(String date)
        // функция удаления посещения, возвращающая логического значение в зависимости от успешности
    {
        Visit Curr = GetVisitByDate(date);
        if (Curr == null) return false; else
        {
            if (Curr == Head.GetNextV() && Curr.GetNextV() == Curr)
            {
                Head.SetNextV(null);
                Curr = null;
            }
            else
            {
                Visit Prev = Head.GetNextV();
                while (Prev.GetNextV() != Curr) Prev = Prev.GetNextV();
                Prev.SetNextV(Curr.GetNextV());
                if (Curr == Head.GetNextV()) Head.SetNextV(Curr.GetNextV());
                Curr = null;
            }
            this.Visits--;
            if (Visits != 0) this.SetTotalCost(CalculateTotalCost());
            else this.SetTotalCost(0);
            return true;
        }
    }
    public string[][] GetPatTable()
    {
        string[][] arr = new string[Visits][];
        Visit Temp;
        if (Visits != 0)
        {
            Temp = Head.GetNextV();
            for (int i = 0; i < Visits; i++)
            {
                arr[i] = new string[] { Temp.GetDate(), Temp.GetService(), Convert.ToString(Temp.GetCost()) };
                Temp = Temp.GetNextV();
            }
            return arr;
        }
        else return null;
        
    }
}

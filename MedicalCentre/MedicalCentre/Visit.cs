using System;

public class Visit
{
	private String Date; // дата визита
	private String Service; // оказанная услуга
	private int Cost; // стоимость услуги
    private Visit NextV; // следующий визит

    public Visit(String aDate, String aService, int aCost)
    {
        this.Date = aDate;
        this.Service = aService;
        this.Cost = aCost;
        this.NextV = null;
    }

    public void SetDate(String newDate) => this.Date = newDate;
    public void SetServise(String newService) => this.Service = newService;
    public void SetCost(int newCost) => this.Cost = newCost;
    public void SetNextV(Visit newVisit) => this.NextV = newVisit;
    public String GetDate() => this.Date;
    public String GetService() => this.Service;
    public int GetCost() => this.Cost;
    public Visit GetNextV() => this.NextV;
    
}

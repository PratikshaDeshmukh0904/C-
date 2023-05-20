public class SalesMan : Employee
{
    //field
    private string _region;
    //constructor of child class
    public SalesMan(int empID,string empName,string location,string region):base(empID,empName,location)
    { 
        this._region = region;
    }

    //property
    public string Region
    {
        set
        
        { 
            _region = value;
        }
        get 
        { 
            return _region;
        }
    }

    //method
    public long GetSalesofCurrentMonth()
    {
        return 100;
    }

    //override method for method overriding
    public override string GetHealthInsuranceMethod1()
    {
        System.Console.WriteLine(base.GetHealthInsuranceMethod1());
        return "Health Insurance amount is:" + 1000;
    }

    //method overriding of abstract method
    public override string GetHealthInsuranceMethod()
    {
        return "Health Insurance amount of salesmaneis:" + 1000;
    }
} 
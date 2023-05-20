public class Manager : Employee
{
    //field
    private string _departmentName;

    //Constructor of child class
    public Manager(int empID, string empName, string location, string departmentName) : base(empID
        , empName, location)
    {

        this.DepartmentName = departmentName;

    }
    //method hiding
    public new string GetHealthInsuranceMethod()
    {
        return "Health Insurance amount is:" + 1500;
    }
    //property
    public string DepartmentName
    {
        set
        {
            _departmentName = value;
        }
        get
        {
            return _departmentName;
        }
    }

    //method
    public long GetTotalSalesofTheYear()
    {
        return 1000;
    }

    //method
    public string GetFullDepartmentName()
    {
        return DepartmentName + "at" + base.Location;
    }

    //sealed method
    public sealed override string GetHealthInsuranceMethod1()
    {
        return base.GetHealthInsuranceMethod1();
    }

    
}
public class BranchManager : Manager
{
    //Constructor of child class
    public BranchManager(int empID, string empName, string location, string departmentName) : base(empID
        , empName, location)
    {

       

    }
    public  override string GetHealthInsuranceMethod1()
    {
        return base.GetHealthInsuranceMethod1();
    }
}


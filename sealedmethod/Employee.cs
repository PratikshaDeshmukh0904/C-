public class Employee
{
    //fields
    private int _empID;
    private string _empName;
    private string _location;

    //constructor
    public Employee(int empId, string empName, string location)
    {
        this._empID = empId;
        this._empName = empName;
        this._location = location;
    }

    //method for method hiding 
    public string GetHealthInsuranceMethod()
    {
        return "Health Insurance amount is:" + 500;
    }

    // virtual method for method overriding
    public virtual string GetHealthInsuranceMethod1()
    {
        return "Health Insurance amount is:" + 500;
    }
    //properties

    public int EmployeeID
    {
        set
        {
            _empID = value;
        }
        get
        {
            return _empID;
        }
    }
    public string EmployeeName
    {
        set
        {
            _empName = value;
        }

        get
        {
            return _empName;
        }
    }
    public string Location
    {
        set
        {
            _location = value;

        }
        get
        {
            return _location;
        }
    }
}


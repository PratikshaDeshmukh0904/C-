public class Employee
{
    //instance field
    private int _empId;
    private string _empName;
    private string _job;

    private double _salary;

    private double _tax;
    //instance property
    public int EmpID
    {
        set 
        {
           if(value >=100)
            {
                _empId = value;
            }
        }
        get
        {
            return _empId;
        }
    }

    //instance property
    public string EmployeeName
    {
        set
        {
            if (value.Length >= 100)
            {
                _empName = value;
            }
        }
        get
        {
            return _empName;
        }
    }

    //instance property
    public string Job
    {
        set
        {
            _job = value;
        }
        get
        {
            return _job;
        }
    }
    //static field
    private static string _companyName;

    //static property
    public static string CompanyName
    {
        set
        {
            if(value.Length >= 20)
            {
                _companyName = value;
            }
        }
        get
        {
            return _companyName;
        }
    }
    //instance constructor
    public Employee(int empId,string empName,string job)
    {
       this._empId = empId;
       this._empName = empName;
       this._job = job;
       this._salary = 1000;
    }

    //constructor2
    public Employee(int empId,string empName)
    {
        _empId = empId;
        _empName = empName;
        this._salary = 1000;

    }
    //Constructor 3
    public Employee()
    {
        _empId = 1;
        this._salary = 1000;
    }
    //static constructor
    static Employee()
    {
        _companyName = "ABC industries";
    }

    //readonly property
    public double Salary
    {
        get
        {
            return _salary;
            
        }
    }

    //writeonly
    public double Tax
    {
        set
        {
            if(value >= 0 && value<=100 )
            {
                _tax = value;
            }
           
        }
    }

    //method
    public double CalculateNetSalary()
    {
        double t = Salary - _tax;
        return t;
    }

    //automatic properties
    public string NativePalce { get; set; } = "New York";


}
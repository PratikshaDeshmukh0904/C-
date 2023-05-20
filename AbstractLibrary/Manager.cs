public class Manager : Employee
{
    //field
    private string _departmentName;

    //Constructor of child class
    public Manager(int empID,string empName,string location,string departmentName):base(empID
        , empName,location)
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
        return DepartmentName + "at" +base.Location;
    }
}


//Method Overriding
/*
 It is a concept which is used to extend the parent class's method,by creating another
method in the child class with same name and same parameters

*creating Parent class

class ParentClassName
{
    public virtual void MethodName(param1,..)
    {
    }
}

*Creating Child class

class ChildClassName:ParentClassName
{
    public override void MethodName(param1,..)
    {
        base.MethodName();
    }
}
*
*When method overriding is done,if the method is called using child class's object;
 the parent class's method first and child's method executed next.
 */
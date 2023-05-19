public class Manager : Employee
{
    //field
    private string _departmentName;

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
}
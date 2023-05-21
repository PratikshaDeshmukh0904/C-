  //child class
    public  class Manager:IEmployee
    {
        //field
        private string _department;
       private int _empID;
        private string _empName;
        private string _location;
        private System.DateTime _dateOfBirth;

        //properties
        public int EmpID
        {
            set
            {
                if (value >=1000 && value <=2000)
                {
                    this._empID = value;
                }
                
            }
            get
            {
                return this._empID;
            }
        }
    public string EmpName
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
    public System.DateTime DateOfBirth
    {
        set
        {
            _dateOfBirth= value;
        }
        get
        {
            return _dateOfBirth;
        }
    }
    public int GetAge()
    {
        int a = System.Convert.ToInt32((System.DateTime.Now.DateOfBirth).TotalDays/365);
        return a;
    }

    }


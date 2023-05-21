namespace HR
{
    //interface that represnts an empoyee in the organisation
    public interface IEmployee
    {

    }
    //interface that represents a manager,which inherits from IEmployee
    public interface IManager : IEmployee
    {

    }
    //interface that represents an executive,which inherits from IEmployee
    public interface IExecutive : IEmployee
    {

    }
    //class that represents a manager,which inherits from manager
    public class Manager : IManager
    {

    }
    //class that represents an assistant manager,which inherits from IManager
    public class AsstManager : IManager
    {

    }

    //class that represents an executive which inherits from executive
    public class Executive : IExecutive
    {

    }
}
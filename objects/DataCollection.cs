public class DataCollection
{
    private List<Person> data;

    //DataCollection():
    //Loads data from .csv using StreamReader object
    public DataCollection()
    {
        List<Person> list = new List<Person>();
        using (var reader = new StreamReader(@"..\..\..\data\data.csv"))
        {
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                string[] cell = reader.ReadLine().Split(",");
                if (cell[0] != "")
                {
                    Person x = new Person(Int32.Parse(cell[0]), cell[1], cell[2], cell[3] == "Approved" ? true : false, Int32.Parse(cell[4]));
                    list.Add(x);
                }
            }
        }
        this.data = list;
    }

    //Get & Set functions for Encapsulation purposes 
    public List<Person> GetData() { return data; }

    public List<Person> SetData(List<Person> data)
    {
        this.data = data;
        return data;
    }

    //QUERY FUNCTIONS
    //Compare given params against Persons present in the data List, return List of revelent Persons. 
    //Comparison compares Substrings to allow for active filtering
    //QueryFirstName() & QueryLastName() non-case sensitive
    public List<Person> QueryID(String id)
    {
        IEnumerable<Person> idQuery =
            from x in this.data
            where id.Length <= x.GetAppID().ToString().Length && x.GetAppID().ToString().Substring(0, id.Length) == id
            select x;
        return idQuery.ToList();
    }

    public List<Person> QueryFirstName(String name)
    {
        IEnumerable<Person> firstNameQuery =
            from x in this.data
            where name.Length <= x.GetFirstName().Length && x.GetFirstName().Substring(0, name.Length).ToLowerInvariant() == name.ToLowerInvariant()
            select x;
        return firstNameQuery.ToList();
    }

    public List<Person> QueryLastName(String name)
    {
        IEnumerable<Person> lastNameQuery =
            from x in this.data
            where name.Length <= x.GetLastName().Length && x.GetLastName().Substring(0, name.Length).ToLowerInvariant() == name.ToLowerInvariant()
            select x;
        return lastNameQuery.ToList();
    }

    public List<Person> QueryStatus(bool status)
    {
        IEnumerable<Person> statusQuery =
            from x in this.data
            where x.GetStatus() == status
            select x;
        return statusQuery.ToList();
    }

    public List<Person> QueryMinCredit(int credit)
    {
        IEnumerable<Person> minCreditQuery =
            from x in this.data
            where x.GetCreditScore() >= credit
            select x;
        return minCreditQuery.ToList();
    }

    public List<Person> QueryMaxCredit(int credit)
    {
        IEnumerable<Person> maxCreditQuery =
          from x in this.data
          where x.GetCreditScore() <= credit
          select x;
        return maxCreditQuery.ToList();
    }
}

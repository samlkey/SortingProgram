public class Person
{
    private int appID;
    private string firstName;
    private string lastName;
    private bool status;
    private int creditScore;

    public Person(int appID, string firstName, string lastName, bool status, int creditScore)
    {
        this.appID = appID;
        this.firstName = firstName;
        this.lastName = lastName;
        this.status = status;
        this.creditScore = creditScore;
    }

    //Getter functions to enforce Encapsulation 
    public int GetAppID() {  return appID; }
    public string GetFirstName() { return firstName; }
    public string GetLastName() { return lastName; }
    public bool GetStatus() { return status; }
    public int GetCreditScore() { return creditScore;  }
}
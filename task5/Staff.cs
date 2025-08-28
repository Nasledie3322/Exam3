
public class Staff : Person
{
    string school;
    double pay;
    public string Staff(string name, string address, string school, double pay);
    public string GetSchool()
    {
        System.Console.WriteLine(school);
    }
    public void SetSchool(string school);
    public double GetPay()
    {
        System.Console.WriteLine(pay);
    }
    public void SetPay(double pay);
    
}
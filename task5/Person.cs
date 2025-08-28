
public class Person
{
    string name;
    string address;
    public Person(string name, string address);
    public string GetName()
    {
        System.Console.WriteLine(name);
    }
    public string GetAddress()
    {
        System.Console.WriteLine(address);
    }
    public void SetAddress(string address);
    
}
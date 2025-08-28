
public class Student : Person
{
    string program;
    int year;
    double fee;
    public void Student(string name, string address, string program, int year, double fee);
    public string GetProgram()
    {
        System.Console.WriteLine(program);
    }
    public void SetProgram(string program);
    public int GetYear()
    {
        System.Console.WriteLine(year);
    }
    public void SetYear(int yaer);
    public double GetFee()
    {
        System.Console.WriteLine(fee);
    }
    public void SetFee(double fee);
    
}
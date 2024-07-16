using System;
abstract class PassengerDetails
{
    private string name;
    private int age;
    private string from;
    private string to;
    private string pnr;
    private string seatAllocation;
    public string GetName(){
        return name;
    }
    public void SetName(string value){
        name = value;
    }

    public int GetAge(){
        return age;
    }
    public void SetAge(int value){
        age = value;
    }

    public string GetFrom(){
        return from;
    }
    public void SetFrom(string value){
        from = value;
    }
    public void SetPNR(string value){
        pnr = value;
    }
    public string GetPNR(){
        return pnr;
    }
    public string GetTo(){
        return to;
    }
    public void SetTo(string value){
        to = value;
    }
    public string GetSeatAllocation(){
        return seatAllocation;
    }
    public void SetSeatAllocation(string value){
        seatAllocation = value;
    }
    public abstract void DisplayPassengerDetails();
}
class PassMain : PassengerDetails{
    public override void DisplayPassengerDetails()
    {
        Console.WriteLine("Passenger Name: " + GetName());
        Console.WriteLine("Passenger Age: " + GetAge());
        Console.WriteLine("From: " + GetFrom());
        Console.WriteLine("To: " + GetTo());
        Console.WriteLine("Seat Allocation: " + GetSeatAllocation());
        Console.WriteLine("PNR: " + GetPNR());
    }
}
class Task2
{
    static void Main(string[] args)
    {
        PassMain passenger1 = new PassMain();
        passenger1.SetName("Sandeep");
        passenger1.SetAge(21);
        passenger1.SetFrom("Vijayawada");
        passenger1.SetTo("Delhi");
        passenger1.SetSeatAllocation("A1");
        passenger1.SetPNR("9876543210");

        PassMain passenger2 = new PassMain();
        passenger2.SetName("Shyam");
        passenger2.SetAge(20);
        passenger2.SetFrom("Bangalore");
        passenger2.SetTo("Hyderabad");
        passenger2.SetSeatAllocation("B1");
        passenger2.SetPNR("987612543");

        Console.WriteLine("Passenger 1 Details:");
        passenger1.DisplayPassengerDetails();
        Console.WriteLine();

        Console.WriteLine("Passenger 2 Details:");
        passenger2.DisplayPassengerDetails();
        Console.WriteLine();
    }
}
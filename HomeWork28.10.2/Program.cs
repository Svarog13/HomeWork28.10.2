class Magazine
{
    private string name;
    private int yearFounded;
    private string desctiption;
    private string contactPhone;
    private string email;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int YearFounded
    {
        get { return yearFounded; }
        set { yearFounded = value; }
    }
    public string Description
    {
        get { return desctiption; }
        set { desctiption = value; }
    }
    public string ContactPhone
    {
        get { return contactPhone; }
        set { contactPhone = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public void EnterData()
    {
        Console.Write("Enter the name of magazine: ");
        Name = Console.ReadLine();
        Console.Write("Enter the year founded: ");
        YearFounded = int.Parse(Console.ReadLine());
        Console.Write("Enter the description of the magazine: ");
        Description = Console.ReadLine();
        Console.Write("Enter the contact phone: ");
        ContactPhone = Console.ReadLine();
        Console.Write("Enter the email: ");
        Email = Console.ReadLine();
        System.Console.WriteLine();
    }
    public void DisplayData()
    {
        System.Console.WriteLine("Magazine Information:");
        System.Console.WriteLine("Name: " + Name);
        System.Console.WriteLine("Year Founded: " + YearFounded);
        System.Console.WriteLine("Description: " + Description);
        System.Console.WriteLine("Contact Phone: " + ContactPhone);
        System.Console.WriteLine("Email: " + Email);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Magazine magazine = new Magazine();
        magazine.EnterData();
        magazine.DisplayData();
    }
}
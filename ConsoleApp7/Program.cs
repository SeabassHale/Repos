class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>()
        {
            new Person(1200, "Mark", "Pent"),
            new Person(3400, "Ba", "Baa"),
            new Person(2300, "Ca", "Caa"),
            new Person(5000, "Da", "Daa"),
            new Person(3250, "Ea", "Eaa"),
        };

        var seniors = people.Where(s => s.Salary > 3000).ToList();
        var seniorSalaries = seniors.Select(x => x.Salary).ToList();
        var seniorSalariesSum = 0;

        seniorSalaries.ForEach (seniorSalary => seniorSalariesSum += seniorSalary) ;
            {
                Console.WriteLine($"The sum of all senior salaries is {seniorSalariesSum}");
            }
        var seniorsNames = people.ToList();
        var seniorsFirstNames = seniors.Select(y => y.FirstName).ToList();
        seniorsFirstNames.ForEach(FirstName => Console.WriteLine($"Hello {FirstName}"));

        }

    class Person
{
    public int Salary { get; }
    public string FirstName { get; }
    public string LastName { get; }

    public Person(int Salary, string FirstName, string LastName)
    {
        this.Salary = Salary;
        this.FirstName = FirstName;
        this.LastName = LastName;
    }
}
}
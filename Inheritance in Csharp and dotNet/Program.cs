using System.Reflection;

public class SimpleClass
{

}

public class SimpleClassExample
{
    public static void Main()
    {
        Type t = typeof(SimpleClass);
        BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public |
                             BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
        MemberInfo[] members = t.GetMembers(flags);
        Console.WriteLine($"Type {t.Name} has {members.Length} members: ");
        foreach (MemberInfo member in members)
        {
            string access = "";
            string stat = "";
            var method = member as MethodBase;
            if (method != null)
            {
                if (method.IsPublic)
                    access = " Public";
                else if (method.IsPrivate)
                    access = " Private";
                else if (method.IsFamily)
                    access = " Protected";
                else if (method.IsAssembly)
                    access = " Internal";
                else if (method.IsFamilyOrAssembly)
                    access = " Protected Internal ";
                if (method.IsStatic)
                    stat = " Static";
            }
            string output = $"{member.Name} ({member.MemberType}): {access}{stat}, Declared by {member.DeclaringType}";
            Console.WriteLine(output);

        }

        //Everything below here was you fucking about with the DateTime stuff. You seem to have made a functional timer of sorts and were able to make it count to a deadline... Maybe useful for your office sim?

        Console.WriteLine($"Today is {DateTime.Now.DayOfWeek}");
        Console.WriteLine($"Yesterday was {DateTime.Now.AddDays(-1).DayOfWeek}");
        Console.WriteLine($"Tomorrow is {DateTime.Now.AddDays(1).DayOfWeek}");
        var startTime = DateTime.Now.AddMinutes(60);


    Start:

        var endTime = DateTime.Now;
//        Console.WriteLine(startTime);
//        Console.WriteLine(endTime);
        var playTime = endTime - startTime;
        Console.WriteLine(playTime);
        goto Start;

    }
}
// The example displays the following output:
//	Type SimpleClass has 9 members:
//	ToString (Method):  Public, Declared by System.Object
//	Equals (Method):  Public, Declared by System.Object
//	Equals (Method):  Public Static, Declared by System.Object
//	ReferenceEquals (Method):  Public Static, Declared by System.Object
//	GetHashCode (Method):  Public, Declared by System.Object
//	GetType (Method):  Public, Declared by System.Object
//	Finalize (Method):  Internal, Declared by System.Object
//	MemberwiseClone (Method):  Internal, Declared by System.Object
//	.ctor (Constructor):  Public, Declared by SimpleClass
public class Students
{
    public Students(string firstName, string lastName, float grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public float Grade { get; private set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade:f2}";
    }
}
namespace properties;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Group group = new Group();
            group.GroupName = "";
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        try
        {
            Student student = new Student();
            student.Name = null;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

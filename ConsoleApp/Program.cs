using SubtypeCovariance;
class Program
{
    static void Main(string[] args)
    {
        // Use generic repository
        var entityRepository = new Repository<Entity>();
        var userRepository = new Repository<User>();

        // Retrieve entity and user via the repository
        Entity myEntity = entityRepository.GetByID(Guid.NewGuid());
        User myUser = userRepository.GetByID(Guid.NewGuid());

        // Set and display entity properties
        myEntity.Name = "Tom";
        Console.WriteLine("New entity ID: " + myEntity.ID);
        Console.WriteLine("New entity Name: " + myEntity.Name);

        // Set and display user properties
        myUser.Name = "Miles";
        myUser.EmailAddress = "miles@example.com";
        myUser.DateOfBirth = new DateTime(1990, 5, 24);
        Console.WriteLine("New user ID: " + myUser.ID);
        Console.WriteLine("New user Name: " + myUser.Name);
        Console.WriteLine("User Email: " + myUser.EmailAddress);
        Console.WriteLine("User DOB: " + myUser.DateOfBirth.ToShortDateString());
    }
}

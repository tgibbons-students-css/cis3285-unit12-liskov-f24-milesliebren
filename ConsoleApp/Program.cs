using SubtypeCovariance;

class Program
{
    static void Main(string[] args)
    {
        // Use specific repositories
        IEntityRepository<Entity> entityRepository = new EntityRepository();
        IEntityRepository<User> userRepository = new UserRepository();

        // Retrieve entity via the entity repository
        Entity myEntity = entityRepository.GetByID(Guid.NewGuid());
        myEntity.Name = "Tom";

        Console.WriteLine("New entity ID: " + myEntity.ID);
        Console.WriteLine("New entity Name: " + myEntity.Name);

        // Retrieve user via the user repository
        User myUser = userRepository.GetByID(Guid.NewGuid());
        myUser.Name = "Miles";
        myUser.EmailAddress = "miles@example.com";
        myUser.DateOfBirth = new DateTime(1990, 5, 24);

        Console.WriteLine("New user ID: " + myUser.ID);
        Console.WriteLine("New user Name: " + myUser.Name);
        Console.WriteLine("User Email: " + myUser.EmailAddress);
        Console.WriteLine("User DOB: " + myUser.DateOfBirth.ToShortDateString());
    }
}

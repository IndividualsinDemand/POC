namespace API.Entities
{
    public class AppUser
    {
        // Id - naming convention shouldn't be changed as Entity Framework uses it for migrations
        // and this is the default naming convention that it uses to identify the primary key
        public int Id { get; set; }
        // UserName - default naming convention for MVC authentication. Can be changed but will require some
        // amount of tweaks to get the authentication working
        public string UserName { get; set; }
    }
}
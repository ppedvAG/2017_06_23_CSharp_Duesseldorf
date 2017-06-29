namespace Levante.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public Address Address { get; set; }
        
        public string ImageUrl
        {
            get { return $"http://lorempixel.com/200/200/people/{Id%10}" ; }
        }
    }
}

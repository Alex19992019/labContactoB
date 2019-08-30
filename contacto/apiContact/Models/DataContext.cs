namespace apiContact.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<apiContact.Models.Contact> Contacts { get; set; }
    }
}
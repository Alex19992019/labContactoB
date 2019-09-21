namespace appContacto.Models
{
    
    public enum TypeContact
    {
        telephone,
        email,
        facebook
    }

    public class Contact
    {
        
        public int ContactID { get; set; }
        public string Name { get; set; }
        public TypeContact Type { get; set; }
        public string ContactValue { get; set; }
    }
}

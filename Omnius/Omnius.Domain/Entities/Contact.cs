using System.ComponentModel.DataAnnotations;

namespace Omnius.Domain.Entities
{
    public class Contact
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int ContactTypeID { get; set; }
    }

    public class ContactType
    {
        public int ID { get; set; }
        public string Name {get; set;}
    }
}
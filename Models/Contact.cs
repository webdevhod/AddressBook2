using System.ComponentModel.DataAnnotations;

namespace AddressBook2.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode)]
        public int? ZipCode { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBook2.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public String FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [NotMapped]
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        public string Address1 { get; set; }
        public string? Address2 { get; set; }

        public string City { get; set; }

        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string State { get; set; }


        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode)]
        public int ZipCode { get; set; }

        [DataType(DataType.PhoneNumber)]
        public String Phone { get; set; }

        [NotMapped]
        [Display(Name = "Image")]
        [DataType(DataType.Upload)]
        public IFormFile? ImageFile { get; set; }

        [NotMapped]
        public String? ImageType { get; set; }

        [Display(Name = "Image")]
        public byte[]? ImageData { get; set; }

        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}

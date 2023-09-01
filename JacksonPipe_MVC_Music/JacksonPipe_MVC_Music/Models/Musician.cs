using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JacksonPipe_MVC_Music.Models
{
    public class Musician
    {
        public int ID { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + (string.IsNullOrEmpty(MiddleName) ? " " : (" " + (char?)MiddleName[0] + ".").ToUpper()) + " " + LastName;
            }
        }
        
        [Required(ErrorMessage = "First Name is required")]
        [StringLength (30)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [StringLength(30)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Phone Number is required")]
        [StringLength(12)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$", ErrorMessage = "Please enter a valid phone number")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "DOB is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }
        
        [Required(ErrorMessage = "SIN is required")]
        [StringLength(9)]
        public string SIN { get; set; }

        [Display(Name = "Instruments")]
        public ICollection<Play> Play { get; set; } = new HashSet<Play>();


        [ForeignKey("FK_InstrumentID")]
        [Display(Name = "Primary Instrument ID")]
        public int InstrumentID { get; set; }
        
        [Display(Name = "Primary Instrument")]
        public Instrument Instrument { get; set; }
        


    }
}

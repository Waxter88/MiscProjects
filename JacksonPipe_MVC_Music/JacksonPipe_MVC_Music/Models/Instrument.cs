using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace JacksonPipe_MVC_Music.Models
{
    public class Instrument
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Instrument Name is required")]
        [StringLength(50)]
        [Display(Name = "Instrument Name")]
        public string Name { get; set; }

        [Display(Name = "Instruments")]
        public ICollection<Play> Play { get; set; } = new HashSet<Play>();
    }
}

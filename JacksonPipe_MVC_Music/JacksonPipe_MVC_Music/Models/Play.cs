using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JacksonPipe_MVC_Music.Models
{
    public class Play
    {
        [Required]
        [ForeignKey("FK_MusicianID")]
        public int MusicianID { get; set; }
        public Musician Musician { get; set; }
        [Required]
        [ForeignKey("FK_InstrumentID")]
        public int InstrumentID { get; set; }
        public Instrument Instrument { get; set; }
    }
}

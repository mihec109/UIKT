using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projekt.Models
{
    public class DokumentiModel
    {
        [Key]
        public int id { get; set; }
        [Required]
        public byte[] obrazec { get; set; }
        [Required]
        public byte[] pravnaPodlaga { get; set; }
        [Required]
        public byte[] dodato { get; set; }

        public int Uporabnik { get; set; }
    }
}

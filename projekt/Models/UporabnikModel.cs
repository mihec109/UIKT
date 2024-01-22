using System.ComponentModel.DataAnnotations;

namespace projekt.Models
{
    public class UporabnikModel
    {
        [Key]
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "{0} rabi biti {2} crke dolgo.", MinimumLength = 6)]
        public string Geslo { get; set; }
        [DataType(DataType.Password)]
        [Compare("Geslo", ErrorMessage = "Gesla se ne ujemajo")]
        public string? Geslo2 { get; set; }

        public List<DokumentiModel> Dokumenti { get; set; }
    }
}

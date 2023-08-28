using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Checkin.Models
{
    [Table("Owners")]
    public class Owner
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo \"{0}\" é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo pode ter no máximo 100 caracteres")]
        [Display(Name = "Proprietário do Evento")]
        public string? Name { get; set; }

    }
}

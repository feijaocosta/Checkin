using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Checkin.Models
{
    [Table ("Eventos")]
    public class Evento
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo \"{0}\" é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo pode ter no máximo 100 caracteres")]
        [Display(Name ="Nome do Evento")]
        public string? Name { get; set; }

        public Owner? Owner { get; set; }

    }
}

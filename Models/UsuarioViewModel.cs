using System.ComponentModel.DataAnnotations;

namespace automapper_example.Models
{
    public class UsuarioViewModel
    {
        [StringLength(100)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [StringLength(100)]
        [Display(Name = "Sobrenome")]
        public string Sobrenome { get; set; }

        [StringLength(100)]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}

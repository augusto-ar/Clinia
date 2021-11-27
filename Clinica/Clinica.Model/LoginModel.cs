using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Model
{
    public class LoginModel
    {
        [RegularExpression(@"^.{2,}$", ErrorMessage = "Minimo 2 caractere especial")]
        [Required(ErrorMessage = "Nescessario preencher o campo Senha")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "A senha tem que ter no minimo 8 e no maximo 15 digitos")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Nescessario preencher o campo Usuario.")]
        [StringLength(20, ErrorMessage = "Usuario deve ter no maximo 20 digitos")]
        public string Login { get; set; }
    }
}

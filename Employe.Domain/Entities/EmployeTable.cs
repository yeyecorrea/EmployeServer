using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe.Domain.Entities
{
    public class EmployeTable
    {
        public int EmployeId { get; set; }

        [Required(ErrorMessage = "El campo {0} es el obligatorio")]
        [StringLength(maximumLength: 50)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es el obligatorio")]
        [Display(Name = "Correo")]
        [DataType(DataType.EmailAddress)]   
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es el obligatorio")]
        [Display(Name = "Salario")]
        public int Salary { get; set; }
    }
}

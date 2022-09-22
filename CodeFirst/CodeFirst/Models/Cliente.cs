using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace CodeFirst.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cli_Id { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(100)]
        public string Cli_Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(100)]
        public string Cli_Apellido { get; set; }

        [Column(TypeName ="numeric(10,0)")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Cli_Tel { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(250)]
        public string Cli_Direccion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public char Cli_Status { get; set; }
    }
}
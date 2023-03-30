using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TesteConfitec.Models.Enum;

namespace TesteConfitec.Models
{
    [Table("Usuarios")]
    public class User
    {
        [Column("Id")]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Column("Name")]
        [Display(Name = "Nome")]
        public string firstName { get; set; }

        [Column ("LastName")]
        [Display(Name = "Sobrenome")]
        public string lastName { get; set; }

        [Column("Email")]
        [Required(ErrorMessage = "O campo 'E-Mail' é requerido!!")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string email { get; set; }

        [Column("Aniversário")]
        [Display(Name ="Aniversário")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime birthday { get; set; }

        //[Column("Escolaridade")]
        //[Display(Name ="Escolaridade")]
        //public int Schoolding {get; set;}
    }

}

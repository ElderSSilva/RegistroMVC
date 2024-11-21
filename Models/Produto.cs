using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC_SQL.Models
{

    [Table ("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int ID { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Descrição")]
        [Display(Name = "Descrição")]
        public string Descrição { get; set; }

    }
}

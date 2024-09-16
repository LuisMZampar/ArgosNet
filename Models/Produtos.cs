using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArgosNet.Models
{
    [Table("TB_ARGOS_PRODUTOS")]
    public class Produtos
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }

        [Required]
        [MaxLength(255)]
        [Column("NOME")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(255)]
        [Column("DESCRICAO")]
        public string Descricao { get; set; }

        [Required]
        [Column("QUANTIDADE")]
        public int Quantidade { get; set; }

        [Column("PRECO")]
        public double? Preco { get; set; }

        [Column("IMAGEM")]
        public string Imagem { get; set; }
    }
}

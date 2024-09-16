using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArgosNet.Models
{
    [Table("TB_ARGOS_CLIENTES")]
    public class Cliente
    {
        [Key]
        [Column("ID_CLIENTE")]
        public long Id_Cliente { get; set; }

        [Required]
        [Column("NOME")]
        public string Nome { get; set; }

        [Column("IDADE")]
        public int? Idade { get; set; }

        [Required]
        [Column("CPF")]
        public string Cpf { get; set; }

        [Required]
        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("CELULAR")]
        public string Celular { get; set; }
    }
}

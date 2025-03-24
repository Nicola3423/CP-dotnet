using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sessions_app.Model
{
    [Table("TDS_TB_BRINQUEDOS")] // Garante o nome da tabela em maiúsculas
    public class Brinquedo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_BRINQUEDO")]
        public int Id_brinquedo { get; set; }

        [Required]
        [Column("NOME_BRINQUEDO")]
        public string Nome_brinquedo { get; set; } = string.Empty; // Inicialização

        [Column("TIPO_BRINQUEDO")]
        public string Tipo_brinquedo { get; set; } = string.Empty;

        [Column("CLASSIFICACAO")]
        public string Classificacao { get; set; } = string.Empty;

        [Column("TAMANHO")]
        public string Tamanho { get; set; } = string.Empty;

        [Column("PRECO", TypeName = "NUMBER(10,2)")] 
        public decimal Preco { get; set; }
    }
}


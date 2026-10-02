using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2023.Models
{

    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatorio informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Obrigatorio informar a placa!")]   
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o ano de fabricação!")]
        public int AnoFabricacao { get; set; }
        
        [Required(ErrorMessage = "Obrigatorio informar o ano do modelo!")]
        public int AnoModelo { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace CalculoCDB.Domain.Request
{
    public class CalculoCdbRequest
    {
        [Required]
        [DataType(DataType.Currency)]
        [Range(1, int.MaxValue)]
        public decimal ValorInvestimento { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int PrazoMeses { get; set; }
    }
}

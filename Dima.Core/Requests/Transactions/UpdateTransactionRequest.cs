using System.ComponentModel.DataAnnotations;
using Dima.Core.Enums;

namespace Dima.Core.Requests.Transactions;

public class UpdateTransactionRequest : RequestBase
{
    public long Id { get; set; }
    [Required(ErrorMessage = "Titulo é obrigatório")]
    public string Title { get; set; }
    [Required(ErrorMessage = "Tipo é obrigatório")]
    public ETransactionType Type { get; set; }
    [Required(ErrorMessage = "Valor é obrigatório")]
    public decimal Amount { get; set; }
    [Required(ErrorMessage = "Categoria é obrigatório")]
    public long CategoryId { get; set; }
    [Required(ErrorMessage = "Data de pago ou recebido é obrigatório")]
    public DateTime? PaidOrReceivedAt { get; set; }
}
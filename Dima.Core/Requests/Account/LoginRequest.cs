using System.ComponentModel.DataAnnotations;

namespace Dima.Core.Requests.Account;

public class LoginRequest : RequestBase
{
    [Required(ErrorMessage = "E-mail")]
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    public string Email { get; set; } = String.Empty;

    [Required(ErrorMessage = "Senha inválida")]
    public string Password { get; set; } = string.Empty;
}
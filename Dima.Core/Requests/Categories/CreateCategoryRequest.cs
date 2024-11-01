using System.ComponentModel.DataAnnotations;

namespace Dima.Core.Requests.Categories;

public class CreateCategoryRequest : RequestBase
{
    public long Id { get; set; }
    [Required(ErrorMessage = "Titulo é obrigatório")]
    [Range(5,80,ErrorMessage = "Título deve ter entre 5 e 80 caracteres")]
    public string Title { get; set; } = string.Empty;
    [Required(ErrorMessage = "Descricão é obrigatório")]
    [MaxLength(255, ErrorMessage = "Descricão deve ter no máximo 255 caracteres")]
    public string Description { get; set; } = string.Empty;
    [Required(ErrorMessage = "Usuário é obrigatório")]
    public string UserId { get; set; } = string.Empty;
}
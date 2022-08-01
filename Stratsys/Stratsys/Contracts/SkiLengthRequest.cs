using Application.Enums;
using System.ComponentModel.DataAnnotations;

namespace Stratsys.Contracts;

public class SkiLengthRequest
{
    [Required]
    public int Length { get; set; }
    [Required]
    public int Age { get; set; }
    [Required]
    public SkiType? SkiType { get; set; }
}

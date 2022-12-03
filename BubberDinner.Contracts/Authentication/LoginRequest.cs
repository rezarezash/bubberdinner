using System.ComponentModel.DataAnnotations;

namespace BubberDinner.Contracts.Authentication;

public record LoginRequest([Required]string Email, [Required]string Password);
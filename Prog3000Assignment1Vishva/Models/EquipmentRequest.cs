using System.ComponentModel.DataAnnotations;

namespace Prog3000Assignment1Vishva.Models;

public class EquipmentRequest
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Phone number is required.")]
    [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone number must be in the format xxx-xxx-xxxx.")]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required(ErrorMessage = "Role is required.")]
    public string Role { get; set; } = string.Empty;

    [Required(ErrorMessage = "Equipment type is required.")]
    [Display(Name = "Equipment Type")]
    public string EquipmentType { get; set; } = string.Empty;

    [Required(ErrorMessage = "Request details are required.")]
    [Display(Name = "Request Details")]
    public string RequestDetails { get; set; } = string.Empty;

    [Required(ErrorMessage = "Duration is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "Duration must be a positive number.")]
    [Display(Name = "Duration (days)")]
    public int? Duration { get; set; }

    public string? Status { get; set; }
}

﻿using System.ComponentModel.DataAnnotations;

namespace Application.Dto;

public class RegisterDto
{
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? Password { get; set; }
}
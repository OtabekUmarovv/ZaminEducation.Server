using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using ZaminEducation.Domain.Entities.MainPages.Commons;

namespace ZaminEducation.Service.DTOs.HomePage;

public class HomePageHeaderForCreationDto
{
    [Required]
    public string Title { get; set; }

    public string Description { get; set; }

    [Required]
    [RegularExpression("^(https?\\:\\/\\/)?(www\\.youtube\\.com|youtu\\.be)\\/.+$")]
    public string YouTubeVideoLink { get; set; }

    public IFormFile File { get; set; }
}
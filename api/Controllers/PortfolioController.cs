using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PortfolioController : ControllerBase
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IStockRepository _stockRepo;
    
    public PortfolioController(UserManager<AppUser> userManager, IStockRepository stockRepo)
    {
        _userManager = userManager;
        _stockRepo = stockRepo;
    }
    
    
}
namespace Stratsys.Controllers;

using Application.Common.Interfaces;
using Contracts;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/skiequipment")]
public class SkiEquipmentController : ControllerBase
{
    private readonly ISkiEquipmentService _skiEquipmentService;

    public SkiEquipmentController(ISkiEquipmentService skiEquipmentService)
    {
        _skiEquipmentService = skiEquipmentService;
    }

    [Route("skilength")]
    [HttpGet]
    public IActionResult GetRecommendedSkiLength(SkiLengthRequest request)
    {
        if(request.SkiType is null)
        {
            return BadRequest("Skitype is missing");
        }

        var result = _skiEquipmentService.GetRecommendedSkiLength(request.Length, request.Age, request.SkiType.Value);

        return Ok(result);
    } 

}

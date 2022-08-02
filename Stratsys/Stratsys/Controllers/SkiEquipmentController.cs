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
        //Added this to avoid VS complaining about possible null reference on line 28.
        if (request.Length is null || request.Age is null || request.SkiType is null)
        {
            return BadRequest("Required data is missing from request");
        }

        var result = _skiEquipmentService.GetRecommendedSkiLength(request.Length.Value, request.Age.Value, request.SkiType.Value);

        return Ok(result);
    } 

}

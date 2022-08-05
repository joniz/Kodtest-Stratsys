using Application.Common.Enums;
using Application.Services.SkiEquipment;

namespace Application.Interfaces
{
    public interface ISkiEquipmentService
    {
        SkiEquipmentResult GetRecommendedSkiLength(int length, int age, SkiType skiType);
    }
}

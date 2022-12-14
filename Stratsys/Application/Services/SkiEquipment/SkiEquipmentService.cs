using Application.Common.Enums;
using Application.Interfaces;
using System;

namespace Application.Services.SkiEquipment
{
    public class SkiEquipmentService : ISkiEquipmentService
    {
        public SkiEquipmentResult GetRecommendedSkiLength(int length, int age, SkiType skiType)
        {
            if (length <= 0)
            {
                return new SkiEquipmentResult(SkiEquipmentStatus.InvalidLength);
            }

            if (age < 0)
            {
                return new SkiEquipmentResult(SkiEquipmentStatus.InvalidAge);
            }

            if (age <= 4)
            {
                return new SkiEquipmentResult(length);
            }

            if (age >= 5 && age <= 8)
            {
                return new SkiEquipmentResult(length + 20);
            }

            return skiType is SkiType.Classic ?
                new SkiEquipmentResult(Math.Min(length + 20, 207)) : new SkiEquipmentResult(Math.Min(length + 15, 192));
        }
    }
}

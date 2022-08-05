using System;
using Application.Common.Enums;

namespace Application.Services.SkiEquipment
{
    public class SkiEquipmentResult
    {
        public int? Result { get; set; }

        public SkiEquipmentStatus Status { get; set; }

        public SkiEquipmentResult(int result)
        {
            Result = result;
            Status = SkiEquipmentStatus.Ok;
        }

        public SkiEquipmentResult(SkiEquipmentStatus status)
        {
            if (status is SkiEquipmentStatus.Ok)
            {
                throw new ArgumentException("Status is not allowed");
            }

            Status = status;
        }
    }
}

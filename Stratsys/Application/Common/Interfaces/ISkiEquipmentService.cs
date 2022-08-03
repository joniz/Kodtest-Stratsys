using Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Services.SkiEquipment;

namespace Application.Common.Interfaces
{
    public interface ISkiEquipmentService
    {
        SkiEquipmentResult GetRecommendedSkiLength(int length, int age, SkiType skiType);
    }
}

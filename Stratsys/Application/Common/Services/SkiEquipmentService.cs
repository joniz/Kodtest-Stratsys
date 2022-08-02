using Application.Common.Interfaces;
using Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Services
{
    public class SkiEquipmentService : ISkiEquipmentService
    {
        public int GetRecommendedSkiLength(int length, int age, SkiType skiType)
        {
            if(length <= 0)
            {
                throw new ArgumentException("length must be greater than 0");
            }

            if(age < 0)
            {
                throw new ArgumentException("Age cannot me less than zero");
            }

            if (age <= 4)
            {
                return length;
            }

            if (age >= 5 && age <= 8)
            {
                return length + 20;
            }

            return skiType is SkiType.Classic ? Math.Min(length + 20, 207) : Math.Min(length + 15, 192);
        }
    }
}

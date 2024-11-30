using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.FlyWeight
{
    public class CropService 
    {
        public List<Crop> GetCrops()
        {
            List<Crop> cropList= new List<Crop>();

            // fetching from the DB
            var carrot = new Crop(1, 4, CropType.Carrot, null);
            var carrot1 = new Crop(2, 6, CropType.Carrot, null);
            var carrot2 = new Crop(3, 8, CropType.Carrot, null);

            cropList.Add(carrot);
            cropList.Add(carrot1);
            cropList.Add(carrot2);

            return cropList;

        }
    }
}
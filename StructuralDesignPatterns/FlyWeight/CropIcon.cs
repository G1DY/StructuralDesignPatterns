using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.FlyWeight
{
    // Flyweight class to store intrinsic states
    public class CropIcon
    {
        private CropType _cropType;

        private byte[] _icon;

        public CropIcon(CropType cropType, byte[] icon) 
        {
            _cropType = cropType;
            _icon = icon;
        }
        public CropType SetCropType{};
        
    }
}
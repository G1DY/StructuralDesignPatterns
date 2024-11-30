using StructuralDesignPatterns.FlyWeight;

var cropService = new CropService();
foreach(var crop in cropService.GetCrops())
{
    crop.Render();
}
namespace TechServe.Model
{
    public class SparePartViewModel
    {
        public string SparePartsModel { get; set; }
        public string PartsType { get; set; }
        public bool IsSelected { get; set; }
        public int RepairOfCostOfThePart { get; set; }
        public int ReplacementOfCostOfThePart { get; set; }
        public int SparePrice { get; set; }
    }
}

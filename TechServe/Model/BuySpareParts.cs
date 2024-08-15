namespace TechServe.Model
{
    public class BuySpareParts
    {
        public int id { get; set; }
        public string SparePartsBrand { get; set; }
        public string SparePartsModel { get; set; }
        public string PartsType { get; set; }
        public int AmountOfSpareParts { get; set; }
        public long Barcode { get; set; }
        public int SparePrice { get; set; }
    }
}

namespace TechServe.Model
{
    public class Master
    {
        public int id { get; set; }
        public string CostumerName { get; set; }
        public long Phone { get; set; }
        public string E_Mail { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string DevicelBrand { get; set; }
        public string DevicelModel { get; set; }
        public string TypeOfService { get; set; }
        public string ServiceStatus { get; set; }
        public string ServiceCode { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public DateOnly ArrivalDate { get; set; }
        public DateOnly CompletionDate { get; set; }
    }
}

namespace TechServe.Model
{
    public class DetailsTable
    {
        public int id { get; set; }
        public string TypeOfService { get; set; }
        public string ServiceStatus { get; set; }
        public string ServiceCode { get; set; }
        public string Description { get; set; }
        public string PartsUsedForRepair { get; set; }
        public float Price { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime CompletionDate { get; set; }
    }
}

namespace Hospital.Models
{
    public class MedicineReport
    {
        public int Id { get; set; }
        public Supplier Supplier { get; set; }
        public Medicine Medicine { get; set; }
        public string Company { get; set; }
        public int Quantity { get; set; }
        public int ProductionDate { get; set; }
        public int ExpireDate { get; set; }
        public string Country { get; set; }
    }
}

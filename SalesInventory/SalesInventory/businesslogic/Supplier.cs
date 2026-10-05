namespace SalesInventory.businesslogic
{
    public class Supplier
    {
        public int SupplierID { get; set; }

        public string SupplierName { get; set; } = "";

        public string ContactPerson { get; set; } = "";

        public string PhoneNumber { get; set; } = "";

        public string EmailAddress { get; set; } = "";

        public string PhysicalAddress { get; set; } = "";

        public string Status { get; set; } = "Active";
    }
}
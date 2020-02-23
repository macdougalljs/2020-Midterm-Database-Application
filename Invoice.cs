namespace MTJeremiahMacDougall
{
    class Invoice
    {

        public int PartNumber { get; set; }

        public string PartDescription { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public Invoice(int partno, string partdesc, int qty, double price)
        {
            PartNumber = partno;
            PartDescription = partdesc;
            Quantity = qty;
            Price = price;
        }

    }
}

namespace eCommerce_Product
{
    public class Product
    {
        public int ProdID { get; set; }
        public string ProdName { get; set; }

        public double ItemPrice { get; set; }

        public int StockAmount {  get; set; }

        public Product(int prodID, string prodName, double itemPrice, int stockAmount)
        {
            ProdID = prodID;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }

        public void IncreaseStock(int amount)
        {
            if (amount > 0)
            {
                StockAmount += amount;
            }
        }

        public void DecreaseStock(int amount)
        {
            if (StockAmount > amount)
            {
                StockAmount -= amount;
            }
        }

    }
}

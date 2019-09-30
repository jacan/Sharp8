namespace _2019Test.Async
{
    public class WarehouseItem
    {
        public int Colli { get; set; }

        public WarehouseItem(int colli=1)
        {
            Colli = colli;
        }

        public string Name { get; set; }
        public int AmountOnShelf { get; set; }
    }
}

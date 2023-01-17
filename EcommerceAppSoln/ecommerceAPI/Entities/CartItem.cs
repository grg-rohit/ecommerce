namespace ecommerceAPI.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; } //foreign key for joining cart entity with cartItem entity

        public int ProductId { get; set; }

        public int Qty { get; set; }
    }
}

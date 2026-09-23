namespace CustomerSupport.Application.DTOs.Products
{
    public sealed class TicketCategoryResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}

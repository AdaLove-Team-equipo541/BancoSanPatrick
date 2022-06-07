namespace SanPatrick.Domain.Common
{
    public class BaseEntity
    {
        public virtual Guid Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? ModifieddBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}

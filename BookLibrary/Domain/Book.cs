namespace BookLibrary.Domain
{
    public class Book : BaseEntity<Guid>
    {
        public Book()
        {
            Id = Guid.NewGuid();
        }

        public string? Title { get; set; }
        public string? Author { get; set; }
        public DateTime YearOfRelease { get; set; }
        public string? Publisher { get; set; }
        public ushort Pages { get; set; }
    }
}

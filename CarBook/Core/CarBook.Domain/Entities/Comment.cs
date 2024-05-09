namespace CarBook.Domain.Entities
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDated { get; set; }
        public string Description { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}

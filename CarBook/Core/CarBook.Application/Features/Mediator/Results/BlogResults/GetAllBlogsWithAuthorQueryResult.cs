using CarBook.Domain.Entities;

namespace CarBook.Application.Features.Mediator.Results.BlogResults
{
    public class GetAllBlogsWithAuthorQueryResult
    {
        public int BlogID { get; set; }
        public string AuthorDescription { get; set; }
        public string AuthorImageUrl { get; set; }
        public string AuthorName { get; set; }
        public int AuthorID { get; set; }
        public string Description { get; internal set; }
        public string CategoryName { get; internal set; }
        public string Title { get; internal set; }
        public DateTime CreatedDate { get; internal set; }
        public string CoverImageUrl { get; internal set; }
        public int CategoryID { get; internal set; }
    }
}

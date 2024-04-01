using CarBook.Application.Features.CQRS.Results.AboutResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Results.BlogResults
{
    public class GetBlogByIdQueryResult : IRequest<GetBlogByIdQueryResult>
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryID { get; set; }

    }
}

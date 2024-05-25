using CarBook.Application.Features.RepositoryPattern;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;

namespace CarBook.Persistance.Repositories.CommentRepositories
{
    public class CommentRepository<T> : IGenericRepository<Comment>
    {
        private readonly CarBookContext _context;

        public CommentRepository(CarBookContext context)
        {
            _context = context;
        }

        public void Create(Comment entity)
        {
            _context.Comments.Add(entity);
            _context.SaveChanges();
        }

        public List<Comment> GetAll()
        {
            return _context.Comments.Select(x => new Comment
            {
                CommentID = x.CommentID,
                BlogID = x.BlogID,
                CreatedDated = x.CreatedDated,
                Name = x.Name,
            }).ToList();
        }

        public Comment GetById(int id)
        {
            return _context.Comments.Find(id);
        }

        public List<Comment> GetCommentsByBlogID(int id)
        {
            var value = _context.Comments.Where(x=>x.BlogID == id).ToList();
            return value;
            // return _context.Set<Comment>().Where(x=>x.BlogID == id).ToList();
        }

        public void Remove(Comment comment)
        {
            var value = _context.Comments.Find(comment.CommentID);
            _context.Remove(value);
            _context.SaveChanges();
        }

        public void Update(Comment entity)
        {
            _context.Comments.Update(entity);
            _context.SaveChanges();
        }
    }
}

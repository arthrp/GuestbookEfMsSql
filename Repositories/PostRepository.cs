using System.Collections.Generic;
using System.Linq;
using GuestbookEfMsSql.Dtos;

namespace GuestbookEfMsSql.Repositories
{
    public class PostRepository
    {
        private readonly MainDbContext _context;
        public PostRepository(MainDbContext context)
        {
            _context = context;
        }

        public List<PostDto> GetAll()
        {
            var posts = _context.Posts.Where(x => true);
            if(!posts.Any()){
                return new List<PostDto>();
            }
            return posts.ToList();
        }

        public void Insert(PostDto post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }
    }
}
using System.Collections.Generic;
using GuestbookEfMsSql.Dtos;

namespace GuestbookEfMsSql.Models
{
    public class GuestbookViewModel
    {
        public List<PostDto> AllPosts {get; set;}
    }
}
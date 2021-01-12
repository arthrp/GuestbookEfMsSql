using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuestbookEfMsSql.Dtos
{
    public class PostDto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime AddedDate { get; set; }
        public string Username { get; set; }
    }
}
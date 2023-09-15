using Blog.Core.Entities;

namespace Blog.Core.Entities
{
    public class PostComment : BaseEntity
    {
        public PostComment(string content, int idPost, int idUser)
        {
            Content = content;
            IdPost = idPost;
            IdUser = idUser;
            CreatedAt = DateTime.Now;
        }

        public string Content { get; private set; }
        public int IdPost { get; private set; }

        public Post Post { get; set; }
        public int IdUser { get; private set; }

        public User User { get; set; }
        public DateTime CreatedAt { get; private set; }
    }
}




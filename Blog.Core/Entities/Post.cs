namespace Blog.Core.Entities
{
    public class Post : BaseEntity
    {
        public Post(string title, string description, int idClient)
        {
            Title = title;
            Description = description;
            IdUser = idClient;

            CreatedAt = DateTime.Now;
            UpdateAt = DateTime.Now;

            Comments = new List<PostComment>();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdUser { get; private set; }
        public User User { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdateAt { get; private set; }
        public List<TagsPost> TagsPost { get; private set; }
        public List<PostComment> Comments { get; private set; }

        
        public void Update(string title, string description)
        {
            Title = title;
            Description = description;
            UpdateAt = DateTime.Now;
        }
    }
}


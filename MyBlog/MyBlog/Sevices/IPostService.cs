using MyBlog.Models;

namespace MyBlog.Sevices
{
    public interface IPostService
    {
        List<Post> GetAllPosts();
        Post GetById(Guid id);
        Post AddPost(Post newPost);
        Post UpdatePost(Post post);
        void DeletePost(Guid id);
        string SaveImage(IFormFile newFile);
    }
}

using MyBlog.Models;

namespace MyBlog.Sevices
{
    public class PostService : IPostService
    {
        List<Post> allpost;
        
        IWebHostEnvironment _env;
        public PostService(IWebHostEnvironment webHostEnvironment)
        {
            _env = webHostEnvironment;

            allpost = new List<Post>()
            {
                new Post()
                {
                    Id = Guid.Parse("f2bbb302-416a-478b-8968-9fc71586ca77"),
                    Title = "First Title",
                    Body = "Main metod: Bu metod ilova ishga tushirilganda bajariladigan boshqa metodlarni chaqiradi. Ushbu metod CreateHostBuilder metodini chaqirib, uni boshqaruvchi obyektini yaratadi va ishga tushiradi",
                    CreatedTime = DateTime.Now,
                    ImageFileName = "254c2414-eec6-4c2d-8ba5-c5cb78e3a411_dorm-png-transparent-dormpng-images-pluspng-dormitory-png-713_702",
                },
                new Post()
                {
                    Id = Guid.Parse("b631f4a9-a67b-43f0-a18a-07c1686319d2"),
                    Title = "Second Title",
                    Body = "Host.CreateDefaultBuilder metodini chaqirib, standart sozlashlarni o'rnatadi. Keyin ConfigureWebHostDefaults metodini chaqirib, veb ilovani boshlash uchun sozlashlarni o'rnatadi. Startup klassini ishlatib, veb ilovani boshlash uchun sozlashlarni o'rnatadi.",
                    CreatedTime = DateTime.Now,
                    ImageFileName = "0102fdd0-86e9-48bd-838c-dfe6d0475ac3_125 1",
                }
            };
        }

        public Post AddPost(Post newPost)
        {
            newPost.Id = Guid.NewGuid();
            newPost.CreatedTime = DateTime.Now;

            allpost.Add(newPost);
            return newPost;
        }

        public void DeletePost(Guid id)
        {
            Post deletePost = allpost.FirstOrDefault(x => x.Id == id);  
            if (deletePost.ImageFileName != null) 
            {
                string uplodFolder = Path.Combine(_env.WebRootPath, "Images");
                string filePath = Path.Combine(uplodFolder, deletePost.ImageFileName);
                FileInfo fileInfo = new FileInfo(filePath);
                if (fileInfo.Exists)
                {
                    fileInfo.Delete();
                }
            }
            if (deletePost != null)
            {
                allpost.Remove(deletePost);
            }
        }

        public List<Post> GetAllPosts()
        {
            return allpost;
        }

        public Post GetById(Guid id)
        {
            var post = allpost.FirstOrDefault(p => p.Id == id);
            return post;
        }

        public string SaveImage(IFormFile newFile)
        {
            string uniqueName = string.Empty;
            if (!File.Exists(newFile.FileName))
            {
                string uplodFolder = Path.Combine(_env.WebRootPath, "Images");
                uniqueName = Guid.NewGuid().ToString() +"_" + newFile.FileName;
                string filePath = Path.Combine(uplodFolder, uniqueName);
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
                newFile.CopyTo(fileStream);
                fileStream.Close();
            }

            return uniqueName;
        }

        public Post UpdatePost(Post post)
        {
            foreach (var item in allpost)
            {
                if (item.Id == post.Id)
                {
                    item.Title = post.Title;
                    item.Body = post.Body;
                    item.Body = post.Body;
                }
            }

            return post;
        }
    }
}

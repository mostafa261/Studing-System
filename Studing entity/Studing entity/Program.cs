using Studing_entity.appliction_Dbcontext;

namespace Studing_entity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
             Post post =new post() {PostName="Elgohary"};
            context.Post.Add(post);
        }
    }
}

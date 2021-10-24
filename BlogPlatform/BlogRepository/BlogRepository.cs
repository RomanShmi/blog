using BlogPlatform.Models;
using System.Collections.Generic;
using System.Linq;


namespace BlogPlatform.BlogRepository
{
    public class BlogRepository : IRepository<Content>
    {
        public BlogContext db;
        public BlogRepository(BlogContext db)  
        { this.db = db; }
   //crud

        //create
        public void Create(Content ct) {
            db.Contents.Add(ct);
            db.SaveChanges();
        }



        //read
        public IEnumerable<Content> GetAll()
        {
            return db.Contents.ToList();
        }



        public Content GetByID(int id) 
        {
            return db.Contents.Find(id);
        }


        //update
        public void Update(Content obj)
        {
            db.Contents.Update(obj);
            db.SaveChanges();
        }



        //delete
        public void Delete(Content obj)
        {
            db.Contents.Remove(obj);
            db.SaveChanges();
        }





    }
}

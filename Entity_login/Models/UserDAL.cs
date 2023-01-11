using Entity_login.Data;
using System.Linq;
namespace Entity_login.Models
{
    public class UserDAL
    {
        private ApplicationDbContext _db;
        public UserDAL(ApplicationDbContext db)
        {
            _db=db;
        }

        public void Regsiter(Users u)
        {
            _db.Users.Add(u);
            _db.SaveChanges();
        }
        public Users Login(Users u)
        {
            var data = (from x in _db.Users
                        where x.Email ==u.Email && x.Password==u.Password
                        select x).FirstOrDefault();
            return data;
        }
    }
}

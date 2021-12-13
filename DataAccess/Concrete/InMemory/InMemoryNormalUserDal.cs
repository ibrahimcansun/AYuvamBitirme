using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryNormalUserDal : INormalUserDal
    {
        List<NormalUser> _normalUsers;
        public InMemoryNormalUserDal()
        {
            _normalUsers = new List<NormalUser>
            {
                new NormalUser{Email="ibolican2000@gmail.com", Name="ibrahim", UserId=1, Password="123456"},
                new NormalUser{Email="mehmet@gmail.com", Name="mehmet", UserId=2, Password="123456"},
                new NormalUser{Email="esra@gmail.com", Name="esra", UserId=3, Password="123456"}
            };
        }
        public void Add(NormalUser normalUser)
        {
            _normalUsers.Add(normalUser);
        }

        public void Delete(NormalUser normalUser)
        {
            //LINQ
            NormalUser userToDelete = _normalUsers.SingleOrDefault(u=>u.UserId == normalUser.UserId);
            _normalUsers.Remove(userToDelete);
        }

        public NormalUser Get(Expression<Func<NormalUser, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<NormalUser> GetAll()
        {
            return _normalUsers;
        }

        public List<NormalUser> GetAll(Expression<Func<NormalUser, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(NormalUser normalUser)
        {
            NormalUser userToUpdate = _normalUsers.SingleOrDefault(u => u.UserId == normalUser.UserId);
            userToUpdate.Email = normalUser.Email;
            userToUpdate.Name = normalUser.Name;
            userToUpdate.Password = normalUser.Password;
            userToUpdate.UserId = normalUser.UserId;

        }
    }
}

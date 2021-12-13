using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserHomeDal : EfEntityRepositoryBase<UserHome, AyuvamContext>, IUserHomeDal
    {
        public List<UserHomeNameDto> GetUserHomeName()
        {
            using (AyuvamContext context = new AyuvamContext())
            {
                var result = from uhm in context.UserHomes
                             join u in context.NormalUsers
                             on uhm.UserId equals u.UserId
                             join h in context.Homes
                             on uhm.HomeId equals h.StructureId
                             select new UserHomeNameDto { UserId = u.UserId, Name = u.Name,
                                 HomeId = h.StructureId, StructureName = h.StructureName };
                return result.ToList();
            }
        }
    }
}

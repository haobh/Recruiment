using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMC.Data.Infrastructure;
using UMC.Model.Models;

namespace UMC.Data.Repositories
{
    public interface IRecruimentRepository : IRepository<RecruimentInfor>
    {
    }
    public class RecruimentRepository : RepositoryBase<RecruimentInfor>,IRecruimentRepository
    {
        public RecruimentRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}

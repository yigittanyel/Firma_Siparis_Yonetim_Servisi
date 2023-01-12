using DAL.DataContext;
using DAL.Repository.IRepositories;
using EL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class UrunRepository : GenericRepository<Urun>, IUrunRepository
    {
        private readonly Context _dbContext;

        public UrunRepository(Context dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

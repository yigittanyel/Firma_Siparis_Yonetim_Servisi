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
    public class FirmaRepository :GenericRepository<Firma>, IFirmaRepository
    {
        private readonly Context _dbContext;

        public FirmaRepository(Context dbContext): base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceNotebook.Core.Repositories;
using ServiceNotebook.DAL.MyDbContext;

namespace ServiceNotebook.DAL.Repositories
{
    public class GeneralRepository<T> : IGeneralRepository<T> where T : BaseEntity
    {
        private readonly ServiceNotebookDB dbContext;
        protected readonly DbSet<T> dbSet;
        public GeneralRepository(ServiceNotebookDB dbContext)
        {
            this.dbContext = dbContext;
            dbSet=dbContext.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
           await dbSet.AddAsync(entity);
           await dbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int Id)
        {
           var entity = dbSet.Find(Id);
            if(entity !=null)
            {
                dbSet.Remove(entity);
                await dbContext.SaveChangesAsync();
                return true;

            }
            return false;
          
           
        }

        public async Task<List<T>> GetAllAsync()
        {
           return await dbSet.ToListAsync();
        }

        public  async Task<T?> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            var existingEntity = await dbSet.FindAsync(entity.Id);
            if (existingEntity != null)
            {   
                dbContext.Entry(existingEntity).CurrentValues.SetValues(entity);
                await dbContext.SaveChangesAsync();
                return true;
              
            }
            else return false;
        }
    }
}

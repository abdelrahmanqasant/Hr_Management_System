using HR_Management.Core.ServiceContract;
using HR_Management.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Infrastructure.RepositoryConcrete;


    public class GenericRepository<T> :IGenericRepository<T> where T :class
{
    private readonly AppDbContext _dbContext;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
    }

    public async Task  AddAsync(T entity)
    {
       await  _dbSet.AddAsync(entity);
        
    }

    public void Remove(T entity)
    {
       _dbSet.Remove(entity);
        
    }
    public void RemoveRange(IEnumerable<T> entities)
    {
        _dbSet.RemoveRange(entities);

    }

    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, string? IncludeWord = null)
    {
        IQueryable<T> query = _dbSet;
        if ((predicate != null))
        {
            query = query.Where(predicate);
        }
        if(IncludeWord != null)
        {
            foreach (var item in IncludeWord.Split(new char[] {','},  StringSplitOptions.RemoveEmptyEntries))

            {
                query = query.Include(item);
            }
        }
       return await query.ToListAsync();
    }

    public async Task<T> GetElement(Expression<Func<T, bool>>? predicate = null, string? IncludeWord = null)
    {
        IQueryable<T> query = _dbSet;
        if ((predicate != null))
        {
            query = query.Where(predicate);
        }
        if (IncludeWord != null)
        {
            foreach (var item in IncludeWord.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))

            {
                query = query.Include(item);
            }
        }
        return  await query.FirstOrDefaultAsync();
    }

    

   
}


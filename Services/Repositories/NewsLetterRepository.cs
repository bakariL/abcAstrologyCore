using ckl.Data;
using ckl.Models;
using ckl.Models.ViewModels;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Services.Repositories
{
    public interface INewsLetterRepository
    {
    
        IQueryable<Newsletter> GetNewsletters();
        IQueryable<Newsletter> GetNewsLetterById(Guid Id);
        EntityEntry<Newsletter> Update(Newsletter newsletter);
        void Add(Newsletter newsletter);
        void Delete(Newsletter newsletter);
        void Save();
    }
    public class NewsLetterRepository : INewsLetterRepository
    {
        private readonly ApplicationDbContext _context;

        public NewsLetterRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Newsletter newsletter)
        {
            _context.Newsletters.Add(newsletter);
            _context.SaveChanges();
        }

        public void Delete(Newsletter newsletter)
        {
            _context.Newsletters.Remove(newsletter);
            _context.SaveChanges();
        }

        public IQueryable<Newsletter> GetNewsLetterById(Guid Id)
        {
            return _context.Newsletters.Where(x => x.Id == Id);    
        }

        public IQueryable<Newsletter> GetNewsletters()
        {
            return _context.Newsletters;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public EntityEntry<Newsletter> Update(Newsletter newsletter)
        {
            return _context.Newsletters.Update(newsletter);
        }
    }
}

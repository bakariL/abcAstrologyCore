using ckl.Data;
using ckl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ckl.Services.Repositories
{
    public interface IRequestRepository
    {
        IQueryable<Request> GetAll();
        int CountAll(IQueryable<Request> requests);
        void Update(IQueryable<Request> requests);
        void Add(Request request);
        void Delete(Request request);
        void Save();
    }
    public class RequestRepository : IRequestRepository
    {
        private ApplicationDbContext _context;
        public RequestRepository(
            ApplicationDbContext context
            )
        {
            _context = context;
        }

        public void Add(Request request)
        {
            _context.Request.Add(request);
            _context.SaveChanges();
        }

        public void Delete(Request request)
        {
            _context.Request.Remove(request);
            _context.SaveChanges();
        }

        public IQueryable<Request> GetAll()
        {
            return _context.Request;
        }
        public int CountAll(IQueryable<Request> requests)
        {
           return _context.Request.Count();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(IQueryable<Request> requests)
        {
            _context.Request.UpdateRange(requests);
        }
    }
}

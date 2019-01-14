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
    public interface ICustomerRepository
    { 
        IQueryable<Customer> GetAll();
        Task<EntityEntry<Customer>> Insert(Customer item);
        IQueryable<Customer> GetCustomerById(string customerId);
        EntityEntry<Customer> Update(Customer customer);
        void Update(IQueryable<Customer> customers);
        void Add(Customer customer);
        void Delete(Customer customer);
        void Delete(IEnumerable<Customer> customers);
        void Save();
    }

    public class CustomerRepository : ICustomerRepository
    {
        public readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Customer> GetAll()
        {
            return _context.Customers;
        }

        public IQueryable<Customer> GetCustomerById(string customerId)
        {
            return _context.Customers.Where(x => x.UserId == customerId);
        }

        public EntityEntry<Customer> Update(Customer customer)
        {
            return _context.Customers.Update(customer);
            
        }



        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

        }

        public void Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();

        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public Task<EntityEntry<Customer>> Insert(Customer item)
        {
            return _context.Customers.AddAsync(item);
        }

        public void Delete(IEnumerable<Customer> customers)
        {
            _context.Customers.RemoveRange(customers);
            _context.SaveChanges();

        }

        public void  Update(IQueryable<Customer> customers)
        {
             _context.UpdateRange(customers);
            _context.SaveChanges();
        }
    }
}
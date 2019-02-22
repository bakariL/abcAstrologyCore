using ckl.Data;
using ckl.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Services.Repositories
{
  public interface IRoleRepository
  {
        IQueryable<IdentityRole> GetAll();
      void Add(IdentityRole role);
  }
  public class RoleRepository : IRoleRepository
  {
    private readonly ApplicationDbContext _context;
    public RoleRepository(ApplicationDbContext context)
    {
        _context = context;
    }

     public IQueryable<IdentityRole> GetAll()
        {
            return _context.Roles;
        }
      public void Add(IdentityRole role)
      {
        _context.Roles.Add(role);
        _context.SaveChanges();
      }
  }
}
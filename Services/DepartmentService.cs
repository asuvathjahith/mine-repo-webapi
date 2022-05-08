using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMS.API.DTO;
using TMS.API.Models;

namespace TMS.API.Services
{
    public class DepartmentService
    {
        private readonly AppDbContext _context;
        private readonly ILogger<DepartmentService> _logger;

        public DepartmentService(AppDbContext context, ILogger<DepartmentService> logger)
        {
            _context = context;
            _logger = logger;
        }

         public Object GetDepartmentByUserId(int id)
        {
            var dbdepartment = _context.Departments.Where(u => u.Id == id).FirstOrDefault();
            if (dbdepartment != null)
            {

                var result = new
                {
                    Id = dbdepartment.Id,
    
                    Name = dbdepartment.Name
                    
                };

                return result;
            }
            return "not found";
        }    
        
        public IEnumerable<Department> GetAllDepartments()
        {
           try
            {
                return _context.Departments.ToList();
            }
            catch (System.InvalidOperationException ex)
            {
                _logger.LogCritical("An Critical error occured in User services. Please check the program.cs, context class and connection string. It happend due to failure of injection of context. ");
                _logger.LogTrace(ex.ToString());
                throw ex;
            }
            catch (System.Exception ex)
            {
                _logger.LogCritical("An Critical error occured in User services. Some external factors are involved. please check the log files to know more about it");
                _logger.LogTrace(ex.ToString());
                throw ex;
            }
        }
    }
}
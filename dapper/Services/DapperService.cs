using System.Data;
using dapper.Context;
using dapper.DataTransferModels;
using dapper.Entities;
using dapper.Interface;
using Dapper;
using Microsoft.Data.SqlClient;

namespace dapper.Services
{
    public class DapperService : IDapper
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;
        public DapperService(AppDbContext context,IConfiguration config) 
        {
            _context = context;
            _configuration = config;
        }

        public string Save(DapperVM model)
        {
            var exists = _context.Dapper.Any(x => x.email == model.email);
            if (exists)
                return "This email already exists";

            var entity = new DapperDbModel
            {
                name = model.name,
                age = model.age,
                email = model.email
            };

            _context.Dapper.Add(entity);
            _context.SaveChanges();

            return "Saved";
        }

        public DapperDbModel? GetByEmail(string email)
        {
            using IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            string query = "SELECT * FROM Dapper WHERE Email = @Email";
            return db.QueryFirstOrDefault<DapperDbModel>(query, new { Email = email });
        }

        public DapperDbModel? GetById(int id)
        {
            using IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            string query = "SELECT * FROM Dapper WHERE Id = @Id";
            return db.QueryFirstOrDefault<DapperDbModel>(query, new { Id = id });
        }

        public IEnumerable<DapperDbModel> GetAll()
        {
            using IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            string query = "SELECT * FROM Dapper";
            return db.Query<DapperDbModel>(query).ToList();
        }

        public string Update(int id, DapperVM model)
        {
            var existing = _context.Dapper.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return "Record not found";

            existing.name = model.name;
            existing.age = model.age;
            existing.email = model.email;

            _context.SaveChanges();
            return "Updated successfully";
        }

        public string Delete(int id)
        {
            var existing = _context.Dapper.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return "Record not found";

            _context.Dapper.Remove(existing);
            _context.SaveChanges();
            return "Deleted successfully";
        }
    }
}

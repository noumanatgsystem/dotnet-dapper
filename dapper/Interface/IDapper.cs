using dapper.DataTransferModels;
using dapper.Entities;

namespace dapper.Interface
{
    public interface IDapper
    {
        string Save(DapperVM model);
        DapperDbModel? GetByEmail(string email);
        DapperDbModel? GetById(int id);
        IEnumerable<DapperDbModel> GetAll();
        string Update(int id, DapperVM model);
        string Delete(int id);
    }
}

using Project_1.Models;
using Information = Project_1.Models.Information;

namespace Project_1.Services
{
    public interface IInformationServices
    {
        Task<IEnumerable<Information>> GetAll();
        Task<Information> GetById(byte id);
        Task<Information> Add(Information information);
        Information update(Information information);
        Information Delete(Information information);
    }
}

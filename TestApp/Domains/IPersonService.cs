using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestApp.Domains
{
    public interface IPersonService
    {
        Task AddPerson(Person person);
        Task<Person> FindPersonAsync(int id);
        Task<List<Person>> GetPeople();
    }
}
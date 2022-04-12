using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestApp.Domains
{
    public class PersonService : IPersonService
    {
        private DbSet<Person> _persons;

        public PersonService(IUnitOfWork uow)
        {
            _persons = uow.Set<Person>();
        }

        public async Task AddPerson(Person person)
        {
            await _persons.AddAsync(person);
        }
        public async Task<Person> FindPersonAsync(int id)
        {
            return await _persons.FindAsync(id);
        }
        
        public async Task<List<Person>> GetPeople()
        {
            return await _persons
                .ToListAsync();
        }
    }
}
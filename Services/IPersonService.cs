using System.Collections.Generic;
using b1.Models;

namespace b1.Services
{
    public interface IPersonService
    {
        public List<Person> GetAll();
        public Person GetOne(int index);
        public Person Create(Person member);
        public Person Update(Person member, int index);
        public void Delete(int index);
    }
}
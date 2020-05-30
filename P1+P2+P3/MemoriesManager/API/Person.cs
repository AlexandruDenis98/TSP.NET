using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MemoriesManager
{
    public partial class Person
    {
        public bool CreatePerson()
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                bool bResult = false;
                if (this == null) return bResult;
                if(this.Id == 0)
                {
                    context.Entry<Person>(this).State = EntityState.Added;
                    context.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public List<Person> GetAllPeople()
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                return context.People.ToList();
            }
        }
        public int DeletePerson(int id)
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                return context.Database.ExecuteSqlCommand("Delete From FilePerson where People_Id = @p0; Delete From People where Id = @p0", id);
            }
        }
        public Person GetPersonByName(string First_name, string Last_name)
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                var query = from p in context.People where p.First_name == First_name && p.Last_name == Last_name select p;
                var person = query.FirstOrDefault<Person>();
                return person;
            }
        }
        public Person UpdatePerson(Person newPerson)
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                var query = from p in context.People where p.Id == newPerson.Id select p;
                var person = query.FirstOrDefault<Person>();
                if(person != null)
                {
                    person.First_name = newPerson.First_name;
                    person.Last_name = newPerson.Last_name;
                    context.Entry(person).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                return person;
            }
        }
        //Update a person name giving its id
        public Person UpdatePersonNameById(int id, string First_name, string Last_name)
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                var query = from p in context.People where p.Id == id select p;
                var person = query.FirstOrDefault<Person>();
                if (person != null)
                {
                    person.First_name = First_name;
                    person.Last_name =  Last_name;
                    context.Entry(person).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                } 
                return person;
            }
        }
    }   
}

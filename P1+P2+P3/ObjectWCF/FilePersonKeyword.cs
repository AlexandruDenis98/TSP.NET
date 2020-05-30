using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MemoriesManager;

namespace ObjectWCF
{
    public class FilePersonKeyword : IFilePersonKeyword
    {
        public bool CreateKeyword(Keyword keyword)
        {
            return keyword.CreateKeyword();
        }
        public List<Keyword> GetAllKeywords()
        {
            Keyword keyword = new Keyword();
            return keyword.GetAllKeywords();
        }
        public int DeleteKeyword(int id)
        {
            Keyword keyword = new Keyword();
            return keyword.DeleteKeyword(id);
        }
        public Keyword GetKeywordByKword(string Kword)
        {
            Keyword keyword = new Keyword();
            return keyword.GetKeywordByKword(Kword);
        }
        public Keyword UpdateKeywordKwordById(int id, string Kword)
        {
            Keyword keyword = new Keyword();
            return keyword.UpdateKeywordKwordById(id, Kword);
        }
        public bool CreatePerson(Person person)
        {
            return person.CreatePerson();
        }

        public int DeletePerson(int id)
        {
            Person person = new Person();
            return person.DeletePerson(id);
        }

        public List<Person> GetAllPeople()
        {
            Person person = new Person();
            return person.GetAllPeople();
        }

        public Person GetPersonByName(string First_name, string Last_name)
        {
            Person person = new Person();
            return person.GetPersonByName(First_name, Last_name);
        }

        public Person UpdatePerson(Person newPerson)
        {
            Person person = new Person();
            return person.UpdatePerson(newPerson);

        }
        //Update a person name giving its id
        public Person UpdatePersonNameById(int id, string First_name, string Last_name)
        {
            Person person = new Person();
            return person.UpdatePersonNameById(id,First_name,Last_name);
        }

        public bool CreateFile(File file)
        {
            return file.CreateFile();
        }
        public List<File> GetAllFiles()
        {
            File file = new File();
            return file.GetAllFiles();
        }
        public int DeleteFileByPath(string filePath)
        {
            File file = new File();
            return file.DeleteFileByPath(filePath);
        }
        public File GetFileByPath(string filePath)
        {
            File file = new File();
            return file.GetFileByPath(filePath);
        }

        public void InsertKeywordIntoFile(string kword, string filePath)
        {
            File file = new File();
            file.InsertKeywordIntoFile(kword, filePath);
        }
        public List<Keyword> GetKeywordsOfFile(string filePath)
        {
            File file = new File();
            return file.GetKeywordsOfFile(filePath);
        }
        public void DeleteKeywordsFromFile(List<int> keywordsIds, string filePath)
        {
            File file = new File();
            file.DeleteKeywordsFromFile(keywordsIds, filePath);
        }
        public void InsertPersonIntoFile(int personId, string filePath)
        {
            File file = new File();
            file.InsertPersonIntoFile(personId, filePath);
        }
        public List<Person> GetPeopleFile(string filePath)
        {
            File file = new File();
            return file.GetPeopleFile(filePath);
        }
        public void DeletePeopleFromFile(List<int> ids, string filePath)
        {
            File file = new File();
            file.DeletePeopleFromFile(ids, filePath);
        }
    }
}

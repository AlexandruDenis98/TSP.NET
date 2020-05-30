using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Net;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Diagnostics;

namespace MemoriesManager
{
    public partial class File
    {
        public bool CreateFile()
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                bool bResult = false;
                if (this == null) return bResult;
                if (this.FileId == 0)
                {

                    context.Entry<File>(this).State = EntityState.Added;
                    context.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public List<File> GetAllFiles()
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                return context.Files.ToList<File>();
            }
        }
        public int DeleteFileByPath(string filePath)
        {
                using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                var query = from f in context.Files where f.Path == filePath select f;
                var file = query.FirstOrDefault<File>();
                return context.Database.ExecuteSqlCommand("Delete From FilePerson where Files_FileId = @p1 ;Delete From FileKeyword where Files_FileId = @p1;" +
                    "Delete From Files where Path = @p0;", filePath, file.FileId); 
            }
        }
        public File GetFileByPath(string filePath)
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                var query = from f in context.Files where f.Path == filePath select f;
                var file = query.FirstOrDefault<File>();
                return file;
            }
        }
        public void InsertKeywordIntoFile(string kword, string filePath)
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                var keyword = context.Keywords.SingleOrDefault(k => k.Kword == kword);
                var file = context.Files.SingleOrDefault(f => f.Path == filePath);
                //retrive all keywords of the file
                var keywords = context.Files
                      .Where(f => f.Path == filePath)
                      .SelectMany(k => k.Keywords);
                //test if file keywords contains parameter keyword
                bool exists = false;
                foreach(Keyword k in keywords)
                {
                    if (k == keyword) exists = true;
                }
                if (!exists)
                {
                    file.Keywords.Add(keyword);
                    context.SaveChanges();
                }
            }     
        }
        public List<Keyword> GetKeywordsOfFile(string filePath)
        {
            List<Keyword> keywordsList = new List<Keyword>();
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                var file = context.Files.SingleOrDefault(f => f.Path == filePath);

                var query = from keyword in context.Keywords
                            where keyword.Files.Any(f => f.FileId == file.FileId)
                            select keyword;

                var keywords = query.ToList<Keyword>();
                return keywords;

            }
        }
        public void DeleteKeywordsFromFile(List<int> keywordsIds, string filePath)  
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                var file = context.Files.First(f => f.Path == filePath);
                foreach (int kId in keywordsIds)
                {
                    context.Database.ExecuteSqlCommand("Delete From FileKeyword where Files_FileId = @p0 and Keywords_Id = @p1;", file.FileId, kId);
                }
            }
        }
        public void InsertPersonIntoFile(int personId, string filePath)
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                var person = context.People.SingleOrDefault(p =>p.Id == personId);
                var file = context.Files.SingleOrDefault(f => f.Path == filePath);
                //retrive people of the file
                var people = context.Files
                      .Where(f => f.Path == filePath)
                      .SelectMany(p => p.People);
                //test if file people contains parameter person
                bool exists = false;
                foreach (Person p in people)
                {
                    if (p == person) exists = true;
                }
                if (!exists)
                {
                    file.People.Add(person);
                    context.SaveChanges();
                }
            }
        }
        public List<Person> GetPeopleFile(string filePath)
        {
            List<Person> peopleList = new List<Person>();
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                var file = context.Files.SingleOrDefault(f => f.Path == filePath);

                var query = from person in context.People
                            where person.Files.Any(f => f.FileId == file.FileId)
                            select person;

                var people= query.ToList<Person>();
                return people;
            }
        }
        public void DeletePeopleFromFile(List<int> peopleIds, string filePath)
        {
            using (MemoriesManagerModelContainer context = new MemoriesManagerModelContainer())
            {
                var file = context.Files.First(f => f.Path == filePath);
                foreach (int PersonId in peopleIds)
                {
                    context.Database.ExecuteSqlCommand("Delete From FilePerson where Files_FileId = @p0 and People_Id = @p1;", file.FileId, PersonId);
                }
            }
        }
    }
}

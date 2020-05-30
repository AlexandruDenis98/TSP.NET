using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoriesManager;
using System.ServiceModel;
namespace ObjectWCF
{
    [ServiceContract]
    interface InterfacePerson
    {
        [OperationContract]
        bool CreatePerson(Person person);

        [OperationContract]
        int DeletePerson(int id);

        [OperationContract]
        List<Person> GetAllPeople();

        [OperationContract]
        Person GetPersonByName(string First_name, string Last_name);

        [OperationContract]
        Person UpdatePerson(Person newPerson);

        [OperationContract]
        Person UpdatePersonNameById(int id, string First_name, string Last_name);
    }
    [ServiceContract]
    interface InterfaceKeyword
    {
        [OperationContract]
        bool CreateKeyword(Keyword keyword);

        [OperationContract]
        int DeleteKeyword(int id);

        [OperationContract]
        List<Keyword> GetAllKeywords();

        [OperationContract]
        Keyword GetKeywordByKword(string Kword);

        [OperationContract]
        Keyword UpdateKeywordKwordById(int id, string Kword);
    }
    [ServiceContract]
    interface InterfaceFile
    {
        [OperationContract]
        bool CreateFile(File file);

        [OperationContract]
        List<File> GetAllFiles();

        [OperationContract]
        int DeleteFileByPath(string filePath);

        [OperationContract]
        File GetFileByPath(string filePath);

        [OperationContract]
        void InsertKeywordIntoFile(string kword, string filePath);

        [OperationContract]
        List<Keyword> GetKeywordsOfFile(string filePath);

        [OperationContract]
        void DeleteKeywordsFromFile(List<int> keywordsIds, string filePath);

        [OperationContract]
        void InsertPersonIntoFile(int personId, string filePath);

        [OperationContract]
        List<Person> GetPeopleFile(string filePath);
        [OperationContract]
        void DeletePeopleFromFile(List<int> ids, string filePath);
    }
    [ServiceContract]
    interface IFilePersonKeyword : InterfacePerson, InterfaceKeyword, InterfaceFile  
    {

    }
}

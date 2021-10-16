using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Persona.Domain.Entities;

namespace Persona.Domain.Interfaces
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetAll();
        Task<IEnumerable<Object>> GetFields();
        Task<IEnumerable<Person>> GetFeminine();
        Task<IEnumerable<Person>> GetByAge();
        Task<IEnumerable<string>> GetJobs();
        Task<IEnumerable<Person>> GetContainsName();
        Task<IEnumerable<Person>> GetByAgeFive();
        Task<IEnumerable<Person>> GetOrdered();
        Task<IEnumerable<Person>> GetOrderedDes();
        int GetCount();
        bool GetExist();
        Person GetUnique();
        Task<IEnumerable<Person>> GetTakeJob();
        Task<IEnumerable<Person>> GetSkip();
        Task<IEnumerable<Person>> GetSkipJob();

    }
}
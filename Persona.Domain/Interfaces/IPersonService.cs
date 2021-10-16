using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Persona.Domain.Entities;

namespace Persona.Domain.Interfaces
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetAllPerson();
        Task<IEnumerable<Object>> GetFieldsPerson();
        Task<IEnumerable<Person>> GetFemininePerson();
        Task<IEnumerable<Person>> GetByAgePerson();
        Task<IEnumerable<string>> GetJobPerson();
        Task<IEnumerable<Person>> GetContainsNamePerson();
        Task<IEnumerable<Person>> GetByAgeFivePerson();
        Task<IEnumerable<Person>> GetOrderedPerson();
        Task<IEnumerable<Person>> GetOrderedDesPerson();
        int GetCountPerson();
        bool GetExistPerson();
        Person GetUniquePerson();
        Task<IEnumerable<Person>> GetTakeJobPerson();
        Task<IEnumerable<Person>> GetSkipPerson();
        Task<IEnumerable<Person>> GetSkipJobPerson();

    }
}
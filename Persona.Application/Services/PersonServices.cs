using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Persona.Domain.Interfaces;
using Persona.Domain.Entities;
using System.Linq;

namespace Persona.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _repository;

        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Person>> GetAllPerson()
        {
            return await _repository.GetAll();
        }

        public async Task<IEnumerable<Object>> GetFieldsPerson()
        {
            return await _repository.GetFields();
        }

        public async Task<IEnumerable<Person>> GetFemininePerson()
        {
            return await _repository.GetFeminine();
        }

        public async Task<IEnumerable<Person>> GetByAgePerson()
        {
            return await _repository.GetByAge();
        }

        public async Task<IEnumerable<string>> GetJobPerson()
        {
            return await _repository.GetJobs(); 
        }

        public async Task<IEnumerable<Person>> GetContainsNamePerson()
        {
            return await _repository.GetContainsName();
        }
        public async Task<IEnumerable<Person>> GetByAgeFivePerson()
        {
            return await _repository.GetByAgeFive();
        }

        public async Task<IEnumerable<Person>> GetOrderedPerson()
        {
            return await _repository.GetOrdered();
        }

        public async Task<IEnumerable<Person>> GetOrderedDesPerson()
        {
            return await _repository.GetOrderedDes();
        }

        public int GetCountPerson()
        {
            return _repository.GetCount();
        }

        public bool GetExistPerson()
        {
            return _repository.GetExist();
        }

        public Person GetUniquePerson()
        {
            return _repository.GetUnique();
        }

        public async Task<IEnumerable<Person>> GetTakeJobPerson()
        {
            return await _repository.GetTakeJob();
        }

        public async Task<IEnumerable<Person>> GetSkipPerson()
        {
            return await _repository.GetSkip();
        }

        public async Task<IEnumerable<Person>> GetSkipJobPerson()
        {
            return await _repository.GetSkipJob();
        }
    }
}
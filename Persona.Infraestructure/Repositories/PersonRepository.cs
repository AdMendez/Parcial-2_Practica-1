using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Persona.Domain.Entities;
using Persona.Domain.Interfaces;
using System.Linq;
using System.IO;
using System.Text.Json;

namespace Persona.Infraestructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        List<Person> _persons;
        
        public PersonRepository()
        {
            var fileName = "dummy.data.queries.json";
            if (File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json).ToList();
            }
        }

        //retornar todas las personas
        public async Task<IEnumerable<Person>> GetAll()
        {
            var query = _persons.Select(person => person);
            await Task.Delay(1000);
            return query;
        }

        //únicamente el nombre completo de las personas, el correo y el año de nacimiento
        public async Task<IEnumerable<Object>> GetFields()
        {
            var query = _persons.Select(person => new{
                Nombre_Completo = $"{person.FirstName} {person.LastName}",
                Correo = person.Email,
                AnioNacimiento = DateTime.Now.AddYears((person.Age * -1)).Year
            });
            await Task.Delay(1000);
            return query;
        }

        //retorne la información de todas las personas cuyo genero sea Femenino
        public async Task<IEnumerable<Person>> GetFeminine()
        {
            var gender = "F";
            var query = _persons.Where(person => person.Gender == char.Parse(gender));
            await Task.Delay(1000);
            return query;
        }

        //retorne la información de todas las personas cuya edad se encuentre entre los 20 y 30 años
        public async Task<IEnumerable<Person>> GetByAge()
        {
            var query = _persons.Where(person => person.Age >= 20 && person.Age <= 30);
            await Task.Delay(1000);
            return query;
        }

        //retorne la información de los diferentes trabajos que tienen las personas
        public async Task<IEnumerable<string>> GetJobs()
        {
            var query = _persons.Select(person => person.Job).Distinct();
            await Task.Delay(1000);
            return query;
        }

        //retorne la información de las personas cuyo nombre contenga la palabra “ar”
        public async Task<IEnumerable<Person>> GetContainsName()
        {
            var word = "ar";
            var query = _persons.Where(p => p.FirstName.Contains(word));
            await Task.Delay(1000);
            return query;
        }

        //retorna la información de las personas cuyas edades sean 25, 35 y 45 años
        public async Task<IEnumerable<Person>> GetByAgeFive()
        {
            var ages = new List<int>{25,35,45};
            var query = _persons.Where(person => ages.Contains(person.Age));
            await Task.Delay(1000);
            return query;
        }

        //retorne la información ordenas por edad para las personas que sean mayores a 40 años
        public async Task<IEnumerable<Person>> GetOrdered()
        {
            var age = 40;
            var query = _persons.Where(person => person.Age > age).OrderBy(person => person.Age);
            await Task.Delay(1000);
            return query;
        }

        //retorne la información ordenada de manera descendente para todas las personas de género masculino 
        //y que se encuentren entre los 20 y 30 años de edad
        public async Task<IEnumerable<Person>> GetOrderedDes()
        {
            var gender = "M";
            var query = _persons.Where(person => person.Gender == char.Parse(gender) 
            && person.Age >= 20 && person.Age <= 30).OrderByDescending(person => person.Age);

            await Task.Delay(1000);
            return query;
        }

        //retorne la cantidad de personas con género femenino
        public int GetCount()
        {
            var gender = "F";
            var query = _persons.Where(person => person.Gender == char.Parse(gender)).Count();
            return query;
        }

        //retorna si existen personas con el apellido “Shemelt”
        public bool GetExist()
        {
            var lastname = "Shemelt";
            var query = _persons.Any(person => person.LastName == lastname);
            return query;
        }

        //retorne únicamente una persona cuyo trabajo sea “Software Consultant” y tenga 25 años de edad
        public Person GetUnique()
        {
            var job = "Software Consultant";
            var query = _persons.First(person => person.Job == job && person.Age == 25);
            return query;
        }

        //retorne la información de las primeras 3 personas cuyo puesto de trabajo sea “Software Consultant”
        public async Task<IEnumerable<Person>> GetTakeJob()
        {
            var job = "Software Consultant";
            var query = _persons.Where(person => person.Job == job).Take(3);
            await Task.Delay(1000);
            return query;
        }

        //que omita la información de las primeras 3 personas cuyo puesto de trabajo sea “Software Consultant”
        public async Task<IEnumerable<Person>> GetSkip()
        {
            var skip = 3;
            var job = "Software Consultant";
            var query = _persons.Where(person => person.Job == job).Skip(skip);
            await Task.Delay(1000);
            return query;
        }

        //que omita la información de las primeras 3 personas 
        //y que retorne la información de las siguientes 3 personas cuyo puesto de trabajo sea 
        //“Software Consultant”
        public async Task<IEnumerable<Person>> GetSkipJob()
        {
            var skip = 3;
            var take = 3;
            var job = "Software Consultant";
            var query = _persons.Where(person => person.Job == job).Skip(skip).Take(take);
            await Task.Delay(1000);
            return query;
        }
    }
}
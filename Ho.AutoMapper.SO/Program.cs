using AutoMapper;
using System;

namespace Ho.AutoMapper.SO
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person
            {
                Name = "HAzEL NUtt"
            };
            Console.WriteLine(myPerson.Name);

            MapperConfiguration configUpper = new MapperConfiguration(cfg => {
                cfg.AddProfile(new UpperCaseProfile());
            });
            IMapper mapperUpper = new Mapper(configUpper);
            Console.WriteLine(mapperUpper.Map<Human>(myPerson).Name);

            MapperConfiguration configLower = new MapperConfiguration(cfg => {
                cfg.AddProfile(new LowerCaseProfile());
            });
            IMapper mapperLower = new Mapper(configLower);
            Console.WriteLine(mapperLower.Map<Human>(myPerson).Name);
        }
    }
}

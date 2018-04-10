using JsonContractResolvers;
using Newtonsoft.Json;
using System;

namespace JsonSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var movie = new Movie
            {
                Id = 1,
                Name = "釜山行",
                Description = "灾难恐怖片"
            };

            var propertiesContractResolver = new PropertiesContractResolver();
            propertiesContractResolver.ExcludeProperties.Add(nameof(movie.Id));

            string json = JsonConvert.SerializeObject(movie, new JsonSerializerSettings
            {
                ContractResolver = propertiesContractResolver
            });

            Console.WriteLine(json);
            Console.ReadKey();
        }
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

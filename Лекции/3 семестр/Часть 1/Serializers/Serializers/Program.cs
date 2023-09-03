using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializers
{
    [Serializable] //атрибут необходим для бинарной сериализации
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }

    public class Comment
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
        public override string ToString()
        {
            return Name + " " + Email + " " + Body;
        }
    }


    internal class Program
    {
        static void Main()
        {
			//пример http вызова к удаленному сервису с последующей десериализацией результат:
			
            HttpClient client = new HttpClient();
            var response = client.GetStringAsync(@"https://jsonplaceholder.typicode.com/comments?postId=1");
            var responseResult = response.Result;
            //Console.WriteLine(responseResult);
            var comments = JsonConvert.DeserializeObject<Comment[]>(responseResult);

            foreach(var comment in comments) {
                Console.WriteLine(comment);
            }

            
			//примеры сериализации/десериализации в разные форматы

            var person = new Person()
            {
                Name = "Вася",
                Age = 20,
                Salary = 30000.0
            };

            var xmlSerializer = new XmlSerializer(typeof(Person));

            using (var writer = new StreamWriter("person.xml")) {
                xmlSerializer.Serialize(writer, person);
            }


            var deserPerson = xmlSerializer.Deserialize(File.OpenRead("person.xml")) as Person;

            //var formatter = new BinaryFormatter();
            //using (var stream = new FileStream("person.dat", FileMode.Create, FileAccess.Write)) {
            //    formatter.Serialize(stream, person);
            //}            

            using (var binaryWriter = new BinaryWriter(File.OpenWrite("person2.dat"))) {
                binaryWriter.Write(person.Name);
                binaryWriter.Write(person.Age);
                binaryWriter.Write(person.Salary);
            }


            var jsonString = JsonConvert.SerializeObject(person);
            File.WriteAllText("person.json", jsonString);

            //var jsonPerson = JsonConvert.DeserializeObject<Person>(jsonString);

        }
    }
}

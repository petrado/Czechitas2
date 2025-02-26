using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Czechitas9_BR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // unify all what was done in lesson and in the BR
            // try all methods, so you understand them
            // make similar case, so Class Animal and create different types f animals that will be written into some folder...
            // follow same procedure

            List<Animal> animals = new List<Animal>
            {
                new Animal("Dog", "Punta", 4),
                new Animal("Chicken", "Slipka", 2),
                new Animal("Had", "Hadik", 0),
                new Animal("Cat", "Micka", 4)
            };

            // try different ways how to create folder
            string path = @"D:\\Pokusy";
            string folder = "PokusnyFolder";
            string pathToFolder = Path.Combine(path, folder);
            Directory.CreateDirectory(pathToFolder);

            // try different ways how to create file and write in it
            string file = "testovaciSoubor.txt";
            string pathToFile = Path.Combine(pathToFolder, file);
            File.WriteAllText(pathToFile, "Insert sample text here");

            string file2 = "StreamWriterText.txt";
            string pathToFile2 = Path.Combine(pathToFolder, file2);
            StreamWriter writer = new StreamWriter(pathToFile2);
            writer.WriteLine("Prvni radek");
            writer.WriteLine("Druhy radek");
            writer.WriteLine("Treti radek");
            writer.Flush();
            writer.Close();

            var pathToFile3 = Path.Combine(pathToFolder, "usingFile.txt");
            using (StreamWriter writer2 = new StreamWriter(pathToFile3))
            {
                writer2.WriteLine("Jeden radek");
                writer2.WriteLine("Druhy radek");
                writer2.WriteLine("Treti radek");
            }

            // equivalent for the BR
            string zooName = "ZooList.csv";
            string pathToZoo = Path.Combine(pathToFolder, zooName);
            File.WriteAllText(pathToZoo, "Species, Name, Legs count");
            File.AppendAllText(pathToZoo, Environment.NewLine);
            foreach (var animal in animals)
            {
                //File.WriteAllText(pathToZoo, $"{animal.Species}, {animal.Name}, {animal.LegsCount}");
                File.AppendAllText(pathToZoo, $"{animal.Species}, {animal.Name}, {animal.LegsCount}");
                File.AppendAllText(pathToZoo, Environment.NewLine);
            }

            string[] readAnimals = File.ReadAllLines(pathToZoo);
            foreach (var animal in readAnimals)
            {
                Console.WriteLine(animal);
            }

            // serialization and deserialization

            // write one line from the object
            var pathToFileXml = Path.Combine(pathToFolder, "XmlFile.txt");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Animal));
            using (StreamWriter writer3 = new StreamWriter(pathToFileXml))
            {
                xmlSerializer.Serialize(writer3, animals[0]);
            }

            // write all array into the xml
            var pathToFileXmlAll = Path.Combine(pathToFolder, "XmlFileAll.txt");
            XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(List<Animal>));
            using (StreamWriter writer4 = new StreamWriter(pathToFileXmlAll))
            {
                xmlSerializer2.Serialize(writer4, animals);
            }

            // get it back
            using (StreamReader streamReader = new StreamReader(pathToFileXml))
            {
                Animal firstAnimal = xmlSerializer.Deserialize(streamReader) as Animal;
                Console.WriteLine($"I read: {firstAnimal.Species}, {firstAnimal.Name}, {firstAnimal.LegsCount}");
            }
        }
    }
}

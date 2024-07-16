using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
[Serializable]
public class Person{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName){
        FirstName = firstName;
        LastName = lastName;
    }
}
class F120{
    static void Main(string[] args){
        string directoryPath = @"D:\koti\dinesh\sandepp\lal";
        string filePath = Path.Combine(directoryPath, "Sandeep.txt");
        DirectoryInfo d1 = new DirectoryInfo(directoryPath);
        try{
            if (!d1.Exists){
                d1.Create();
                Console.WriteLine("Directory already exists");
            }
            using(FileStream fileStream = File.Create(filePath)){
                Console.WriteLine( "Directory created successfully");
            }
            Person person = new Person("Sandeep", "Lol");
            //serialize the person object to a file
            using(FileStream fileStream = File.Create(filePath)){
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fileStream, person);
            }
            Console.WriteLine("Person object serialized successfully");
            //deserialize the person object from the file
            Person deserializedPerson;
            using(FileStream fileStream = File.OpenRead(filePath)){
                BinaryFormatter bf = new BinaryFormatter();
                deserializedPerson = (Person)bf.Deserialize(fileStream);
            }
            Console.WriteLine("Deserialized Person: "+ deserializedPerson.FirstName + " "+ deserializedPerson.LastName);
        }
        catch(IOException e){
            Console.WriteLine("Error: "+e.Message);
        }
    }
}
using Newtonsoft.Json;
using ObjectLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SerializationFormatsUI
{
    class SerializationFormatsUI
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student
                {
                    FullName = "Gautier Jacquier",
                    Age = 21,
                    Gender = "Male",
                    BriefDescription = "Recognizes errors",
                    Evaluation = 5
                },
                new Student
                {
                    FullName = "Henry Choquet",
                    Age = 24,
                    Gender = "Male",
                    BriefDescription = "Needs visual cues",
                    Evaluation = 4
                },
                new Student
                {
                    FullName = "Adrien Portier",
                    Age = 19,
                    Gender = "Male",
                    BriefDescription = "Well-mannered",
                    Evaluation = 5
                },
                new Student
                {
                    FullName = "Zacharie Bocuse",
                    Age = 23,
                    Gender = "Male",
                    BriefDescription = "Understandable speech",
                    Evaluation = 2
                },
                new Student
                {
                    FullName = "Jean-François Mignard",
                    Age = 20,
                    Gender = "Male",
                    BriefDescription = "Variable motivation level",
                    Evaluation = 5
                },
                new Student
                {
                    FullName = "Claude Gérald",
                    Age = 19,
                    Gender = "Male",
                    BriefDescription = "Alert",
                    Evaluation = 3
                },
                new Student
                {
                    FullName = "Emmeline Pinchon",
                    Age = 25,
                    Gender = "Female",
                    BriefDescription = "Follows multi-step directions",
                    Evaluation = 5
                },
                new Student
                {
                    FullName = "Julienne Vasseur",
                    Age = 21,
                    Gender = "Female",
                    BriefDescription = "Accepts mistakes",
                    Evaluation = 4
                },
                new Student
                {
                    FullName = "Honorine Ballesdens",
                    Age = 19,
                    Gender = "Female",
                    BriefDescription = "Asks for help",
                    Evaluation = 3
                },
                new Student
                {
                    FullName = "Francine Loupe",
                    Age = 19,
                    Gender = "Female",
                    BriefDescription = "Actively involved in learning",
                    Evaluation = 5
                }
            };

            Student student = new Student();
            student.FullName = "Julienne Vasseur";
            student.Age = 21;
            student.Gender = "Female";
            student.BriefDescription = "Accepts mistakes";
            student.Evaluation = 4;
            student.Save("StudentObjectToXml.xml");


            //var jsonString = File.ReadAllText("StudentObjectToJson.json");

            //var jsonString = "[{\"FullName\":\"Gautier Jacquier\",\"Age\":21,\"Gender\":\"Male\",\"BriefDescription\":\"Recognizes errors\",\"Evaluation\":5.0},{\"FullName\":\"Henry Choquet\",\"Age\":24,\"Gender\":\"Male\",\"BriefDescription\":\"Needs visual cues\",\"Evaluation\":4.0},{\"FullName\":\"Adrien Portier\",\"Age\":19,\"Gender\":\"Male\",\"BriefDescription\":\"Well-mannered\",\"Evaluation\":5.0},{\"FullName\":\"Zacharie Bocuse\",\"Age\":23,\"Gender\":\"Male\",\"BriefDescription\":\"Understandable speech\",\"Evaluation\":2.0},{\"FullName\":\"Jean-François Mignard\",\"Age\":20,\"Gender\":\"Male\",\"BriefDescription\":\"Variable motivation level\",\"Evaluation\":5.0},{\"FullName\":\"Claude Gérald\",\"Age\":19,\"Gender\":\"Male\",\"BriefDescription\":\"Alert\",\"Evaluation\":3.0},{\"FullName\":\"Emmeline Pinchon\",\"Age\":25,\"Gender\":\"Female\",\"BriefDescription\":\"Follows multi-step directions\",\"Evaluation\":5.0},{\"FullName\":\"Julienne Vasseur\",\"Age\":21,\"Gender\":\"Female\",\"BriefDescription\":\"Accepts mistakes\",\"Evaluation\":4.0},{\"FullName\":\"Honorine Ballesdens\",\"Age\":19,\"Gender\":\"Female\",\"BriefDescription\":\"Asks for help\",\"Evaluation\":3.0},{\"FullName\":\"Francine Loupe\",\"Age\":19,\"Gender\":\"Female\",\"BriefDescription\":\"Actively involved in learning\",\"Evaluation\":5.0}]";
            //var studentList = JsonConvert.DeserializeObject<List<Student>>(jsonString);

            //var studentsJson = JsonConvert.SerializeObject(students);
            //Console.WriteLine(studentsJson);

            Console.ReadKey();
            
        }
    }
}

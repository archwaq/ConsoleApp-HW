using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ObjectLibrary
{
    public class Student
    {
        public Student()
        {

        }

        [XmlElement]
        public Student[] Students;
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string BriefDescription { get; set; }
        public double Evaluation { get; set; }

        public void Save(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Student));
                xml.Serialize(stream, this);
            }
        }

        public Student LoadFromFile(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(Student));
                return (Student)xml.Deserialize(stream);
            }
        }
    }
}

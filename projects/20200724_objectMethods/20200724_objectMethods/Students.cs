using System;
namespace _20200724_objectMethods
{
    public class Students
    {
        public string name;
        public string major;
        public double gpa;
        public Students(string name, string major, double gpa)
        {
            this.name = name;
            this.major = major;
            this.gpa = gpa;
        }

        public bool hasHonnors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}

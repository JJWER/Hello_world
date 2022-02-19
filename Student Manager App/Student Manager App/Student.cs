using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Manager_App
{
    internal class Student
    {
        private string _id;
        private string _name;
        private string _major;
        private string _GPAx;

        private string v1;
        private string v2;
        private string v3;

        public Student(string id, 
            string name,
            string major,string GPAx) { 
            this._id = id;
            this._name = name;
            this._major = major;
            this._GPAx = GPAx;
        }

        public Student(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        //encapsulation
        public string getId() { return this._id; }
        public string getName() { return this._name; }
        public string getMajor() { return this._major; }
        public string getGPAx() { return this._GPAx;}


    }
}

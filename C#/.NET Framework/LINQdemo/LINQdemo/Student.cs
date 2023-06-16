using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LINQdemo
{
    class Student : IComparable<Student>
    {
        public string name { get; set; }
        public int age { get; set; }
        public int grade { get; set; }

        public Student(string name, int age, int grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }
        public int CompareTo(Student other)
        {
            //Sort by name if the grade and age are the same.
            if(this.grade == other.grade && this.age == other.age)
            {
                return this.name.CompareTo(other.name);
            }
            //Sort by age if grade is the same.
            if(this.grade == other.grade)
            {
                return this.age.CompareTo(other.age);
            }
            //Default to grade sort.
            return other.grade.CompareTo(this.grade);
        }
    }
}

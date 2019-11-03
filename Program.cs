using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;


namespace CreateClass
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }

        public string Gender { get; set; }

        public string IsGender()
        {
            string message;
            if (Gender == "Female")
                message = "Female";
            else if (Gender == "Male")
                message = "Male";
            else
                message = "Gender must be Female or Male";
            return message;
        }
        //Default constructor
        public Person()
        {
            Name = "Default name";
            BirthDay = DateTime.Parse("2000/01/01");
            Gender = "Default gender";
        }

        //instance constructor has 3 parameters.
        public Person(
            string name,
            DateTime birthDay,
            string gender)
        {
            this.Name = name;
            this.BirthDay = birthDay;
            this.Gender = gender;
        }
        public override string ToString()
        {
            return "Person:\nName: " + Name + "\nBirth Day: " + BirthDay.ToString("d") + "\nGender: " + IsGender() + "\n\n";
        }
    }
    public class Employee : Person
    {
        public int Salary { get; set; }
        public string Profession { get; set; }

       
        
        

        public Employee()
        {
            Name = "Default name";
            BirthDay = DateTime.Parse("2000/01/01");
            Gender = "Default gender";
            Salary = 0;
            Profession = "unknown";

           
        }

        //instance constructor has 5 parameters.
        public Employee(
            string name,
            DateTime birthDay,
            string gender,
            int salary,
            string profession)
        {
            this.Name = name;
            this.BirthDay = birthDay;
            this.Gender = gender;
            this.Salary = salary;
            this.Profession = profession;
           

        }


        public override string ToString()
        {
            return "\n\nPerson:\nName: " + Name + "\nBirth Day: " + BirthDay.ToString("d") + "\nGender: " + IsGender() + "\nSalary: " + Salary + " PLN" + "\nProfession: " + Profession;
        }
    }
    public static class Room
    {
        public static int RoomNumber(this Employee newEmployee)
        {
            if (newEmployee.Profession == "Architect")
                return 1;
            else
                return 2;
        }
       

    }
    class Programe
    {
        static void Main(string[] args)
        {
            //crate an instance of Person by using the constructor that takes 3 arguments.
            Person newPerson = new Person(
                "Alice",
                DateTime.Parse("1990/1/20"),
                "Female");
            Person newPerson2 = new Person();

            Employee newEmployee = new Employee(
                "Tom",
                DateTime.Parse("1980/12/3"),
                "Male",
                12000,
                "Architect");

            Employee newEmployee2 = new Employee(
               "Sofie",
               DateTime.Parse("1985/2/23"),
               "Female",
               12000,
               "Teacher");

            Console.Write(newPerson.ToString());
            Console.Write(newPerson2.ToString());
            Console.Write(newEmployee.ToString());
            Console.Write("\nRoom number: " + newEmployee.RoomNumber());
            Console.Write(newEmployee2.ToString());
            Console.Write("\nRoom number: " + newEmployee2.RoomNumber());
            Console.ReadLine();
        }
    }

}
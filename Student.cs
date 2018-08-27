using System;
using System.Collections.Generic;

namespace lightning{

 public class Student : Person{


public List<Exercises> assignedExercises { get; } = new List<Exercises>();

 public Student(string firstName, string lastName )
        {
            _firstName = firstName;
            _lastName = lastName;
           
        }
    






}
}
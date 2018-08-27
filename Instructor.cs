using System;
using System.Collections.Generic;

namespace lightning{

 public class Instructor : Person{




 public Instructor(string firstName, string lastName )
        {
            _firstName = firstName;
            _lastName = lastName;
           
        }
    
public void Assign(Student student, Exercises Exercises) 
{
student.assignedExercises.Add(Exercises);
}





}
}
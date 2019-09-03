using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DesignPatterns.ReflectionAndAnnotation
{
    class Annotation
    {
        public void AnnotationMain()
        {
            Employee employee = new Employee();
            employee.EmployeeName = " ";
            var context = new ValidationContext(employee, null, null);
            bool IsValid = Validator.TryValidateObject(employee, null, null);
            Console.WriteLine(IsValid);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{
    class ReplaceString
    {
        Utility utility = new Utility();
        public void Replace()
        {
            string  display = "Hello <<UserName>>,How are you?";
            Console.Write("Name ");
            string name = utility.String_Input();
            try
            {
                if (name.Length > 3)
                {

                    display = display.Replace("<<UserName>>", name);
                    Console.WriteLine(display);
                }
                else
                {
                    Console.WriteLine("Enterd Name Length sohuld be at more than 3 letter");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.ReadKey();
        }
    }
}

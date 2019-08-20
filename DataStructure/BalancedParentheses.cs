using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructure
{
    /// <summary>
    /// class for check parenthesis in given expression 
    /// </summary>
    class BalancedParentheses
    {
        Utility utility = new Utility();
            /// <summary>
            /// Check the expression paranthesis.
            /// </summary>
            public void CheckExpressionParanthesis()
            {
                try
                {
                string text = File.ReadAllText(@"C:\Users\admin\source\repos\DataStructure\DataStructure\Balanced_Parentheses.txt");
                string[] arr = text.Split(' ');
                Console.WriteLine(arr.Length);
                
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == "(")
                    {
                        utility.AddString("(");
                    }
                    else if (arr[i] == ")")
                    {
                        utility.DeleteString("(");
                    }

                }
                utility.IsEmpty();


            }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }


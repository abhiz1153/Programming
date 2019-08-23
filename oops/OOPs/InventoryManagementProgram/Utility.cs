// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPs.InventoryManagementProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class Utility
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// returns true if string contain any special Character
        /// </summary>
        /// <param name="userName">Takes the username </param>
        /// <returns>returns  if string contains any Character </returns>
        public static bool ContainsCharacter(string userName)
        {
            try
            {
                char[] userNameCharacter = userName.ToCharArray();
                //// check each character in given string wheather it is a Character.
                for (int i = 0; i < userNameCharacter.Length; i++)
                {
                    if (!char.IsLetterOrDigit(userNameCharacter[i]))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// returns true if string contain any digit.
        /// </summary>
        /// <param name ="userName"> Takes Username</param>
        /// <returns>returns true if string contains any digit</returns>
        public static bool ContainsDigit(string userName)
        {
            char[] userNameCharacter = userName.ToCharArray();
            //// check each character in given string wheather it is a Character.
            for (int i = 0; i < userNameCharacter.Length; i++)
            {
                if (char.IsDigit(userNameCharacter[i]))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks the string is empty or Null.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>returns false if string is null or empty</returns>
        public static bool CheckString(string name)
        {
            try
            {
                name = name.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Determines whether the specified input is number.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is number; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNumber(string input)
        {
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]) == false)
                    {
                        return false;
                    }
                }

                return true;
            }


            
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }

        }
        public static string pathData()
        {
            string path = @"C:\Users\admin\source\repos\OOPs\OOPs\InventoryManagementProgram\InventoryData.json";
            return path;   
        }
    }
}
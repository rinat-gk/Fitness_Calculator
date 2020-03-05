using FitnessCalculator.BL.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FitnessCalculator.BL.Controller
{

    /// <summary>
    /// User controller.
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Application User.
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Create new User Controller
        /// </summary>
        /// <param name="user"></param>
        public UserController (string userName, string genderName, DateTime birthDay, double weight, double height) 

        {
            var gender = new Gender(genderName);
            User = new User(userName, gender, birthDay, weight, height);            
        }

        /// <summary>
        /// Save User data.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }


        /// <summary>
        /// Receive User data.
        /// </summary>
        /// <returns> Application User.</returns>
        public UserController()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if(formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
                
            }

        }
    }
}

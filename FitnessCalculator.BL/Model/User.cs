using System;


namespace FitnessCalculator.BL.Model
{

    #region Settings
    /// <summary>
    /// User.
    /// </summary>
    
    [Serializable]
    public class User
    {
        /// <summary>
        /// Username.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gender.
        /// </summary>
        public Gender Gender { get; }

        /// <summary>
        /// Birth Date.
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// Weight.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Height.
        /// </summary>
        public double Height { get; set; }

        #endregion

        /// <summary>
        /// Create new user.
        /// </summary>
        /// <param name="name">Username.</param>
        /// <param name="gender">Gender.</param>
        /// <param name="birthDate">DateofBirth.</param>
        /// <param name="weight">Weight.</param>
        /// <param name="height">Height.</param>
        public User (string name,
                     Gender gender,
                     DateTime birthDate,
                     double weight, 
                     double height)
        {
            #region Check rules
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name can't be empty or null", nameof(name));
            }

            if(gender == null)
            {
                throw new ArgumentNullException("Gender can't be null.", nameof(gender));
            }

            if(birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now )
            {
                throw new ArgumentException("No such data", nameof(birthDate));
            }

            if(weight <= 0)
            {
                throw new ArgumentException("No such weight", nameof(weight));
            }

            if(height <= 0)
            {
                throw new ArgumentException("No such heigh", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name;
        }


    }
}

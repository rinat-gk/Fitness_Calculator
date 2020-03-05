using System;


namespace FitnessCalculator.BL.Model
{
    /// <summary>
    /// Gender.
    /// </summary>
    [Serializable]
    public class Gender
    {
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Create new gender
        /// </summary>
        /// <param name="name">Gender name. </param>
        public Gender (string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Gender can't be empty!", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name; 
        }

    }
}

using System;

namespace ITMO.CSCourse2021.Labs.Lab13.E2.DeveloperInfoAttribute.DLL
{
    namespace CustomAttribute
    {     
        /// <summary>
        /// This class is a custom attribute that allows
        /// the name of the developer of a class to be stored
        /// with the metadata of that class.
        /// </summary>
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct, AllowMultiple = true)]
        public class DeveloperInfoAttribute : System.Attribute
        {
            private string developerName;
            private string dateCreated;

            // Constructor. Developer name is the only
            // mandatory parameter for this attribute.
            public DeveloperInfoAttribute(string developerName)
            {
                this.developerName = developerName;
            }
            public string Developer
            {
                get
                {
                    return developerName;
                }
            }
            // Optional parameter
            public string Date
            {
                get
                {
                    return dateCreated;
                }
                set
                {
                    dateCreated = value;
                }
            }
        }
    }

}

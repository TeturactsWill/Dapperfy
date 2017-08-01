namespace Dapperfy.Attributes
{
    using System;

    /// <summary>
    /// Defines the name of a column the property maps to.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class ColumnAttribute : Attribute
    {
        public ColumnAttribute(string name)
        {
            Name = name;
        }

        /// <summary>
        /// The name of the column this property is an alias of.
        /// </summary>
        public string Name { get; set; }
    }
}

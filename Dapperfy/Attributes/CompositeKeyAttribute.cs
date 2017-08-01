namespace Dapperfy.Attributes
{
    using System;

    /// <summary>
    /// Defines a composite key within Sql. If the 
    /// <see cref="CompositeKeyAttribute.Name"/> is null. 
    /// All unnamed keys are assumed associated.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CompositeKeyAttribute : Attribute
    {

        public CompositeKeyAttribute() { }

        public CompositeKeyAttribute(string name)
        {
            Name = name;
        }

        /// <summary>
        /// A name to associate the composite key, if more than one composite key exists on a record.
        /// </summary>
        public string Name { get; set; }
    }
}

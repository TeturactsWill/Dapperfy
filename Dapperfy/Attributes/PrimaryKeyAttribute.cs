namespace Dapperfy.Attributes
{
    using System;

    /// <summary>
    /// Indicates the primary key of an object. This property will be ignored in inserts, and used
    /// in generation of some commands/queries, where the search targets a primary key.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class PrimaryKeyAttribute : Attribute
    {
    }
}

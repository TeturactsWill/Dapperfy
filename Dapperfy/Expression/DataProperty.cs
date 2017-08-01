namespace Dapperfy.Expression
{
    internal class DataProperty
    {
        public DataProperty() { }

        public DataProperty(string name, object value, string alias = null)
        {
            Name = name;
            Value = value;
            Alias = alias;
        }

        /// <summary>
        /// The name of the column this property is associated with.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The alias to assign to the property. Mostly has use in selects, 
        /// when you want the name to return as something different than the column name.
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// The value of a property that will be a part of the generated Sql.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Returns <see cref="true"/> if the Alias is not null, or empty.
        /// </summary>
        public bool HasAlias => !string.IsNullOrEmpty(Alias);
    }
}

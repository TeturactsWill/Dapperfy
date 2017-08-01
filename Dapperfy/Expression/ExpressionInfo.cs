namespace Dapperfy.Expression
{
    using System.Collections.Generic;

    internal class ExpressionInfo
    {

        public string Target { get; set; }

        public string Schema { get; set; }

        public string Database { get; set; }

        public IEnumerable<DataProperty> ExpressionBodyProperties { get; set; }

        public IEnumerable<DataProperty> FilterProperties { get; set; }

        public IEnumerable<DataProperty> SortProperties { get; set; }
    }
}

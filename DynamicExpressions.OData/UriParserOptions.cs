using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.OData.UriParser;

namespace DynamicExpressions.OData
{
    internal class UriParserOptions
    {
        public string Filter { get; set; }
        public string FilterExpression { get; set; }
        public string OrderBy { get; set; }
        public string OrderByExpression { get; set; }

        public long? Top { get; set; }
        public long? Skip { get; set; }
        public bool Count { get; set; }

        public ODataUriParserSettings ParserSettings { get; set; }
    }
}

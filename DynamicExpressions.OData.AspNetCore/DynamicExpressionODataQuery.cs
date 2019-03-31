using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.OData.UriParser;

namespace DynamicExpressions.OData.AspNetCore
{
    public class DynamicExpressionODataQuery
    {
        public void Thing<T>(HttpRequest request) where T : class
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntityType<T>();

            var model = builder.GetEdmModel();
            var path = new ODataUriParser(model, new Uri("")).ParsePath();
            
            var x = new ODataQueryOptionParser(model, path, null);
        }
    }
}

//-----------------------------------------------------------------------------
// <copyright file="EnumsEdmModel.cs" company=".NET Foundation">
//      Copyright (c) .NET Foundation and Contributors. All rights reserved.
//      See License.txt in the project root for license information.
// </copyright>
//------------------------------------------------------------------------------

using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace Microsoft.AspNetCore.OData.E2E.Tests.Lists
{
    internal class EnumsEdmModel
    {
        public static IEdmModel GetConventionModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            EntitySetConfiguration<Employee> employees = builder.EntitySet<Employee>("Employees");          

            builder.Namespace = typeof(Employee).Namespace;

            var edmModel = builder.GetEdmModel();
            return edmModel;
        }

           }
}

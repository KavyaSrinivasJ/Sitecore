using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Foundation.Repository.Context
{
    public class IContextWrapper
    {
        string Datasource { get; }

        public void GetParameterValue(string v)
        {
            throw new NotImplementedException();
        }
    }
}
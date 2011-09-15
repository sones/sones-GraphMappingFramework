using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sones.GraphMappingFramework.ClientUtils
{
    class EdgeTypeCreator
    {
        private ServiceToken ServiceToken { get; private set; }

        protected EdgeTypeCreator(ServiceToken myServiceToken)
        {
            ServiceToken = myServiceToken;
        }

    }
}

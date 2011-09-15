using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sones.GraphMappingFramework.ClientUtils
{
    class EdgeTypeStore
    {
        private ServiceToken ServiceToken { get; private set; }

        protected EdgeTypeStore(ServiceToken myServiceToken)
        {
            ServiceToken = myServiceToken;
        }

    }
}

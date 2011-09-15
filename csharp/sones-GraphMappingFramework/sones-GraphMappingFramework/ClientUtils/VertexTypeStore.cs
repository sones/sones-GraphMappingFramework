using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sones.GraphMappingFramework.ClientUtils
{
    class VertexTypeStore
    {
        private ServiceToken ServiceToken { get; private set; }

        protected VertexTypeStore(ServiceToken myServiceToken)
        {
            ServiceToken = myServiceToken;
        }
    }
}

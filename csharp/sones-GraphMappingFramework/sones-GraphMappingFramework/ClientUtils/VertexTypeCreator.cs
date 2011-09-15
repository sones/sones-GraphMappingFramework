using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sones.GraphMappingFramework.ClientUtils
{
    class VertexTypeCreator
    {
        private ServiceToken ServiceToken { get; private set; }

        protected VertexTypeCreator(ServiceToken myServiceToken)
        {
            ServiceToken = myServiceToken;
        }
    }
}

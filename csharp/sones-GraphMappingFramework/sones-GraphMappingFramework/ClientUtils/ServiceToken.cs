using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sones.GraphMappingFramework.ServiceReference;

namespace sones.GraphMappingFramework.ClientUtils
{
    public class ServiceToken
    {
        public Nullable<long> CurrentTransactionToken { get; set; }
        
        //public RPCServiceContract ServiceReference { get; private set; }

        public GraphDS GraphDSService { get;  set; }
        
        public VertexTypeService VertexTypeService { get;  set; }
        
        public VertexInstanceService VertexInstanceService { get;  set; }
        
        public EdgeTypeService EdgeTypeService { get;  set; }
       
        public EdgeInstanceService EdgeInstanceService { get;  set; }

       
    }
}

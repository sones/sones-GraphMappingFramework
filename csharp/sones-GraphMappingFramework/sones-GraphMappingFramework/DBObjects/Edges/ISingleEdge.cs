using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sones.GraphMappingFramework.DBObjects.Vertex;

namespace sones.GraphMappingFramework.DBObjects.Edges
{
    public interface ISingleEdge : IEdge
    {
        public IVertex GetTargetVertex(); 
    }
}

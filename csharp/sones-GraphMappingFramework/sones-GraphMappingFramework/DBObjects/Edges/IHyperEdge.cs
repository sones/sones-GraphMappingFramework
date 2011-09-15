using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sones.GraphMappingFramework.DBObjects.Edges
{
    public interface IHyperEdge : IEdge
    {
        List<ISingleEdge> GetEdges();
    }
}

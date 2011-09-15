using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sones.GraphMappingFramework.DBObjects.Edges;

namespace sones.GraphMappingFramework.DBObjects.Vertex
{
    public interface IVertex
    {
        #region incoming edges

        /// <summary>
        /// Checks if there are any incoming edges from given vertex type.
        /// </summary>
        /// <param name="myVertexType"></param>
        /// <param name="myAttributeName"></param>
        /// <returns></returns>
        public Boolean HasIncomingVertices(IVertexType myVertexType, String myAttributeName);
        public List<Tuple<long, long, List<IVertex>>> GetIncomingVertices();

        /// <summary>
        /// Returns a list of incoming edges from given vertex type.
        /// </summary>
        /// <param name="myVertexType"></param>
        /// <param name="myAttributeName"></param>
        /// <returns></returns>
        public List<IVertex> GetIncomingVertices(IVertexType myVertexType, String myAttributeName);

        #endregion

        #region incoming edges

        public Boolean HasOutgoingEdge(String myPropertyName);
        public List<Tuple<long, IEdge>> GetOutgoingEdges();
        public List<Tuple<long, IHyperEdge>> GetOutgoingHyperEdges();
        public List<Tuple<long, ISingleEdge>> GetOutgoingSingleEdges();
        public IEdge GetOutgoingEdge(String myAttributeName);
        public IHyperEdge GetOutgoingHyperEdge(String myAttributeName);
        public ISingleEdge GetOutgoingSingleEdge(String myAttributeName);

        #endregion
    }
}

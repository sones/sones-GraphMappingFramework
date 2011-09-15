using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sones.GraphMappingFramework.DBObjects.Definitions;

namespace sones.GraphMappingFramework.DBObjects
{
    public interface IVertexType
    {
         Boolean IsSealed();
         Boolean HasParentType();
         Boolean HasChildTypes();
         Boolean IsAncestor(IVertexType myotherType);
         Boolean IsAncestor(IVertexType myotherType, Boolean myIncludeSelf);
         Boolean IsDescendant(IVertexType myotherType);
         Boolean IsDescendant(IVertexType myotherType, Boolean myIncludeSelf);
         List<IVertexType> GetDescendantTypes();
         List<IVertexType> GetDescendantTypes(Boolean myIncludeSelf);
         List<IVertexType> GetAncestorTypes();
         List<IVertexType> GetAncestorTypes(Boolean myIncludeSelf);
         List<IVertexType> GetKinsmenTypes();
         List<IVertexType> GetKinsmenTypes(Boolean myIncludeSelf);
         List<IVertexType> GetChildrenTypes();
         List<IVertexType> GetParentType();

        #region Attributes

         Boolean HasAttribute(String myAttributeName);
         Boolean HasAttributes(Boolean myIncludeAncestors);
         AttributeDefinition GetAttributeDefinition(String myAttributeName);
         List<AttributeDefinition> GetAttributeDefinitions(Boolean myIncludeAncestors);

        #endregion

        #region Properties

         Boolean HasProperty(String myPropertyName);
         Boolean HasProperties(Boolean myIncludeAncestors);
         PropertyDefinition GetPropertyDefinition(String myPropertyName);
         List<PropertyDefinition> GetPropertyDefinitions(Boolean myIncludeAncestors);
         List<PropertyDefinition> GetPropertyDefinitions(List<String> myPropertyNames);

        #endregion

        #region Incoming

         Boolean HasBinaryProperty(String myPropertyName);
         Boolean HasBinaryProperties(Boolean myIncludeAncestors);
         BinaryPropertyDefinition GetBinaryPropertyDefinition(String myPropertyName);
         List<BinaryPropertyDefinition> GetBinaryPropertyDefinitions(Boolean myIncludeAncestors);

        #endregion

        #region Incoming Edges

         Boolean HasIncomingEdge();
         Boolean HasIncomingEdges(Boolean myIncludeAncestors);
         IncomingEdgeDefinition GetIncomingEdgeDefinition(String myEdgeName);
         List<IncomingEdgeDefinition> GetIncomingEdgeDefinitions(Boolean myIncludeAncestors);

        #endregion

        #region Outgoing Edges

         Boolean HasOutgoingEdge(String myEdgeName);
         Boolean HasOutgoingEdges(Boolean myIncludeAncestors);
         OutgoingEdgeDefinition GetOutgoingEdgeDefinition(String myEdgeName);
         List<OutgoingEdgeDefinition> GetOutgoingEdgeDefinitions(Boolean myIncludeAncestors);

        #endregion

        #region Uniques

        Boolean HasUniqueDefinitions(Boolean myIncludeAncestors);
        List<UniqueDefinition> GetUniqueDefinitions(Boolean myIncludeAncestors);
        #endregion

        #region Indices
         Boolean HasIndexDefinitions(Boolean myIncludeAncestors);
         List<IndexDefinition> GetIndexDefinitions(Boolean myIncludeAncestors);

        #endregion
    }
}

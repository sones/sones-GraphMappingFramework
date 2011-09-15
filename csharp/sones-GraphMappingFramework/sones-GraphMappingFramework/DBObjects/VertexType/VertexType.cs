using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sones.GraphMappingFramework.DBObjects.Definitions;

namespace sones.GraphMappingFramework.DBObjects.VertexType
{
    internal class VertexType : IVertexType
    {

        public bool IsSealed()
        {
            throw new NotImplementedException();
        }

        public bool HasParentType()
        {
            throw new NotImplementedException();
        }

        public bool HasChildTypes()
        {
            throw new NotImplementedException();
        }

        public bool IsAncestor(IVertexType myotherType)
        {
            throw new NotImplementedException();
        }

        public bool IsAncestor(IVertexType myotherType, bool myIncludeSelf)
        {
            throw new NotImplementedException();
        }

        public bool IsDescendant(IVertexType myotherType)
        {
            throw new NotImplementedException();
        }

        public bool IsDescendant(IVertexType myotherType, bool myIncludeSelf)
        {
            throw new NotImplementedException();
        }

        public List<IVertexType> GetDescendantTypes()
        {
            throw new NotImplementedException();
        }

        public List<IVertexType> GetDescendantTypes(bool myIncludeSelf)
        {
            throw new NotImplementedException();
        }

        public List<IVertexType> GetAncestorTypes()
        {
            throw new NotImplementedException();
        }

        public List<IVertexType> GetAncestorTypes(bool myIncludeSelf)
        {
            throw new NotImplementedException();
        }

        public List<IVertexType> GetKinsmenTypes()
        {
            throw new NotImplementedException();
        }

        public List<IVertexType> GetKinsmenTypes(bool myIncludeSelf)
        {
            throw new NotImplementedException();
        }

        public List<IVertexType> GetChildrenTypes()
        {
            throw new NotImplementedException();
        }

        public List<IVertexType> GetParentType()
        {
            throw new NotImplementedException();
        }

        public bool HasAttribute(string myAttributeName)
        {
            throw new NotImplementedException();
        }

        public bool HasAttributes(bool myIncludeAncestors)
        {
            throw new NotImplementedException();
        }

        public AttributeDefinition GetAttributeDefinition(string myAttributeName)
        {
            throw new NotImplementedException();
        }

        public List<AttributeDefinition> GetAttributeDefinitions(bool myIncludeAncestors)
        {
            throw new NotImplementedException();
        }

        public bool HasProperty(string myPropertyName)
        {
            throw new NotImplementedException();
        }

        public bool HasProperties(bool myIncludeAncestors)
        {
            throw new NotImplementedException();
        }

        public PropertyDefinition GetPropertyDefinition(string myPropertyName)
        {
            throw new NotImplementedException();
        }

        public List<PropertyDefinition> GetPropertyDefinitions(bool myIncludeAncestors)
        {
            throw new NotImplementedException();
        }

        public List<PropertyDefinition> GetPropertyDefinitions(List<string> myPropertyNames)
        {
            throw new NotImplementedException();
        }

        public bool HasBinaryProperty(string myPropertyName)
        {
            throw new NotImplementedException();
        }

        public bool HasBinaryProperties(bool myIncludeAncestors)
        {
            throw new NotImplementedException();
        }

        public BinaryPropertyDefinition GetBinaryPropertyDefinition(string myPropertyName)
        {
            throw new NotImplementedException();
        }

        public List<BinaryPropertyDefinition> GetBinaryPropertyDefinitions(bool myIncludeAncestors)
        {
            throw new NotImplementedException();
        }

        public bool HasIncomingEdge()
        {
            throw new NotImplementedException();
        }

        public bool HasIncomingEdges(bool myIncludeAncestors)
        {
            throw new NotImplementedException();
        }

        public IncomingEdgeDefinition GetIncomingEdgeDefinition(string myEdgeName)
        {
            throw new NotImplementedException();
        }

        public List<IncomingEdgeDefinition> GetIncomingEdgeDefinitions(bool myIncludeAncestors)
        {
            throw new NotImplementedException();
        }

        public bool HasOutgoingEdge(string myEdgeName)
        {
            throw new NotImplementedException();
        }

        public bool HasOutgoingEdges(bool myIncludeAncestors)
        {
            throw new NotImplementedException();
        }

        public OutgoingEdgeDefinition GetOutgoingEdgeDefinition(string myEdgeName)
        {
            throw new NotImplementedException();
        }

        public List<OutgoingEdgeDefinition> GetOutgoingEdgeDefinitions(bool myIncludeAncestors)
        {
            throw new NotImplementedException();
        }

        public bool HasUniqueDefinitions(bool myIncludeAncestors)
        {
            throw new NotImplementedException();
        }

        public List<UniqueDefinition> GetUniqueDefinitions(bool myIncludeAncestors)
        {
            throw new NotImplementedException();
        }

        public bool HasIndexDefinitions(bool myIncludeAncestors)
        {
            throw new NotImplementedException();
        }

        public List<IndexDefinition> GetIndexDefinitions(bool myIncludeAncestors)
        {
            throw new NotImplementedException();
        }
    }
}

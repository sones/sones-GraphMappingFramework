using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sones.GraphMappingFramework.DBObjects.Definitions;

namespace sones.GraphMappingFramework.DBObjects.EdgeType
{
    internal class EdgeType : IEdgeType
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

        public bool IsAncestor(IEdgeType myotherType)
        {
            throw new NotImplementedException();
        }

        public bool IsAncestor(IEdgeType myotherType, bool myIncludeSelf)
        {
            throw new NotImplementedException();
        }

        public bool IsDescendant(IEdgeType myotherType)
        {
            throw new NotImplementedException();
        }

        public bool IsDescendant(IEdgeType myotherType, bool myIncludeSelf)
        {
            throw new NotImplementedException();
        }

        public List<IEdgeType> GetDescendantTypes()
        {
            throw new NotImplementedException();
        }

        public List<IEdgeType> GetDescendantTypes(bool myIncludeSelf)
        {
            throw new NotImplementedException();
        }

        public List<IEdgeType> GetAncestorTypes()
        {
            throw new NotImplementedException();
        }

        public List<IEdgeType> GetAncestorTypes(bool myIncludeSelf)
        {
            throw new NotImplementedException();
        }

        public List<IEdgeType> GetKinsmenTypes()
        {
            throw new NotImplementedException();
        }

        public List<IEdgeType> GetKinsmenTypes(bool myIncludeSelf)
        {
            throw new NotImplementedException();
        }

        public List<IEdgeType> GetChildrenTypes()
        {
            throw new NotImplementedException();
        }

        public List<IEdgeType> GetParentType()
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
    }
}

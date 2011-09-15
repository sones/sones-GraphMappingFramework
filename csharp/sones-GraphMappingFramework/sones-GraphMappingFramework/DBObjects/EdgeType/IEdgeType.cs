using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sones.GraphMappingFramework.DBObjects.Definitions;

namespace sones.GraphMappingFramework.DBObjects.EdgeType
{
    public interface IEdgeType
    {
         Boolean IsSealed();
         Boolean HasParentType();
         Boolean HasChildTypes();
         Boolean IsAncestor(IEdgeType myotherType);
         Boolean IsAncestor(IEdgeType myotherType, Boolean myIncludeSelf);
         Boolean IsDescendant(IEdgeType myotherType);
         Boolean IsDescendant(IEdgeType myotherType, Boolean myIncludeSelf);
         List<IEdgeType> GetDescendantTypes();
         List<IEdgeType> GetDescendantTypes(Boolean myIncludeSelf);
         List<IEdgeType> GetAncestorTypes();
         List<IEdgeType> GetAncestorTypes(Boolean myIncludeSelf);
         List<IEdgeType> GetKinsmenTypes();
         List<IEdgeType> GetKinsmenTypes(Boolean myIncludeSelf);
         List<IEdgeType> GetChildrenTypes();
         List<IEdgeType> GetParentType();

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
    }
}

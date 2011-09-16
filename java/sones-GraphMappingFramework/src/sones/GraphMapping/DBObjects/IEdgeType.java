package sones.GraphMapping.DBObjects;

import java.util.List;

import sones.GraphMapping.Definitions.AttributeDefinition;
import sones.GraphMapping.Definitions.PropertyDefinition;

public interface IEdgeType {
	public boolean IsSealed();
	public boolean HasParentType();
	public boolean HasChildTypes();
	public boolean IsAncestor(IEdgeType _otherType);
	public boolean IsAncestor(IEdgeType _otherType, boolean _IncludeSelf);
	public boolean IsDescendant(IEdgeType _otherType);
	public boolean IsDescendant(IEdgeType _otherType, boolean _IncludeSelf);
	public List<IEdgeType> GetDescendantTypes();
	public List<IEdgeType> GetDescendantTypes(boolean _IncludeSelf);
	public List<IEdgeType> GetAncestorTypes();
	public List<IEdgeType> GetAncestorTypes(boolean _IncludeSelf);
	public List<IEdgeType> GetKinsmenTypes();
	public List<IEdgeType> GetKinsmenTypes(boolean _IncludeSelf);
	public List<IEdgeType> GetChildrenTypes();
	public List<IEdgeType> GetParentType();
	// Attributes
	public boolean HasAttribute(String _AttributeName);
	public boolean HasAttributes(boolean _IncludeAncestors);
	public AttributeDefinition GetAttributeDefinition(String _AttributeName);
	public List<AttributeDefinition> GetAttributeDefinitions(boolean _IncludeAncestors);
	// Properties
	public boolean HasProperty(String _PropertyName);
	public boolean HasProperties(boolean _IncludeAncestors);
	public PropertyDefinition GetPropertyDefinition(String _PropertyName);
	public List<PropertyDefinition> GetPropertyDefinitions(boolean _IncludeAncestors);
	public List<PropertyDefinition> GetPropertyDefinitions(List<String> _PropertyNames);
}

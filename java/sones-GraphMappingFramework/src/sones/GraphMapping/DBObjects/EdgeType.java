package sones.GraphMapping.DBObjects;

import java.util.List;

import sones.GraphMapping.Definitions.AttributeDefinition;
import sones.GraphMapping.Definitions.PropertyDefinition;

public class EdgeType implements IEdgeType {

	@Override
	public boolean IsSealed() {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean HasParentType() {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean HasChildTypes() {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean IsAncestor(EdgeType _otherType) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean IsAncestor(EdgeType _otherType, boolean _IncludeSelf) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean IsDescendant(EdgeType _otherType) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean IsDescendant(EdgeType _otherType, boolean _IncludeSelf) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public List<EdgeType> GetDescendantTypes() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<EdgeType> GetDescendantTypes(boolean _IncludeSelf) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<EdgeType> GetAncestorTypes() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<EdgeType> GetAncestorTypes(boolean _IncludeSelf) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<EdgeType> GetKinsmenTypes() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<EdgeType> GetKinsmenTypes(boolean _IncludeSelf) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<EdgeType> GetChildrenTypes() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<EdgeType> GetParentType() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public boolean HasAttribute(String _AttributeName) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean HasAttributes(boolean _IncludeAncestors) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public AttributeDefinition GetAttributeDefinition(String _AttributeName) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<AttributeDefinition> GetAttributeDefinitions(
			boolean _IncludeAncestors) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public boolean HasProperty(String _PropertyName) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean HasProperties(boolean _IncludeAncestors) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public PropertyDefinition GetPropertyDefinition(String _PropertyName) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<PropertyDefinition> GetPropertyDefinitions(
			boolean _IncludeAncestors) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<PropertyDefinition> GetPropertyDefinitions(
			List<String> _PropertyNames) {
		// TODO Auto-generated method stub
		return null;
	}

}

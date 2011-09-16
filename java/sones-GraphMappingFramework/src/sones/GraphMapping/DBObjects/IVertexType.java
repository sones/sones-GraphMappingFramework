package sones.GraphMapping.DBObjects;

import java.util.List;

import sones.GraphMapping.Definitions.AttributeDefinition;
import sones.GraphMapping.Definitions.BinaryPropertyDefinition;
import sones.GraphMapping.Definitions.IncomingEdgeDefinition;
import sones.GraphMapping.Definitions.IndexDefinitions;
import sones.GraphMapping.Definitions.OutgoingEdgeDefinition;
import sones.GraphMapping.Definitions.PropertyDefinition;
import sones.GraphMapping.Definitions.UniqueDefinition;

public interface IVertexType {
	public boolean IsSealed();
	public boolean HasParentType();
	public boolean HasChildTypes();
	public boolean IsAncestor(IVertexType _otherType);
	public boolean IsAncestor(IVertexType _otherType, boolean _IncludeSelf);
	public boolean IsDescendant(IVertexType _otherType);
	public boolean IsDescendant(IVertexType _otherType, boolean _IncludeSelf);
	public List<IVertexType> GetDescendantTypes();
	public List<IVertexType> GetDescendantTypes(boolean _IncludeSelf);
	public List<IVertexType> GetAncestorTypes();
	public List<IVertexType> GetAncestorTypes(boolean _IncludeSelf);
	public List<IVertexType> GetKinsmenTypes();
	public List<IVertexType> GetKinsmenTypes(boolean _IncludeSelf);
	public List<IVertexType> GetChildrenTypes();
	public List<IVertexType> GetParentType();
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
	// incoming
	public boolean HasBinaryProperty(String _PropertyName);
	public boolean HasBinaryProperties(boolean _IncludeAncestors);
	public BinaryPropertyDefinition GetBinaryPropertyDefinition(String _PropertyName);
	public List<BinaryPropertyDefinition> GetBinaryPropertyDefinitions(boolean _IncludeAncestors);
	// incoming edges
	public boolean HasIncomingEdge();
	public boolean HasIncomingEdges(boolean _IncludeAncestors);
	public IncomingEdgeDefinition GetIncomingEdgeDefinition(String _EdgeName);
	public List<IncomingEdgeDefinition> GetIncomingEdgeDefinitions(boolean _IncludeAncestors);
	// outgoing edges
	public boolean HasOutgoingEdge(String _EdgeName);
	public boolean HasOutgoingEdges(boolean _IncludeAncestors);
	public OutgoingEdgeDefinition GetOutgoingEdgeDefinition(String _EdgeName);
	public List<OutgoingEdgeDefinition> GetOutgoingEdgeDefinitions(boolean _IncludeAncestors);
	// uniques
	public boolean HasUniqueDefinitions(boolean _IncludeAncestors);
	public List<UniqueDefinition> GetUniqueDefinitions(boolean _IncludeAncestors);
	// indices
	public boolean HasIndexDefinitions(boolean _IncludeAncestors);
	public List<IndexDefinitions> GetIndexDefinitions(boolean _IncludeAncestors);
}

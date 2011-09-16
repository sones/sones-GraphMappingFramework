package sones.GraphMapping;

import java.util.List;

import sones.GraphMapping.DBObjects.IVertexType;
import sones.GraphMapping.Predefinitions.VertexTypePredefinition;
import sones.util.Tuple2;

public class VertexTypeCreator {
	private ServiceToken ServiceToken;
	protected VertexTypeCreator(ServiceToken _ServiceToken)
	{
		ServiceToken = _ServiceToken;
	}
	
	public IVertexType CreateType(VertexTypePredefinition _Predefinition)
	{
		
	}
	
	public IVertexType CreateType(String _TypeName, List<Tuple2<String, String>> _PropertyDefinitions)
	{
		
	}
	
	public VertexTypePredefinition CreatePredefinition(String _TypeName)
	{
		
	}
	
	public VertexTypePredefinition CreatePredefinition(String _TypeName, IVertexType _ParentType)
	{
		
	}
}

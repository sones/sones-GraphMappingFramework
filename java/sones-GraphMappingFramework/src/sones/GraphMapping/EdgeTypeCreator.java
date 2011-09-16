package sones.GraphMapping;

import java.util.List;

import sones.GraphMapping.DBObjects.IEdgeType;
import sones.GraphMapping.Predefinitions.EdgeTypePredefinition;
import sones.util.Tuple2;

public class EdgeTypeCreator {
	private ServiceToken ServiceToken;
	protected EdgeTypeCreator(ServiceToken _ServiceToken)
	{
		ServiceToken = _ServiceToken;
	}
	
	public IEdgeType CreateType(EdgeTypePredefinition _Predefinition)
	{
		
	}
	
	public IEdgeType CreateType(String _TypeName, List<Tuple2<String, String>> _PropertyDefinitions)
	{
		
	}
	
	public EdgeTypePredefinition CreatePredefinition(String _TypeName)
	{
		
	}
	
	public EdgeTypePredefinition CreatePredefinition(String _TypeName, IEdgeType _ParentType)
	{
		
	}
}

package sones.GraphMapping.DBObjects;

import java.util.List;

import sones.util.Tuple2;

public interface IEdge {
	// structured properties
	public Object GetProperty(String _PropertyName);
	public String GetPropertyAsString(String _PropertyName);
	public List<Tuple2<String, Object>> GetProperties();
	public boolean HasProperty(String _PropertyName);
	public int GetCountOfProperties();

	// unstructured properties
	public Object GetUnstructuredProperty(String _PropertyName);
	public String GetUnstructuredPropertyAsString(String _PropertyName);
	public List<Tuple2<String, Object>> GetUnstructuredProperties();
	public boolean HasUnstructuredProperty(String _PropertyName);
	public int GetCountOfUnstructuredProperties();
	
	public String GetComment();
	public long GetCreationDate();
	public long GetModificationDate();
}

package sones.GraphMapping.DBObjects;

import java.util.List;

import sones.util.Tuple2;
import sones.util.Tuple3;

public interface IVertex {
	// incoming edges
	
	/*
	 * Checks if there are any incoming edges from given vertex type.
	 * @param _VertexType Vertex type that points to this vertex.
	 * @param _AttributeName Attribute of given vertex type that points to this vertex.
	 * @return Returns true if there are any incoming edges, otherwise false.
	 */
	public boolean HasIncomingVertices(IVertexType _VertexType, String _AttributeName);
	public List<Tuple3<Long, Long, List<IVertex>>> GetIncomingVertices();
	
	/*
	 * Returns a list of incoming edges from given vertex type.
	 * @param _VertexType Vertex type that points to this vertex.
	 * @param _AttributeName Attribute of given vertex type that points to this vertex.
	 * @return List of vertices that point at this vertex.
	 */
	public List<IVertex> GetIncomingVertices(IVertexType _VertexType, String _AttributeName);
	
	// outcoming edges
	public boolean HasOutgoingEdge(String _PropertyName);
	public List<Tuple2<Long, IEdge>> GetOutgoingEdges();
	public List<Tuple2<Long, IHyperEdge>> GetOutgoingHyperEdges();
	public List<Tuple2<Long, ISingleEdge>> GetOutgoingSingleEdges();
	public IEdge GetOutgoingEdge(String _AttributeName);
	public IHyperEdge GetOutgoingHyperEdge(String _AttributeName);
	public ISingleEdge GetOutgoingSingleEdge(String _AttributeName);
	
	// structured properties
	public Object GetProperty(String _PropertyName);
	public boolean HasProperty(String _PropertyName);
	public int GetCountOfProperties();
	public List<Tuple2<Long, Object>> GetAllProperties();
	public String GetPropertyAsString(String _PropertyName);
	
	// unstructured properties
	public Object GetUnstructuredProperty(String _PropertyName);
	public List<Tuple2<String, Object>> GetUnstructuredProperties();
	public boolean HasUnstructuredProperty(String _PropertyName);
	public int GetCountOfUnstructuredProperties();
	public String GetUnstructuredPropertyAsString(String _PropertyName);
	
	public String GetComment();
	public long GetCreationDate();
	public long GetModificationDate();
}

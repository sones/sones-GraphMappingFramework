package sones.GraphMapping.DBObjects;

import java.util.List;

public interface IHyperEdge extends IEdge {
	public List<ISingleEdge> GetEdges();
}

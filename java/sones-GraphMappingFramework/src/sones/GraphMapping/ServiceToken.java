package sones.GraphMapping;

import com.sones.EdgeInstanceService;
import com.sones.EdgeTypeService;
import com.sones.GraphDS;
import com.sones.RPCServiceContract;
import com.sones.VertexInstanceService;
import com.sones.VertexTypeService;

public class ServiceToken {
	private Long CurrentTransactionToken;
	public RPCServiceContract ServiceReference;
	public GraphDS GraphDSService;
	public VertexTypeService VertexTypeService;
	public VertexInstanceService VertexInstanceService;
	public EdgeTypeService EdgeTypeService;
	public EdgeInstanceService EdgeInstanceService;
	
	public Long getCurrentTransactionToken()
	{
		return CurrentTransactionToken;
	}
	
	protected void setCurrentTransactionToken(Long _CurrentTransactionToken)
	{
		CurrentTransactionToken = _CurrentTransactionToken;
	}
}

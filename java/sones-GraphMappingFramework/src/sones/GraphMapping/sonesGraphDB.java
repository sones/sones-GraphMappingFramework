package sones.GraphMapping;

import java.net.URL;

import com.sones.RPCServiceContract;
import com.sones.ServiceSecurityToken;


public class sonesGraphDB {
	private VertexTypeStore VertexTypeStore;
	private EdgeTypeStore EdgeTypeStore;
	private VertexTypeCreator VertexTypeCreator;
	private EdgeTypeCreator EdgeTypeCreator;
	private ServiceSecurityToken SecurityToken;
	protected ServiceToken ServiceToken;
	
	private sonesGraphDB(URL myServiceAddress, String myUsername, String myPassword)
	{
		ServiceToken.ServiceReference = new RPCServiceContract();
		
		VertexTypeStore = new VertexTypeStore(ServiceToken);
		EdgeTypeStore = new EdgeTypeStore(ServiceToken);
		VertexTypeCreator = new VertexTypeCreator(ServiceToken);
		EdgeTypeCreator = new EdgeTypeCreator(ServiceToken);
	}
	
	public static sonesGraphDB Open(URL myServiceAddress, String myUsername, String myPassword )
	{
		return new sonesGraphDB(myServiceAddress, myUsername, myPassword);
	}
	
	public VertexTypeStore getVertexTypeStore() {
		return VertexTypeStore;
	}
	public EdgeTypeStore getEdgeTypeStore()
	{
		return EdgeTypeStore;
	}
	public VertexTypeCreator getVertexTypeCreator()
	{
		return VertexTypeCreator;
	}
	public EdgeTypeCreator getEdgeTypeCreator()
	{
		return EdgeTypeCreator;
	}
	
	public void BeginTransaction()
	{
		ServiceToken.setCurrentTransactionToken(ServiceToken.GraphDSService.beginTransaction(SecurityToken));
	}


	public void RollbackLastTransaction()
	{
		if (CurrentTransactionToken.HasValue)
		{
			NativeServices.GraphDS.RollbackTransaction(new RollbackTransactionRequest(SecurityToken, CurrentTransactionToken.Value));
			return;
		}
		throw new TransactionException("There was no transaction id available! Probably 'BeginTransaction()' was never called.");
	}
            

}

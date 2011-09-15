using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sones.GraphMappingFramework.ClientUtils;
using sones.GraphMappingFramework.ServiceReference;
using System.Security.Policy;
using System.ServiceModel;
using System.Net;
using sones.GraphMappingFramework.ErrorHandling;

namespace sones.GraphMappingFramework
{
    public class sonesGraphDB
    {
        private VertexTypeStore VertexTypeStore;
        private EdgeTypeStore EdgeTypeStore;
        private VertexTypeCreator VertexTypeCreator;
        private EdgeTypeCreator EdgeTypeCreator;

        private SecurityToken SecurityToken;

        protected ServiceToken ServiceToken;

        private sonesGraphDB(Uri myServiceAddress, String myUsername, String myPassword)
        {
            BasicHttpBinding BasicBinding = new BasicHttpBinding();
            BasicBinding.Name = "sonesBasic";
            BasicBinding.MessageEncoding = WSMessageEncoding.Text;
            BasicBinding.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;

            ServiceToken = new ServiceToken();

            try
            {
                var Request = HttpWebRequest.Create(myServiceAddress.ToString());
                var Response = Request.GetResponse();
            }
            catch (Exception ex)
            {
                throw new Exception("The GraphDB remote service is unreachable! Maybe the service was not started.", ex);
            }

            try
            {
                
                ServiceToken.GraphDSService = ChannelFactory<GraphDS>.CreateChannel(BasicBinding, new EndpointAddress(myServiceAddress));
                ServiceToken.VertexTypeService = ChannelFactory<VertexTypeService>.CreateChannel(BasicBinding, new EndpointAddress(myServiceAddress));
                ServiceToken.VertexInstanceService = ChannelFactory<VertexInstanceService>.CreateChannel(BasicBinding, new EndpointAddress(myServiceAddress));
                ServiceToken.EdgeTypeService = ChannelFactory<EdgeTypeService>.CreateChannel(BasicBinding, new EndpointAddress(myServiceAddress));
                ServiceToken.EdgeInstanceService = ChannelFactory<EdgeInstanceService>.CreateChannel(BasicBinding, new EndpointAddress(myServiceAddress));

            }
            catch (Exception ex)
            {
                throw new Exception("The GraphDB is reachably but there occured an error, creating the native services!", ex);
            }
        }

         static sonesGraphDB Open(Uri myServiceAddress, String myUsername, String myPassword)
        {
            return new sonesGraphDB(myServiceAddress, myUsername, myPassword);
        }

         VertexTypeStore GetVertexTypeStore()
        {
            return VertexTypeStore;
        }
         EdgeTypeStore GetEdgeTypeStore()
        {
            return EdgeTypeStore;
        }
         VertexTypeCreator GetVertexTypeCreator()
        {
            return VertexTypeCreator;
        }
         EdgeTypeCreator GetEdgeTypeCreator()
        {
            return EdgeTypeCreator;
        }

         void BeginTransaction()
        {
            ServiceToken.CurrentTransactionToken = ServiceToken.GraphDSService.BeginTransaction(new BeginTransactionRequest(SecurityToken)).BeginTransactionResult;
        }


         void RollbackLastTransaction()
        {
            if (ServiceToken.CurrentTransactionToken.HasValue)
            {
                ServiceToken.GraphDSService.RollbackTransaction(new RollbackTransactionRequest(SecurityToken, ServiceToken.CurrentTransactionToken.Value));
                return;
            }
            throw new TransactionException("There was no transaction id available! Probably 'BeginTransaction()' was never called.");
        }
           
    }
}

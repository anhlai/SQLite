using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT1002U00GrdComment3Args : IContractArgs
    {
        private String _bunho;
        private String _orderDate;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String OrderDate
        {
            get { return this._orderDate; }
            set { this._orderDate = value; }
        }

        public XRT1002U00GrdComment3Args() { }

        public XRT1002U00GrdComment3Args(String bunho, String orderDate)
        {
            this._bunho = bunho;
            this._orderDate = orderDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT1002U00GrdComment3Request();
        }
    }
}
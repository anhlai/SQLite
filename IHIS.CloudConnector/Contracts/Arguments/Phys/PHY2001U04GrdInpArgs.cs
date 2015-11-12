using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04GrdInpArgs : IContractArgs
    {
        private String _orderDate;

        public String OrderDate
        {
            get { return this._orderDate; }
            set { this._orderDate = value; }
        }

        public PHY2001U04GrdInpArgs() { }

        public PHY2001U04GrdInpArgs(String orderDate)
        {
            this._orderDate = orderDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04GrdInpRequest();
        }
    }
}
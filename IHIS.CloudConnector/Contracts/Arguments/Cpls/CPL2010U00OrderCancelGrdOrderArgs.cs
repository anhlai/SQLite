using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL2010U00OrderCancelGrdOrderArgs : IContractArgs
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

        public CPL2010U00OrderCancelGrdOrderArgs() { }

        public CPL2010U00OrderCancelGrdOrderArgs(String bunho, String orderDate)
        {
            this._bunho = bunho;
            this._orderDate = orderDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL2010U00OrderCancelGrdOrderRequest();
        }
    }
}
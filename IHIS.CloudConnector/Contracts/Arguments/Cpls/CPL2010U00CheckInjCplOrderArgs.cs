using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL2010U00CheckInjCplOrderArgs : IContractArgs
    {
        private String _ioGubun;
        private String _bunho;
        private String _orderDate;

        public String IoGubun
        {
            get { return this._ioGubun; }
            set { this._ioGubun = value; }
        }

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

        public CPL2010U00CheckInjCplOrderArgs() { }

        public CPL2010U00CheckInjCplOrderArgs(String ioGubun, String bunho, String orderDate)
        {
            this._ioGubun = ioGubun;
            this._bunho = bunho;
            this._orderDate = orderDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL2010U00CheckInjCplOrderRequest();
        }
    }
}
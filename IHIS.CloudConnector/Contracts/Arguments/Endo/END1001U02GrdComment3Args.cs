using System;
using IHIS.CloudConnector.Contracts.Models.Endo;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Endo
{
    public class END1001U02GrdComment3Args : IContractArgs
    {
        private String _hospCode;
        private String _bunho;
        private String _orderDate;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
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

        public END1001U02GrdComment3Args() { }

        public END1001U02GrdComment3Args(String hospCode, String bunho, String orderDate)
        {
            this._hospCode = hospCode;
            this._bunho = bunho;
            this._orderDate = orderDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.END1001U02GrdComment3Request();
        }
    }
}
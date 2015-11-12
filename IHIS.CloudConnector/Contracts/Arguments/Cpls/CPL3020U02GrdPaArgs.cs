using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL3020U02GrdPaArgs : IContractArgs
    {
        private String _fromDate;
        private String _toDate;
        private String _jangbiCode;

        public String FromDate
        {
            get { return this._fromDate; }
            set { this._fromDate = value; }
        }

        public String ToDate
        {
            get { return this._toDate; }
            set { this._toDate = value; }
        }

        public String JangbiCode
        {
            get { return this._jangbiCode; }
            set { this._jangbiCode = value; }
        }

        public CPL3020U02GrdPaArgs() { }

        public CPL3020U02GrdPaArgs(String fromDate, String toDate, String jangbiCode)
        {
            this._fromDate = fromDate;
            this._toDate = toDate;
            this._jangbiCode = jangbiCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL3020U02GrdPaRequest();
        }
    }
}
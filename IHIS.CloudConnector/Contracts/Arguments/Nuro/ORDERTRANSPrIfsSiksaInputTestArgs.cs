using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class ORDERTRANSPrIfsSiksaInputTestArgs : IContractArgs
    {
        private String _hospCode;
        private String _bunho;
        private String _fromDate;
        private String _fromSik;
        private String _toDate;
        private String _toSik;

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

        public String FromDate
        {
            get { return this._fromDate; }
            set { this._fromDate = value; }
        }

        public String FromSik
        {
            get { return this._fromSik; }
            set { this._fromSik = value; }
        }

        public String ToDate
        {
            get { return this._toDate; }
            set { this._toDate = value; }
        }

        public String ToSik
        {
            get { return this._toSik; }
            set { this._toSik = value; }
        }

        public ORDERTRANSPrIfsSiksaInputTestArgs() { }

        public ORDERTRANSPrIfsSiksaInputTestArgs(String hospCode, String bunho, String fromDate, String fromSik, String toDate, String toSik)
        {
            this._hospCode = hospCode;
            this._bunho = bunho;
            this._fromDate = fromDate;
            this._fromSik = fromSik;
            this._toDate = toDate;
            this._toSik = toSik;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ORDERTRANSPrIfsSiksaInputTestRequest();
        }
    }
}
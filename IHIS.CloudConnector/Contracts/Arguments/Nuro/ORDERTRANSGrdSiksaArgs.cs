using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class ORDERTRANSGrdSiksaArgs : IContractArgs
    {
        private String _sendYn;
        private String _hospCode;
        private String _bunho;
        private String _pk1001;
        private String _actingDate;

        public String SendYn
        {
            get { return this._sendYn; }
            set { this._sendYn = value; }
        }

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

        public String Pk1001
        {
            get { return this._pk1001; }
            set { this._pk1001 = value; }
        }

        public String ActingDate
        {
            get { return this._actingDate; }
            set { this._actingDate = value; }
        }

        public ORDERTRANSGrdSiksaArgs() { }

        public ORDERTRANSGrdSiksaArgs(String sendYn, String hospCode, String bunho, String pk1001, String actingDate)
        {
            this._sendYn = sendYn;
            this._hospCode = hospCode;
            this._bunho = bunho;
            this._pk1001 = pk1001;
            this._actingDate = actingDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ORDERTRANSGrdSiksaRequest();
        }
    }
}
using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class ORDERTRANSGrdHokenArgs : IContractArgs
    {
        private String _actingDate;
        private String _gubun;
        private String _hospCode;
        private String _bunho;
        private String _sendYn;

        public String ActingDate
        {
            get { return this._actingDate; }
            set { this._actingDate = value; }
        }

        public String Gubun
        {
            get { return this._gubun; }
            set { this._gubun = value; }
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

        public String SendYn
        {
            get { return this._sendYn; }
            set { this._sendYn = value; }
        }

        public ORDERTRANSGrdHokenArgs() { }

        public ORDERTRANSGrdHokenArgs(String actingDate, String gubun, String hospCode, String bunho, String sendYn)
        {
            this._actingDate = actingDate;
            this._gubun = gubun;
            this._hospCode = hospCode;
            this._bunho = bunho;
            this._sendYn = sendYn;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ORDERTRANSGrdHokenRequest();
        }
    }
}
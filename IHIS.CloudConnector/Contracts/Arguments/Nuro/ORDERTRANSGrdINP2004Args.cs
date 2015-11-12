using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class ORDERTRANSGrdINP2004Args : IContractArgs
    {
        private String _hospCode;
        private String _bunho;
        private String _sendYn;
        private String _actingDate;
        private String _sunabDate;
        private String _fkinp1001;

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

        public String ActingDate
        {
            get { return this._actingDate; }
            set { this._actingDate = value; }
        }

        public String SunabDate
        {
            get { return this._sunabDate; }
            set { this._sunabDate = value; }
        }

        public String Fkinp1001
        {
            get { return this._fkinp1001; }
            set { this._fkinp1001 = value; }
        }

        public ORDERTRANSGrdINP2004Args() { }

        public ORDERTRANSGrdINP2004Args(String hospCode, String bunho, String sendYn, String actingDate, String sunabDate, String fkinp1001)
        {
            this._hospCode = hospCode;
            this._bunho = bunho;
            this._sendYn = sendYn;
            this._actingDate = actingDate;
            this._sunabDate = sunabDate;
            this._fkinp1001 = fkinp1001;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ORDERTRANSGrdINP2004Request();
        }
    }
}
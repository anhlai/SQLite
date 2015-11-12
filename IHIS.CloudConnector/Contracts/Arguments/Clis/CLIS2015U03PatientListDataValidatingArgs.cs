using System;
using IHIS.CloudConnector.Contracts.Models.Clis;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Clis
{
    public class CLIS2015U03PatientListDataValidatingArgs : IContractArgs
    {
        private String _hospCode;
        private String _bunho;
        private String _protocolId;

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

        public String ProtocolId
        {
            get { return this._protocolId; }
            set { this._protocolId = value; }
        }

        public CLIS2015U03PatientListDataValidatingArgs() { }

        public CLIS2015U03PatientListDataValidatingArgs(String hospCode, String bunho, String protocolId)
        {
            this._hospCode = hospCode;
            this._bunho = bunho;
            this._protocolId = protocolId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CLIS2015U03PatientListDataValidatingRequest();
        }
    }
}
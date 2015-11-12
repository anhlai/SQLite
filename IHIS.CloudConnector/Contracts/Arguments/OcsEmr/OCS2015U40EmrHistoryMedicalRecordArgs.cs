using System;
using IHIS.CloudConnector.Contracts.Models.OcsEmr;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
    public class OCS2015U40EmrHistoryMedicalRecordArgs : IContractArgs
    {
        private String _hospCode;
        private String _bunho;
        private String _pkout1001;

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

        public String Pkout1001
        {
            get { return this._pkout1001; }
            set { this._pkout1001 = value; }
        }

        public OCS2015U40EmrHistoryMedicalRecordArgs() { }

        public OCS2015U40EmrHistoryMedicalRecordArgs(String hospCode, String bunho, String pkout1001)
        {
            this._hospCode = hospCode;
            this._bunho = bunho;
            this._pkout1001 = pkout1001;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS2015U40EmrHistoryMedicalRecordRequest();
        }
    }
}
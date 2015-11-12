using System;
using IHIS.CloudConnector.Contracts.Models.OcsEmr;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
    public class OCS2015U40EmrMedicalRecordContentArgs : IContractArgs
    {
        private String _recordId;
        private String _version;

        public String RecordId
        {
            get { return this._recordId; }
            set { this._recordId = value; }
        }

        public String Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        public OCS2015U40EmrMedicalRecordContentArgs() { }

        public OCS2015U40EmrMedicalRecordContentArgs(String recordId, String version)
        {
            this._recordId = recordId;
            this._version = version;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS2015U40EmrMedicalRecordContentRequest();
        }
    }
}
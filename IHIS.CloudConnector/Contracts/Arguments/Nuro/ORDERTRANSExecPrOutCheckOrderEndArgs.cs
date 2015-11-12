using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class ORDERTRANSExecPrOutCheckOrderEndArgs : IContractArgs
    {
        private String _hospCode;
        private String _actingDate;
        private String _doctor;
        private String _bunho;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String ActingDate
        {
            get { return this._actingDate; }
            set { this._actingDate = value; }
        }

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public ORDERTRANSExecPrOutCheckOrderEndArgs() { }

        public ORDERTRANSExecPrOutCheckOrderEndArgs(String hospCode, String actingDate, String doctor, String bunho)
        {
            this._hospCode = hospCode;
            this._actingDate = actingDate;
            this._doctor = doctor;
            this._bunho = bunho;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ORDERTRANSExecPrOutCheckOrderEndRequest();
        }
    }
}
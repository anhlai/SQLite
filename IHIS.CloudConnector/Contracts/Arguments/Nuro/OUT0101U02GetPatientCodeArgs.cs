using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class OUT0101U02GetPatientCodeArgs : IContractArgs
    {
        private String _getPatientCodeYn;

        public String GetPatientCodeYn
        {
            get { return this._getPatientCodeYn; }
            set { this._getPatientCodeYn = value; }
        }

        public OUT0101U02GetPatientCodeArgs() { }

        public OUT0101U02GetPatientCodeArgs(String getPatientCodeYn)
        {
            this._getPatientCodeYn = getPatientCodeYn;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OUT0101U02GetPatientCodeRequest();
        }
    }
}
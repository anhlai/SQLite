using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0803U00GetFindWorkerArgs : IContractArgs
    {
        private String _findMode;
        private String _patStatus;

        public String FindMode
        {
            get { return this._findMode; }
            set { this._findMode = value; }
        }

        public String PatStatus
        {
            get { return this._patStatus; }
            set { this._patStatus = value; }
        }

        public OCS0803U00GetFindWorkerArgs() { }

        public OCS0803U00GetFindWorkerArgs(String findMode, String patStatus)
        {
            this._findMode = findMode;
            this._patStatus = patStatus;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0803U00GetFindWorkerRequest();
        }
    }
}
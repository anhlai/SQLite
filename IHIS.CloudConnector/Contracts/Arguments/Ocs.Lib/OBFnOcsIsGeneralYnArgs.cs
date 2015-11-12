using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
    public class OBFnOcsIsGeneralYnArgs : IContractArgs
    {
        private String _hangmogCode;

        public String HangmogCode
        {
            get { return this._hangmogCode; }
            set { this._hangmogCode = value; }
        }

        public OBFnOcsIsGeneralYnArgs() { }

        public OBFnOcsIsGeneralYnArgs(String hangmogCode)
        {
            this._hangmogCode = hangmogCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OBFnOcsIsGeneralYnRequest();
        }
    }
}
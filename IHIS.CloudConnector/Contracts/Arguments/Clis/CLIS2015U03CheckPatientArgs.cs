using System;
using IHIS.CloudConnector.Contracts.Models.Clis;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Clis
{
    public class CLIS2015U03CheckPatientArgs : IContractArgs
    {
        private String _hospCode;
        private List<CLIS2015U03CheckPatientRequestInfo> _checkItem = new List<CLIS2015U03CheckPatientRequestInfo>();

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public List<CLIS2015U03CheckPatientRequestInfo> CheckItem
        {
            get { return this._checkItem; }
            set { this._checkItem = value; }
        }

        public CLIS2015U03CheckPatientArgs() { }

        public CLIS2015U03CheckPatientArgs(String hospCode, List<CLIS2015U03CheckPatientRequestInfo> checkItem)
        {
            this._hospCode = hospCode;
            this._checkItem = checkItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CLIS2015U03CheckPatientRequest();
        }
    }
}
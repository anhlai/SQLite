using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0301U00CboDoctorGwaArgs : IContractArgs
    {
        private LoadColumnCodeNameInfo _gwaInfo;
        private LoadColumnCodeNameInfo _userInfo;
        private String _userId;
        private String _hospCode;

        public LoadColumnCodeNameInfo GwaInfo
        {
            get { return this._gwaInfo; }
            set { this._gwaInfo = value; }
        }

        public LoadColumnCodeNameInfo UserInfo
        {
            get { return this._userInfo; }
            set { this._userInfo = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0301U00CboDoctorGwaArgs() { }

        public OCS0301U00CboDoctorGwaArgs(LoadColumnCodeNameInfo gwaInfo, LoadColumnCodeNameInfo userInfo, String userId, String hospCode)
        {
            this._gwaInfo = gwaInfo;
            this._userInfo = userInfo;
            this._userId = userId;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0301U00CboDoctorGwaRequest();
        }
    }
}
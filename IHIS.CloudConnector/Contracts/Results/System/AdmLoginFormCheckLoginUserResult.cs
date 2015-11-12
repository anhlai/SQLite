using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.System
{
    public class AdmLoginFormCheckLoginUserResult : AbstractContractResult
    {
        private List<AdmLoginFormCheckLoginUserInfo> _userInfoItem = new List<AdmLoginFormCheckLoginUserInfo>();
        private String _sessionId;

        public List<AdmLoginFormCheckLoginUserInfo> UserInfoItem
        {
            get { return this._userInfoItem; }
            set { this._userInfoItem = value; }
        }

        public String SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        public AdmLoginFormCheckLoginUserResult() { }

    }
}
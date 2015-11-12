using System;

namespace IHIS.CloudConnector.Contracts.Models.System
{
    public class AdmLoginFormCheckLoginUserInfo
    {
        private String _userId;
        private String _userNm;
        private String _userGroup;
        private String _hospCode;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String UserNm
        {
            get { return this._userNm; }
            set { this._userNm = value; }
        }

        public String UserGroup
        {
            get { return this._userGroup; }
            set { this._userGroup = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public AdmLoginFormCheckLoginUserInfo() { }

        public AdmLoginFormCheckLoginUserInfo(String userId, String userNm, String userGroup, String hospCode)
        {
            this._userId = userId;
            this._userNm = userNm;
            this._userGroup = userGroup;
            this._hospCode = hospCode;
        }

    }
}
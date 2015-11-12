using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0133U00grdOCS0133ItemArgs : IContractArgs
    {
        private String _inputControl;
        private String _userInfo;

        public String InputControl
        {
            get { return this._inputControl; }
            set { this._inputControl = value; }
        }

        public String UserInfo
        {
            get { return this._userInfo; }
            set { this._userInfo = value; }
        }

        public OCS0133U00grdOCS0133ItemArgs() { }

        public OCS0133U00grdOCS0133ItemArgs(String inputControl, String userInfo)
        {
            this._inputControl = inputControl;
            this._userInfo = userInfo;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0133U00grdOCS0133ItemRequest();
        }
    }
}
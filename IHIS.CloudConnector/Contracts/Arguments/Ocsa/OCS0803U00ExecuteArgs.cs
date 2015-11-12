using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0803U00ExecuteArgs : IContractArgs
    {
        private List<OCS0803U00grdOCS0804ItemInfo> _inputOCS0804 = new List<OCS0803U00grdOCS0804ItemInfo>();
        private List<OCS0803U00grdOCS0803ItemInfo> _inputOCS0803 = new List<OCS0803U00grdOCS0803ItemInfo>();
        private String _userId;

        public List<OCS0803U00grdOCS0804ItemInfo> InputOCS0804
        {
            get { return this._inputOCS0804; }
            set { this._inputOCS0804 = value; }
        }

        public List<OCS0803U00grdOCS0803ItemInfo> InputOCS0803
        {
            get { return this._inputOCS0803; }
            set { this._inputOCS0803 = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public OCS0803U00ExecuteArgs() { }

        public OCS0803U00ExecuteArgs(List<OCS0803U00grdOCS0804ItemInfo> inputOCS0804, List<OCS0803U00grdOCS0803ItemInfo> inputOCS0803, String userId)
        {
            this._inputOCS0804 = inputOCS0804;
            this._inputOCS0803 = inputOCS0803;
            this._userId = userId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0803U00ExecuteRequest();
        }
    }
}
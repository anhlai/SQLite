using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0212U00fwkGongbiCodeArgs : IContractArgs
    {
        private String _find1;
        private String _startDate;

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public String StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        public BAS0212U00fwkGongbiCodeArgs() { }

        public BAS0212U00fwkGongbiCodeArgs(String find1, String startDate)
        {
            this._find1 = find1;
            this._startDate = startDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0212U00fwkGongbiCodeRequest();
        }
    }
}
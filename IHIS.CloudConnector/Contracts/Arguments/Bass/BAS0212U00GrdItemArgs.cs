using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0212U00GrdItemArgs : IContractArgs
    {
        private String _gongbiCode;
        private String _startDate;

        public String GongbiCode
        {
            get { return this._gongbiCode; }
            set { this._gongbiCode = value; }
        }

        public String StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        public BAS0212U00GrdItemArgs() { }

        public BAS0212U00GrdItemArgs(String gongbiCode, String startDate)
        {
            this._gongbiCode = gongbiCode;
            this._startDate = startDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0212U00GrdItemRequest();
        }
    }
}
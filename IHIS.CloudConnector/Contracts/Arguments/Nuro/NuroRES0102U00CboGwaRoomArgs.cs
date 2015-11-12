using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroRES0102U00CboGwaRoomArgs : IContractArgs
    {
        private String _gwa;
        private String _date;
        private String _hospCode;

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public NuroRES0102U00CboGwaRoomArgs() { }

        public NuroRES0102U00CboGwaRoomArgs(String gwa, String date, String hospCode)
        {
            this._gwa = gwa;
            this._date = date;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.NuroRES0102U00CboGwaRoomRequest();
        }
    }
}
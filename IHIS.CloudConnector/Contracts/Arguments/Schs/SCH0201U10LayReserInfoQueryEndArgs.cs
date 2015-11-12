using System;
using IHIS.CloudConnector.Contracts.Models.Schs;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
    public class SCH0201U10LayReserInfoQueryEndArgs : IContractArgs
    {
        private String _bunho;
        private String _reserDate;
        private String _gwa;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String ReserDate
        {
            get { return this._reserDate; }
            set { this._reserDate = value; }
        }

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public SCH0201U10LayReserInfoQueryEndArgs() { }

        public SCH0201U10LayReserInfoQueryEndArgs(String bunho, String reserDate, String gwa)
        {
            this._bunho = bunho;
            this._reserDate = reserDate;
            this._gwa = gwa;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.SCH0201U10LayReserInfoQueryEndRequest();
        }
    }
}
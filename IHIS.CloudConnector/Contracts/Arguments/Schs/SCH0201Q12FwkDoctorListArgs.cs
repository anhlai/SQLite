using System;
using IHIS.CloudConnector.Contracts.Models.Schs;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
    public class SCH0201Q12FwkDoctorListArgs : IContractArgs
    {
        private String _gwa;
        private String _find1;

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public SCH0201Q12FwkDoctorListArgs() { }

        public SCH0201Q12FwkDoctorListArgs(String gwa, String find1)
        {
            this._gwa = gwa;
            this._find1 = find1;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.SCH0201Q12FwkDoctorListRequest();
        }
    }
}
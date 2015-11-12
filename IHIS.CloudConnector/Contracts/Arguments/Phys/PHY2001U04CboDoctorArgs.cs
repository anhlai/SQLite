using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04CboDoctorArgs : IContractArgs
    {
        private String _gwa;

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public PHY2001U04CboDoctorArgs() { }

        public PHY2001U04CboDoctorArgs(String gwa)
        {
            this._gwa = gwa;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04CboDoctorRequest();
        }
    }
}
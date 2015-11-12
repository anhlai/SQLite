using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04LayDoctorNameArgs : IContractArgs
    {
        private String _doctor;
        private String _date;

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        public PHY2001U04LayDoctorNameArgs() { }

        public PHY2001U04LayDoctorNameArgs(String doctor, String date)
        {
            this._doctor = doctor;
            this._date = date;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04LayDoctorNameRequest();
        }
    }
}
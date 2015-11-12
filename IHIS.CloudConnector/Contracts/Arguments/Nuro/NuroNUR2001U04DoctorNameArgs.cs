using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroNUR2001U04DoctorNameArgs : IContractArgs
    {
        private string _doctorCode;
        private string _date;

        public string DoctorCode
        {
            get { return _doctorCode; }
            set { _doctorCode = value; }
        }

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public NuroNUR2001U04DoctorNameArgs(string doctorCode, string date)
        {
            _doctorCode = doctorCode;
            _date = date;
        }

        public NuroNUR2001U04DoctorNameArgs()
        {
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroNUR2001U04DoctorNameRequest();
        }
    }
}

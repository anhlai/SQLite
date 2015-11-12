using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroRES0102U00CboDoctorArgs : IContractArgs
    {
        private String _gwa;
        private String _appDate;
        private String _hospCode;

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String AppDate
        {
            get { return this._appDate; }
            set { this._appDate = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public NuroRES0102U00CboDoctorArgs() { }

        public NuroRES0102U00CboDoctorArgs(String gwa, String appDate, String hospCode)
        {
            this._gwa = gwa;
            this._appDate = appDate;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.NuroRES0102U00CboDoctorRequest();
        }
    }
}
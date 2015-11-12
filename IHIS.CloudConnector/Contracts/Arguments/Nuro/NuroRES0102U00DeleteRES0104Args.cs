using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroRES0102U00DeleteRES0104Args : IContractArgs
    {
        private String _startDate;
        private String _doctor;
        private String _hospCode;

        public String StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public NuroRES0102U00DeleteRES0104Args() { }

        public NuroRES0102U00DeleteRES0104Args(String startDate, String doctor, String hospCode)
        {
            this._startDate = startDate;
            this._doctor = doctor;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.NuroRES0102U00DeleteRES0104Request();
        }
    }
}
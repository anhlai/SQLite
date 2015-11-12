using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroRES0102U00InsertRES0104Args : IContractArgs
    {
        private String _userId;
        private String _doctor;
        private String _sayu;
        private String _startDate;
        private String _endDate;
        private String _hospCode;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String Sayu
        {
            get { return this._sayu; }
            set { this._sayu = value; }
        }

        public String StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        public String EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public NuroRES0102U00InsertRES0104Args() { }

        public NuroRES0102U00InsertRES0104Args(String userId, String doctor, String sayu, String startDate, String endDate, String hospCode)
        {
            this._userId = userId;
            this._doctor = doctor;
            this._sayu = sayu;
            this._startDate = startDate;
            this._endDate = endDate;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.NuroRES0102U00InsertRES0104Request();
        }
    }
}
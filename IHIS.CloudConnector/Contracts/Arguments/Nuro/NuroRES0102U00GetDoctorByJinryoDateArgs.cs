using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroRES0102U00GetDoctorByJinryoDateArgs : IContractArgs
    {
        private String _doctor;
        private String _jinryoPreDate;
        private Boolean _byResPm;
        private String _hospCode;

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String JinryoPreDate
        {
            get { return this._jinryoPreDate; }
            set { this._jinryoPreDate = value; }
        }

        public Boolean ByResPm
        {
            get { return this._byResPm; }
            set { this._byResPm = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public NuroRES0102U00GetDoctorByJinryoDateArgs() { }

        public NuroRES0102U00GetDoctorByJinryoDateArgs(String doctor, String jinryoPreDate, Boolean byResPm, String hospCode)
        {
            this._doctor = doctor;
            this._jinryoPreDate = jinryoPreDate;
            this._byResPm = byResPm;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.NuroRES0102U00GetDoctorByJinryoDateRequest();
        }
    }
}
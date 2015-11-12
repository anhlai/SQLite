using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroRES0102U00InsertRES0103Req1Args : IContractArgs
    {
        private String _userId;
        private String _doctor;
        private String _amStartHhmm;
        private String _pmStartHhmm;
        private String _remark;
        private String _jinryoPreDate;
        private String _amEndHhmm;
        private String _pmEndHhmm;
        private String _amGwaRoom;
        private String _pmGwaRoom;
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

        public String AmStartHhmm
        {
            get { return this._amStartHhmm; }
            set { this._amStartHhmm = value; }
        }

        public String PmStartHhmm
        {
            get { return this._pmStartHhmm; }
            set { this._pmStartHhmm = value; }
        }

        public String Remark
        {
            get { return this._remark; }
            set { this._remark = value; }
        }

        public String JinryoPreDate
        {
            get { return this._jinryoPreDate; }
            set { this._jinryoPreDate = value; }
        }

        public String AmEndHhmm
        {
            get { return this._amEndHhmm; }
            set { this._amEndHhmm = value; }
        }

        public String PmEndHhmm
        {
            get { return this._pmEndHhmm; }
            set { this._pmEndHhmm = value; }
        }

        public String AmGwaRoom
        {
            get { return this._amGwaRoom; }
            set { this._amGwaRoom = value; }
        }

        public String PmGwaRoom
        {
            get { return this._pmGwaRoom; }
            set { this._pmGwaRoom = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public NuroRES0102U00InsertRES0103Req1Args() { }

        public NuroRES0102U00InsertRES0103Req1Args(String userId, String doctor, String amStartHhmm, String pmStartHhmm, String remark, String jinryoPreDate, String amEndHhmm, String pmEndHhmm, String amGwaRoom, String pmGwaRoom, String hospCode)
        {
            this._userId = userId;
            this._doctor = doctor;
            this._amStartHhmm = amStartHhmm;
            this._pmStartHhmm = pmStartHhmm;
            this._remark = remark;
            this._jinryoPreDate = jinryoPreDate;
            this._amEndHhmm = amEndHhmm;
            this._pmEndHhmm = pmEndHhmm;
            this._amGwaRoom = amGwaRoom;
            this._pmGwaRoom = pmGwaRoom;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.NuroRES0102U00InsertRES0103Req1Request();
        }
    }
}
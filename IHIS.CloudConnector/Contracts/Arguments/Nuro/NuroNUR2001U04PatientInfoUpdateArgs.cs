using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroNUR2001U04PatientInfoUpdateArgs : IContractArgs
    {
        private string _updId;
        private string _comingStatus;
        private string _arriveTime;
        private string _receptionType;
        private string _pkout1001;

        public string UpdId
        {
            get { return _updId; }
            set { _updId = value; }
        }

        public string ComingStatus
        {
            get { return _comingStatus; }
            set { _comingStatus = value; }
        }

        public string ArriveTime
        {
            get { return _arriveTime; }
            set { _arriveTime = value; }
        }

        public string ReceptionType
        {
            get { return _receptionType; }
            set { _receptionType = value; }
        }

        public string Pkout1001
        {
            get { return _pkout1001; }
            set { _pkout1001 = value; }
        }

        public NuroNUR2001U04PatientInfoUpdateArgs(string updId, string comingStatus, string arriveTime, string receptionType, string pkout1001)
        {
            _updId = updId;
            _comingStatus = comingStatus;
            _arriveTime = arriveTime;
            _receptionType = receptionType;
            _pkout1001 = pkout1001;
        }

        public NuroNUR2001U04PatientInfoUpdateArgs()
        {
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroNUR2001U04PatientInfoUpdateRequest();
        }
    }
}

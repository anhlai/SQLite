using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroPatientGridViewArgs : IContractArgs
    {
        private String _patientCode;
        private String _comingDate;
        private Boolean _changeComingDate;

        public String PatientCode
        {
            get { return this._patientCode; }
            set { this._patientCode = value; }
        }

        public String ComingDate
        {
            get { return this._comingDate; }
            set { this._comingDate = value; }
        }

        public Boolean ChangeComingDate
        {
            get { return this._changeComingDate; }
            set { this._changeComingDate = value; }
        }

        public NuroPatientGridViewArgs() { }

        public NuroPatientGridViewArgs(String patientCode, String comingDate, Boolean changeComingDate)
        {
            this._patientCode = patientCode;
            this._comingDate = comingDate;
            this._changeComingDate = changeComingDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroPatientGridViewRequest();
        }
    }
}
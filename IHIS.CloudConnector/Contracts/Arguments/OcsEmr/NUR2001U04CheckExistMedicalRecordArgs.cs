using System;
using IHIS.CloudConnector.Contracts.Models.OcsEmr;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
    public class NUR2001U04CheckExistMedicalRecordArgs : IContractArgs
    {
        private String _patientCode;

        public String PatientCode
        {
            get { return this._patientCode; }
            set { this._patientCode = value; }
        }

        public NUR2001U04CheckExistMedicalRecordArgs() { }

        public NUR2001U04CheckExistMedicalRecordArgs(String patientCode)
        {
            this._patientCode = patientCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.NUR2001U04CheckExistMedicalRecordRequest();
        }
    }
}
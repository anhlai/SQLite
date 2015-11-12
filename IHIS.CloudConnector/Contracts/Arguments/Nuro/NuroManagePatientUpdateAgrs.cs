using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using NuroManagePatientUpdateData = IHIS.CloudConnector.Contracts.Models.Nuro.NuroManagePatientUpdateData;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroManagePatientUpdateAgrs : IContractArgs
    {
        private NuroManagePatientUpdateData _managePatientUpdateData;

        public NuroManagePatientUpdateAgrs()
        {

        }

        public NuroManagePatientUpdateAgrs(NuroManagePatientUpdateData managePatientUpdateData)
        {
            _managePatientUpdateData = managePatientUpdateData;
        }

        public NuroManagePatientUpdateData ManagePatientUpdateData
        {
            get { return _managePatientUpdateData; }
            set { _managePatientUpdateData = value; }
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroManagePatientUpdateRequest();
        }
    }
}

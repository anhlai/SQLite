using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0001U00GrdSaveArgs : IContractArgs
    {
        private String _qUserId;
        private String _fHospCode;
        private List<CPL0001U00GrdSlipInfo> _dt = new List<CPL0001U00GrdSlipInfo>();

        public String QUserId
        {
            get { return this._qUserId; }
            set { this._qUserId = value; }
        }

        public String FHospCode
        {
            get { return this._fHospCode; }
            set { this._fHospCode = value; }
        }

        public List<CPL0001U00GrdSlipInfo> Dt
        {
            get { return this._dt; }
            set { this._dt = value; }
        }

        public CPL0001U00GrdSaveArgs() { }

        public CPL0001U00GrdSaveArgs(String qUserId, String fHospCode, List<CPL0001U00GrdSlipInfo> dt)
        {
            this._qUserId = qUserId;
            this._fHospCode = fHospCode;
            this._dt = dt;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0001U00GrdSaveRequest();
        }
    }
}
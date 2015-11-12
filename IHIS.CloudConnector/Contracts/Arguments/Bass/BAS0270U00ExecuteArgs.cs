using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0270U00ExecuteArgs : IContractArgs
    {
        private List<BAS0270U00GrdBAS0271Info> _grdBAS0271Info = new List<BAS0270U00GrdBAS0271Info>();
        private List<BAS0270U00GrdBAS0272Info> _grdBAS0272Info = new List<BAS0270U00GrdBAS0272Info>();
        private String _userId;
        private String _hospCode;

        public List<BAS0270U00GrdBAS0271Info> GrdBAS0271Info
        {
            get { return this._grdBAS0271Info; }
            set { this._grdBAS0271Info = value; }
        }

        public List<BAS0270U00GrdBAS0272Info> GrdBAS0272Info
        {
            get { return this._grdBAS0272Info; }
            set { this._grdBAS0272Info = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public BAS0270U00ExecuteArgs() { }

        public BAS0270U00ExecuteArgs(List<BAS0270U00GrdBAS0271Info> grdBAS0271Info, List<BAS0270U00GrdBAS0272Info> grdBAS0272Info, String userId, String hospCode)
        {
            this._grdBAS0271Info = grdBAS0271Info;
            this._grdBAS0272Info = grdBAS0272Info;
            this._userId = userId;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0270U00ExecuteRequest();
        }
    }
}
using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OcsaOCS0221U00SaveLayoutArgs : IContractArgs
    {
        private List<OcsaOCS0221U00GrdOCS0221ListInfo> _ocs0221SaveItem = new List<OcsaOCS0221U00GrdOCS0221ListInfo>();
        private List<OcsaOCS0221U00GrdOCS0222ListInfo> _ocs0222SaveItem = new List<OcsaOCS0221U00GrdOCS0222ListInfo>();
        private String _userId;
        private String _hospCode;

        public List<OcsaOCS0221U00GrdOCS0221ListInfo> Ocs0221SaveItem
        {
            get { return this._ocs0221SaveItem; }
            set { this._ocs0221SaveItem = value; }
        }

        public List<OcsaOCS0221U00GrdOCS0222ListInfo> Ocs0222SaveItem
        {
            get { return this._ocs0222SaveItem; }
            set { this._ocs0222SaveItem = value; }
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

        public OcsaOCS0221U00SaveLayoutArgs() { }

        public OcsaOCS0221U00SaveLayoutArgs(List<OcsaOCS0221U00GrdOCS0221ListInfo> ocs0221SaveItem, List<OcsaOCS0221U00GrdOCS0222ListInfo> ocs0222SaveItem, String userId, String hospCode)
        {
            this._ocs0221SaveItem = ocs0221SaveItem;
            this._ocs0222SaveItem = ocs0222SaveItem;
            this._userId = userId;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OcsaOCS0221U00SaveLayoutRequest();
        }
    }
}
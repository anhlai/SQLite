using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OcsaOCS0208U00SaveLayoutArgs : IContractArgs
    {
        private List<OcsaOCS0208U00GrdOCS0208U00ListInfo> _grdSaveItem = new List<OcsaOCS0208U00GrdOCS0208U00ListInfo>();
        private String _userId;
        private String _hospCode;

        public List<OcsaOCS0208U00GrdOCS0208U00ListInfo> GrdSaveItem
        {
            get { return this._grdSaveItem; }
            set { this._grdSaveItem = value; }
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

        public OcsaOCS0208U00SaveLayoutArgs() { }

        public OcsaOCS0208U00SaveLayoutArgs(List<OcsaOCS0208U00GrdOCS0208U00ListInfo> grdSaveItem, String userId, String hospCode)
        {
            this._grdSaveItem = grdSaveItem;
            this._userId = userId;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OcsaOCS0208U00SaveLayoutRequest();
        }
    }
}
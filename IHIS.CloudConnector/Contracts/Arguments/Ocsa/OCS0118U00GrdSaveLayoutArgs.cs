using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0118U00GrdSaveLayoutArgs : IContractArgs
    {
        private List<OCS0118U00GrdSaveLayoutInfo> _grdSaveLayoutInfo = new List<OCS0118U00GrdSaveLayoutInfo>();

        public List<OCS0118U00GrdSaveLayoutInfo> GrdSaveLayoutInfo
        {
            get { return this._grdSaveLayoutInfo; }
            set { this._grdSaveLayoutInfo = value; }
        }

        public OCS0118U00GrdSaveLayoutArgs() { }

        public OCS0118U00GrdSaveLayoutArgs(List<OCS0118U00GrdSaveLayoutInfo> grdSaveLayoutInfo)
        {
            this._grdSaveLayoutInfo = grdSaveLayoutInfo;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0118U00GrdSaveLayoutRequest();
        }
    }
}
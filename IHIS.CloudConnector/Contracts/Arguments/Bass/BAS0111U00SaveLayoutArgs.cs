using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0111U00SaveLayoutArgs : IContractArgs
    {
        private String _qUserId;
        private String _fHospCode;
        private List<BAS0111U00GrdBas0111ItemInfo> _grdItem = new List<BAS0111U00GrdBas0111ItemInfo>();

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

        public List<BAS0111U00GrdBas0111ItemInfo> GrdItem
        {
            get { return this._grdItem; }
            set { this._grdItem = value; }
        }

        public BAS0111U00SaveLayoutArgs() { }

        public BAS0111U00SaveLayoutArgs(String qUserId, String fHospCode, List<BAS0111U00GrdBas0111ItemInfo> grdItem)
        {
            this._qUserId = qUserId;
            this._fHospCode = fHospCode;
            this._grdItem = grdItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0111U00SaveLayoutRequest();
        }
    }
}
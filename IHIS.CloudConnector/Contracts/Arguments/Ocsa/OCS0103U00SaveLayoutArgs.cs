using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U00SaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<OCS0103U00GrdOCS0103Info> _grdOcs0103Item = new List<OCS0103U00GrdOCS0103Info>();
        private List<OCS0103U00GrdOCS0108Info> _grdOcs0108Item = new List<OCS0103U00GrdOCS0108Info>();
        private List<OCS0103U00GrdOCS0115Info> _grdOcs0115Item = new List<OCS0103U00GrdOCS0115Info>();
        private List<OCS0103U00GrdOCS0113Info> _grdOcs0113Item = new List<OCS0103U00GrdOCS0113Info>();
        private String _hospCode;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<OCS0103U00GrdOCS0103Info> GrdOcs0103Item
        {
            get { return this._grdOcs0103Item; }
            set { this._grdOcs0103Item = value; }
        }

        public List<OCS0103U00GrdOCS0108Info> GrdOcs0108Item
        {
            get { return this._grdOcs0108Item; }
            set { this._grdOcs0108Item = value; }
        }

        public List<OCS0103U00GrdOCS0115Info> GrdOcs0115Item
        {
            get { return this._grdOcs0115Item; }
            set { this._grdOcs0115Item = value; }
        }

        public List<OCS0103U00GrdOCS0113Info> GrdOcs0113Item
        {
            get { return this._grdOcs0113Item; }
            set { this._grdOcs0113Item = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0103U00SaveLayoutArgs() { }

        public OCS0103U00SaveLayoutArgs(String userId, List<OCS0103U00GrdOCS0103Info> grdOcs0103Item, List<OCS0103U00GrdOCS0108Info> grdOcs0108Item, List<OCS0103U00GrdOCS0115Info> grdOcs0115Item, List<OCS0103U00GrdOCS0113Info> grdOcs0113Item, String hospCode)
        {
            this._userId = userId;
            this._grdOcs0103Item = grdOcs0103Item;
            this._grdOcs0108Item = grdOcs0108Item;
            this._grdOcs0115Item = grdOcs0115Item;
            this._grdOcs0113Item = grdOcs0113Item;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U00SaveLayoutRequest();
        }
    }
}
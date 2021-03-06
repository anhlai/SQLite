using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0101U00TransactionalArgs : IContractArgs
    {
        private List<OCS0101U00GrdOcs0101ListItemInfo> _listGrdOcs0101 = new List<OCS0101U00GrdOcs0101ListItemInfo>();
        private List<OCS0101U00GrdOcs0102ListItemInfo> _listGrdOcs0102 = new List<OCS0101U00GrdOcs0102ListItemInfo>();
        private String _userId;
        private String _hospCode;

        public List<OCS0101U00GrdOcs0101ListItemInfo> ListGrdOcs0101
        {
            get { return this._listGrdOcs0101; }
            set { this._listGrdOcs0101 = value; }
        }

        public List<OCS0101U00GrdOcs0102ListItemInfo> ListGrdOcs0102
        {
            get { return this._listGrdOcs0102; }
            set { this._listGrdOcs0102 = value; }
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

        public OCS0101U00TransactionalArgs() { }

        public OCS0101U00TransactionalArgs(List<OCS0101U00GrdOcs0101ListItemInfo> listGrdOcs0101, List<OCS0101U00GrdOcs0102ListItemInfo> listGrdOcs0102, String userId, String hospCode)
        {
            this._listGrdOcs0101 = listGrdOcs0101;
            this._listGrdOcs0102 = listGrdOcs0102;
            this._userId = userId;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0101U00TransactionalRequest();
        }
    }
}
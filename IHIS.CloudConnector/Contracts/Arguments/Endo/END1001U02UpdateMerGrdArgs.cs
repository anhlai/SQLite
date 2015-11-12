using System;
using IHIS.CloudConnector.Contracts.Models.Endo;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Endo
{
    public class END1001U02UpdateMerGrdArgs : IContractArgs
    {
        private List<END1001U02DsvDwInfo> _dsvdwObj = new List<END1001U02DsvDwInfo>();
        private List<END1001U02GrdPaStatusInfo> _grdpaStatusObj = new List<END1001U02GrdPaStatusInfo>();
        private String _updId;
        private String _residentYn;
        private String _hospCode;
        private String _fkOcs;
        private String _c3;
        private String _bunho;
        private String _hangmogCode;

        public List<END1001U02DsvDwInfo> DsvdwObj
        {
            get { return this._dsvdwObj; }
            set { this._dsvdwObj = value; }
        }

        public List<END1001U02GrdPaStatusInfo> GrdpaStatusObj
        {
            get { return this._grdpaStatusObj; }
            set { this._grdpaStatusObj = value; }
        }

        public String UpdId
        {
            get { return this._updId; }
            set { this._updId = value; }
        }

        public String ResidentYn
        {
            get { return this._residentYn; }
            set { this._residentYn = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String FkOcs
        {
            get { return this._fkOcs; }
            set { this._fkOcs = value; }
        }

        public String C3
        {
            get { return this._c3; }
            set { this._c3 = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String HangmogCode
        {
            get { return this._hangmogCode; }
            set { this._hangmogCode = value; }
        }

        public END1001U02UpdateMerGrdArgs() { }

        public END1001U02UpdateMerGrdArgs(List<END1001U02DsvDwInfo> dsvdwObj, List<END1001U02GrdPaStatusInfo> grdpaStatusObj, String updId, String residentYn, String hospCode, String fkOcs, String c3, String bunho, String hangmogCode)
        {
            this._dsvdwObj = dsvdwObj;
            this._grdpaStatusObj = grdpaStatusObj;
            this._updId = updId;
            this._residentYn = residentYn;
            this._hospCode = hospCode;
            this._fkOcs = fkOcs;
            this._c3 = c3;
            this._bunho = bunho;
            this._hangmogCode = hangmogCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.END1001U02UpdateMerGrdRequest();
        }
    }
}
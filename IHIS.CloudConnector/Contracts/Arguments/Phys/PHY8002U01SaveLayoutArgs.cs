using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY8002U01SaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private String _fkOcs;
        private String _ioKubun;
        private List<PHY8002U01GrdPHY8002LisItemInfo> _input8002 = new List<PHY8002U01GrdPHY8002LisItemInfo>();
        private List<PHY8002U01GrdPHY8003LisItemInfo> _input8003 = new List<PHY8002U01GrdPHY8003LisItemInfo>();
        private List<PHY8002U01GrdPHY8004LisItemInfo> _input8004 = new List<PHY8002U01GrdPHY8004LisItemInfo>();
        private String _approveDoctorGwa;
        private String _approveDoctorId;
        private String _pkScan001;
        private String _bunho;
        private String _copyPkocskey;
        private String _userGubun;
        private String _leaveCnt;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String FkOcs
        {
            get { return this._fkOcs; }
            set { this._fkOcs = value; }
        }

        public String IoKubun
        {
            get { return this._ioKubun; }
            set { this._ioKubun = value; }
        }

        public List<PHY8002U01GrdPHY8002LisItemInfo> Input8002
        {
            get { return this._input8002; }
            set { this._input8002 = value; }
        }

        public List<PHY8002U01GrdPHY8003LisItemInfo> Input8003
        {
            get { return this._input8003; }
            set { this._input8003 = value; }
        }

        public List<PHY8002U01GrdPHY8004LisItemInfo> Input8004
        {
            get { return this._input8004; }
            set { this._input8004 = value; }
        }

        public String ApproveDoctorGwa
        {
            get { return this._approveDoctorGwa; }
            set { this._approveDoctorGwa = value; }
        }

        public String ApproveDoctorId
        {
            get { return this._approveDoctorId; }
            set { this._approveDoctorId = value; }
        }

        public String PkScan001
        {
            get { return this._pkScan001; }
            set { this._pkScan001 = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String CopyPkocskey
        {
            get { return this._copyPkocskey; }
            set { this._copyPkocskey = value; }
        }

        public String UserGubun
        {
            get { return this._userGubun; }
            set { this._userGubun = value; }
        }

        public String LeaveCnt
        {
            get { return this._leaveCnt; }
            set { this._leaveCnt = value; }
        }

        public PHY8002U01SaveLayoutArgs() { }

        public PHY8002U01SaveLayoutArgs(String userId, String fkOcs, String ioKubun, List<PHY8002U01GrdPHY8002LisItemInfo> input8002, List<PHY8002U01GrdPHY8003LisItemInfo> input8003, List<PHY8002U01GrdPHY8004LisItemInfo> input8004, String approveDoctorGwa, String approveDoctorId, String pkScan001, String bunho, String copyPkocskey, String userGubun, String leaveCnt)
        {
            this._userId = userId;
            this._fkOcs = fkOcs;
            this._ioKubun = ioKubun;
            this._input8002 = input8002;
            this._input8003 = input8003;
            this._input8004 = input8004;
            this._approveDoctorGwa = approveDoctorGwa;
            this._approveDoctorId = approveDoctorId;
            this._pkScan001 = pkScan001;
            this._bunho = bunho;
            this._copyPkocskey = copyPkocskey;
            this._userGubun = userGubun;
            this._leaveCnt = leaveCnt;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY8002U01SaveLayoutRequest();
        }
    }
}
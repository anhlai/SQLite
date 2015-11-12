using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using PHY8002U00GrdPHY8002Info = IHIS.CloudConnector.Contracts.Models.Phys.PHY8002U00GrdPHY8002Info;
using PHY8002U00GrdPHY8003Info = IHIS.CloudConnector.Contracts.Models.Phys.PHY8002U00GrdPHY8003Info;
using PHY8002U00GrdPHY8004Info = IHIS.CloudConnector.Contracts.Models.Phys.PHY8002U00GrdPHY8004Info;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
	public class PHY8002U00SaveLayoutArgs : IContractArgs
	{
		private String _userId;
		private String _fkOcs;
		private String _ioKubun;
		private List<PHY8002U00GrdPHY8002Info> _phy8002Info = new List<PHY8002U00GrdPHY8002Info>();
		private List<PHY8002U00GrdPHY8003Info> _phy8003Info = new List<PHY8002U00GrdPHY8003Info>();
		private List<PHY8002U00GrdPHY8004Info> _phy8004Info = new List<PHY8002U00GrdPHY8004Info>();
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

		public List<PHY8002U00GrdPHY8002Info> Phy8002Info
		{
			get { return this._phy8002Info; }
			set { this._phy8002Info = value; }
		}

		public List<PHY8002U00GrdPHY8003Info> Phy8003Info
		{
			get { return this._phy8003Info; }
			set { this._phy8003Info = value; }
		}

		public List<PHY8002U00GrdPHY8004Info> Phy8004Info
		{
			get { return this._phy8004Info; }
			set { this._phy8004Info = value; }
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

		public PHY8002U00SaveLayoutArgs() { }

		public PHY8002U00SaveLayoutArgs(String userId, String fkOcs, String ioKubun, List<PHY8002U00GrdPHY8002Info> phy8002Info, List<PHY8002U00GrdPHY8003Info> phy8003Info, List<PHY8002U00GrdPHY8004Info> phy8004Info, String approveDoctorGwa, String approveDoctorId, String pkScan001, String bunho, String copyPkocskey, String userGubun, String leaveCnt)
		{
			this._userId = userId;
			this._fkOcs = fkOcs;
			this._ioKubun = ioKubun;
			this._phy8002Info = phy8002Info;
			this._phy8003Info = phy8003Info;
			this._phy8004Info = phy8004Info;
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
			return new PHY8002U00SaveLayoutRequest();
		}
	}
}
using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class OcsoGetNotApproveOrderCntInfo
	{
		private String _ioGubun;
		private String _userId;
		private String _insteadYn;
		private String _approveYn;
		private String _key;

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String InsteadYn
		{
			get { return this._insteadYn; }
			set { this._insteadYn = value; }
		}

		public String ApproveYn
		{
			get { return this._approveYn; }
			set { this._approveYn = value; }
		}

		public String Key
		{
			get { return this._key; }
			set { this._key = value; }
		}

		public OcsoGetNotApproveOrderCntInfo() { }

		public OcsoGetNotApproveOrderCntInfo(String ioGubun, String userId, String insteadYn, String approveYn, String key)
		{
			this._ioGubun = ioGubun;
			this._userId = userId;
			this._insteadYn = insteadYn;
			this._approveYn = approveYn;
			this._key = key;
		}

	}
}
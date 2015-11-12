using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class PrOcsInterfaceInsertInfo
	{
		private String _ioGubun;
		private String _pkKey;
		private String _userId;

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String PkKey
		{
			get { return this._pkKey; }
			set { this._pkKey = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public PrOcsInterfaceInsertInfo() { }

		public PrOcsInterfaceInsertInfo(String ioGubun, String pkKey, String userId)
		{
			this._ioGubun = ioGubun;
			this._pkKey = pkKey;
			this._userId = userId;
		}

	}
}
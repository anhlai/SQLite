using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
	public class CHT0115Q00GrdScPreArgs : IContractArgs
	{
		private String _susikDetailGubun;
		private String _susikName;
		private String _ioGubun;
		private String _userId;

		public String SusikDetailGubun
		{
			get { return this._susikDetailGubun; }
			set { this._susikDetailGubun = value; }
		}

		public String SusikName
		{
			get { return this._susikName; }
			set { this._susikName = value; }
		}

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

		public CHT0115Q00GrdScPreArgs() { }

		public CHT0115Q00GrdScPreArgs(String susikDetailGubun, String susikName, String ioGubun, String userId)
		{
			this._susikDetailGubun = susikDetailGubun;
			this._susikName = susikName;
			this._ioGubun = ioGubun;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new CHT0115Q00GrdScPreRequest();
		}
	}
}
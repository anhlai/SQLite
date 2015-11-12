using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
	public class CHT0115Q00GrdScPostArgs : IContractArgs
	{
		private String _susikDetailGubun;
		private String _susikName;

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

		public CHT0115Q00GrdScPostArgs() { }

		public CHT0115Q00GrdScPostArgs(String susikDetailGubun, String susikName)
		{
			this._susikDetailGubun = susikDetailGubun;
			this._susikName = susikName;
		}

		public IExtensible GetRequestInstance()
		{
			return new CHT0115Q00GrdScPostRequest();
		}
	}
}
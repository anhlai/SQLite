using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class Ocs0103Q00GrdHangMogArgs : IContractArgs
	{
		private String _queryCode;
		private String _orderGubun;
		private String _childYn;
		private String _inputTab;

		public String QueryCode
		{
			get { return this._queryCode; }
			set { this._queryCode = value; }
		}

		public String OrderGubun
		{
			get { return this._orderGubun; }
			set { this._orderGubun = value; }
		}

		public String ChildYn
		{
			get { return this._childYn; }
			set { this._childYn = value; }
		}

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public Ocs0103Q00GrdHangMogArgs() { }

		public Ocs0103Q00GrdHangMogArgs(String queryCode, String orderGubun, String childYn, String inputTab)
		{
			this._queryCode = queryCode;
			this._orderGubun = orderGubun;
			this._childYn = childYn;
			this._inputTab = inputTab;
		}

		public IExtensible GetRequestInstance()
		{
			return new Ocs0103Q00GrdHangMogRequest();
		}
	}
}
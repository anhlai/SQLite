using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U13GrdOrderListArgs : IContractArgs
	{
		private String _memb;
		private String _yaksokCode;
		private String _fkInOutKey;
		private String _orderMode;
		private String _inputTab;
		private String _inputGubun;

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public String YaksokCode
		{
			get { return this._yaksokCode; }
			set { this._yaksokCode = value; }
		}

		public String FkInOutKey
		{
			get { return this._fkInOutKey; }
			set { this._fkInOutKey = value; }
		}

		public String OrderMode
		{
			get { return this._orderMode; }
			set { this._orderMode = value; }
		}

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public String InputGubun
		{
			get { return this._inputGubun; }
			set { this._inputGubun = value; }
		}

		public OCS0103U13GrdOrderListArgs() { }

		public OCS0103U13GrdOrderListArgs(String memb, String yaksokCode, String fkInOutKey, String orderMode, String inputTab, String inputGubun)
		{
			this._memb = memb;
			this._yaksokCode = yaksokCode;
			this._fkInOutKey = fkInOutKey;
			this._orderMode = orderMode;
			this._inputTab = inputTab;
			this._inputGubun = inputGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U13GrdOrderListRequest();
		}
	}
}
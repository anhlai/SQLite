using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U16LayGroupTabArgs : IContractArgs
	{
		private String _orderMode;
		private String _memb;
		private String _yaksokCode;
		private String _inputTab;
		private String _fkInOutKey;
		private String _orderDate;
		private String _inputGubun;

		public String OrderMode
		{
			get { return this._orderMode; }
			set { this._orderMode = value; }
		}

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

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public String FkInOutKey
		{
			get { return this._fkInOutKey; }
			set { this._fkInOutKey = value; }
		}

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public String InputGubun
		{
			get { return this._inputGubun; }
			set { this._inputGubun = value; }
		}

		public OCS0103U16LayGroupTabArgs() { }

		public OCS0103U16LayGroupTabArgs(String orderMode, String memb, String yaksokCode, String inputTab, String fkInOutKey, String orderDate, String inputGubun)
		{
			this._orderMode = orderMode;
			this._memb = memb;
			this._yaksokCode = yaksokCode;
			this._inputTab = inputTab;
			this._fkInOutKey = fkInOutKey;
			this._orderDate = orderDate;
			this._inputGubun = inputGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U16LayGroupTabRequest();
		}
	}
}
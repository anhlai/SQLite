using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U18GrdOrderArgs : IContractArgs
	{
		private String _memb;
		private String _yaksokCode;
		private String _fkInOutKey;
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

		public OCS0103U18GrdOrderArgs() { }

		public OCS0103U18GrdOrderArgs(String memb, String yaksokCode, String fkInOutKey, String inputTab, String inputGubun)
		{
			this._memb = memb;
			this._yaksokCode = yaksokCode;
			this._fkInOutKey = fkInOutKey;
			this._inputTab = inputTab;
			this._inputGubun = inputGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U18GrdOrderRequest();
		}
	}
}
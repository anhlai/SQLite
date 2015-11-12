using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0301Q09GrdOCS0301Args : IContractArgs
	{
		private String _memb;
		private String _yaksokCode;
		private String _inputTab;

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

		public OCS0301Q09GrdOCS0301Args() { }

		public OCS0301Q09GrdOCS0301Args(String memb, String yaksokCode, String inputTab)
		{
			this._memb = memb;
			this._yaksokCode = yaksokCode;
			this._inputTab = inputTab;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0301Q09GrdOCS0301Request();
		}
	}
}
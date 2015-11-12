using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class InsteadModifiedCheckArgs : IContractArgs
	{
		private String _pkkey;
		private String _inputGubun;
		private String _ioGubun;

		public String Pkkey
		{
			get { return this._pkkey; }
			set { this._pkkey = value; }
		}

		public String InputGubun
		{
			get { return this._inputGubun; }
			set { this._inputGubun = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public InsteadModifiedCheckArgs() { }

		public InsteadModifiedCheckArgs(String pkkey, String inputGubun, String ioGubun)
		{
			this._pkkey = pkkey;
			this._inputGubun = inputGubun;
			this._ioGubun = ioGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new InsteadModifiedCheckRequest();
		}
	}
}
using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuts
{
	public class NUT0001U00GetNaewonKeyArgs : IContractArgs
	{
		private String _pkocs;
		private String _ioKubun;

		public String Pkocs
		{
			get { return this._pkocs; }
			set { this._pkocs = value; }
		}

		public String IoKubun
		{
			get { return this._ioKubun; }
			set { this._ioKubun = value; }
		}

		public NUT0001U00GetNaewonKeyArgs() { }

		public NUT0001U00GetNaewonKeyArgs(String pkocs, String ioKubun)
		{
			this._pkocs = pkocs;
			this._ioKubun = ioKubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new NUT0001U00GetNaewonKeyRequest();
		}
	}
}
using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003P01UpdateJubsuArgs : IContractArgs
	{
		private String _naewonYn;
		private String _pkNaewonKey;

		public String NaewonYn
		{
			get { return this._naewonYn; }
			set { this._naewonYn = value; }
		}

		public String PkNaewonKey
		{
			get { return this._pkNaewonKey; }
			set { this._pkNaewonKey = value; }
		}

		public OcsoOCS1003P01UpdateJubsuArgs() { }

		public OcsoOCS1003P01UpdateJubsuArgs(String naewonYn, String pkNaewonKey)
		{
			this._naewonYn = naewonYn;
			this._pkNaewonKey = pkNaewonKey;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003P01UpdateJubsuRequest();
		}
	}
}
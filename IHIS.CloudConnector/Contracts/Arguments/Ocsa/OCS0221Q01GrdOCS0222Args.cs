using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0221Q01GrdOCS0222Args : IContractArgs
	{
		private String _memb;
		private String _seq;

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public String Seq
		{
			get { return this._seq; }
			set { this._seq = value; }
		}

		public OCS0221Q01GrdOCS0222Args() { }

		public OCS0221Q01GrdOCS0222Args(String memb, String seq)
		{
			this._memb = memb;
			this._seq = seq;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0221Q01GrdOCS0222Request();
		}
	}
}
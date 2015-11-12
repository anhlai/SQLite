using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0230U00GrdBas0230Args : IContractArgs
	{
		private String _startYmd;

		public String StartYmd
		{
			get { return this._startYmd; }
			set { this._startYmd = value; }
		}

		public BAS0230U00GrdBas0230Args() { }

		public BAS0230U00GrdBas0230Args(String startYmd)
		{
			this._startYmd = startYmd;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0230U00GrdBas0230Request();
		}
	}
}
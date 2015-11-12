using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OUTSANGU00createGwaDataArgs : IContractArgs
	{
		private String _outJubsuYn;

		public String OutJubsuYn
		{
			get { return this._outJubsuYn; }
			set { this._outJubsuYn = value; }
		}

		public OUTSANGU00createGwaDataArgs() { }

		public OUTSANGU00createGwaDataArgs(String outJubsuYn)
		{
			this._outJubsuYn = outJubsuYn;
		}

		public IExtensible GetRequestInstance()
		{
			return new OUTSANGU00createGwaDataRequest();
		}
	}
}
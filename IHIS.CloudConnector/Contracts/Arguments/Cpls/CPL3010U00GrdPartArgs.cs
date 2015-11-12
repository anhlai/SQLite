using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3010U00GrdPartArgs : IContractArgs
	{
		private String _partJubsuDate;

		public String PartJubsuDate
		{
			get { return this._partJubsuDate; }
			set { this._partJubsuDate = value; }
		}

		public CPL3010U00GrdPartArgs() { }

		public CPL3010U00GrdPartArgs(String partJubsuDate)
		{
			this._partJubsuDate = partJubsuDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3010U00GrdPartRequest();
		}
	}
}
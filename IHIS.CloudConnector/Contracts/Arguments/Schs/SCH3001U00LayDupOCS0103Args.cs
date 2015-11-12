using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SCH3001U00LayDupOCS0103Args : IContractArgs
	{
		private String _jundalPart;

		public String JundalPart
		{
			get { return this._jundalPart; }
			set { this._jundalPart = value; }
		}

		public SCH3001U00LayDupOCS0103Args() { }

		public SCH3001U00LayDupOCS0103Args(String jundalPart)
		{
			this._jundalPart = jundalPart;
		}

		public IExtensible GetRequestInstance()
		{
			return new SCH3001U00LayDupOCS0103Request();
		}
	}
}
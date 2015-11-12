using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class InjsINJ1001U01InfectionListArgs : IContractArgs
	{
		private String _bunho;
		private String _queryDate;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String QueryDate
		{
			get { return this._queryDate; }
			set { this._queryDate = value; }
		}

		public InjsINJ1001U01InfectionListArgs() { }

		public InjsINJ1001U01InfectionListArgs(String bunho, String queryDate)
		{
			this._bunho = bunho;
			this._queryDate = queryDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new InjsINJ1001U01InfectionListRequest();
		}
	}
}
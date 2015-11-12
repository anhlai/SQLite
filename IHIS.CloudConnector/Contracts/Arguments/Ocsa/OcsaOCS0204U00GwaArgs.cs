using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using LoadColumnCodeNameInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.LoadColumnCodeNameInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OcsaOCS0204U00GwaArgs : IContractArgs
	{
		private LoadColumnCodeNameInfo _requestValue;
		private String _sabun;

		public LoadColumnCodeNameInfo RequestValue
		{
			get { return this._requestValue; }
			set { this._requestValue = value; }
		}

		public String Sabun
		{
			get { return this._sabun; }
			set { this._sabun = value; }
		}

		public OcsaOCS0204U00GwaArgs() { }

		public OcsaOCS0204U00GwaArgs(LoadColumnCodeNameInfo requestValue, String sabun)
		{
			this._requestValue = requestValue;
			this._sabun = sabun;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsaOCS0204U00GwaRequest();
		}
	}
}
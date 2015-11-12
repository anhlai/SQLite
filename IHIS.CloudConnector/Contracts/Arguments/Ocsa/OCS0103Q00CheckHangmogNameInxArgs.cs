using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103Q00CheckHangmogNameInxArgs : IContractArgs
	{
		private String _hangmogNameInx;

		public String HangmogNameInx
		{
			get { return this._hangmogNameInx; }
			set { this._hangmogNameInx = value; }
		}

		public OCS0103Q00CheckHangmogNameInxArgs() { }

		public OCS0103Q00CheckHangmogNameInxArgs(String hangmogNameInx)
		{
			this._hangmogNameInx = hangmogNameInx;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103Q00CheckHangmogNameInxRequest();
		}
	}
}
using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U06EmrRecordArgs : IContractArgs
	{
		private String _bunho;
		private String _hospCode;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String HospCode
		{
			get { return this._hospCode; }
			set { this._hospCode = value; }
		}

		public OCS2015U06EmrRecordArgs() { }

		public OCS2015U06EmrRecordArgs(String bunho, String hospCode)
		{
			this._bunho = bunho;
			this._hospCode = hospCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U06EmrRecordRequest();
		}
	}
}
using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U30EmrTagGetTagArgs : IContractArgs
	{
		private String _tagLevel;
		private String _sysId;

		public String TagLevel
		{
			get { return this._tagLevel; }
			set { this._tagLevel = value; }
		}

		public String SysId
		{
			get { return this._sysId; }
			set { this._sysId = value; }
		}

		public OCS2015U30EmrTagGetTagArgs() { }

		public OCS2015U30EmrTagGetTagArgs(String tagLevel, String sysId)
		{
			this._tagLevel = tagLevel;
			this._sysId = sysId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U30EmrTagGetTagRequest();
		}
	}
}
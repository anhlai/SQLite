using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class InjsINJ1001U01SettingPrintArgs : IContractArgs
	{
		private String _userId;
		private String _bPrintName;
		private String _ipAddr;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String BPrintName
		{
			get { return this._bPrintName; }
			set { this._bPrintName = value; }
		}

		public String IpAddr
		{
			get { return this._ipAddr; }
			set { this._ipAddr = value; }
		}

		public InjsINJ1001U01SettingPrintArgs() { }

		public InjsINJ1001U01SettingPrintArgs(String userId, String bPrintName, String ipAddr)
		{
			this._userId = userId;
			this._bPrintName = bPrintName;
			this._ipAddr = ipAddr;
		}

		public IExtensible GetRequestInstance()
		{
			return new InjsINJ1001U01SettingPrintRequest();
		}
	}
}
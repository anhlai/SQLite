using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DrgsDRG5100P01SetPrintArgs : IContractArgs
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

		public DrgsDRG5100P01SetPrintArgs() { }

		public DrgsDRG5100P01SetPrintArgs(String userId, String bPrintName, String ipAddr)
		{
			this._userId = userId;
			this._bPrintName = bPrintName;
			this._ipAddr = ipAddr;
		}

		public IExtensible GetRequestInstance()
		{
			return new DrgsDRG5100P01SetPrintRequest();
		}
	}
}
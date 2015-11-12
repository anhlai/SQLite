using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0210U00DupCheckArgs : IContractArgs
	{
		private String _gubun;
		private String _startDate;

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public String StartDate
		{
			get { return this._startDate; }
			set { this._startDate = value; }
		}

		public BAS0210U00DupCheckArgs() { }

		public BAS0210U00DupCheckArgs(String gubun, String startDate)
		{
			this._gubun = gubun;
			this._startDate = startDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0210U00DupCheckRequest();
		}
	}
}
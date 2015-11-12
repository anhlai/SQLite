using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OUTSANGU00findBoxToGwaArgs : IContractArgs
	{
		private String _startDate;
		private String _find1;

		public String StartDate
		{
			get { return this._startDate; }
			set { this._startDate = value; }
		}

		public String Find1
		{
			get { return this._find1; }
			set { this._find1 = value; }
		}

		public OUTSANGU00findBoxToGwaArgs() { }

		public OUTSANGU00findBoxToGwaArgs(String startDate, String find1)
		{
			this._startDate = startDate;
			this._find1 = find1;
		}

		public IExtensible GetRequestInstance()
		{
			return new OUTSANGU00findBoxToGwaRequest();
		}
	}
}
using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OUTSANGU00GetDoctorNameArgs : IContractArgs
	{
		private String _gwa;
		private String _find1;
		private String _startDate;

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String Find1
		{
			get { return this._find1; }
			set { this._find1 = value; }
		}

		public String StartDate
		{
			get { return this._startDate; }
			set { this._startDate = value; }
		}

		public OUTSANGU00GetDoctorNameArgs() { }

		public OUTSANGU00GetDoctorNameArgs(String gwa, String find1, String startDate)
		{
			this._gwa = gwa;
			this._find1 = find1;
			this._startDate = startDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new OUTSANGU00GetDoctorNameRequest();
		}
	}
}
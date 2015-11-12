using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0503Q00LoadConsultInfoArgs : IContractArgs
	{
		private String _gwa;
		private String _doctor;
		private String _fromDate;
		private String _toDate;

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String FromDate
		{
			get { return this._fromDate; }
			set { this._fromDate = value; }
		}

		public String ToDate
		{
			get { return this._toDate; }
			set { this._toDate = value; }
		}

		public OCS0503Q00LoadConsultInfoArgs() { }

		public OCS0503Q00LoadConsultInfoArgs(String gwa, String doctor, String fromDate, String toDate)
		{
			this._gwa = gwa;
			this._doctor = doctor;
			this._fromDate = fromDate;
			this._toDate = toDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0503Q00LoadConsultInfoRequest();
		}
	}
}
using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OUTSANGU00findBoxToDoctorArgs : IContractArgs
	{
		private String _gwa;
		private String _find1;
		private String _doctorYmd;

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

		public String DoctorYmd
		{
			get { return this._doctorYmd; }
			set { this._doctorYmd = value; }
		}

		public OUTSANGU00findBoxToDoctorArgs() { }

		public OUTSANGU00findBoxToDoctorArgs(String gwa, String find1, String doctorYmd)
		{
			this._gwa = gwa;
			this._find1 = find1;
			this._doctorYmd = doctorYmd;
		}

		public IExtensible GetRequestInstance()
		{
			return new OUTSANGU00findBoxToDoctorRequest();
		}
	}
}
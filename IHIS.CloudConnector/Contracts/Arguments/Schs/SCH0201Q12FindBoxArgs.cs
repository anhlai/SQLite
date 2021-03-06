using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SCH0201Q12FindBoxArgs : IContractArgs
	{
		private String _gwa;
		private String _doctor;

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

		public SCH0201Q12FindBoxArgs() { }

		public SCH0201Q12FindBoxArgs(String gwa, String doctor)
		{
			this._gwa = gwa;
			this._doctor = doctor;
		}

		public IExtensible GetRequestInstance()
		{
			return new SCH0201Q12FindBoxRequest();
		}
	}
}
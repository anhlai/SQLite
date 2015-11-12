using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OcsaOCS0304U00GetYaksokDirectNameArgs : IContractArgs
	{
		private String _membGubun;
		private String _code;
		private String _doctor;

		public String MembGubun
		{
			get { return this._membGubun; }
			set { this._membGubun = value; }
		}

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public OcsaOCS0304U00GetYaksokDirectNameArgs() { }

		public OcsaOCS0304U00GetYaksokDirectNameArgs(String membGubun, String code, String doctor)
		{
			this._membGubun = membGubun;
			this._code = code;
			this._doctor = doctor;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsaOCS0304U00GetYaksokDirectNameRequest();
		}
	}
}
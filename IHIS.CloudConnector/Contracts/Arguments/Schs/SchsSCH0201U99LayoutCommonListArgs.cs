using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201U99LayoutCommonListArgs : IContractArgs
	{
		private String _doctor;
		private String _fGwa;

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String FGwa
		{
			get { return this._fGwa; }
			set { this._fGwa = value; }
		}

		public SchsSCH0201U99LayoutCommonListArgs() { }

		public SchsSCH0201U99LayoutCommonListArgs(String doctor, String fGwa)
		{
			this._doctor = doctor;
			this._fGwa = fGwa;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201U99LayoutCommonListRequest();
		}
	}
}
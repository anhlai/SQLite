using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuts
{
	public class NUT0001U00LoadDoctorGwaArgs : IContractArgs
	{
		private String _inOutGubun;
		private String _pkocskey;

		public String InOutGubun
		{
			get { return this._inOutGubun; }
			set { this._inOutGubun = value; }
		}

		public String Pkocskey
		{
			get { return this._pkocskey; }
			set { this._pkocskey = value; }
		}

		public NUT0001U00LoadDoctorGwaArgs() { }

		public NUT0001U00LoadDoctorGwaArgs(String inOutGubun, String pkocskey)
		{
			this._inOutGubun = inOutGubun;
			this._pkocskey = pkocskey;
		}

		public IExtensible GetRequestInstance()
		{
			return new NUT0001U00LoadDoctorGwaRequest();
		}
	}
}
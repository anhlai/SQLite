using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuts
{
	public class NUT0001U00InitializeScreenArgs : IContractArgs
	{
		private String _doctorGwaName;
		private String _gwaCode;
		private String _pkocskey;
		private String _inOutGubun;
		private String _hangmogCode;

		public String DoctorGwaName
		{
			get { return this._doctorGwaName; }
			set { this._doctorGwaName = value; }
		}

		public String GwaCode
		{
			get { return this._gwaCode; }
			set { this._gwaCode = value; }
		}

		public String Pkocskey
		{
			get { return this._pkocskey; }
			set { this._pkocskey = value; }
		}

		public String InOutGubun
		{
			get { return this._inOutGubun; }
			set { this._inOutGubun = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public NUT0001U00InitializeScreenArgs() { }

		public NUT0001U00InitializeScreenArgs(String doctorGwaName, String gwaCode, String pkocskey, String inOutGubun, String hangmogCode)
		{
			this._doctorGwaName = doctorGwaName;
			this._gwaCode = gwaCode;
			this._pkocskey = pkocskey;
			this._inOutGubun = inOutGubun;
			this._hangmogCode = hangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new NUT0001U00InitializeScreenRequest();
		}
	}
}
using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class InjsINJ1001U01TempListArgs : IContractArgs
	{
		private String _jubsuDate;
		private String _bunho;
		private String _doctor;
		private String _reserDate;

		public String JubsuDate
		{
			get { return this._jubsuDate; }
			set { this._jubsuDate = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String ReserDate
		{
			get { return this._reserDate; }
			set { this._reserDate = value; }
		}

		public InjsINJ1001U01TempListArgs() { }

		public InjsINJ1001U01TempListArgs(String jubsuDate, String bunho, String doctor, String reserDate)
		{
			this._jubsuDate = jubsuDate;
			this._bunho = bunho;
			this._doctor = doctor;
			this._reserDate = reserDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new InjsINJ1001U01TempListRequest();
		}
	}
}
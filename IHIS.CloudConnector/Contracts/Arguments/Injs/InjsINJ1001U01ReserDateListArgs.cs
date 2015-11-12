using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class InjsINJ1001U01ReserDateListArgs : IContractArgs
	{
		private String _bunho;
		private String _doctor;
		private String _actingFlag;
		private String _reserDate;

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

		public String ActingFlag
		{
			get { return this._actingFlag; }
			set { this._actingFlag = value; }
		}

		public String ReserDate
		{
			get { return this._reserDate; }
			set { this._reserDate = value; }
		}

		public InjsINJ1001U01ReserDateListArgs() { }

		public InjsINJ1001U01ReserDateListArgs(String bunho, String doctor, String actingFlag, String reserDate)
		{
			this._bunho = bunho;
			this._doctor = doctor;
			this._actingFlag = actingFlag;
			this._reserDate = reserDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new InjsINJ1001U01ReserDateListRequest();
		}
	}
}
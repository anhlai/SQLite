using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class InjsINJ1001U01ChkbStateArgs : IContractArgs
	{
		private String _reserDate;
		private String _actingFlag;
		private String _bunho;
		private String _doctor;

		public String ReserDate
		{
			get { return this._reserDate; }
			set { this._reserDate = value; }
		}

		public String ActingFlag
		{
			get { return this._actingFlag; }
			set { this._actingFlag = value; }
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

		public InjsINJ1001U01ChkbStateArgs() { }

		public InjsINJ1001U01ChkbStateArgs(String reserDate, String actingFlag, String bunho, String doctor)
		{
			this._reserDate = reserDate;
			this._actingFlag = actingFlag;
			this._bunho = bunho;
			this._doctor = doctor;
		}

		public IExtensible GetRequestInstance()
		{
			return new InjsINJ1001U01ChkbStateRequest();
		}
	}
}
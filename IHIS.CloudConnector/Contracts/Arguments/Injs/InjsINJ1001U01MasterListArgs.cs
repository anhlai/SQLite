using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class InjsINJ1001U01MasterListArgs : IContractArgs
	{
		private String _actingFlag;
		private String _reserDate;
		private String _gwa;

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

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public InjsINJ1001U01MasterListArgs() { }

		public InjsINJ1001U01MasterListArgs(String actingFlag, String reserDate, String gwa)
		{
			this._actingFlag = actingFlag;
			this._reserDate = reserDate;
			this._gwa = gwa;
		}

		public IExtensible GetRequestInstance()
		{
			return new InjsINJ1001U01MasterListRequest();
		}
	}
}
using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class InjsINJ1001U01UpdateArgs : IContractArgs
	{
		private String _actingFlag;
		private String _actingDate;
		private String _tonggyeCode;
		private String _mixGroup;
		private String _jujongja;
		private String _updId;
		private String _silsiRemark;
		private String _pkinj1002;

		public String ActingFlag
		{
			get { return this._actingFlag; }
			set { this._actingFlag = value; }
		}

		public String ActingDate
		{
			get { return this._actingDate; }
			set { this._actingDate = value; }
		}

		public String TonggyeCode
		{
			get { return this._tonggyeCode; }
			set { this._tonggyeCode = value; }
		}

		public String MixGroup
		{
			get { return this._mixGroup; }
			set { this._mixGroup = value; }
		}

		public String Jujongja
		{
			get { return this._jujongja; }
			set { this._jujongja = value; }
		}

		public String UpdId
		{
			get { return this._updId; }
			set { this._updId = value; }
		}

		public String SilsiRemark
		{
			get { return this._silsiRemark; }
			set { this._silsiRemark = value; }
		}

		public String Pkinj1002
		{
			get { return this._pkinj1002; }
			set { this._pkinj1002 = value; }
		}

		public InjsINJ1001U01UpdateArgs() { }

		public InjsINJ1001U01UpdateArgs(String actingFlag, String actingDate, String tonggyeCode, String mixGroup, String jujongja, String updId, String silsiRemark, String pkinj1002)
		{
			this._actingFlag = actingFlag;
			this._actingDate = actingDate;
			this._tonggyeCode = tonggyeCode;
			this._mixGroup = mixGroup;
			this._jujongja = jujongja;
			this._updId = updId;
			this._silsiRemark = silsiRemark;
			this._pkinj1002 = pkinj1002;
		}

		public IExtensible GetRequestInstance()
		{
			return new InjsINJ1001U01UpdateRequest();
		}
	}
}
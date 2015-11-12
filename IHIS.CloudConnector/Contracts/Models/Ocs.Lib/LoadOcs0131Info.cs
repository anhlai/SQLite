using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class LoadOcs0131Info
	{
		private String _codeType;
		private String _codeTypeName;
		private String _choiceUser;
		private String _ment;
		private String _sysDate;
		private String _updId;
		private String _updDate;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public String CodeTypeName
		{
			get { return this._codeTypeName; }
			set { this._codeTypeName = value; }
		}

		public String ChoiceUser
		{
			get { return this._choiceUser; }
			set { this._choiceUser = value; }
		}

		public String Ment
		{
			get { return this._ment; }
			set { this._ment = value; }
		}

		public String SysDate
		{
			get { return this._sysDate; }
			set { this._sysDate = value; }
		}

		public String UpdId
		{
			get { return this._updId; }
			set { this._updId = value; }
		}

		public String UpdDate
		{
			get { return this._updDate; }
			set { this._updDate = value; }
		}

		public LoadOcs0131Info() { }

		public LoadOcs0131Info(String codeType, String codeTypeName, String choiceUser, String ment, String sysDate, String updId, String updDate)
		{
			this._codeType = codeType;
			this._codeTypeName = codeTypeName;
			this._choiceUser = choiceUser;
			this._ment = ment;
			this._sysDate = sysDate;
			this._updId = updId;
			this._updDate = updDate;
		}

	}
}
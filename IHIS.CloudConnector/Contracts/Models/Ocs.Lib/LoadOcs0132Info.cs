using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class LoadOcs0132Info
	{
		private String _codeType;
		private String _code;
		private String _codeName;
		private String _valuePoint;
		private String _sortKey;
		private String _groupKey;
		private String _ment;
		private String _sysDate;
		private String _updId;
		private String _updDate;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public String CodeName
		{
			get { return this._codeName; }
			set { this._codeName = value; }
		}

		public String ValuePoint
		{
			get { return this._valuePoint; }
			set { this._valuePoint = value; }
		}

		public String SortKey
		{
			get { return this._sortKey; }
			set { this._sortKey = value; }
		}

		public String GroupKey
		{
			get { return this._groupKey; }
			set { this._groupKey = value; }
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

		public LoadOcs0132Info() { }

		public LoadOcs0132Info(String codeType, String code, String codeName, String valuePoint, String sortKey, String groupKey, String ment, String sysDate, String updId, String updDate)
		{
			this._codeType = codeType;
			this._code = code;
			this._codeName = codeName;
			this._valuePoint = valuePoint;
			this._sortKey = sortKey;
			this._groupKey = groupKey;
			this._ment = ment;
			this._sysDate = sysDate;
			this._updId = updId;
			this._updDate = updDate;
		}

	}
}
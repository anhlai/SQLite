using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class HIOcsSpecificCommentInfo
	{
		private String _specificCommentName;
		private String _specificCommentSysId;
		private String _specificCommentPgmId;
		private String _specificCommentNotNull;
		private String _specificCommentTableId;
		private String _specificCommentColId;

		public String SpecificCommentName
		{
			get { return this._specificCommentName; }
			set { this._specificCommentName = value; }
		}

		public String SpecificCommentSysId
		{
			get { return this._specificCommentSysId; }
			set { this._specificCommentSysId = value; }
		}

		public String SpecificCommentPgmId
		{
			get { return this._specificCommentPgmId; }
			set { this._specificCommentPgmId = value; }
		}

		public String SpecificCommentNotNull
		{
			get { return this._specificCommentNotNull; }
			set { this._specificCommentNotNull = value; }
		}

		public String SpecificCommentTableId
		{
			get { return this._specificCommentTableId; }
			set { this._specificCommentTableId = value; }
		}

		public String SpecificCommentColId
		{
			get { return this._specificCommentColId; }
			set { this._specificCommentColId = value; }
		}

		public HIOcsSpecificCommentInfo() { }

		public HIOcsSpecificCommentInfo(String specificCommentName, String specificCommentSysId, String specificCommentPgmId, String specificCommentNotNull, String specificCommentTableId, String specificCommentColId)
		{
			this._specificCommentName = specificCommentName;
			this._specificCommentSysId = specificCommentSysId;
			this._specificCommentPgmId = specificCommentPgmId;
			this._specificCommentNotNull = specificCommentNotNull;
			this._specificCommentTableId = specificCommentTableId;
			this._specificCommentColId = specificCommentColId;
		}

	}
}
using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class LoadOftenUsedResponseInfo
	{
		private String _memb;
		private String _slipCode;
		private String _slipName;
		private String _hangmogCode;
		private String _hangmogName;
		private String _seq;
		private String _hospCode;
		private String _membGubun;
		private String _wonnaeDrgYn;
		private String _orderByKey;

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public String SlipCode
		{
			get { return this._slipCode; }
			set { this._slipCode = value; }
		}

		public String SlipName
		{
			get { return this._slipName; }
			set { this._slipName = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String HangmogName
		{
			get { return this._hangmogName; }
			set { this._hangmogName = value; }
		}

		public String Seq
		{
			get { return this._seq; }
			set { this._seq = value; }
		}

		public String HospCode
		{
			get { return this._hospCode; }
			set { this._hospCode = value; }
		}

		public String MembGubun
		{
			get { return this._membGubun; }
			set { this._membGubun = value; }
		}

		public String WonnaeDrgYn
		{
			get { return this._wonnaeDrgYn; }
			set { this._wonnaeDrgYn = value; }
		}

		public String OrderByKey
		{
			get { return this._orderByKey; }
			set { this._orderByKey = value; }
		}

		public LoadOftenUsedResponseInfo() { }

		public LoadOftenUsedResponseInfo(String memb, String slipCode, String slipName, String hangmogCode, String hangmogName, String seq, String hospCode, String membGubun, String wonnaeDrgYn, String orderByKey)
		{
			this._memb = memb;
			this._slipCode = slipCode;
			this._slipName = slipName;
			this._hangmogCode = hangmogCode;
			this._hangmogName = hangmogName;
			this._seq = seq;
			this._hospCode = hospCode;
			this._membGubun = membGubun;
			this._wonnaeDrgYn = wonnaeDrgYn;
			this._orderByKey = orderByKey;
		}

	}
}
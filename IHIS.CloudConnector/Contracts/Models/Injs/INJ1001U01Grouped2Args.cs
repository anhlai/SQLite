using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ1001U01Grouped2Args : IContractArgs
	{
		private String _bunho;
		private String _queryDate;
		private String _orderDate;
		private String _postOrderYn;
		private String _preOrderYn;
		private String _reserDate;
		private String _actingFlag;
		private String _gwa;
		private String _doctor;
		private String _actingDate;
		private String _commtGubun;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String QueryDate
		{
			get { return this._queryDate; }
			set { this._queryDate = value; }
		}

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public String PostOrderYn
		{
			get { return this._postOrderYn; }
			set { this._postOrderYn = value; }
		}

		public String PreOrderYn
		{
			get { return this._preOrderYn; }
			set { this._preOrderYn = value; }
		}

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

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String ActingDate
		{
			get { return this._actingDate; }
			set { this._actingDate = value; }
		}

		public String CommtGubun
		{
			get { return this._commtGubun; }
			set { this._commtGubun = value; }
		}

		public INJ1001U01Grouped2Args() { }

		public INJ1001U01Grouped2Args(String bunho, String queryDate, String orderDate, String postOrderYn, String preOrderYn, String reserDate, String actingFlag, String gwa, String doctor, String actingDate, String commtGubun)
		{
			this._bunho = bunho;
			this._queryDate = queryDate;
			this._orderDate = orderDate;
			this._postOrderYn = postOrderYn;
			this._preOrderYn = preOrderYn;
			this._reserDate = reserDate;
			this._actingFlag = actingFlag;
			this._gwa = gwa;
			this._doctor = doctor;
			this._actingDate = actingDate;
			this._commtGubun = commtGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new INJ1001U01Grouped2Request();
		}
	}
}
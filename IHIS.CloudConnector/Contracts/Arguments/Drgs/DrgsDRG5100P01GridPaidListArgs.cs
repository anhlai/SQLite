using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DrgsDRG5100P01GridPaidListArgs : IContractArgs
	{
		private String _fromDate;
		private String _toDate;
		private String _gwa;
		private String _wonyoiYn;
		private String _gubun;
		private String _bunho;
		private Boolean _xrbOrderValue;

		public String FromDate
		{
			get { return this._fromDate; }
			set { this._fromDate = value; }
		}

		public String ToDate
		{
			get { return this._toDate; }
			set { this._toDate = value; }
		}

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String WonyoiYn
		{
			get { return this._wonyoiYn; }
			set { this._wonyoiYn = value; }
		}

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public Boolean XrbOrderValue
		{
			get { return this._xrbOrderValue; }
			set { this._xrbOrderValue = value; }
		}

		public DrgsDRG5100P01GridPaidListArgs() { }

		public DrgsDRG5100P01GridPaidListArgs(String fromDate, String toDate, String gwa, String wonyoiYn, String gubun, String bunho, Boolean xrbOrderValue)
		{
			this._fromDate = fromDate;
			this._toDate = toDate;
			this._gwa = gwa;
			this._wonyoiYn = wonyoiYn;
			this._gubun = gubun;
			this._bunho = bunho;
			this._xrbOrderValue = xrbOrderValue;
		}

		public IExtensible GetRequestInstance()
		{
			return new DrgsDRG5100P01GridPaidListRequest();
		}
	}
}
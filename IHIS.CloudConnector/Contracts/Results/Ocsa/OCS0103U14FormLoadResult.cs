using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocsa
{
	public class OCS0103U14FormLoadResult : AbstractContractResult
	{
		private String _userOptResult;
		private String _codeName;
		private String _mainDoctorCode;
		private List<LoadOftenUsedTabResponseInfo> _loadOfterUsedTabResponseInfo = new List<LoadOftenUsedTabResponseInfo>();

		public String UserOptResult
		{
			get { return this._userOptResult; }
			set { this._userOptResult = value; }
		}

		public String CodeName
		{
			get { return this._codeName; }
			set { this._codeName = value; }
		}

		public String MainDoctorCode
		{
			get { return this._mainDoctorCode; }
			set { this._mainDoctorCode = value; }
		}

		public List<LoadOftenUsedTabResponseInfo> LoadOfterUsedTabResponseInfo
		{
			get { return this._loadOfterUsedTabResponseInfo; }
			set { this._loadOfterUsedTabResponseInfo = value; }
		}

		public OCS0103U14FormLoadResult() { }

	}
}
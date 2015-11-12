using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using GetMainGwaDoctorCodeInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.GetMainGwaDoctorCodeInfo;
using LoadColumnCodeNameInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.LoadColumnCodeNameInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U18InitializeScreenArgs : IContractArgs
	{
		private String _mOrderMode;
		private LoadColumnCodeNameInfo _colCodeName;
		private GetMainGwaDoctorCodeInfo _gwaDoctorCode;
		private String _userId;
		private String _inputTab;

		public String MOrderMode
		{
			get { return this._mOrderMode; }
			set { this._mOrderMode = value; }
		}

		public LoadColumnCodeNameInfo ColCodeName
		{
			get { return this._colCodeName; }
			set { this._colCodeName = value; }
		}

		public GetMainGwaDoctorCodeInfo GwaDoctorCode
		{
			get { return this._gwaDoctorCode; }
			set { this._gwaDoctorCode = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public OCS0103U18InitializeScreenArgs() { }

		public OCS0103U18InitializeScreenArgs(String mOrderMode, LoadColumnCodeNameInfo colCodeName, GetMainGwaDoctorCodeInfo gwaDoctorCode, String userId, String inputTab)
		{
			this._mOrderMode = mOrderMode;
			this._colCodeName = colCodeName;
			this._gwaDoctorCode = gwaDoctorCode;
			this._userId = userId;
			this._inputTab = inputTab;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U18InitializeScreenRequest();
		}
	}
}
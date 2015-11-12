using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using GetMainGwaDoctorCodeInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.GetMainGwaDoctorCodeInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class GetMainGwaDoctorCodeArgs : IContractArgs
	{
		private GetMainGwaDoctorCodeInfo _inputInfo;

		public GetMainGwaDoctorCodeInfo InputInfo
		{
			get { return this._inputInfo; }
			set { this._inputInfo = value; }
		}

		public GetMainGwaDoctorCodeArgs() { }

		public GetMainGwaDoctorCodeArgs(GetMainGwaDoctorCodeInfo inputInfo)
		{
			this._inputInfo = inputInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new GetMainGwaDoctorCodeRequest();
		}
	}
}
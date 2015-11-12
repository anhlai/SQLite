using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using CheckPatientStatusRequestInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.CheckPatientStatusRequestInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class CheckPatientStatusArgs : IContractArgs
	{
		private CheckPatientStatusRequestInfo _inputInfo;

		public CheckPatientStatusRequestInfo InputInfo
		{
			get { return this._inputInfo; }
			set { this._inputInfo = value; }
		}

		public CheckPatientStatusArgs() { }

		public CheckPatientStatusArgs(CheckPatientStatusRequestInfo inputInfo)
		{
			this._inputInfo = inputInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new CheckPatientStatusRequest();
		}
	}
}
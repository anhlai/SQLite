using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using LoadConsultEndYNInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.LoadConsultEndYNInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class LoadConsultEndYNArgs : IContractArgs
	{
		private LoadConsultEndYNInfo _loadConsultEndYNInfo;

		public LoadConsultEndYNInfo LoadConsultEndYNInfo
		{
			get { return this._loadConsultEndYNInfo; }
			set { this._loadConsultEndYNInfo = value; }
		}

		public LoadConsultEndYNArgs() { }

		public LoadConsultEndYNArgs(LoadConsultEndYNInfo loadConsultEndYNInfo)
		{
			this._loadConsultEndYNInfo = loadConsultEndYNInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new LoadConsultEndYNRequest();
		}
	}
}
using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using LoadOftenUsedTabInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.LoadOftenUsedTabInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U12MakeSangyongTabArgs : IContractArgs
	{
		private LoadOftenUsedTabInfo _requestInfo;

		public LoadOftenUsedTabInfo RequestInfo
		{
			get { return this._requestInfo; }
			set { this._requestInfo = value; }
		}

		public OCS0103U12MakeSangyongTabArgs() { }

		public OCS0103U12MakeSangyongTabArgs(LoadOftenUsedTabInfo requestInfo)
		{
			this._requestInfo = requestInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U12MakeSangyongTabRequest();
		}
	}
}
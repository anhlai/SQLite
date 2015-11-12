using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using LoadOftenUsedInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.LoadOftenUsedInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class LoadOftenUsedArgs : IContractArgs
	{
		private LoadOftenUsedInfo _inputInfo;

		public LoadOftenUsedInfo InputInfo
		{
			get { return this._inputInfo; }
			set { this._inputInfo = value; }
		}

		public LoadOftenUsedArgs() { }

		public LoadOftenUsedArgs(LoadOftenUsedInfo inputInfo)
		{
			this._inputInfo = inputInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new LoadOftenUsedRequest();
		}
	}
}
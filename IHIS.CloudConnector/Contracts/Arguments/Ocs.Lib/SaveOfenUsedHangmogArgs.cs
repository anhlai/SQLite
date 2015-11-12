using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using SaveOfenUsedHangmogInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.SaveOfenUsedHangmogInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class SaveOfenUsedHangmogArgs : IContractArgs
	{
		private SaveOfenUsedHangmogInfo _info1;

		public SaveOfenUsedHangmogInfo Info1
		{
			get { return this._info1; }
			set { this._info1 = value; }
		}

		public SaveOfenUsedHangmogArgs() { }

		public SaveOfenUsedHangmogArgs(SaveOfenUsedHangmogInfo info1)
		{
			this._info1 = info1;
		}

		public IExtensible GetRequestInstance()
		{
			return new SaveOfenUsedHangmogRequest();
		}
	}
}
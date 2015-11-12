using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using DeleteOftenUsedHangmogInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.DeleteOftenUsedHangmogInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class DeleteOftenUsedHangmogArgs : IContractArgs
	{
		private DeleteOftenUsedHangmogInfo _info1;

		public DeleteOftenUsedHangmogInfo Info1
		{
			get { return this._info1; }
			set { this._info1 = value; }
		}

		public DeleteOftenUsedHangmogArgs() { }

		public DeleteOftenUsedHangmogArgs(DeleteOftenUsedHangmogInfo info1)
		{
			this._info1 = info1;
		}

		public IExtensible GetRequestInstance()
		{
			return new DeleteOftenUsedHangmogRequest();
		}
	}
}
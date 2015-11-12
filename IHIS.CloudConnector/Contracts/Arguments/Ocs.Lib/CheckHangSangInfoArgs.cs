using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using CheckHangSangInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.CheckHangSangInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class CheckHangSangInfoArgs : IContractArgs
	{
		private CheckHangSangInfo _hangSangInfo;

		public CheckHangSangInfo HangSangInfo
		{
			get { return this._hangSangInfo; }
			set { this._hangSangInfo = value; }
		}

		public CheckHangSangInfoArgs() { }

		public CheckHangSangInfoArgs(CheckHangSangInfo hangSangInfo)
		{
			this._hangSangInfo = hangSangInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new CheckHangSangInfoRequest();
		}
	}
}
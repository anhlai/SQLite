using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OutTaGwaJinryoCntInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.OutTaGwaJinryoCntInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class GetOutTaGwaJinryoCntArgs : IContractArgs
	{
		private OutTaGwaJinryoCntInfo _cntInfo;

		public OutTaGwaJinryoCntInfo CntInfo
		{
			get { return this._cntInfo; }
			set { this._cntInfo = value; }
		}

		public GetOutTaGwaJinryoCntArgs() { }

		public GetOutTaGwaJinryoCntArgs(OutTaGwaJinryoCntInfo cntInfo)
		{
			this._cntInfo = cntInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new GetOutTaGwaJinryoCntRequest();
		}
	}
}
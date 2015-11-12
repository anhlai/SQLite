using System;
using ProtoBuf;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class FnCplLoadDupGrdHangmogArgs : IContractArgs
	{
		private List<FnCplLoadDupGrdHangmogInfo> _fnCplInfo = new List<FnCplLoadDupGrdHangmogInfo>();

		public List<FnCplLoadDupGrdHangmogInfo> FnCplInfo
		{
			get { return this._fnCplInfo; }
			set { this._fnCplInfo = value; }
		}

		public FnCplLoadDupGrdHangmogArgs() { }

		public FnCplLoadDupGrdHangmogArgs(List<FnCplLoadDupGrdHangmogInfo> fnCplInfo)
		{
			this._fnCplInfo = fnCplInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new IHIS.CloudConnector.Messaging.FnCplLoadDupGrdHangmogRequest();
		}
	}
}
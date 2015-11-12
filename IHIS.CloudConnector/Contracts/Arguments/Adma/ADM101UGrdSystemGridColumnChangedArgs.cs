using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM101UGrdSystemGridColumnChangedArgs : IContractArgs
	{
		private String _buseoCode;

		public String BuseoCode
		{
			get { return this._buseoCode; }
			set { this._buseoCode = value; }
		}

		public ADM101UGrdSystemGridColumnChangedArgs() { }

		public ADM101UGrdSystemGridColumnChangedArgs(String buseoCode)
		{
			this._buseoCode = buseoCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADM101UGrdSystemGridColumnChangedRequest();
		}
	}
}
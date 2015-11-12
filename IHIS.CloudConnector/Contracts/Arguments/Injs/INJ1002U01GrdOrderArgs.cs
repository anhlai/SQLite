using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ1002U01GrdOrderArgs : IContractArgs
	{
		private String _bunho;
		private String _reserDate;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String ReserDate
		{
			get { return this._reserDate; }
			set { this._reserDate = value; }
		}

		public INJ1002U01GrdOrderArgs() { }

		public INJ1002U01GrdOrderArgs(String bunho, String reserDate)
		{
			this._bunho = bunho;
			this._reserDate = reserDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new INJ1002U01GrdOrderRequest();
		}
	}
}
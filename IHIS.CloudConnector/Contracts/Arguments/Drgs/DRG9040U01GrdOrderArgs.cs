using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG9040U01GrdOrderArgs : IContractArgs
	{
		private String _fromDate;
		private String _toDate;
		private String _bunho;

		public String FromDate
		{
			get { return this._fromDate; }
			set { this._fromDate = value; }
		}

		public String ToDate
		{
			get { return this._toDate; }
			set { this._toDate = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public DRG9040U01GrdOrderArgs() { }

		public DRG9040U01GrdOrderArgs(String fromDate, String toDate, String bunho)
		{
			this._fromDate = fromDate;
			this._toDate = toDate;
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG9040U01GrdOrderRequest();
		}
	}
}
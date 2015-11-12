using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ1002R01LayQuery1Args : IContractArgs
	{
		private String _fromDate;
		private String _toDate;

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

		public INJ1002R01LayQuery1Args() { }

		public INJ1002R01LayQuery1Args(String fromDate, String toDate)
		{
			this._fromDate = fromDate;
			this._toDate = toDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new INJ1002R01LayQuery1Request();
		}
	}
}
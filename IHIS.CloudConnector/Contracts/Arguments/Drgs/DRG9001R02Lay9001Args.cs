using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG9001R02Lay9001Args : IContractArgs
	{
		private String _date;

		public String Date
		{
			get { return this._date; }
			set { this._date = value; }
		}

		public DRG9001R02Lay9001Args() { }

		public DRG9001R02Lay9001Args(String date)
		{
			this._date = date;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG9001R02Lay9001Request();
		}
	}
}
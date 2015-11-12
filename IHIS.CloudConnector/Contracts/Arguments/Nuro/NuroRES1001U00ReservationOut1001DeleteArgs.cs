using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00ReservationOut1001DeleteArgs : IContractArgs
	{
		private String _pkout1001;

		public String Pkout1001
		{
			get { return this._pkout1001; }
			set { this._pkout1001 = value; }
		}

		public NuroRES1001U00ReservationOut1001DeleteArgs() { }

		public NuroRES1001U00ReservationOut1001DeleteArgs(String pkout1001)
		{
			this._pkout1001 = pkout1001;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00ReservationOut1001DeleteRequest();
		}
	}
}
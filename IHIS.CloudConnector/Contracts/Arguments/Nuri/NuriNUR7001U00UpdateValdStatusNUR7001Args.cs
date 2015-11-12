using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NuriNUR7001U00UpdateValdStatusNUR7001Args : IContractArgs
	{
		private String _userId;
		private String _bunho;
		private String _measureDate;
		private String _seq;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String MeasureDate
		{
			get { return this._measureDate; }
			set { this._measureDate = value; }
		}

		public String Seq
		{
			get { return this._seq; }
			set { this._seq = value; }
		}

		public NuriNUR7001U00UpdateValdStatusNUR7001Args() { }

		public NuriNUR7001U00UpdateValdStatusNUR7001Args(String userId, String bunho, String measureDate, String seq)
		{
			this._userId = userId;
			this._bunho = bunho;
			this._measureDate = measureDate;
			this._seq = seq;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuriNUR7001U00UpdateValdStatusNUR7001Request();
		}
	}
}
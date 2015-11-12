using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NuriNUR7001U00GetMaxSeqInNUR7001Args : IContractArgs
	{
		private String _bunho;
		private String _measureDate;

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

		public NuriNUR7001U00GetMaxSeqInNUR7001Args() { }

		public NuriNUR7001U00GetMaxSeqInNUR7001Args(String bunho, String measureDate)
		{
			this._bunho = bunho;
			this._measureDate = measureDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuriNUR7001U00GetMaxSeqInNUR7001Request();
		}
	}
}
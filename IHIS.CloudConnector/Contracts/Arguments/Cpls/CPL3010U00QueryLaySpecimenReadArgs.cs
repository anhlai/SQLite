using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3010U00QueryLaySpecimenReadArgs : IContractArgs
	{
		private String _specimenReadValue;
		private String _partJubsuja;
		private String _gumJubsuDate;

		public String SpecimenReadValue
		{
			get { return this._specimenReadValue; }
			set { this._specimenReadValue = value; }
		}

		public String PartJubsuja
		{
			get { return this._partJubsuja; }
			set { this._partJubsuja = value; }
		}

		public String GumJubsuDate
		{
			get { return this._gumJubsuDate; }
			set { this._gumJubsuDate = value; }
		}

		public CPL3010U00QueryLaySpecimenReadArgs() { }

		public CPL3010U00QueryLaySpecimenReadArgs(String specimenReadValue, String partJubsuja, String gumJubsuDate)
		{
			this._specimenReadValue = specimenReadValue;
			this._partJubsuja = partJubsuja;
			this._gumJubsuDate = gumJubsuDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3010U00QueryLaySpecimenReadRequest();
		}
	}
}
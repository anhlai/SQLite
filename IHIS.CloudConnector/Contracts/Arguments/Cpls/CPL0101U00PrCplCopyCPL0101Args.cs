using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0101U00PrCplCopyCPL0101Args : IContractArgs
	{
		private String _hangmogCode;
		private String _specimenCode;
		private String _emergency;
		private String _newSpecimenCode;
		private String _newEmergency;

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String SpecimenCode
		{
			get { return this._specimenCode; }
			set { this._specimenCode = value; }
		}

		public String Emergency
		{
			get { return this._emergency; }
			set { this._emergency = value; }
		}

		public String NewSpecimenCode
		{
			get { return this._newSpecimenCode; }
			set { this._newSpecimenCode = value; }
		}

		public String NewEmergency
		{
			get { return this._newEmergency; }
			set { this._newEmergency = value; }
		}

		public CPL0101U00PrCplCopyCPL0101Args() { }

		public CPL0101U00PrCplCopyCPL0101Args(String hangmogCode, String specimenCode, String emergency, String newSpecimenCode, String newEmergency)
		{
			this._hangmogCode = hangmogCode;
			this._specimenCode = specimenCode;
			this._emergency = emergency;
			this._newSpecimenCode = newSpecimenCode;
			this._newEmergency = newEmergency;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0101U00PrCplCopyCPL0101Request();
		}
	}
}
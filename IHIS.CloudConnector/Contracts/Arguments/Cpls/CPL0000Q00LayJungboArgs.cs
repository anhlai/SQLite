using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0000Q00LayJungboArgs : IContractArgs
	{
		private String _specimenSer;
		private String _hangmogCode;
		private String _specimenCode;
		private String _emergency;

		public String SpecimenSer
		{
			get { return this._specimenSer; }
			set { this._specimenSer = value; }
		}

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

		public CPL0000Q00LayJungboArgs() { }

		public CPL0000Q00LayJungboArgs(String specimenSer, String hangmogCode, String specimenCode, String emergency)
		{
			this._specimenSer = specimenSer;
			this._hangmogCode = hangmogCode;
			this._specimenCode = specimenCode;
			this._emergency = emergency;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0000Q00LayJungboRequest();
		}
	}
}
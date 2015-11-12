using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0000Q00ResultListQuerySelect1Args : IContractArgs
	{
		private String _specimenSer;
		private String _srlCode;
		private String _jundalGubun;

		public String SpecimenSer
		{
			get { return this._specimenSer; }
			set { this._specimenSer = value; }
		}

		public String SrlCode
		{
			get { return this._srlCode; }
			set { this._srlCode = value; }
		}

		public String JundalGubun
		{
			get { return this._jundalGubun; }
			set { this._jundalGubun = value; }
		}

		public CPL0000Q00ResultListQuerySelect1Args() { }

		public CPL0000Q00ResultListQuerySelect1Args(String specimenSer, String srlCode, String jundalGubun)
		{
			this._specimenSer = specimenSer;
			this._srlCode = srlCode;
			this._jundalGubun = jundalGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0000Q00ResultListQuerySelect1Request();
		}
	}
}
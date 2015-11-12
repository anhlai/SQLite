using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3020U00GrdPaRowFocusChangedArgs : IContractArgs
	{
		private String _specimentSer;
		private String _specimenSer;
		private String _jundalGubun;

		public String SpecimentSer
		{
			get { return this._specimentSer; }
			set { this._specimentSer = value; }
		}

		public String SpecimenSer
		{
			get { return this._specimenSer; }
			set { this._specimenSer = value; }
		}

		public String JundalGubun
		{
			get { return this._jundalGubun; }
			set { this._jundalGubun = value; }
		}

		public CPL3020U00GrdPaRowFocusChangedArgs() { }

		public CPL3020U00GrdPaRowFocusChangedArgs(String specimentSer, String specimenSer, String jundalGubun)
		{
			this._specimentSer = specimentSer;
			this._specimenSer = specimenSer;
			this._jundalGubun = jundalGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3020U00GrdPaRowFocusChangedRequest();
		}
	}
}
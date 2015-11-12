using System;
using ProtoBuf;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class OFUpdateDataArgs : IContractArgs
	{
		private String _existData;
		private String _pkSeq;
		private String _membGubun;
		private String _memb;
		private String _userId;
		private String _yaksokGubun;
		private String _yaksokGubunName;
		private String _inputTab;
		private String _yaksokName;
		private String _selectYn;
		private String _pkocs0303;
		private List<OFUpdateOCS0303UpdateDataInfo> _updateDataItem = new List<OFUpdateOCS0303UpdateDataInfo>();

		public String ExistData
		{
			get { return this._existData; }
			set { this._existData = value; }
		}

		public String PkSeq
		{
			get { return this._pkSeq; }
			set { this._pkSeq = value; }
		}

		public String MembGubun
		{
			get { return this._membGubun; }
			set { this._membGubun = value; }
		}

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String YaksokGubun
		{
			get { return this._yaksokGubun; }
			set { this._yaksokGubun = value; }
		}

		public String YaksokGubunName
		{
			get { return this._yaksokGubunName; }
			set { this._yaksokGubunName = value; }
		}

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public String YaksokName
		{
			get { return this._yaksokName; }
			set { this._yaksokName = value; }
		}

		public String SelectYn
		{
			get { return this._selectYn; }
			set { this._selectYn = value; }
		}

		public String Pkocs0303
		{
			get { return this._pkocs0303; }
			set { this._pkocs0303 = value; }
		}

		public List<OFUpdateOCS0303UpdateDataInfo> UpdateDataItem
		{
			get { return this._updateDataItem; }
			set { this._updateDataItem = value; }
		}

		public OFUpdateDataArgs() { }

		public OFUpdateDataArgs(String existData, String pkSeq, String membGubun, String memb, String userId, String yaksokGubun, String yaksokGubunName, String inputTab, String yaksokName, String selectYn, String pkocs0303, List<OFUpdateOCS0303UpdateDataInfo> updateDataItem)
		{
			this._existData = existData;
			this._pkSeq = pkSeq;
			this._membGubun = membGubun;
			this._memb = memb;
			this._userId = userId;
			this._yaksokGubun = yaksokGubun;
			this._yaksokGubunName = yaksokGubunName;
			this._inputTab = inputTab;
			this._yaksokName = yaksokName;
			this._selectYn = selectYn;
			this._pkocs0303 = pkocs0303;
			this._updateDataItem = updateDataItem;
		}

		public IExtensible GetRequestInstance()
		{
			return new IHIS.CloudConnector.Messaging.OFUpdateDataRequest();
		}
	}
}
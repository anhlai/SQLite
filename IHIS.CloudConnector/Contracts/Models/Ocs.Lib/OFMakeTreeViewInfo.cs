using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class OFMakeTreeViewInfo
	{
		private String _memb;
		private String _pkSeq;
		private String _yaksokGubun;
		private String _yaksokGubunName;
		private String _seq;
		private String _membGubun;
		private String _inputTab;
		private String _existData;

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public String PkSeq
		{
			get { return this._pkSeq; }
			set { this._pkSeq = value; }
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

		public String Seq
		{
			get { return this._seq; }
			set { this._seq = value; }
		}

		public String MembGubun
		{
			get { return this._membGubun; }
			set { this._membGubun = value; }
		}

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public String ExistData
		{
			get { return this._existData; }
			set { this._existData = value; }
		}

		public OFMakeTreeViewInfo() { }

		public OFMakeTreeViewInfo(String memb, String pkSeq, String yaksokGubun, String yaksokGubunName, String seq, String membGubun, String inputTab, String existData)
		{
			this._memb = memb;
			this._pkSeq = pkSeq;
			this._yaksokGubun = yaksokGubun;
			this._yaksokGubunName = yaksokGubunName;
			this._seq = seq;
			this._membGubun = membGubun;
			this._inputTab = inputTab;
			this._existData = existData;
		}

	}
}
using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class InjsINJ1001U01CommentListArgs : IContractArgs
	{
		private String _bunho;
		private String _commtGubun;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String CommtGubun
		{
			get { return this._commtGubun; }
			set { this._commtGubun = value; }
		}

		public InjsINJ1001U01CommentListArgs() { }

		public InjsINJ1001U01CommentListArgs(String bunho, String commtGubun)
		{
			this._bunho = bunho;
			this._commtGubun = commtGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new InjsINJ1001U01CommentListRequest();
		}
	}
}
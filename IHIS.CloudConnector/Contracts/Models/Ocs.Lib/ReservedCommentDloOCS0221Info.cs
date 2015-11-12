using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
    public class ReservedCommentDloOCS0221Info
    {
        private String _memb;
        private String _seq;
        private String _categoryGubun;
        private String _categoryName;
        private String _commentLimit;

        public String Memb
        {
            get { return this._memb; }
            set { this._memb = value; }
        }

        public String Seq
        {
            get { return this._seq; }
            set { this._seq = value; }
        }

        public String CategoryGubun
        {
            get { return this._categoryGubun; }
            set { this._categoryGubun = value; }
        }

        public String CategoryName
        {
            get { return this._categoryName; }
            set { this._categoryName = value; }
        }

        public String CommentLimit
        {
            get { return this._commentLimit; }
            set { this._commentLimit = value; }
        }

        public ReservedCommentDloOCS0221Info() { }

        public ReservedCommentDloOCS0221Info(String memb, String seq, String categoryGubun, String categoryName, String commentLimit)
        {
            this._memb = memb;
            this._seq = seq;
            this._categoryGubun = categoryGubun;
            this._categoryName = categoryName;
            this._commentLimit = commentLimit;
        }

    }
}
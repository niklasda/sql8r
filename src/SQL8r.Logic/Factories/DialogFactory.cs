﻿using System.Windows.Forms;

namespace SQL8r.Logic.Factories
{
    public class DialogFactory
    {
        private static DialogFactory _instance;

        //
        // Constructors
        //

        private DialogFactory()
        {
        }

        public static DialogFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DialogFactory();
                }
                return _instance;
            }
        }

        private int getExtensionId(string fileName)
        {
            if (fileName.EndsWith(" *", System.StringComparison.OrdinalIgnoreCase))
            {
                fileName = fileName.Substring(0, fileName.Length - 2);
            }
            int idx = fileName.LastIndexOf('.');
            int len = fileName.Length;
            string ext = fileName.Substring(idx, len - idx);
            int extId;
            if (ext.ToUpperInvariant().Equals(".CS"))
            {
                extId = 1;
            }
            else if (ext.ToUpperInvariant().Equals(".VB"))
            {
                extId = 2;
            }
            else 
            {
                extId = 3;
            }
            return extId;
        }

        public SaveFileDialog GetSaveFileDialog(string oldFileName)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "C# Files|*.cs|VB.NET Files|*.vb|SQL Files|*.sql|All Files|*.*";
            sfd.FilterIndex = getExtensionId(oldFileName);
            return sfd;
        }

        //public SaveFileDialog GetSaveCSharpCodeDialog()
        //{
        //    var sfd = new SaveFileDialog();
        //    sfd.Filter = "C# Files|*.cs|VB.NET Files|*.vb|All Files|*.*";

        //    return sfd;
        //}

        //public SaveFileDialog GetSaveVbNetCodeDialog()
        //{
        //    var sfd = new SaveFileDialog();
        //    sfd.Filter = "VB.NET Files|*.vb|C# Files|*.cs|All Files|*.*";

        //    return sfd;
        //}

        public SaveFileDialog GetSaveFormatDialog(string format)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = string.Format("{0}|All Files|*.*", format);

            return sfd;
        }

        public SaveFileDialog GetSaveProjectDialog()
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Project Files|*.sqlproj|All Files|*.*";

            return sfd;
        }

        public SaveFileDialog GetCreateProjectDialog()
        {
            var sfd = new SaveFileDialog();
            sfd.OverwritePrompt = true;
            sfd.Filter = "Project Files|*.sqlproj|All Files|*.*";

            return sfd;
        }

        public SaveFileDialog GetCreateSQLiteDialog()
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Filebased Db Files|*.sqlite;*.fdb;*.mdb;*.xls|All Files|*.*";

            return sfd;
        }

        public OpenFileDialog GetOpenSQLiteDialog()
        {
            var ofd = new OpenFileDialog();
			ofd.Filter = "Filebased Db Files|*.sqlite;*.fdb;*.mdb;*.xls|All Files|*.*";

            return ofd;
        }

        public OpenFileDialog GetOpenProjectDialog()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Project Files|*.sqlproj|All Files|*.*";

            return ofd;
        }

        public OpenFileDialog GetImportProjectDialog()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "C# Project Files|*.csproj|VB.NET Project Files|*.vbproj|All Files|*.*";

            return ofd;
        }

        public SaveFileDialog GetCreateFileDialog()
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "SQL Files|*.sql|C# Files|*.cs|VB.NET Files|*.vb|All Files|*.*";

            return sfd;
        }

        public SaveFileDialog GetCompileToFileDialog()
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "DLL Files|*.dll|All Files|*.*";

            return sfd;
        }

        public OpenFileDialog GetOpenStyleDialog()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Style Libraries|*.isl|All Files|*.*";

            return ofd;            
        }

        
    }
}
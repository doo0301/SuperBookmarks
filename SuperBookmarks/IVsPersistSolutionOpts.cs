﻿using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Internal.VisualStudio.Shell;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell.Interop;

namespace Konamiman.SuperBookmarks
{
    public partial class SuperBookmarksPackage
    {
        private const string persistenceKey = "Konamiman.SuperBookmarks";

        public int SaveUserOptions(IVsSolutionPersistence pPersistence)
        {
            return pPersistence.SavePackageUserOpts(this, persistenceKey);
        }

        public int LoadUserOptions(IVsSolutionPersistence pPersistence, uint grfLoadOpts)
        {
            return pPersistence.LoadPackageUserOpts(this, persistenceKey);
        }

        public int WriteUserOptions(IStream pOptionsStream, string pszKey)
        {
            if(pszKey != persistenceKey)
                throw new InvalidOperationException("SuperBookmarks: WriteUserOptions was called for unknown key " + pszKey);

            var info = this.BookmarksManager.GetPersistableInfo();
            var stream = new DataStreamFromComStream(pOptionsStream);
            info.SerializeTo(stream);

            return VSConstants.S_OK;
        }

        public int ReadUserOptions(IStream pOptionsStream, string pszKey)
        {
            if (pszKey != persistenceKey)
                throw new InvalidOperationException("SuperBookmarks: ReadUserOptions was called for unknown key " + pszKey);

            var stream = new DataStreamFromComStream(pOptionsStream);
            if (stream.Length > 0)
            {
                var info = PersistableBookmarksInfo.DeserializeFrom(stream);
                this.BookmarksManager.RecreateBookmarksFromPersistableInfo(info);
            }

            return VSConstants.S_OK;
        }
    }
}
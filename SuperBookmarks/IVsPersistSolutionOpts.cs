﻿using System;
using Microsoft.Internal.VisualStudio.Shell;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell.Interop;

namespace Konamiman.SuperBookmarks
{
    public partial class SuperBookmarksPackage
    {
        private const string persistenceKey = "Konamiman.SuperBookmarks";

        public int SaveUserOptions(IVsSolutionPersistence pPersistence) =>
            Helpers.SafeInvoke(() => _SaveUserOptions(pPersistence));

        private int _SaveUserOptions(IVsSolutionPersistence pPersistence)
        {
            return
                StorageOptions.SaveBookmarksToOwnFile ?
                VSConstants.S_OK :
                pPersistence.SavePackageUserOpts(this, persistenceKey);
        }

        public int LoadUserOptions(IVsSolutionPersistence pPersistence, uint grfLoadOpts) =>
            Helpers.SafeInvoke(() => _LoadUserOptions(pPersistence, grfLoadOpts));

        private int _LoadUserOptions(IVsSolutionPersistence pPersistence, uint grfLoadOpts)
        {
            solutionService.GetSolutionInfo(out string solutionPath, out string solutionFilePath, out string suoPath);
            this.BookmarksManager.SolutionPath = solutionPath;

            return
                StorageOptions.SaveBookmarksToOwnFile ?
                VSConstants.S_OK :
                pPersistence.LoadPackageUserOpts(this, persistenceKey);
        }

        public int WriteUserOptions(IStream pOptionsStream, string pszKey) =>
            Helpers.SafeInvoke(() => _WriteUserOptions(pOptionsStream, pszKey));

        private int _WriteUserOptions(IStream pOptionsStream, string pszKey)
        {
            if(pszKey != persistenceKey)
                throw new InvalidOperationException("SuperBookmarks: WriteUserOptions was called for unknown key " + pszKey);

            var info = this.BookmarksManager.GetSerializableInfo();
            var stream = new DataStreamFromComStream(pOptionsStream);
            info.SerializeTo(stream, prettyPrint: false);

            return VSConstants.S_OK;
        }

        public int ReadUserOptions(IStream pOptionsStream, string pszKey) =>
            Helpers.SafeInvoke(() => _ReadUserOptions(pOptionsStream, pszKey));

        private int _ReadUserOptions(IStream pOptionsStream, string pszKey)
        {
            if (pszKey != persistenceKey)
                throw new InvalidOperationException("SuperBookmarks: ReadUserOptions was called for unknown key " + pszKey);

            var stream = new DataStreamFromComStream(pOptionsStream);
            SerializableBookmarksInfo info;
            try
            {
                info = SerializableBookmarksInfo.DeserializeFrom(stream);
            }
            catch
            {
                Helpers.ShowErrorMessage("Sorry, I couldn't parse the bookmarks information from the .suo file", showHeader: false);
                return VSConstants.S_OK;
            }
            this.BookmarksManager.RecreateBookmarksFromSerializedInfo(info);
            Helpers.WriteToStatusBar($"Restored {Helpers.Quantifier(info.TotalBookmarksCount, "bookmark")} for {Helpers.Quantifier(info.TotalFilesCount, "file")} from .suo file");

            return VSConstants.S_OK;
        }
    }
}

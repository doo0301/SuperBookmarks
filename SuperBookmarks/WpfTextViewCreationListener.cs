﻿using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;
using Microsoft.VisualStudio.Text;

namespace Konamiman.SuperBookmarks
{
    [Export(typeof(IWpfTextViewCreationListener))]
    [ContentType("text")]
    [TextViewRole(PredefinedTextViewRoles.Editable)]
    class WpfTextViewCreationListener : IWpfTextViewCreationListener
    {
        [Import]
        public ITextDocumentFactoryService documentService = null;

        public void TextViewCreated(IWpfTextView textView) =>
            Helpers.SafeInvoke(() => _TextViewCreated(textView));
        
        private void _TextViewCreated(IWpfTextView textView)
        {
            var buffer = Helpers.GetRootTextBuffer(textView.TextBuffer);
            if (buffer == null)
                return; //that's probably a projection, don't mess with it

            if (!documentService.TryGetTextDocument(buffer, out ITextDocument textDocument))
                return;

            var fileName = textDocument.FilePath;
            if(fileName != null)
                SuperBookmarksPackage.Instance.BookmarksManager.RegisterTextView(fileName, textView);
        }
    }
}

// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Presentation.iOS.Prospects
{
    [Register ("ProspectsViewController")]
    partial class ProspectsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tvProspects { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (tvProspects != null) {
                tvProspects.Dispose ();
                tvProspects = null;
            }
        }
    }
}
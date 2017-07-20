// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//

using Foundation;
using MvvmCross.Binding.iOS.Views;

namespace iOSApp.Views
{
    [Register ("ImageCell")]
    partial class ImageCell
    {
        [Outlet]
        MvxImageView image { get; set; }
        
        void ReleaseDesignerOutlets ()
        {
            if (image != null) {
                image.Dispose ();
                image = null;
            }
        }
    }
}

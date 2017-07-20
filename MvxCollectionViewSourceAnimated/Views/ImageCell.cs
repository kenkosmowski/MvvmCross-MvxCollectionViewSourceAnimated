using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using System;
using UIKit;

namespace iOSApp.Views
{
    public partial class ImageCell : MvxCollectionViewCell
    {
        public static readonly UINib Nib = UINib.FromName(nameof(ImageCell), NSBundle.MainBundle);
        public static readonly NSString Key = new NSString(nameof(ImageCell));

        public ImageCell(IntPtr handle) : base(handle)
        {
            this.Initialize();
        }

        public static ImageCell Create()
        {
            return (ImageCell)Nib.Instantiate(null, null)[0];
        }

        protected void Initialize()
        {
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<ImageCell, string>();
                set.Bind(this.image).To(x => x);
                set.Apply();
            });
        }
    }
}
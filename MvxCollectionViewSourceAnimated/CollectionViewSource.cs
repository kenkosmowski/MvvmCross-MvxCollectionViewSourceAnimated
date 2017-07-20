using Foundation;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace iOSApp
{
    public class CollectionViewSource : MvxCollectionViewSourceAnimated
    {
        private readonly NSString cellIdentifier;

        public CollectionViewSource(UICollectionView collectionView, string nibName, string cellIdentifier = null, NSBundle bundle = null)
            : base(collectionView)
        {
            cellIdentifier = cellIdentifier ?? nibName;
            this.cellIdentifier = new NSString(cellIdentifier);
            collectionView.RegisterNibForCell(UINib.FromName(nibName, bundle ?? NSBundle.MainBundle), cellIdentifier);
        }

        protected override UICollectionViewCell GetOrCreateCellFor(UICollectionView collectionView, NSIndexPath indexPath, object item)
        {
            return (UICollectionViewCell)collectionView.DequeueReusableCell(this.cellIdentifier, indexPath);
        }
    }
}
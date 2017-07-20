using CoreGraphics;
using iOSApp.ViewModel;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using UIKit;

namespace iOSApp.Views
{
    [MvxRootPresentation(WrapInNavigationController = false)]
    public partial class MainView : MvxViewController
    {
        private UICollectionView collectionView;

        public MainView() : base("MainView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.collectionView = new UICollectionView(new CGRect(0, 100, UIScreen.MainScreen.Bounds.Width, 200), new UICollectionViewFlowLayout());

            this.View.AddSubview(this.collectionView);

            var source = new CollectionViewSource(collectionView, ImageCell.Key);
            this.collectionView.Source = source;

            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Bind(source).To(x => x.Items);
            set.Bind(this.Button).To(x => x.MoveCommand);
            set.Apply();
        }
    }
}

using System.Collections.ObjectModel;
using MvvmCross.Core.ViewModels;

namespace iOSApp.ViewModel
{
    public class MainViewModel : MvxViewModel
    {
        private ObservableCollection<string> items;
        public ObservableCollection<string> Items
        {
            get => this.items;
            set
            {
                this.items = value;
                this.RaisePropertyChanged(() => this.Items);
            }
        }

        public MvxCommand MoveCommand { get; set; }

        public MainViewModel()
        {
            this.MoveCommand = new MvxCommand(this.MoveImage);
        }

        private void MoveImage()
        {
            this.Items.Move(2, 0);
        }

        public override void ViewCreated()
        {
            base.ViewCreated();

            this.Items = new ObservableCollection<string>();
            this.Items.Add("https://cdn.pixabay.com/photo/2016/03/31/20/01/auto-1295461_960_720.png");
            this.Items.Add("https://cdn.pixabay.com/photo/2013/07/13/13/26/auto-161040_960_720.png");
            this.Items.Add("https://cdn.pixabay.com/photo/2012/04/12/23/47/car-30984_960_720.png");
        }
    }
}

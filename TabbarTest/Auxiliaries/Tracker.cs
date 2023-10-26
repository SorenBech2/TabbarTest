using CommunityToolkit.Mvvm.ComponentModel;

namespace TabbarTest.Auxiliaries
{
    public partial class Tracker : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsLoggedOut))]
        bool isLoggedIn;
        public bool IsLoggedOut => !IsLoggedIn;
    }
}

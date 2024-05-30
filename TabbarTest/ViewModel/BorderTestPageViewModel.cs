using CommunityToolkit.Mvvm.ComponentModel;

namespace TabbarTest.ViewModel
{
    public partial class BorderTestPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        string stringInQuestion = "Inital text not exceeding one line in length";
    }
}

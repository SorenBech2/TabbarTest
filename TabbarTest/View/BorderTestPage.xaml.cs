using TabbarTest.ViewModel;

namespace TabbarTest.View
{
    public partial class BorderTestPage : ContentPage
    {
        readonly BorderTestPageViewModel _viewModel;
        
        public BorderTestPage(BorderTestPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            _viewModel = viewModel;
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            if (button.Content.ToString() == "Yes")
            {
                _viewModel.StringInQuestion = "New text which is longer than one line and should course the border to extend and include the new line(s).";
            }
            else
            {
                _viewModel.StringInQuestion = "New text which is one line in length.";
            }
        }
    }
}
using TabbarTest.Auxiliaries;

namespace TabbarTest.View;

public partial class Page3 : ContentPage
{
	Tracker _tracker;
	public Page3(Tracker tracker)
	{
		InitializeComponent();
		_tracker = tracker;
	}

    private void LogInOutBtn_Clicked(object sender, EventArgs e)
    {
		if (_tracker.IsLoggedIn)
			_tracker.IsLoggedIn = false;
		else
			_tracker.IsLoggedIn = true;
    }
}
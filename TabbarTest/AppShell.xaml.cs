using TabbarTest.Auxiliaries;

namespace TabbarTest
{
    public partial class AppShell : Shell
    {
        public AppShell(Tracker tracker)
        {
            InitializeComponent();
            BindingContext = tracker;
            tracker.IsLoggedIn = true;
        }

        // Below function ensures, that user start on first page of every tab, even though the tab has been left on subsequent pages.
        protected override void OnNavigating(ShellNavigatingEventArgs args)
        {
            base.OnNavigating(args);

            if (args.Source == ShellNavigationSource.ShellSectionChanged)
            {
                var navigation = Shell.Current.Navigation;
                var pages = navigation.NavigationStack;
                for (var i = pages.Count - 1; i >= 1; i--)
                    navigation.RemovePage(pages[i]);
            }
        }
    }
}

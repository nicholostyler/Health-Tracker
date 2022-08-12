namespace Health_Tracker;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        if (DeviceInfo.Idiom == DeviceIdiom.Phone)
            Shell.Current.CurrentItem = PhoneTabs;




    }
}

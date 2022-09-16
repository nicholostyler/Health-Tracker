namespace Health_Tracker;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("addnew", typeof(AddWeightRecordView));
		
	}
}

using Health_Tracker.ViewModel;

namespace Health_Tracker;

public partial class Logbook : ContentPage
{
	public Logbook(WeightRecordViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
		WeightListView.ItemsSource = viewModel.WeightRecords;

    }

	private async void NewWeightButton_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("addnew");
	}
}
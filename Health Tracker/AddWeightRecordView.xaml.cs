using Health_Tracker.ViewModel;

namespace Health_Tracker;

public partial class AddWeightRecordView : ContentPage
{
	WeightRecordViewModel _viewModel;

	public AddWeightRecordView(WeightRecordViewModel viewModel)
	{
		InitializeComponent();
		if (viewModel == null) return;
		_viewModel = viewModel;
	}

	private async void SaveButton_Clicked(object sender, EventArgs e)
	{
		try
		{
            await _viewModel.AddWeightRecord(new Models.WeightRecordModel { Date = DateTimeOffset.Now, Weight = 265 });

        }catch (Exception ex)
		{
			string error = ex.Message;

		}

    }
}
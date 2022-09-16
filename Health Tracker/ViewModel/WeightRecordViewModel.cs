using Health_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Tracker.ViewModel
{
    public class WeightRecordViewModel
    {
        public ObservableCollection<WeightRecordModel> WeightRecords { get; set; }
        private ProfileModel _profile;
        public ProfileModel Profile
        {
            get
            {
                return _profile;
            }
            set
            {
                _profile = value;
                NotifyPropertyChanged("Profile");
            }
        }

        public WeightRecordViewModel()
        {
            WeightRecords = new ObservableCollection<WeightRecordModel>();
            Profile = new ProfileModel();
        }

        public async Task AddWeightRecord(WeightRecordModel newWeightRecord)
        {
            if (newWeightRecord == null) return;
            Profile.CurrentWeight = newWeightRecord.Weight;


            WeightRecords.Insert(0, newWeightRecord);

            // Calculate new statistics
            //GetWeightMonthAgo();
            //GetWeightWeekAgo();
            //GetWeightYearAgo();
            //GetTotalWeightLoss();
            // begin to save into JSON
            //await SerializeWeightRecordsAsync();
            //await SerializeProfileAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}

using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using LibrarianDashboard.Models;

namespace LibrarianDashboard.Converters
{
    public class DoubleToGridLengthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double width)
            {
                return new GridLength(width);
            }
            return new GridLength(260);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is GridLength gridLength)
            {
                return gridLength.Value;
            }
            return 260.0;
        }
    }

    public class CountActiveAttendanceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ObservableCollection<AttendanceRecord> records)
            {
                return records.Count(r => !r.ExitTime.HasValue);
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }

    public class NullToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value == null || (value is string s && string.IsNullOrEmpty(s))) ? Visibility.Collapsed : Visibility.Visible;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }

    public class TotalHoursConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ObservableCollection<AttendanceRecord> records)
            {
                double totalHours = 0;
                foreach (var record in records)
                {
                    if (record.ExitTime.HasValue)
                    {
                        totalHours += (record.ExitTime.Value - record.EntryTime).TotalHours;
                    }
                    else
                    {
                        totalHours += (DateTime.Now - record.EntryTime).TotalHours;
                    }
                }
                return $"{totalHours:F1}h";
            }
            return "0.0h";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}

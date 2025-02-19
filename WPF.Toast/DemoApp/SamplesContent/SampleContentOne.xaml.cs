﻿using System.Windows.Controls;
using WPF.Toast.Events;
using WPF.Toast.Interfaces;

namespace DemoApp.SamplesContent
{
    /// <summary>
    /// Interaction logic for SampleContentOne.xaml
    /// </summary>
    public partial class SampleContentOne : Border, IToastActionContent
    {
        public SampleContentOne()
        {
            InitializeComponent();
        }
        private void OnOkClick(object sender, System.Windows.RoutedEventArgs e)
        {
            SnoozedIndex = snoozedSelection.SelectedIndex;
            IsSnoozed = (bool)snoozedAction.IsChecked;
            IsCancel = (bool)cancelAction.IsChecked;
            IsOK = (bool)okAction.IsChecked;
        }

        private void OnCancelClick(object sender, System.Windows.RoutedEventArgs e)
        {
            IsCancel = true;
            SnoozedIndex = snoozedSelection.SelectedIndex;
            IsSnoozed = (bool)snoozedAction.IsChecked;
            IsOK = (bool)okAction.IsChecked;
            ToastClosed?.Invoke(this);
        }
        public bool IsCancel { get; set; }
        public bool IsOK { get; set; }
        public bool IsSnoozed { get; set; }
        public int SnoozedIndex { get; set; }

        public event ToastActionContentEventHandler ToastClosed;
    }
}

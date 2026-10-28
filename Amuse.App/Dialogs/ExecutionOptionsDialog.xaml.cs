// Copyright (c) Adam Clark. All rights reserved.
// Licensed under the Apache 2.0 License.
using Amuse.App.Common;
using System.Threading.Tasks;
using TensorStack.WPF;
using TensorStack.WPF.Controls;

namespace Amuse.App.Dialogs
{
    /// <summary>
    /// Interaction logic for ExecutionOptionsDialog.xaml
    /// </summary>
    public partial class ExecutionOptionsDialog : DialogControl
    {
        private ExecutionOptionsModel _executionOptions;

        public ExecutionOptionsDialog(Settings settings)
        {
            Settings = settings;
            SaveCommand = new AsyncRelayCommand(SaveAsync, CanExecuteSave);
            CancelCommand = new AsyncRelayCommand(CancelAsync);
            InitializeComponent();
        }

        public Settings Settings { get; }
        public AsyncRelayCommand SaveCommand { get; }
        public AsyncRelayCommand CancelCommand { get; }

        public ExecutionOptionsModel ExecutionOptions
        {
            get { return _executionOptions; }
            set { SetProperty(ref _executionOptions, value); }
        }


        public Task<bool> ShowDialogAsync(ExecutionOptionsModel executionOptions)
        {
            ExecutionOptions = executionOptions.DeepClone();
            return base.ShowDialogAsync();
        }
    }
}

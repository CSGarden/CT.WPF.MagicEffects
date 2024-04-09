using CommunityToolkit.Mvvm.ComponentModel;
using CT.WPF.MagicEffects.Demo.Models;
using CT.WPF.MagicEffects.Demo.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace CT.WPF.MagicEffects.Demo.ViewModels.TabControlTop {
    public partial class TopOneViewModel : ObservableObject {

        public TopOneViewModel() {
            AllControl = new List<ControlModel> {
                new ControlModel("人像颜色替换", typeof(MonochromeEffectControl)),
                new ControlModel("纹理颜色替换", typeof(TexturedColorReplaceEffectControl))
            };
            SearchControl = new CollectionViewSource {
                Source = AllControl
            };

            SearchControl.View.Culture = new System.Globalization.CultureInfo("zh-CN");

            SearchControl.View.Filter = obj => (((obj as ControlModel)?.Title ?? string.Empty) + ((obj as ControlModel)?.TitlePinyin ?? string.Empty)).ToLower().Contains(SearchKey?.ToLower() ?? string.Empty);

            SearchControl.View.SortDescriptions.Add(new SortDescription(nameof(ControlModel.Title),ListSortDirection.Ascending));
            CurrentShowControl = AllControl.FirstOrDefault();
        }

        [ObservableProperty]
        private string? searchKey;

        partial void OnSearchKeyChanged(string? value) {
            SearchControl?.View.Refresh();
        }

        [ObservableProperty]
        private UserControl? content;

        [ObservableProperty]
        private string? title;

        [ObservableProperty]
        private CollectionViewSource? searchControl;

        [ObservableProperty]
        private int selectedDemoType;

        partial void OnSelectedDemoTypeChanged(int value) {
            CurrentShowControl = AllControl.FirstOrDefault();
        }

        [ObservableProperty]
        private ControlModel? currentShowControl;
        partial void OnCurrentShowControlChanged(ControlModel? value) {
            UpdateContentBasedOnCurrentShowControl();
            Title = CurrentShowControl?.Title;
        }
        

        private void UpdateContentBasedOnCurrentShowControl() {
            if (CurrentShowControl == null) {
                Content = null;
            } else {
                Content = (UserControl?)Activator.CreateInstance(CurrentShowControl.Content);
            }
        }

        [ObservableProperty]
        private IEnumerable<ControlModel> allControl;
    }
}

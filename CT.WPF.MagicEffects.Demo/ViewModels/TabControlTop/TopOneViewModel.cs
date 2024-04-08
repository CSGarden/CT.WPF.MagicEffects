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
            // 假设我们这里初始化一个控件示例，在实际应用中你需要根据实际情况填充这个列表。
            AllControl = new List<ControlModel> {
                new ControlModel("人像颜色替换", typeof(UserControl))
                // 注意: 这里假设UserControl替换为你实际使用的控件类。
            };
            SearchControl = new CollectionViewSource {
                Source = AllControl
            };

            SearchControl.View.Culture = new System.Globalization.CultureInfo("zh-CN");

            SearchControl.View.Filter = obj => (((obj as ControlModel)?.Title ?? string.Empty) + ((obj as ControlModel)?.TitlePinyin ?? string.Empty)).ToLower().Contains(SearchKey?.ToLower() ?? string.Empty);

            SearchControl.View.SortDescriptions.Add(new SortDescription(nameof(ControlModel.Title),ListSortDirection.Ascending));

            // 初始设置CurrentShowControl
            CurrentShowControl = AllControl.FirstOrDefault();
        }

        [ObservableProperty]
        private string? searchKey;

        partial void OnSearchKeyChanged(string? value) {
            SearchControl?.View.Refresh();
        }

        [ObservableProperty]
        private UserControl? content;

        partial void OnContentChanged(UserControl? value) {
            // 这个方法只是作为一个展示使用，实际上内容更新是在OnCurrentShowControlChanged中处理
        }

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
        public void OnCurrentShowControlChanged() {
            UpdateContentBasedOnCurrentShowControl();
            Title = CurrentShowControl?.Title;
        }

        private void UpdateContentBasedOnCurrentShowControl() {
            if (CurrentShowControl == null) {
                Content = null;
            } else {
                // 确保类型有无参构造函数
                Content = (UserControl?)Activator.CreateInstance(CurrentShowControl.Content);
            }
        }

        [ObservableProperty]
        private IEnumerable<ControlModel> allControl;
    }
}

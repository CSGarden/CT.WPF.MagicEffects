﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT.WPF.MagicEffects.Demo.ViewModels {
    public class ViewModelLocator {
        public static ViewModelLocator Instance { get; private set; }
        private IServiceProvider serviceProvider;
        public ViewModelLocator() {
            RegisterViewModel();
            Instance = this;
        }
        private void RegisterViewModel() {
            if (serviceProvider == null) {
                var serviceCollection = new ServiceCollection();

                //Regist your view models here
                serviceCollection.AddScoped<MainViewModel>();

                serviceProvider = serviceCollection.BuildServiceProvider();
            }
        }

        public MainViewModel Main {
            get {
                return serviceProvider?.GetService<MainViewModel>();
            }
        }
    }
}

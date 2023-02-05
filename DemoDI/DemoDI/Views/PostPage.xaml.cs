using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms;
using DemoDI.ViewModels;

namespace DemoDI.Views
{
    public partial class PostPage : ContentPage
    {
        PostViewModel _vm;
        public PostPage()
        {
            InitializeComponent();
            _vm = Startup.ServiceProvider.GetService<PostViewModel>();
            BindingContext = _vm;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await _vm.PostsAsync();

        }
    }
}


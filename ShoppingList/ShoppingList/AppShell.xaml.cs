using ShoppingList.ViewModels;
using ShoppingList.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ShoppingList
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

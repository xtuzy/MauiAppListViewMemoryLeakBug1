using System.ComponentModel;

namespace MauiAppListViewMemoryLeakBug1;

public partial class ListViewPage : ContentPage
{
	public ListViewPage()
	{
		InitializeComponent();
		this.BindingContext = new ViewModel();
	}
}


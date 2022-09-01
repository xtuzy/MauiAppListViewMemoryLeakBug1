namespace MauiAppListViewMemoryLeakBug1;

public partial class ScrollViewPage : ContentPage
{
	public ScrollViewPage()
	{
		InitializeComponent();
        var viewmodel = new ViewModel();
        foreach (var model in viewmodel.list)
        {
            stacklayout.Add(new VerticalStackLayout()
            {
                new Label(){Text = model.Text},
                new Label(){Text = model.Detail},
            });
        }
    }
}
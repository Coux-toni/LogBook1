using LogBook.LogbookCore.ViewModels;

namespace LogBookMaui.Pages;

public partial class ReportPage : ContentPage
{
	public ReportPage(ReportViewModel viewmodel)
	{
		InitializeComponent();
		this.BindingContext = viewmodel;
	}
}
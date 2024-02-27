using MeshCodeApp.Models.Response;

namespace MeshCodeApp.Controls;

public partial class CupomControl : ContentView
{
	public CupomControl()
	{
		InitializeComponent();
	}

    #region Bindable Properties

    public static readonly BindableProperty CupomProperty = BindableProperty.Create(
        nameof(Cupom),
        typeof(CupomDto),
        typeof(CupomControl)
        );

    #endregion

    #region [Properties]

    public CupomDto Cupom
    {
        get => (CupomDto)this.GetValue(CupomProperty);
        set => this.SetValue(CupomProperty, value);
    }
    #endregion
}
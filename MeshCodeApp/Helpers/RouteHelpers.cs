namespace MeshCodeApp.Helpers
{
    public static class RouteHelpers
    {
        public static async Task LogoffAsync()
        {
            try
            {
                SessionHelper.ResetToken();
                await Application.Current.MainPage.Navigation.PushModalAsync(new Login(new LoginViewModel()));
            }
            catch (Exception ex)
            {

            }
        }

        public static async Task GoToHomeMeshCode()
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushModalAsync(new HomeMeshCode(new HomeMeshCodeViewModel()));
            }
            catch (Exception ex)
            {

            }
        }

    }
}

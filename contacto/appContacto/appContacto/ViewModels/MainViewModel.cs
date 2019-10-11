namespace appContacto.ViewModels
{
    public class MainViewModel
    {

        #region Constructor
        public MainViewModel()
        {
            instance = this;
        } 
        #endregion
        #region singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance==null)
            {
                instance = new MainViewModel();
            }
            return (instance);
        }
        #endregion
    }
}

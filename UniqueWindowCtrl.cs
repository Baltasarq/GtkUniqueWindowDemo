namespace UniqueWindowDemo
{
    /// <summary>
    /// The unique window control.
    /// </summary>
    class UniqueWindowCtrl
    {
        public UniqueWindowCtrl()
        {
            this.view = new UniqueWindowView();
            this.view.DeleteEvent += (o, args) => this.Quit();
            this.view.BtLogin.Clicked += (sender, e) => this.ShowNotebook();
        }
        
        /// <summary>Prepares the window to start</summary>
        public void Start()
        {
            this.ShowLogin();
        }
        
        /// <summary>Shows the login page, hiding everything else.</summary>
        public void ShowLogin()
        {
            this.view.VbLoginPage.Show();
            this.view.NbNotebook.Hide();
        }
        
        /// <summary>Shows the notebook page, hiding everything else.</summary>
        public void ShowNotebook()
        {
            this.view.VbLoginPage.Hide();
            this.view.NbNotebook.Show();
        }
        
        /// <summary>Quits the application.</summary>
        void Quit()
        {
            this.view.Hide();
            Gtk.Application.Quit();
        }
        
        UniqueWindowView view;
    }
}

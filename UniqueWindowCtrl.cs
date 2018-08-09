namespace UniqueWindowDemo
{
    class UniqueWindowCtrl
    {
        public UniqueWindowCtrl()
        {
            this.view = new UniqueWindowView();
            this.view.DeleteEvent += (o, args) => this.Quit();
            this.view.btLogin.Clicked += (sender, e) => this.ShowNotebook();
        }
        
        public void Start()
        {
            this.ShowLogin();
        }
        
        public void ShowLogin()
        {
            this.view.vbLoginPage.Show();
            this.view.nbNotebook.Hide();
        }
        
        public void ShowNotebook()
        {
            this.view.vbLoginPage.Hide();
            this.view.nbNotebook.Show();
        }
        
        void Quit()
        {
            this.view.Hide();
            Gtk.Application.Quit();
        }
        
        UniqueWindowView view;
    }
}

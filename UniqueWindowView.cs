namespace UniqueWindowDemo
{
    class UniqueWindowView: Gtk.Window
    {
        public UniqueWindowView()
            :base( Gtk.WindowType.Toplevel )
        {
            this.Build();
        }
        
        void Build()
        {
            var vbMainBox = new Gtk.VBox();
        
            this.vbLoginPage = this.BuildLoginPage();
            this.vbNotebook = this.BuildNotebook();
        
            vbMainBox.PackStart( this.vbLoginPage, true, true, 100 );
            vbMainBox.PackStart( this.vbNotebook, true, true, 5 );
            vbMainBox.Show();
            
            this.Add( vbMainBox );
            this.SetSizeRequest( 600, 400 );
            this.Title = "Unique window demo";
            this.Show();
        }
        
        Gtk.VBox BuildLoginPage()
        {
            var toret = new Gtk.VBox();
            var hbLogin = new Gtk.HBox();
            var hbUsr = new Gtk.HBox();
            var hbPsw = new Gtk.HBox();
            var edUsr = new Gtk.Entry();
            var edPsw = new Gtk.Entry();
            var lblUsr = new Gtk.Label( "User" );
            var lblPsw = new Gtk.Label( "Password" );
            
            this.btLogin = new Gtk.Button( "Login" );
            hbLogin.PackEnd( btLogin, false, false, 5 );
                        
            hbUsr.PackStart( lblUsr, false, false, 5 );
            hbUsr.PackStart( edUsr, true, true, 5 );
            
            hbPsw.PackStart( lblPsw, false, false, 5 );
            hbPsw.PackStart( edPsw, true, true, 5 );
            
            toret.PackStart( hbUsr, false, true, 5 );
            toret.PackStart( hbPsw, false, true, 5 );
            toret.PackStart( hbLogin, false, false, 10 );
            
            toret.ShowAll();
            return toret;
        }
        
        Gtk.VBox BuildNotebook()
        {
            var lblButton1 = new Gtk.Label( "Button1" );
            var lblButton2 = new Gtk.Label( "Button2" );
            
            this.nbNotebook = new Gtk.Notebook();
            this.nbNotebook.AppendPage( lblButton1, new Gtk.Label( "Tab1" ) );
            this.nbNotebook.AppendPage( lblButton2, new Gtk.Label( "Tab2" ) );
            
            this.nbNotebook.ShowAll();
            this.nbNotebook.TabPos = Gtk.PositionType.Right;
            
            var toret = new Gtk.VBox( true, 5 );
            toret.PackStart( this.nbNotebook );
            toret.ShowAll();
            
            return toret;
        }
        
        public Gtk.VBox vbLoginPage {
            get; private set;
        }
        
        public Gtk.VBox vbNotebook {
            get; private set;
        }
            
        public Gtk.Notebook nbNotebook {
            get; private set;
        }
        
        public Gtk.Button btLogin {
            get; private set;
        }
    }
}

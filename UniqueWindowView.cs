namespace UniqueWindowDemo
{
    /// <summary>
    /// The unique window view.
    /// </summary>
    class UniqueWindowView: Gtk.Window
    {
        public UniqueWindowView()
            :base( Gtk.WindowType.Toplevel )
        {
            this.Build();
        }
        
        /// <summary>
        /// Build the widgets in this window.
        /// </summary>
        void Build()
        {
            var vbMainBox = new Gtk.VBox();
        
            this.VbLoginPage = this.BuildLoginPage();
            this.VbNotebook = this.BuildNotebookPage();
        
            vbMainBox.PackStart( this.VbLoginPage, true, true, 100 );
            vbMainBox.PackStart( this.VbNotebook, true, true, 5 );
            vbMainBox.Show();
            
            this.Add( vbMainBox );
            this.SetSizeRequest( 600, 400 );
            this.Title = "Unique window demo";
            this.Show();
        }
        
        /// <summary>
        /// Builds the login page.
        /// </summary>
        /// <returns>The login page, as a Gtk.VBox</returns>
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
            
            this.BtLogin = new Gtk.Button( "Login" );
            hbLogin.PackEnd( BtLogin, false, false, 5 );
                        
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
        
        /// <summary>
        /// Builds the notebook page.
        /// </summary>
        /// <returns>The notebook page, as a Gtk.VBox.</returns>
        Gtk.VBox BuildNotebookPage()
        {
            var lblButton1 = new Gtk.Label( "Page 1" );
            var lblButton2 = new Gtk.Label( "Page 2" );
            
            this.NbNotebook = new Gtk.Notebook();
            this.NbNotebook.AppendPage( lblButton1, new Gtk.Label( "Tab 1" ) );
            this.NbNotebook.AppendPage( lblButton2, new Gtk.Label( "Tab 2" ) );
            
            this.NbNotebook.ShowAll();
            this.NbNotebook.TabPos = Gtk.PositionType.Right;
            
            var toret = new Gtk.VBox( true, 5 );
            toret.PackStart( this.NbNotebook );
            toret.ShowAll();
            
            return toret;
        }
        
        /// <summary>The VBox for the login page.</summary>
        public Gtk.VBox VbLoginPage {
            get; private set;
        }

        /// <summary>The VBox for the notebook page.</summary>        
        public Gtk.VBox VbNotebook {
            get; private set;
        }
            
        /// <summary>The notebook for the second page, as a Gtk.Notebook.</summary>
        public Gtk.Notebook NbNotebook {
            get; private set;
        }
        
        /// <summary>The Gtk.Button triggering the login.</summary>
        public Gtk.Button BtLogin {
            get; private set;
        }
    }
}

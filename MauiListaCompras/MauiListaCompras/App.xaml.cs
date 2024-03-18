using MauiListaCompras.Helpers;

namespace MauiListaCompras
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper _db;

        public static SQLiteDatabaseHelper Db
        {
            get
            {
                if (_db == null) 
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData),
                             "banco_sql_compras.db3"
                        );

                    _db = new SQLiteDatabaseHelper( path );
                }//fechar if verificando se _db é null

                return _db;
            }//fechar método get
        }
        public App() 
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}

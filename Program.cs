namespace Projeto_PAP_WilliamAlves_24_25
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            /* login Login = new login();
             Login.ShowDialog();*/

            PaginaInicial Login = new PaginaInicial();
            Login.ShowDialog();

            Application.Run();
        }
    }
}
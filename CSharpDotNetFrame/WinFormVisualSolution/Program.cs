namespace WinFormVisualSolution
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

            LogInWinForm logInWinForm = new LogInWinForm();
            if (logInWinForm.ShowDialog() != DialogResult.OK)
            {
                logInWinForm.Close();
                return;
            }

            Application.Run(new mainWindow());
        }
    }
}
namespace WinFormsApp1
{
    internal static class ChessRenderer
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Start()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Form1 form = new Form1();
            form.Text = "Chess";

            Application.Run(form);
        }
    }
}
namespace Travel_Mentor
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
            
            // A�a��da Login screen olacak, �uan d�zeltmeler i�in b�yle kullan�l�yor.
            Application.Run(new Form1());
        }
    }
}
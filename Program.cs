using System.Security.Principal;
using WinOptimizer.Managers;
using WinOptimizer.UI;

namespace WinOptimizer;

class Program
{
    static int Main(string[] args)
    {
        Console.Title = "SkyRocket Optimizer v2.0";

        if (!IsRunningAsAdministrator())
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    🚫 ERROR: NOT ADMINISTRATOR                    ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("  This application requires Administrator privileges to");
            Console.WriteLine("  modify system settings, services, and registry keys.");
            Console.WriteLine();
            Console.Write("  Would you like to restart as Administrator? (Y/N): ");
            Console.ResetColor();

            var input = Console.ReadLine()?.Trim().ToUpper();
            
            if (input == "Y" || input == "YES")
            {
                try
                {
                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = System.Diagnostics.Process.GetCurrentProcess().MainModule?.FileName ?? "SkyRocketOptimizer.exe",
                        UseShellExecute = true,
                        Verb = "runas"
                    };
                    System.Diagnostics.Process.Start(psi);
                    return 0;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n  Failed to restart as Administrator.");
                    Console.ResetColor();
                    return 1;
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n  Exiting application...");
            Console.ResetColor();
            return 1;
        }

        ShowSplashScreen();

        try
        {
            var logger = new Logger();
            var backupManager = new BackupManager();
            var restoreManager = new RestoreManager(backupManager, logger);
            var menu = new Menu(backupManager, logger, restoreManager);

            logger.Info("SkyRocket Optimizer v2.0 started");
            menu.ShowMainMenu();
            logger.Info("SkyRocket Optimizer v2.0 exited normally");

            return 0;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n  ╔═══════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("  ║                         FATAL ERROR                               ║");
            Console.WriteLine("  ╚═══════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine($"\n  {ex.Message}");
            Console.ResetColor();
            return 1;
        }
    }

    static bool IsRunningAsAdministrator()
    {
        try
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        catch
        {
            return false;
        }
    }

    static void ShowSplashScreen()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
    ╔═══════════════════════════════════════════════════════════════════════════════╗
    ║                                                                               ║
    ║                           ██╗    ██╗███████╗██╗      ║                         ║
    ║                           ██║    ██║██╔════╝██║     ║                          ║
    ║                           ██║ █╗ ██║█████╗  ██║     ║                          ║
    ║                           ██║███╗██║██╔══╝  ██║     ║                          ║
    ║                           ╚███╔███╔╝███████╗███████╗║                          ║
    ║                            ╚══╝╚══╝ ╚══════╝╚══════╝║                          ║
    ║                                                                               ║
    ║              ██████╗ ██╗  ██╗ ██████╗ ███████╗██████╗ ███████╗██╗   ██╗       ║
    ║              ██╔══██╗██║  ██║██╔═══██╗██╔════╝██╔══██╗██╔════╝██║   ██║       ║
    ║              ██████╔╝███████║██║   ██║█████╗  ██████╔╝███████╗██║   ██║       ║
    ║              ██╔═══╝ ██╔══██║██║   ██║██╔══╝  ██╔══██╗██╔════╝██║   ██║       ║
    ║              ██║     ██║  ██║╚██████╔╝██║     ██║  ██║███████╗╚██████╔╝       ║
    ║              ╚═╝     ╚═╝  ╚═╝ ╚═════╝ ╚═╝     ╚═╝  ╚═╝╚══════╝ ╚═════╝        ║
    ║                                                                               ║
    ║                           ╔═══════════════════════════════╗                    ║
    ║                           ║      🚀 SKYROCKET v2.0 🚀   ║                    ║
    ║                           ╚═══════════════════════════════╝                    ║
    ║                                                                               ║
    ║                           (C) 2026 isvexed - All Rights Reserved             ║
    ║                                                                               ║
    ╚═══════════════════════════════════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        
        AnimateLoading();
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  ✓ Running with Administrator privileges...");
        Console.ResetColor();
        Thread.Sleep(800);
    }

    static void AnimateLoading()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("  ");
        var frames = new[] { "▓", "▒", "░", " " };
        for (int i = 0; i < 20; i++)
        {
            foreach (var frame in frames)
            {
                Console.Write($"\r  Loading... {frame}");
                Thread.Sleep(30);
            }
        }
        Console.Write("\r  Loading... Done!  ");
        Console.ResetColor();
        Console.WriteLine();
    }
}

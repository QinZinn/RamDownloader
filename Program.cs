using System.Diagnostics;
using System.Threading;
Console.WriteLine("=== RamDownloader v1.0 ===");
Console.WriteLine("Enter the amount of RAM you want to download (MiB): ");
int ram = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\nPreparing to download {ram} MiB of RAM...");
Thread.Sleep(3000);
for (int i = 0; i <= 100; i++)
{
    Console.Write($"\rDownloading... {i}%");
    Thread.Sleep(40);
}
Console.WriteLine("\n\nAdding RAM to system...");
Thread.Sleep(2000);
Console.WriteLine("RAM installed successfully!");
Thread.Sleep(1500);
Console.WriteLine("\nExecuting the process...");
Thread.Sleep(1000);
Process.Start(new ProcessStartInfo
{
    FileName = "https://www.youtube.com/watch?v=dQw4w9WgXcQ",
    UseShellExecute = true
});
Console.WriteLine("\nGET RICKROLL'ED");
Thread.Sleep(5000);
Environment.Exit(0);

using System;
using System.Net.Http;
using System.Threading.Tasks;

/// <summary>
/// Provides functionality to request a URL from the user and verify its online status.
/// Demonstrates basic networking, exception handling, and async/await in C#.
/// </summary>
public class SystemHealthStructure
{
    /// <summary>
    /// Prompts the user to enter a URL.
    /// </summary>
    /// <returns>The URL entered by the user as a string.</returns>
    public string getURL()
    {
        Console.WriteLine("URL:");
        string url = Console.ReadLine();
        return url;
    }

    /// <summary>
    /// Asynchronously checks whether the provided URL is online.
    /// Sends a lightweight HEAD request to minimize data transfer.
    /// </summary>
    /// <param name="url">The URL to check.</param>
    /// <returns>
    /// A task representing the asynchronous operation.
    /// The task result is <c>true</c> if the URL responded successfully; otherwise, <c>false</c>.
    /// </returns>
    public static async Task<bool> isURLOnline(string url)
    {
        try
        {
            using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(10);
                using (HttpResponseMessage response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Head, url)))
                {
                    return response.IsSuccessStatusCode;
                }
            }
        }
        catch (HttpRequestException)
        {
            return false;
        }
        catch (TaskCanceledException)
        {
            return false;
        }
        catch (Exception)
        {
            return false;
        }
    }

    /// <summary>
    /// Application entry point.
    /// Prompts the user for a URL, checks if it's reachable, and displays the result.
    /// </summary>
    public async Task<int> MainAsync()
    {
        string url = getURL();
        bool isOnline = await isURLOnline(url);
        if (isOnline)
        {
            Console.WriteLine("URL is online.\n");
        }
        else
        {
            Console.WriteLine("URL is offline.\n");
        }
        return 0;
    }

    public static async Task Main(string[] args)
    {
        var systemHealth = new SystemHealthStructure();
        await systemHealth.MainAsync();
    }
}

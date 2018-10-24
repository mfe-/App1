using System;
using System.Diagnostics;

public static class AsyncErrorHandler
{
    /// <summary>
    /// Handles only exceptions which are thrown in a async declared method
    /// </summary>
    /// <param name="exception"></param>
    public static void HandleException(Exception exception)
    {
        Debug.WriteLine("Exception occurred: " + exception.Message);
    }
}
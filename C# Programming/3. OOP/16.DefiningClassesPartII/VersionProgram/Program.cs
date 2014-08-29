using System;

[Version("0.01")]
class Program
{
    static void Main()
    {
        Type type = typeof(Program);
        object[] allAttributes = type.GetCustomAttributes(false);
        foreach (VersionAttribute versionAtribute in allAttributes)
        {
            Console.WriteLine("Version: {0} ", versionAtribute.Version);
        }
    }
}
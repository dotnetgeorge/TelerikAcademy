using System;
using System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Struct |
AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method,
AllowMultiple = true)]
public class VersionAttribute : System.Attribute
{
    public string version;

    public string Version
    {
        get { return this.version; }
    }


    public VersionAttribute(string version)
    {
        this.version = version;
    }
}
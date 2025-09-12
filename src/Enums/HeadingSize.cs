using Intellenum;

namespace Soenneker.Quark.Headings.Enums;

/// <summary>
/// An enumeration for Quark.Headings, representing HTML heading levels.
/// This enum contains the standard HTML heading levels (h1-h6).
/// </summary>
[Intellenum<string>]
public partial class HeadingSize
{
    /// <summary>
    /// H1 heading level.
    /// The largest heading level.
    /// </summary>
    public static readonly HeadingSize S1 = new("1");

    /// <summary>
    /// H2 heading level.
    /// The second largest heading level.
    /// </summary>
    public static readonly HeadingSize S2 = new("2");

    /// <summary>
    /// H3 heading level.
    /// The default heading level.
    /// </summary>
    public static readonly HeadingSize S3 = new("3");

    /// <summary>
    /// H4 heading level.
    /// The fourth heading level.
    /// </summary>
    public static readonly HeadingSize S4 = new("4");

    /// <summary>
    /// H5 heading level.
    /// The fifth heading level.
    /// </summary>
    public static readonly HeadingSize S5 = new("5");

    /// <summary>
    /// H6 heading level.
    /// The smallest heading level.
    /// </summary>
    public static readonly HeadingSize S6 = new("6");
}
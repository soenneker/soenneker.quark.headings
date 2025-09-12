using Soenneker.Quark.Headings.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Headings.Tests;

[Collection("Collection")]
public sealed class HeadingTests : FixturedUnitTest
{
    private readonly IHeading _blazorlibrary;

    public HeadingTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _blazorlibrary = Resolve<IHeading>(true);
    }

    [Fact]
    public void Default()
    {

    }
}

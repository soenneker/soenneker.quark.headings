using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Headings.Tests;

[Collection("Collection")]
public sealed class HeadingTests : FixturedUnitTest
{
    public HeadingTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}

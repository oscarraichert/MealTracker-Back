using FluentAssertions;
using HtmlBuilder.Entities;
using HtmlBuilder.Entities.Tags;
using MealTracker.Entities;

namespace HtmlBuilder.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var html = new Div(new Text("teste maluco"));

            html.BuildTag().Should().Be("<div>teste maluco</div>");
        }

        [Fact]
        public void Test2()
        {
            var html = new Div(new Div(new Text("div drento da div")));

            html.BuildTag().Should().Be("<div><div>div drento da div</div></div>");
        }

        [Fact]
        public void Test3()
        {
            var html = new Div(new Div(new Input()));

            html.BuildTag().Should().Be("<div><div><input></div></div>");
        }
    }
}
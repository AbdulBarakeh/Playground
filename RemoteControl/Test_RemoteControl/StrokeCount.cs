using RemoteControl;

namespace Test_RemoteControl
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("agh",6)]
        [TestCase("rnj",12)]
        [TestCase("nst",10)]
        [TestCase("478",11)]
        public void StrokeCount(string code,int res)
        {
            var strokes = RemoteControl.RemoteControl.NumberOfStrokes(code);
            Assert.That(strokes,Is.EqualTo(res));
        }
    }
}
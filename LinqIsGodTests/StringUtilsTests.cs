using LinqIsGod;
using Xunit;

namespace LinqIsGodTests {
    public class StringUtilsTests {

        [Fact]
        [Trait("Category", "Static Tests")]
        public void LinqSubstringStaticTest() {

            //Arrange

            string testData = "This is a Substring Test";
            string expected = "";
            string actual = "";
            int startPos = 0;
            int endpos = 10;

            //Act

            expected = testData.Substring(startPos, endpos);
            actual = testData.LinqSubstring(startPos, endpos);

            //Assert

            Assert.True(expected == actual);

        }

        [Fact]
        [Trait("Category", "Static Tests")]
        public void LinqLengthTest() {

            //Arrange

            string testData = "This is a Length Test";
            int expected = 0;
            int actual = 0;


            //Act

            expected = testData.Length;
            actual = testData.LinqLength();

            //Assert

            Assert.True(expected == actual);

        }




        [Fact]
        [Trait("Category", "Static Tests")]
        public void LinqIndexOfTest() {

            //Arrange

            string testData = "This is an Index of Test";
            int expected = 0;
            int actual = 0;


            //Act

            expected = testData.IndexOf('i');
            actual = testData.LinqIndexOf('i');

            //Assert

            Assert.True(expected == actual);

        }


        [Fact]
        [Trait("Category", "Static Tests")]
        public void LinqStartsWithTest() {

            //Arrange

            string testData = "This is a StartsWith Test";
            bool expected = false;
            bool actual = false;


            //Act

            expected = testData.StartsWith('T');
            actual = testData.LinqStartsWith('T');

            //Assert

            Assert.True(expected == actual);

        }

        [Fact]
        [Trait("Category", "Static Tests")]
        public void LinqEndsWithTest() {

            //Arrange

            string testData = "This is a PadLeft Test";
            bool expected = false;
            bool actual = false;


            //Act

            expected = testData.EndsWith("t");
            actual = testData.LinqEndsWith('t');

            //Assert

            Assert.True(expected == actual);

        }

        [Fact]
        [Trait("Category", "Static Tests")]
        public void LinqRemoveTest() {

            //Arrange

            string testData = "This is a PadLeft Test";
            string expected = "";
            string actual = "";


            //Act

            expected = testData.PadLeft(25, '0');
            actual = testData.LinqPadLeft(25, '0');

            //Assert

            Assert.True(expected == actual);

        }

        [Fact]
        [Trait("Category", "Static Tests")]
        public void LinqReplaceOfTest() {

            //Arrange

            string testData = "This is an Index of Test";
            string expected = "";
            string actual = "";


            //Act

            expected = testData.Replace('i','o');
            actual = testData.LinqReplace('i','o');

            //Assert

            Assert.True(expected == actual);

        }

        [Fact]
        [Trait("Category", "Static Tests")]
        public void LinqPadLeftTest() {

            //Arrange

            string testData = "This is a PadLeft Test";
            string expected = "";
            string actual = "";


            //Act

            expected = testData.PadLeft(25, '0');
            actual = testData.LinqPadLeft(25, '0');

            //Assert

            Assert.True(expected == actual);

        }


        [Fact]
        [Trait("Category", "Static Tests")]
        public void LinqPadRightTest() {

            //Arrange

            string testData = "This is a PadLeft Test";
            string expected = "";
            string actual = "";


            //Act

            expected = testData.PadLeft(25, '0');
            actual = testData.LinqPadRight(25, '0');

            //Assert

            Assert.True(expected == actual);

        }
    }
}

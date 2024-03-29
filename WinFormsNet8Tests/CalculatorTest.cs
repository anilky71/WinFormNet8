using WinFormNet8.Business;

namespace WinFormsNet8Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            Calculator c = new Calculator();
            Assert.Equal(2, c.Add(1, 1));
        }
        [Fact]
        public void TestSub()
        {
            Calculator c = new Calculator();
            Assert.Equal(0, c.Subtract(1, 1));
        }
        [Fact]
        public void TestMul()
        {
            Calculator c = new Calculator();
            Assert.Equal(1, c.Multiply(1, 1));
        }
        [Fact]
        public void TestDiv()
        {
            Calculator c = new Calculator();
            Assert.Equal(1, c.Divide(1, 1));
        }
        
    }
}
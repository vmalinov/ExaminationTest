using ExaminationBL;

namespace UnitTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IExaminationProcessor examintaionProcessor = new ExaminationProcessor();
            string input = "5\r\ns 70 78 82 57 74\r\nl 68 81 81 60 78\r\ns 63 76 55 80 75\r\ns 90 100 96 10 10\r\nl 88 78 81 97 93";

            Assert.AreEqual(2, examintaionProcessor.GetPassedCount(input));
        }

        [Test]
        public void Test2()
        {
            IExaminationProcessor examintaionProcessor = new ExaminationProcessor();
            string input = "20\r\nl 100 67 39 85 87\r\ns 38 75 75 45 90\r\nl 43 95 7 35 49\r\nl 82 77 74 35 44\r\ns 96 80 92 58 84\r\nl 23 60 44 27 3\r\nl 42 24 52 23 63\r\ns 44 78 98 51 10\r\nl 93 38 73 88 12\r\nl 34 29 43 48 61\r\nl 83 33 97 3 59\r\nl 24 84 22 35 33\r\ns 81 42 80 34 87\r\nl 8 87 82 80 100\r\nl 48 75 75 3 50\r\nl 93 76 25 71 31\r\ns 60 92 64 66 11\r\nl 61 47 6 21 83\r\nl 68 1 47 81 78\r\nl 8 72 54 20 25";

            Assert.AreEqual(3, examintaionProcessor.GetPassedCount(input));
        }

        [Test]
        public void InputLinesCountIsWrong()
        {
            IExaminationProcessor examintaionProcessor = new ExaminationProcessor();
            string input = "22\r\nl 100 67 39 85 87\r\ns 38 75 75 45 90\r\nl 43 95 7 35 49\r\nl 82 77 74 35 44\r\ns 96 80 92 58 84\r\nl 23 60 44 27 3\r\nl 42 24 52 23 63\r\ns 44 78 98 51 10\r\nl 93 38 73 88 12\r\nl 34 29 43 48 61\r\nl 83 33 97 3 59\r\nl 24 84 22 35 33\r\ns 81 42 80 34 87\r\nl 8 87 82 80 100\r\nl 48 75 75 3 50\r\nl 93 76 25 71 31\r\ns 60 92 64 66 11\r\nl 61 47 6 21 83\r\nl 68 1 47 81 78\r\nl 8 72 54 20 25";

            Assert.Throws<Exception>(() => examintaionProcessor.GetPassedCount(input));
            var ex = Assert.Throws<Exception>(() => examintaionProcessor.GetPassedCount(input));
            Assert.That(ex.Message, Is.EqualTo("Input string has incorrect format:" + input));
        }

        [Test]
        public void ScoresIsNotDigit()
        {
            IExaminationProcessor examintaionProcessor = new ExaminationProcessor();
            string input = "20\r\nl F 67 39 85 87\r\ns 38 75 75 45 90\r\nl 43 95 7 35 49\r\nl 82 77 74 35 44\r\ns 96 80 92 58 84\r\nl 23 60 44 27 3\r\nl 42 24 52 23 63\r\ns 44 78 98 51 10\r\nl 93 38 73 88 12\r\nl 34 29 43 48 61\r\nl 83 33 97 3 59\r\nl 24 84 22 35 33\r\ns 81 42 80 34 87\r\nl 8 87 82 80 100\r\nl 48 75 75 3 50\r\nl 93 76 25 71 31\r\ns 60 92 64 66 11\r\nl 61 47 6 21 83\r\nl 68 1 47 81 78\r\nl 8 72 54 20 25";

            Assert.Throws<Exception>(() => examintaionProcessor.GetPassedCount(input));
            var ex = Assert.Throws<Exception>(() => examintaionProcessor.GetPassedCount(input));
            Assert.That(ex.Message, Is.EqualTo("Input string has incorrect format:l F 67 39 85 87\r"));
        }

        [Test]
        public void ScoresAreNotCorrect()
        {
            IExaminationProcessor examintaionProcessor = new ExaminationProcessor();
            string input = "20\r\nl 34 67 3985 87\r\ns 38 75 75 45 90\r\nl 43 95 7 35 49\r\nl 82 77 74 35 44\r\ns 96 80 92 58 84\r\nl 23 60 44 27 3\r\nl 42 24 52 23 63\r\ns 44 78 98 51 10\r\nl 93 38 73 88 12\r\nl 34 29 43 48 61\r\nl 83 33 97 3 59\r\nl 24 84 22 35 33\r\ns 81 42 80 34 87\r\nl 8 87 82 80 100\r\nl 48 75 75 3 50\r\nl 93 76 25 71 31\r\ns 60 92 64 66 11\r\nl 61 47 6 21 83\r\nl 68 1 47 81 78\r\nl 8 72 54 20 25";

            Assert.Throws<Exception>(() => examintaionProcessor.GetPassedCount(input));
            var ex = Assert.Throws<Exception>(() => examintaionProcessor.GetPassedCount(input));
            Assert.That(ex.Message, Is.EqualTo("Input string has incorrect format:l 34 67 3985 87\r"));
        }
    }
}
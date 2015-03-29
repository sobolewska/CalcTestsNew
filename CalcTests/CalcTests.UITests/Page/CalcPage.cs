using System.Diagnostics;
using CalcTests.UITests.Model;

namespace CalcTests.UITests.Page
{
    public class CalcPage : IPage
    {
        private CalcModel _calcModel;
        private Process _process;

        public CalcPage()
        {
            Init();
        }

        public string Id
        {
            get { return GetType().FullName; }
        }

        private void Init()
        {
            _process = Process.Start("calc");
            _calcModel = new CalcModel();
            _calcModel.WaitForExistance();
            _calcModel.WaitForEnabled();
        }

        private void PressOne()
        {
            _calcModel.BtnOne.Click();
        }

        private void PressTwo()
        {
            _calcModel.BtnTwo.Click();
        }

        private void PressPlMin()
        {
            _calcModel.PlMin.Click();
        }

        private void PressNumber(int number)
        {
            switch (number)
            {
                case 1:
                    PressOne();
                    break;
                case 2:
                    PressTwo();
                    break;
                case -1:
                    PressOne();
                    PressPlMin();
                    break;
                case -2:
                    PressTwo();
                    PressPlMin();
                    break;
            }
        }

        public void Add(int first, int second)
        {
            PressNumber(first);
            _calcModel.Plus.Click();
            PressNumber(second);
            _calcModel.EqualsBtn.Click();
        }

        public string GetResult()
        {
            return _calcModel.Result.GetText();
        }

        public void Close()
        {
            _process.CloseMainWindow();
            _process.Close();
        }
    }
}
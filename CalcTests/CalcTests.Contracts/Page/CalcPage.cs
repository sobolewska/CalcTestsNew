using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcTests.Contracts.Model;

namespace CalcTests.Contracts.Page
{
    public class CalcPage : IPage
    {
        private Calc _calcModel;

        private void PressOne()
        {
            _calcModel.BtnOne.Click();
        }

        private void PressTwo()
        {
            _calcModel.BtnTwo.Click();
        }

        private void PressNumber(int number)
        {
            switch (number)
            {
                case 1 :
                    PressOne();
                    break;
                case 2 :
                    PressTwo();
                    break;
                default :
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

        public string Id
        {
            get { return "Calck"; }
        }

        public void Init()
        {
            System.Diagnostics.Process.Start("calc");
            _calcModel = new Calc();
            _calcModel.WaitForExistance();
            _calcModel.WaitForEnabled();
        }
    }
}

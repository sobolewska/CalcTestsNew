using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIElementsStub;

namespace CalcTests.Contracts.Model
{
    public class Calc : Pane
    {
        public Text Result { get; set; }
        public Button Plus { get; set; }
        public Button BtnOne { get; set; }
        public Button BtnTwo { get; set; }
        public Button EqualsBtn { get; set; }
        
        public Calc()
            : base(null, new Root(), "Kalkulator")
        {
            Result = new Text("150", this);
            Plus = new Button("93", this);
            BtnOne = new Button("131", this);
            BtnTwo = new Button("132", this);
            EqualsBtn = new Button("121", this);

            ElementsToWaitFor.AddRange(new IElement[] {
                this,
                Result,
                Plus,
                BtnOne,
                BtnTwo,
                EqualsBtn
            });
        }
    }
}

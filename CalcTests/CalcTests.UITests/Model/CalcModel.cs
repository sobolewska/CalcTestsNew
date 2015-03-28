using UIElementsStub;

namespace CalcTests.UITests.Model
{
    public class CalcModel : Pane
    {
        public CalcModel()
            : base(null, new Root(), "Kalkulator")
        {
            Result = new Text("150", this);
            Plus = new Button("93", this);
            BtnOne = new Button("131", this);
            BtnTwo = new Button("132", this);
            EqualsBtn = new Button("121", this);
            PlMin = new Button("80", this);

            ElementsToWaitFor.AddRange(new IElement[]
            {
                Result,
                Plus,
                BtnOne,
                BtnTwo,
                EqualsBtn,
                PlMin
            });
        }

        public Text Result { get; set; }
        public Button Plus { get; set; }
        public Button BtnOne { get; set; }
        public Button BtnTwo { get; set; }
        public Button EqualsBtn { get; set; }
        public Button PlMin { get; set; }
    }
}
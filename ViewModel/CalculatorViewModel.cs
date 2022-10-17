using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalculatorV2.ViewModel.Common;
using CalculatorV2.Model;
using System.Security.Policy;

// use a different calculator mode
namespace CalculatorV2.ViewModel
{
    public class CalculatorViewModel : NotificationObject
    {
        private CalculatorData calculatorData = new CalculatorData();

        public CalculatorViewModel()
        {
            calculatorData.num1 = 0;
            calculatorData.num2 = 0;
            calculatorData.result = 0;
            calculateLine = "test";
        }


        string textLine;
        public string TextLine
        {
            set { textLine = value; this.RaisePropertyChanged("textLine");  }
            get { return textLine; }
        }
        string calculateLine;
        public string CalculateLine
        {
            set { calculateLine = value; this.RaisePropertyChanged("calculateLine"); }
            get { return calculateLine; }
        }

        private BaseCommand clickEnter;
        public BaseCommand ClickEnter
        {
            get
            {
                if (clickEnter == null)
                {
                    clickEnter = new BaseCommand(new Action<object>(o =>
                    {
                        calculateLine = "teststestt";
                        textLine += calculateLine;
                        textLine += "\n";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickEnter;
            }
        }
        private BaseCommand clickClear;
        public BaseCommand ClickClear
        {
            get
            {
                if (clickClear == null)
                {
                    clickClear = new BaseCommand(new Action<object>(o =>
                    {
                        calculateLine = "";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickClear;
            }
        }
        private BaseCommand clickDelete;
        public BaseCommand ClickDelete
        {
            get
            {
                if (clickDelete == null)
                {
                    clickDelete = new BaseCommand(new Action<object>(o =>
                    {
                        // when empty, don't remove
                        if (calculateLine == "")
                            return;
                        calculateLine = calculateLine.Remove(CalculateLine.Length-1);
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickDelete;
            }
        }

        private BaseCommand clickMul;
        public BaseCommand ClickMul
        {
            get
            {
                if (clickMul == null)
                { 
                    clickMul = new BaseCommand(new Action<object>(o =>
                    {
                        calculateLine += "*";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickMul;
            }
        }
        private BaseCommand clickSub;
        public BaseCommand ClickSub
        {
            get
            {
                if (clickSub == null)
                {
                    clickSub = new BaseCommand(new Action<object>(o =>
                    {
                        calculateLine += "-";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickSub;
            }
        }
        private BaseCommand clickAdd;
        public BaseCommand ClickAdd
        {
            get
            {
                if (clickAdd == null)
                {
                    clickAdd = new BaseCommand(new Action<object>(o =>
                    {
                        calculateLine += "*";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickAdd;
            }
        }
        private BaseCommand clickDiv;
        public BaseCommand ClickDiv
        {
            get
            {
                if (clickDiv == null)
                {
                    clickDiv = new BaseCommand(new Action<object>(o =>
                    {
                        calculateLine += "/";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickDiv;
            }
        }

        private BaseCommand clickDot;
        public BaseCommand ClickDot
        {
            get
            {
                if (clickDot == null)
                {
                    clickDot = new BaseCommand(new Action<object>(o =>
                    {
                        // add dot only when there are something
                        if (calculateLine == "")
                            return;
                        calculateLine += ".";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickDot;
            }
        }

        private BaseCommand clickDataButton0;
        public BaseCommand ClickDataButton0
        {
            get
            {
                if (clickDataButton0 == null)
                {
                    clickDataButton0 = new BaseCommand(new Action<object>(o =>
                    {
                        // 0 is only add to string when begin with real num.
                        if (calculateLine == "")
                            return;
                        calculateLine += "0";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickDataButton0;
            }
        }
        private BaseCommand clickDataButton1;
        public BaseCommand ClickDataButton1
        {
            get
            {
                if (clickDataButton1 == null)
                {
                    clickDataButton1 = new BaseCommand(new Action<object>(o =>
                    {
                        calculateLine += "1";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickDataButton1;
            }
        }
        private BaseCommand clickDataButton2;
        public BaseCommand ClickDataButton2
        {
            get
            {
                if (clickDataButton2 == null)
                {
                    clickDataButton2 = new BaseCommand(new Action<object>(o =>
                    {
                        calculateLine += "2";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickDataButton2;
            }
        }
        private BaseCommand clickDataButton3;
        public BaseCommand ClickDataButton3
        {
            get
            {
                if (clickDataButton3 == null)
                {
                    clickDataButton3 = new BaseCommand(new Action<object>(o =>
                    {
                        calculateLine += "3";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickDataButton3;
            }
        }
        private BaseCommand clickDataButton4;
        public BaseCommand ClickDataButton4
        {
            get
            {
                if (clickDataButton4 == null)
                {
                    clickDataButton4 = new BaseCommand(new Action<object>(o =>
                    {
                        calculateLine += "4";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickDataButton4;
            }
        }
        private BaseCommand clickDataButton5;
        public BaseCommand ClickDataButton5
        {
            get
            {
                if (clickDataButton5 == null)
                {
                    clickDataButton5 = new BaseCommand(new Action<object>(o =>
                    {
                        calculateLine += "5";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickDataButton5;
            }
        }
        private BaseCommand clickDataButton6;
        public BaseCommand ClickDataButton6
        {
            get
            {
                if (clickDataButton6 == null)
                {
                    clickDataButton6 = new BaseCommand(new Action<object>(o =>
                    {
                        calculateLine += "6";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickDataButton6;
            }
        }
        
        private BaseCommand clickDataButton7;
        public BaseCommand ClickDataButton7
        {
            get
            {
                if (clickDataButton7 == null)
                {
                    clickDataButton7 = new BaseCommand(new Action<object>(o =>
                    {
                        calculateLine += "7";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickDataButton7;
            }

        }
        
        
        private BaseCommand clickDataButton8;
        public BaseCommand ClickDataButton8
        {
            get
            {
                if (clickDataButton8 == null)
                {
                    clickDataButton8 = new BaseCommand(new Action<object>(o =>
                    {
                        calculateLine += "8";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickDataButton8;
            }
        }
        private BaseCommand clickDataButton9;
        public BaseCommand ClickDataButton9
        {
            get
            {
                if (clickDataButton9 == null)
                {
                    clickDataButton9 = new BaseCommand(new Action<object>(o =>
                    {
                        calculateLine += "9";
                        this.RaisePropertyChanged("calculateLine");
                    }));
                }
                return clickDataButton9;
            }
        }

    
    


        public double Num1
        {
            get
            {
                return calculatorData.num1;
            }
            set
            {
                calculatorData.num1 = value;
                this.RaisePropertyChanged("num1");
            }
        }
        public double Num2
        {
            get
            {
                return calculatorData.num2;
            }
            set
            {
                calculatorData.num2 = value;
                this.RaisePropertyChanged("num2");
            }
        }

        public double Result
        {
            get
            {
                return calculatorData.result;
            }
            set
            {
                calculatorData.result = value;
                this.RaisePropertyChanged("result");
            }
        }


    }
}

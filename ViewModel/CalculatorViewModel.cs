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
            calculatorData.processLine = "test";
            calculatorData.historyLine = "history test";
        }

        public string HistoryLine
        {
            set { calculatorData.historyLine = value; this.RaisePropertyChanged("historyLine"); }
            get { return calculatorData.historyLine; }
        }
        public string ProcessLine
        {
            set { calculatorData.processLine = value; this.RaisePropertyChanged("processLine"); }
            get { return calculatorData.processLine; }
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
                        calculatorData.DoCalculate();
                        calculatorData.historyLine += ("\n" + calculatorData.processLine + '=' + calculatorData.result);
                        calculatorData.processLine = "";
                        this.RaisePropertyChanged("processLine");
                        this.RaisePropertyChanged("historyLine");
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
                        calculatorData.processLine = "";
                        this.RaisePropertyChanged("processLine");
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
                        if (calculatorData.processLine == "")
                            return;
                        calculatorData.processLine = calculatorData.processLine.Remove(calculatorData.processLine.Length-1);
                        this.RaisePropertyChanged("processLine");
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
                        calculatorData.processLine += "*";
                        this.RaisePropertyChanged("processLine");
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
                        calculatorData.processLine += "-";
                        this.RaisePropertyChanged("processLine");
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
                        calculatorData.processLine += "+";
                        this.RaisePropertyChanged("processLine");
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
                        calculatorData.processLine += "/";
                        this.RaisePropertyChanged("processLine");
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
                        if (calculatorData.processLine == "")
                            return;
                        calculatorData.processLine += ".";
                        this.RaisePropertyChanged("processLine");
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
                        if (calculatorData.processLine == "")
                            return;
                        calculatorData.processLine += "0";
                        this.RaisePropertyChanged("processLine");
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
                        calculatorData.processLine += "1";
                        this.RaisePropertyChanged("processLine");
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
                        calculatorData.processLine += "2";
                        this.RaisePropertyChanged("processLine");
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
                        calculatorData.processLine += "3";
                        this.RaisePropertyChanged("processLine");
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
                        calculatorData.processLine += "4";
                        this.RaisePropertyChanged("processLine");
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
                        calculatorData.processLine += "5";
                        this.RaisePropertyChanged("processLine");
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
                        calculatorData.processLine += "6";
                        this.RaisePropertyChanged("processLine");
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
                        calculatorData.processLine += "7";
                        this.RaisePropertyChanged("processLine");
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
                        calculatorData.processLine += "8";
                        this.RaisePropertyChanged("processLine");
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
                        calculatorData.processLine += "9";
                        this.RaisePropertyChanged("processLine");
                    }));
                }
                return clickDataButton9;
            }
        }

    }
}

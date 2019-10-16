
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Input;
namespace WpfUnitConverter.ViewModels
{
    
    public class UnitConverterViewModel : ObservableObject
    {
        public ICommand ButtonConvertCommand { get; set; }
        public ICommand PickedOperandUnit { get; set; }

        private double _result;

        public double Operand { get; set; }
        public string OperandUnit { get; set; }
        public string ResultUnit { get; set; }
        public double Result { get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }
        public List<string> Units { get; set; }


        private List<string> BuildOutUnitComboBoxSource()
        {
            return new List<string>() { "Inches", "Feet", "Miles", "Millimeters", "Centimeters", "Meters", "Kilometers" };
        }
        private void PerformCalculation(object obj)
        {
            Result = 0;
            #region Math
            switch (OperandUnit) {
                case "Inches":
                    if(ResultUnit == null || ResultUnit == "")
                    {
                        Result = 0;
                    }
                    else
                    {
                        switch (ResultUnit)
                        {
                            case "Inches":
                                Result = Operand;
                                break;
                            case "Feet":
                                Result = Operand * 0.084;
                                break;
                            case "Miles":
                                Result = Operand / 63360;
                                break;
                            case "Millimeters":
                                Result = Operand * 25.4;
                                break;
                            case "Centimeters":
                                Result = Operand *  2.54;
                                break;
                            case "Meters":
                                Result = Operand / 39.37;
                                break;
                            case "Kilometers":
                                Result = Operand / 39370.079;
                                break;
                        }
                    }
                    #endregion

                    break;
                case "Feet":
                    #region Math
                    if (ResultUnit == null || ResultUnit == "")
                    {
                        Result = 0;
                    }
                    else
                    {
                        switch (ResultUnit)
                        {
                            case "Inches":
                                Result = Operand * 12;
                                break;
                            case "Feet":
                                Result = Operand;
                                break;
                            case "Miles":
                                Result = Operand / 5280;
                                break;
                            case "Millimeters":
                                Result = Operand * 304.8;
                                break;
                            case "Centimeters":
                                Result = Operand * 30.48;
                                break;
                            case "Meters":
                                Result = Operand / 3.281;
                                break;
                            case "Kilometers":
                                Result = Operand / 3280.84;
                                break;
                        }
                    }
                    #endregion
                    break;
                case "Miles":
                    #region Math
                    if (ResultUnit == null || ResultUnit == "")
                    {
                        Result = 0;
                    }
                    else
                    {
                        switch (ResultUnit)
                        {
                            case "Inches":
                                Result = Operand * 63360;
                                break;
                            case "Feet":
                                Result = Operand * 5280;
                                break;
                            case "Miles":
                                Result = Operand;
                                break;
                            case "Millimeters":
                                Result = Operand * 1.609e+6;
                                break;
                            case "Centimeters":
                                Result = Operand * 160934.4;
                                break;
                            case "Meters":
                                Result = Operand * 1609.344;
                                break;
                            case "Kilometers":
                                Result = Operand * 1.609;
                                break;
                        }
                    }
                        #endregion
                        break;
                case "Millimeters":
                    #region Math
                    if (ResultUnit == null || ResultUnit == "")
                    {
                        Result = 0;
                    }
                    else
                    {
                        switch (ResultUnit)
                        {
                            case "Inches":
                                Result = Operand * 25.4;
                                break;
                            case "Feet":
                                Result = Operand / 304.8;
                                break;
                            case "Miles":
                                Result = Operand / 1.609e+6;
                                break;
                            case "Millimeters":
                                Result = Operand;
                                break;
                            case "Centimeters":
                                Result = Operand / 10;
                                break;
                            case "Meters":
                                Result = Operand /1000;
                                break;
                            case "Kilometers":
                                Result = Operand / 1e+6;
                                break;
                        }
                    }
                        #endregion
                        break;
                case "Centimeters":
                    #region Math
                    if (ResultUnit == null || ResultUnit == "")
                    {
                        Result = 0;
                    }
                    else
                    {
                        switch (ResultUnit)
                        {
                            case "Inches":
                                Result = Operand / 2.54;
                                break;
                            case "Feet":
                                Result = Operand / 30.48;
                                break;
                            case "Miles":
                                Result = Operand / 160934.4;
                                break;
                            case "Millimeters":
                                Result = Operand / 10;
                                break;
                            case "Centimeters":
                                Result = Operand;
                                break;
                            case "Meters":
                                Result = Operand / 100;
                                break;
                            case "Kilometers":
                                Result = Operand / 100000;
                                break;
                        }
                    }
                    #endregion
                    break;
                case "Meters":
                    #region Math
                    if (ResultUnit == null || ResultUnit == "")
                    {
                        Result = 0;
                    }
                    else
                    {
                        switch (ResultUnit)
                        {
                            case "Inches":
                                Result = Operand * 39.37;
                                break;
                            case "Feet":
                                Result = Operand * 3.281;
                                break;
                            case "Miles":
                                Result = Operand / 1609.344;
                                break;
                            case "Millimeters":
                                Result = Operand * 1000;
                                break;
                            case "Centimeters":
                                Result = Operand * 100;
                                break;
                            case "Meters":
                                Result = Operand;
                                break;
                            case "Kilometers":
                                Result = Operand / 1000;
                                break;
                        }
                    }
                    #endregion
                    break;
                case "Kilometers":
                    #region Math
                    if (ResultUnit == null || ResultUnit == "")
                    {
                        Result = 0;
                    }
                    else
                    {
                        switch (ResultUnit)
                        {
                            case "Inches":
                                Result = Operand * 39370.079;
                                break;
                            case "Feet":
                                Result = Operand * 3280.84;
                                break;
                            case "Miles":
                                Result = Operand / 1.609;
                                break;
                            case "Millimeters":
                                Result = Operand * 1e+6;
                                break;
                            case "Centimeters":
                                Result = Operand * 100000;
                                break;
                            case "Meters":
                                Result = Operand * 1000;
                                break;
                            case "Kilometers":
                                Result = Operand;
                                break;
                        }
                    }
                    #endregion
                    break;
            }

        }

        public UnitConverterViewModel()
        {
            Operand = 0;
            Units = BuildOutUnitComboBoxSource();
            ButtonConvertCommand = new RelayCommand(new Action<object>(PerformCalculation));
        }

    }
}

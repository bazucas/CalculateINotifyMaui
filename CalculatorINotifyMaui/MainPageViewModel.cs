using PropertyChanged;
using System.Windows.Input;

namespace CalculatorINotifyMaui;

[AddINotifyPropertyChangedInterface]
public class MainPageViewModel
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }
    public int Result { get; set; }

    public ICommand AddCommand => new Command(() => Result = Number1 + Number2);
}
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ContentViewReuse;

public class MainViewModel : INotifyPropertyChanged
{
    private string _itemNr = "42";
    public string ItemNr
    {
        get => _itemNr;
        set
        {
            if (_itemNr != value)
            {
                _itemNr = value;
                OnPropertyChanged();
            }
        }
    }

    #region INotifyPropertyChanged implementation
    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    #endregion

}
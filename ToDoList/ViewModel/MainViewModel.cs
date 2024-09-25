using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;



namespace ToDoList.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel() { 
            items=new ObservableCollection<string>();
        }

       [ObservableProperty]
       ObservableCollection<string> items;
        
       [ObservableProperty]
       private string text;


       [RelayCommand]
       private void Add()
       {
            if (string.IsNullOrWhiteSpace(Text))
                return;
            
            items.Add(Text);
          Text = string.Empty;
       }
        [RelayCommand]
        void Delete(string d)
        {
            if (items.Contains(d)) 
            {
                Items.Remove(d);
            }
        }
    }
}

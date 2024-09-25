using ToDoList.ViewModel;

namespace ToDoList
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext= (vm);
        }

     
    }

}

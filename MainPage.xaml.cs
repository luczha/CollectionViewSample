using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Runtime.CompilerServices;

namespace App6
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();



            BindingContext = new VM_CounterList();



        }
    }

    public class VM_CounterList
    {
      

        public ObservableCollection<AlbumsForList> albumList { get; set; }


        public VM_CounterList()
        {
            albumList = new ObservableCollection<AlbumsForList>() {


                 new AlbumsForList(){ 
                 
                     Name="No.1",
                     DemoImage = "screen.png",
                     Pictures = new ObservableCollection<SinglePicture>{ new SinglePicture() {ImageSource="screen.png" },new SinglePicture() {ImageSource="screen.png" },new SinglePicture() {ImageSource="screen.png" },new SinglePicture() {ImageSource="screen.png" },new SinglePicture() {ImageSource="screen.png" },new SinglePicture() {ImageSource="screen.png" } },
                 },

                 new AlbumsForList(){

                     Name="No.1",
                     DemoImage = "screen.png",
                     Pictures = new ObservableCollection<SinglePicture>{ new SinglePicture() {ImageSource="screen.png" },new SinglePicture() {ImageSource="screen.png" },new SinglePicture() {ImageSource="screen.png" },new SinglePicture() {ImageSource="screen.png" },new SinglePicture() {ImageSource="screen.png" },new SinglePicture() {ImageSource="screen.png" } },
                 },

                 new AlbumsForList(){

                     Name="No.1",
                     DemoImage = "screen.png",
                     Pictures = new ObservableCollection<SinglePicture>{ new SinglePicture() {ImageSource="screen.png" },new SinglePicture() {ImageSource="screen.png" },new SinglePicture() {ImageSource="screen.png" },new SinglePicture() {ImageSource="screen.png" },new SinglePicture() {ImageSource="screen.png" },new SinglePicture() {ImageSource="screen.png" } },
                 },

                 new AlbumsForList(){

                     Name="No.1",
                     DemoImage = "screen.png",
                     Pictures = new ObservableCollection<SinglePicture>{ new SinglePicture() {ImageSource="screen.png" },new MyImage() {ImageSource="screen.png" },new MyImage() {ImageSource="screen.png" },new MyImage() {ImageSource="screen.png" },new MyImage() {ImageSource="screen.png" },new MyImage() {ImageSource="screen.png" } },
                 },

            };


            
        }

    }

    public class AlbumsForList : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Name { get; set; }

        public ObservableCollection<SinglePicture> Pictures { get; set; }

        private string demoImage;
        public string DemoImage
        {
            set
            {
                if (demoImage != value)
                {
                    demoImage = value;
                    NotifyPropertyChanged("DemoImage");
                }
            }
            get { return demoImage; }
        }
    }
      

    public class SinglePicture : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        

        private string imageSource;
        public string ImageSource
        {
            set
            {
                if (imageSource != value)
                {
                    imageSource = value;
                    NotifyPropertyChanged("ImageSource");
                }
            }
            get { return imageSource; }
        }
    }


  
}

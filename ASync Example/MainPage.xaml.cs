using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Declare the required namespaces
using System.Threading.Tasks;
using Windows.UI.Popups;
using System.Net.Http;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
namespace ASync_Example
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly ASyncExamples ASyncExample = new ASyncExamples();

        public MainPage()
        {
            this.InitializeComponent();
        }

        //Usuaully avoid async voids, they're sluggish. However we can get away with it in the case of control events
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //Await Request Content as a String
            string ExampleTask = await ASyncExample.PostMethod();

            //Handle the result if null or empty and display in the textblock
            if (ExampleTask?.Length == 0)
            {
                textBlock.Text = "Something's broken...";
            }
            else
            {
                textBlock.Text = ExampleTask;
            }
        }

        private async void Button1_Click(object sender, RoutedEventArgs e)
        {
           //Place Holder for alternative ASync Method 
        }
    }
}

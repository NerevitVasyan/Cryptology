using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptLibrary;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndroidCrypto
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InputPage : ContentPage
	{
        List<string> algorithms;
          
         public InputPage ()
		{
			InitializeComponent ();
            algorithms = new List<string>
            {
                "Caesar",
                "XOR"
            };
            Pick.ItemsSource = algorithms;
            Pick.SelectedIndex = 0;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            CryptLibrary.ICryptService ser = new Caesar();
            OutputPage p = new OutputPage();
            InputText.Text = ser.Crypt(InputText.Text, KeyInput.Text);
        }
        private void EncryptClick(object sender, EventArgs e)
        {
            CryptLibrary.ICryptService ser = new Caesar();
            InputText.Text = ser.Decrypt(InputText.Text, KeyInput.Text);
            
        }
    }
}
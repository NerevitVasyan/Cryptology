using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndroidCrypto
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OutputPage : ContentPage
	{
        public Label label2;
		public OutputPage ()
		{
			InitializeComponent ();
            label2 = Label1;
        }
	}
}
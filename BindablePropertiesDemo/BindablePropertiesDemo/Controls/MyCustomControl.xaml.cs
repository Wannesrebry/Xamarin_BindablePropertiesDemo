using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindablePropertiesDemo.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCustomControl : ContentView
    {
        #region Title Property
        public static readonly BindableProperty TitleTextProperty = BindableProperty.Create(
            nameof(TitleText), // getter name
            typeof(string), // type 
            typeof(MyCustomControl), // Control class
            defaultValue: string.Empty,
            defaultBindingMode: BindingMode.OneWay, // default OneWay
            propertyChanged: TitleTextPropertyChanged
        );

        private static void TitleTextPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var control = (MyCustomControl) bindable;
            control.Title.Text = newvalue?.ToString();
        }

        public string TitleText
        {
            get
            {
                return base.GetValue(TitleTextProperty)?.ToString();
            }
            set
            {
                base.SetValue(TitleTextProperty, value);
            }
        }
        #endregion

        #region Description Property

        public static readonly BindableProperty DescriptionTextProperty = BindableProperty.Create(
            nameof(DescriptionText), // getter name
            typeof(string), // type 
            typeof(MyCustomControl), // Control class
            defaultValue: string.Empty,
            defaultBindingMode: BindingMode.OneWay, // default OneWay
            propertyChanged: DescriptionTextPropertyChanged
        );

        private static void DescriptionTextPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var control = (MyCustomControl) bindable;
            control.Description.Text = newvalue?.ToString();
        }

        public string DescriptionText
        {
            get
            {
                return base.GetValue(DescriptionTextProperty)?.ToString();
            }
            set
            {
                base.SetValue(DescriptionTextProperty, value);
            }
        }

        #endregion

        public MyCustomControl()
        {
            InitializeComponent();
        }
    }
}
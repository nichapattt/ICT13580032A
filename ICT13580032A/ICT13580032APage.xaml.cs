using Xamarin.Forms;

namespace ICT13580032A
{
    public partial class ICT13580032APage : ContentPage
    {
        public ICT13580032APage()
        {
            InitializeComponent();

            okButton.Clicked += OkButton_Clicked;

            gendarPicker.Items.Add("ชาย");
            gendarPicker.Items.Add("หญิง");

            mySlider.ValueChanged += MySlider_ValueChanged;

            myStepper.ValueChanged += MyStepper_ValueChanged;
        }

        void OkButton_Clicked(object sender, System.EventArgs e)
        {
            firstNameLabel.Text = firstNameEntey.Text;
        }

        void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }

        void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }
    }
}

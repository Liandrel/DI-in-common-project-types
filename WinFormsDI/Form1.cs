using DIDemoLib;

namespace WinFormsDI
{
    public partial class Form1 : Form
    {
        private readonly IMesseges _messeges;

        public Form1(IMesseges messeges)
        {
            InitializeComponent();
            _messeges = messeges;

            helloText.Text = _messeges.SayHello();
            goodbyeText.Text = _messeges.SayGoodBye();
        }
    }
}
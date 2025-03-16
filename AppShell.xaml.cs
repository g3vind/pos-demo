using System.Diagnostics;

namespace pos_demo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }
        private void OnPointerEntered(object sender, PointerEventArgs e)
        {
            if (FooterFrame != null)
            {
                FooterFrame.HasShadow = true;
                FooterFrame.BackgroundColor = Colors.LightGray; // Change background on hover
            }
        }

        private void OnPointerExited(object sender, PointerEventArgs e)
        {
            if (FooterFrame != null)
            {
                FooterFrame.HasShadow = false;
                FooterFrame.BackgroundColor = Colors.Transparent; // Revert background
            }

        }
        private void OnPhoneTapped(object sender, EventArgs e)
        {
            try
            {
                Launcher.OpenAsync("tel:+91 6206359037"); // Open dialer with the number
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error launching dialer: " + ex.Message);
            }
        }

    }
}

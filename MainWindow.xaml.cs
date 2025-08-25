using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Contract_Monthly_Claim_System
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContent.Content = new RoleSelectionPage(); // Start with role selection
            HideAllButtons();
        }

        private void HideAllButtons()
        {
            btnSubmit.Visibility = Visibility.Collapsed;
            btnApprove.Visibility = Visibility.Collapsed;
            btnUpload.Visibility = Visibility.Collapsed;
            btnTrack.Visibility = Visibility.Collapsed;
        }

        public void SetRole(string role)
        {
            HideAllButtons();

            if (role == "Lecturer")
            {
                btnSubmit.Visibility = Visibility.Visible;
                btnUpload.Visibility = Visibility.Visible;
                btnTrack.Visibility = Visibility.Visible;
            }
            else if (role == "Coordinator")
            {
                btnApprove.Visibility = Visibility.Visible;
                btnTrack.Visibility = Visibility.Visible;
            }
            else if (role == "Manager")
            {
                btnApprove.Visibility = Visibility.Visible;
                btnTrack.Visibility = Visibility.Visible;
            }

            // Load the default first page
            MainContent.Content = null;
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new SubmitClaim();
        }

        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ApproveClaimPage();
        }

        private void UploadDocs_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new UploadDocumentsPage();
        }

        private void TrackStatus_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new TrackStatusPage();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            // Reset to role selection page
            MainContent.Content = new RoleSelectionPage();
            HideAllButtons();  // Hide navigation buttons again
        }
    }
}
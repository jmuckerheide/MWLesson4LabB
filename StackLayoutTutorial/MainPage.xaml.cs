using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StackLayoutTutorial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //string userTitle = "";
        //string userDescription = "";
        void User_review(object sender, System.EventArgs e)
        {
            //UserTitle();
            //UserDescription();
            string userT = "";
            string userD = "";
            userTitle.Text = ((Button)sender).Text;
            userDescription.Text = ((Button)sender).Text;

            userT = userTitle.Text;
            userD = userDescription.Text;

            userPost.Text = userT + ": " + userD;


        }
        void UserTitle() 
        {
            var userTitle = "";
            //userTitle.Text = userTitle; 
        }
        void UserDescription() { }
        void Handle_Post() 
        {
        
        }
    }
}

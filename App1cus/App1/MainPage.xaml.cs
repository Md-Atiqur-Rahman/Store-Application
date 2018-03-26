using App1.ServiceReference1;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ServiceReference1.Service1SoapClient client = new ServiceReference1.Service1SoapClient();

        public MainPage()
        {
            this.InitializeComponent();


            SortedSet<string> Country = new SortedSet<string> {"Bangladesh",
                "India",
                "Canada",
                "Japan",
                "China",
                "Spain",
                "Italy",
                "Australia",
                "Switzerland",
                "Iran",
                "South Korea"};
            textcomboCountry.ItemsSource = Country;
            //ClearControl();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {

            try
            {


                Customer Cus = new Customer();
                Cus.CID= int.Parse(textid.Text);
                Cus.CName = textName.Text;
                Cus.Country = textcomboCountry.SelectedItem.ToString();
                Cus.PinCode = textpin.Text;
                Cus.City = textCity.Text;
                Cus.Addresss = textAdd.Text;
                Cus.phone_Number =int.Parse(textPhone.Text);
                Cus.Email = textEmail.Text;


                var result = client.InsertAsync(Cus);
                

                if (result.Result.Body.InsertResult > 0)
                {
                    Windows.UI.Popups.MessageDialog mesg = new Windows.UI.Popups.MessageDialog("Saved Success");
                    mesg.ShowAsync();
                    ClearControl();
                }
                else
                {
                    Windows.UI.Popups.MessageDialog mesg = new Windows.UI.Popups.MessageDialog("Saved Failed");
                    mesg.ShowAsync();
                }
            }
            catch (Exception ex)
            {
                Windows.UI.Popups.MessageDialog mesg = new Windows.UI.Popups.MessageDialog(ex.Message.ToString());
                mesg.ShowAsync();
            }


        }


        private void ClearControl()
        {
            
            textid.Text="";
            textName.Text = "";
            textcomboCountry.PlaceholderText = "";
            textpin.Text = "";
            textCity.Text = "";
            textAdd.Text = "";
            textPhone.Text = "";
            textEmail.Text="";
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                Customer Cus = new Customer();
                Cus.CID = int.Parse(textid.Text);
                Cus.CName = textName.Text;
                Cus.Country = textcomboCountry.SelectedItem.ToString();
                Cus.PinCode = textpin.Text;
                Cus.City = textCity.Text;
                Cus.Addresss = textAdd.Text;
                Cus.phone_Number = int.Parse(textPhone.Text);
                Cus.Email = textEmail.Text;

                var result = client.UpdateAsync(Cus, int.Parse(textid.Text));
                if (result.Result.Body.UpdateResult > 0)
                {
                    Windows.UI.Popups.MessageDialog mesg = new Windows.UI.Popups.MessageDialog("UpDate Complete");
                    mesg.ShowAsync();
                    ClearControl();
                }
                else
                {
                    Windows.UI.Popups.MessageDialog mesg = new Windows.UI.Popups.MessageDialog("UpDate Failed");
                    mesg.ShowAsync();
                }
            }
            catch(Exception ex)
            {
                Windows.UI.Popups.MessageDialog mesg = new Windows.UI.Popups.MessageDialog(ex.Message.ToString());
                mesg.ShowAsync();
            }
           
        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                var emp = client.SearchAsync(int.Parse(textid.Text));

                Customer ct = emp.Result.Body.SearchResult;
                this.DataContext = ct;
               

                if (int.Parse(textid.Text) == 0)
                {
                    Windows.UI.Popups.MessageDialog mesg = new Windows.UI.Popups.MessageDialog("Data Not found");
                    mesg.ShowAsync();
                    

                }

            }
            catch (Exception ex)
            {
                Windows.UI.Popups.MessageDialog mesg = new Windows.UI.Popups.MessageDialog("not Found");
                mesg.ShowAsync();
            }


        }

        private async  void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int result = await  client.DeleteAsync(int.Parse(textid.Text));
           if(result>0)
           {
               Windows.UI.Popups.MessageDialog m = new Windows.UI.Popups.MessageDialog("Deleted");
             await   m.ShowAsync();
           }
            else
           {
               Windows.UI.Popups.MessageDialog m = new Windows.UI.Popups.MessageDialog("Error");
               await m.ShowAsync();
           }
            ClearControl();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearControl();
        }

        
    }
}

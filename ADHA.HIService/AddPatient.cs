using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Security.Cryptography.X509Certificates;
using nehta.mcaR3.ConsumerSearchIHI;
using Nehta.VendorLibrary.Common;
using Nehta.VendorLibrary.HI;

namespace ADHA.HIService
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }

        private void btnIHILookup_Click(object sender, EventArgs e)
        {
            // Obtain the certificate by serial number
            X509Certificate2 tlsCert = X509CertificateUtil.GetCertificate(
                "2f6a",
                X509FindType.FindBySerialNumber,
                StoreName.My,
                StoreLocation.CurrentUser,
                true
                );

            // The same certificate is used for signing the request.
            // This certificate will be different to TLS cert for some operations.
            X509Certificate2 signingCert = tlsCert;

            // Set up client product information (PCIN)
            // Values below should be provided by Medicare
            ProductType product = new ProductType()
            {
                platform = "windows 10",              // Can be any value
                productName = "Telecare Connect",               // Provided by Medicare
                productVersion = "1.0",            // Provided by Medicare
                vendor = new QualifiedId()
                {
                    id = "TEE00000",                    // Provided by Medicare               
                    qualifier = "http://ns.electronichealth.net.au/id/hi/vendorid/1.0"                          // Provided by Medicare
                }
            };

            // Set up user identifier details
            QualifiedId user = new QualifiedId()
            {
                id = "User Id",                 // User ID internal to your system
                qualifier = "http://<anything>/id/<anything>/userid/1.0"
                // Eg: http://ns.yourcompany.com.au/id/yoursoftware/userid/1.0
            };

            // Set up organisation identifier details, only required for CSP software. If run as a CSP software, the certificate needs to be a CSP certificate

            //QualifiedId hpio = new QualifiedId()
            //{
            //    id = "", // HPIO internal to your system
            //    qualifier = "" // Eg: http://ns.yourcompany.com.au/id/yoursoftware/userid/1.0
            //};

            // Instantiate the client
            ConsumerSearchIHIClient client = new ConsumerSearchIHIClient(
                new Uri("https://www5.medicareaustralia.gov.au/cert/soap/services/"),
                product,
                user,
                null, // or hpio if implemented as a CSP software
                signingCert,
                tlsCert);

            // Set up the request IHI
            searchIHI request = new searchIHI();

            request.medicareCardNumber = txtMedicareNo.Text;
            request.dateOfBirth = DateTime.Parse(txtDob.Text);
            request.givenName = txtGivenName.Text;
            request.familyName = txtFamilyName.Text;
            request.familyName = txtFamilyName.Text;
            request.medicareIRN = txtMedicareIRN.Text; // optional. Please provide any value otherwise comment out this code as sending blank IRN in the request returns format error.

            // For the sake of simplicity, example use simple text box with the following options. 
            // M - Male
            // F - Female
            // I - Intersex or Indeterminate
            // N - No stated. 
            // In actual CIS software, Select list / Combo box is used.
            switch (txtGender.Text)
            {
                case "M":
                    request.sex = SexType.M;
                    break;
                case "F":
                    request.sex = SexType.F;
                    break;
                case "I":
                    request.sex = SexType.I;
                    break;
                default:
                    request.sex = SexType.N;
                    break;
            }

            try
            {
                // Invokes a basic search
                searchIHIResponse ihiResponse = client.BasicMedicareSearch(request);
                string ihiNumber = ihiResponse.searchIHIResult.ihiNumber;
                txtIHINumber.Text = ihiNumber.Substring(ihiNumber.Length - 16, 16);
                txtIHIStatus.Text = ihiResponse.searchIHIResult.ihiStatus.ToString();
                txtRecordStatus.Text = ihiResponse.searchIHIResult.ihiRecordStatus.ToString();

                txtSoapRequest.Text = client.SoapMessages.SoapRequest;
                txtSoapResponse.Text = client.SoapMessages.SoapResponse;

            }
            catch (FaultException fex)
            {
                txtError.Text = "";
                txtSoapResponse.Text = "";

                string returnError = "";
                MessageFault fault = fex.CreateMessageFault();

                if (fault.HasDetail)
                {
                    ServiceMessagesType error = fault.GetDetail<ServiceMessagesType>();

                    //error.serviceMessage.
                    // Look at error details in here
                    if (error.serviceMessage.Length > 0)
                        returnError = error.serviceMessage[0].code + ": " + error.serviceMessage[0].reason;
                }

                txtError.Text = returnError;

                // If an error is encountered, client.LastSoapResponse often provides a more
                // detailed description of the error.
                string soapResponse = client.SoapMessages.SoapResponse;
                string soapRequest = client.SoapMessages.SoapRequest;
                txtSoapResponse.Text = soapResponse;
                txtSoapRequest.Text = soapRequest;

            }
            catch (Exception ex)
            {
                txtError.Text = ex.Message;
            }
        }

        private void SavePatient_Click(object sender, EventArgs e)
        {

        }

        private void txtSoapRequest_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoapResponse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

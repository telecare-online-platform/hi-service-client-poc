
namespace ADHA.HIService
{
    partial class AddPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.txtGivenName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtMedicareNo = new System.Windows.Forms.TextBox();
            this.txtMedicareIRN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIHIStatus = new System.Windows.Forms.TextBox();
            this.txtRecordStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIHINumber = new System.Windows.Forms.TextBox();
            this.txtSoapRequest = new System.Windows.Forms.RichTextBox();
            this.txtSoapResponse = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnIHILookup = new System.Windows.Forms.Button();
            this.SavePatient = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Location = new System.Drawing.Point(129, 20);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(100, 20);
            this.txtFamilyName.TabIndex = 0;
            this.txtFamilyName.Text = "GREEN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Family Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medical No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DOB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Given Name";
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(129, 79);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(100, 20);
            this.txtDob.TabIndex = 6;
            this.txtDob.Text = "05 MAY 1978";
            // 
            // txtGivenName
            // 
            this.txtGivenName.Location = new System.Drawing.Point(129, 48);
            this.txtGivenName.Name = "txtGivenName";
            this.txtGivenName.Size = new System.Drawing.Size(100, 20);
            this.txtGivenName.TabIndex = 7;
            this.txtGivenName.Text = "HORACIO";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(129, 115);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 20);
            this.txtGender.TabIndex = 8;
            this.txtGender.Text = "M";
            // 
            // txtMedicareNo
            // 
            this.txtMedicareNo.Location = new System.Drawing.Point(129, 149);
            this.txtMedicareNo.Name = "txtMedicareNo";
            this.txtMedicareNo.Size = new System.Drawing.Size(75, 20);
            this.txtMedicareNo.TabIndex = 9;
            this.txtMedicareNo.Text = "5950096792";
            // 
            // txtMedicareIRN
            // 
            this.txtMedicareIRN.Location = new System.Drawing.Point(129, 189);
            this.txtMedicareIRN.Name = "txtMedicareIRN";
            this.txtMedicareIRN.Size = new System.Drawing.Size(52, 20);
            this.txtMedicareIRN.TabIndex = 10;
            this.txtMedicareIRN.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "IRN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "HI Service SOAP Request";
            // 
            // txtIHIStatus
            // 
            this.txtIHIStatus.Location = new System.Drawing.Point(530, 45);
            this.txtIHIStatus.Name = "txtIHIStatus";
            this.txtIHIStatus.Size = new System.Drawing.Size(100, 20);
            this.txtIHIStatus.TabIndex = 19;
            // 
            // txtRecordStatus
            // 
            this.txtRecordStatus.Location = new System.Drawing.Point(530, 76);
            this.txtRecordStatus.Name = "txtRecordStatus";
            this.txtRecordStatus.Size = new System.Drawing.Size(100, 20);
            this.txtRecordStatus.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "HI Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Record Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "IHI";
            // 
            // txtIHINumber
            // 
            this.txtIHINumber.Location = new System.Drawing.Point(530, 17);
            this.txtIHINumber.Name = "txtIHINumber";
            this.txtIHINumber.Size = new System.Drawing.Size(100, 20);
            this.txtIHINumber.TabIndex = 14;
            // 
            // txtSoapRequest
            // 
            this.txtSoapRequest.Location = new System.Drawing.Point(27, 255);
            this.txtSoapRequest.Name = "txtSoapRequest";
            this.txtSoapRequest.Size = new System.Drawing.Size(677, 125);
            this.txtSoapRequest.TabIndex = 22;
            this.txtSoapRequest.Text = "";
            this.txtSoapRequest.TextChanged += new System.EventHandler(this.txtSoapRequest_TextChanged);
            // 
            // txtSoapResponse
            // 
            this.txtSoapResponse.Location = new System.Drawing.Point(27, 414);
            this.txtSoapResponse.Name = "txtSoapResponse";
            this.txtSoapResponse.Size = new System.Drawing.Size(677, 125);
            this.txtSoapResponse.TabIndex = 23;
            this.txtSoapResponse.Text = "";
            this.txtSoapResponse.TextChanged += new System.EventHandler(this.txtSoapResponse_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "HI Service SOAP Response";
            // 
            // btnIHILookup
            // 
            this.btnIHILookup.Location = new System.Drawing.Point(472, 128);
            this.btnIHILookup.Name = "btnIHILookup";
            this.btnIHILookup.Size = new System.Drawing.Size(92, 23);
            this.btnIHILookup.TabIndex = 26;
            this.btnIHILookup.Text = "IHI Lookup";
            this.btnIHILookup.UseVisualStyleBackColor = true;
            this.btnIHILookup.Click += new System.EventHandler(this.btnIHILookup_Click);
            // 
            // SavePatient
            // 
            this.SavePatient.Location = new System.Drawing.Point(472, 192);
            this.SavePatient.Name = "SavePatient";
            this.SavePatient.Size = new System.Drawing.Size(92, 23);
            this.SavePatient.TabIndex = 27;
            this.SavePatient.Text = "Save Patient";
            this.SavePatient.UseVisualStyleBackColor = true;
            this.SavePatient.Click += new System.EventHandler(this.SavePatient_Click);
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(27, 579);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(677, 37);
            this.txtError.TabIndex = 28;
            this.txtError.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 553);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Error";
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 628);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.SavePatient);
            this.Controls.Add(this.btnIHILookup);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSoapResponse);
            this.Controls.Add(this.txtSoapRequest);
            this.Controls.Add(this.txtIHIStatus);
            this.Controls.Add(this.txtRecordStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIHINumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMedicareIRN);
            this.Controls.Add(this.txtMedicareNo);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtGivenName);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFamilyName);
            this.Name = "AddPatient";
            this.Text = "Add Patient";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFamilyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.TextBox txtGivenName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtMedicareNo;
        private System.Windows.Forms.TextBox txtMedicareIRN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIHIStatus;
        private System.Windows.Forms.TextBox txtRecordStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIHINumber;
        private System.Windows.Forms.RichTextBox txtSoapRequest;
        private System.Windows.Forms.RichTextBox txtSoapResponse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnIHILookup;
        private System.Windows.Forms.Button SavePatient;
        private System.Windows.Forms.RichTextBox txtError;
        private System.Windows.Forms.Label label11;
    }
}
namespace AdmissionEnquiryForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Form components
        private Label lblName;
        private TextBox txtName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblCourse;
        private ComboBox cmbCourse;
        private Button btnSubmit;
        private Button btnClose;

        // Form initialization
        private void InitializeComponent()
        {
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblPhone = new Label();
            this.txtPhone = new TextBox();
            this.lblCourse = new Label();
            this.cmbCourse = new ComboBox();
            this.btnSubmit = new Button();
            this.btnClose = new Button();
            
            // Setting properties for form components
            this.SuspendLayout();
            
            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            
            // txtName
            this.txtName.Location = new System.Drawing.Point(120, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 1;
            
            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            
            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(120, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 3;
            
            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(30, 110);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(44, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone:";
            
            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(120, 110);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 5;
            
            // lblCourse
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(30, 150);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(46, 13);
            this.lblCourse.TabIndex = 6;
            this.lblCourse.Text = "Course:";
            
            // cmbCourse
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
                "Computer Science",
                "Mathematics",
                "Physics",
                "Engineering",
                "Biology"});
            this.cmbCourse.Location = new System.Drawing.Point(120, 150);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(200, 21);
            this.cmbCourse.TabIndex = 7;
            
            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(120, 200);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 30);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new EventHandler(this.btnSubmit_Click);
            
            // btnClose
            this.btnClose.Location = new System.Drawing.Point(230, 200);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);
            
            // Form1 (Main Form)
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Admission Enquiry Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

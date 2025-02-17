namespace RegistrationForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Form components
        private Label lblRegNumber;
        private TextBox txtRegNumber;
        private Label lblName;
        private TextBox txtName;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblClass;
        private TextBox txtClass;
        private Label lblAddress;
        private TextBox txtAddress;
        private Button btnSubmit;
        private Button btnClose;

        // Form initialization
        private void InitializeComponent()
        {
            this.lblRegNumber = new Label();
            this.txtRegNumber = new TextBox();
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblAge = new Label();
            this.txtAge = new TextBox();
            this.lblClass = new Label();
            this.txtClass = new TextBox();
            this.lblAddress = new Label();
            this.txtAddress = new TextBox();
            this.btnSubmit = new Button();
            this.btnClose = new Button();
            
            // Setting properties for form components
            this.SuspendLayout();
            
            // lblRegNumber
            this.lblRegNumber.AutoSize = true;
            this.lblRegNumber.Location = new System.Drawing.Point(30, 30);
            this.lblRegNumber.Name = "lblRegNumber";
            this.lblRegNumber.Size = new System.Drawing.Size(90, 13);
            this.lblRegNumber.TabIndex = 0;
            this.lblRegNumber.Text = "Registration No:";
            
            // txtRegNumber
            this.txtRegNumber.Location = new System.Drawing.Point(120, 30);
            this.txtRegNumber.Name = "txtRegNumber";
            this.txtRegNumber.Size = new System.Drawing.Size(200, 20);
            this.txtRegNumber.TabIndex = 1;
            
            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            
            // txtName
            this.txtName.Location = new System.Drawing.Point(120, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 3;
            
            // lblAge
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(30, 110);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age:";
            
            // txtAge
            this.txtAge.Location = new System.Drawing.Point(120, 110);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(200, 20);
            this.txtAge.TabIndex = 5;
            
            // lblClass
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(30, 150);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(34, 13);
            this.lblClass.TabIndex = 6;
            this.lblClass.Text = "Class:";
            
            // txtClass
            this.txtClass.Location = new System.Drawing.Point(120, 150);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(200, 20);
            this.txtClass.TabIndex = 7;
            
            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(30, 190);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address:";
            
            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(120, 190);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 9;
            
            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(120, 230);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 30);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new EventHandler(this.btnSubmit_Click);
            
            // btnClose
            this.btnClose.Location = new System.Drawing.Point(230, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);
            
            // Form1 (Main Form)
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtRegNumber);
            this.Controls.Add(this.lblRegNumber);
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

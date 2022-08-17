namespace Taxi_App
{
    partial class Form1
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lboxResult = new System.Windows.Forms.ListBox();
            this.gboxAssociation = new System.Windows.Forms.GroupBox();
            this.rbCATA = new System.Windows.Forms.RadioButton();
            this.rbITA = new System.Windows.Forms.RadioButton();
            this.rbGPTA = new System.Windows.Forms.RadioButton();
            this.lboxRoute = new System.Windows.Forms.ListBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.TbAdditional = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblRoute = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAdditional = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gboxAssociation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(388, 247);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(59, 46);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = "Next Operator";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(388, 169);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(59, 46);
            this.btnVerify.TabIndex = 22;
            this.btnVerify.Text = "Verify Taxis";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lboxResult
            // 
            this.lboxResult.FormattingEnabled = true;
            this.lboxResult.Location = new System.Drawing.Point(55, 168);
            this.lboxResult.Margin = new System.Windows.Forms.Padding(2);
            this.lboxResult.Name = "lboxResult";
            this.lboxResult.Size = new System.Drawing.Size(319, 134);
            this.lboxResult.TabIndex = 21;
            // 
            // gboxAssociation
            // 
            this.gboxAssociation.Controls.Add(this.rbCATA);
            this.gboxAssociation.Controls.Add(this.rbITA);
            this.gboxAssociation.Controls.Add(this.rbGPTA);
            this.gboxAssociation.Location = new System.Drawing.Point(332, 24);
            this.gboxAssociation.Margin = new System.Windows.Forms.Padding(2);
            this.gboxAssociation.Name = "gboxAssociation";
            this.gboxAssociation.Padding = new System.Windows.Forms.Padding(2);
            this.gboxAssociation.Size = new System.Drawing.Size(105, 113);
            this.gboxAssociation.TabIndex = 20;
            this.gboxAssociation.TabStop = false;
            this.gboxAssociation.Text = "Taxi Association";
            // 
            // rbCATA
            // 
            this.rbCATA.AutoSize = true;
            this.rbCATA.Location = new System.Drawing.Point(4, 80);
            this.rbCATA.Margin = new System.Windows.Forms.Padding(2);
            this.rbCATA.Name = "rbCATA";
            this.rbCATA.Size = new System.Drawing.Size(46, 17);
            this.rbCATA.TabIndex = 2;
            this.rbCATA.TabStop = true;
            this.rbCATA.Text = "CTA";
            this.rbCATA.UseVisualStyleBackColor = true;
            // 
            // rbITA
            // 
            this.rbITA.AutoSize = true;
            this.rbITA.Location = new System.Drawing.Point(4, 50);
            this.rbITA.Margin = new System.Windows.Forms.Padding(2);
            this.rbITA.Name = "rbITA";
            this.rbITA.Size = new System.Drawing.Size(42, 17);
            this.rbITA.TabIndex = 1;
            this.rbITA.TabStop = true;
            this.rbITA.Text = "ITA";
            this.rbITA.UseVisualStyleBackColor = true;
            // 
            // rbGPTA
            // 
            this.rbGPTA.AutoSize = true;
            this.rbGPTA.Location = new System.Drawing.Point(4, 17);
            this.rbGPTA.Margin = new System.Windows.Forms.Padding(2);
            this.rbGPTA.Name = "rbGPTA";
            this.rbGPTA.Size = new System.Drawing.Size(54, 17);
            this.rbGPTA.TabIndex = 0;
            this.rbGPTA.TabStop = true;
            this.rbGPTA.Text = "GPTA";
            this.rbGPTA.UseVisualStyleBackColor = true;
            // 
            // lboxRoute
            // 
            this.lboxRoute.FormattingEnabled = true;
            this.lboxRoute.Items.AddRange(new object[] {
            "Promosa",
            "Mohadin",
            "Ikageng",
            "Industria"});
            this.lboxRoute.Location = new System.Drawing.Point(232, 55);
            this.lboxRoute.Margin = new System.Windows.Forms.Padding(2);
            this.lboxRoute.Name = "lboxRoute";
            this.lboxRoute.Size = new System.Drawing.Size(76, 82);
            this.lboxRoute.TabIndex = 19;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(140, 88);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(2);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(75, 20);
            this.tbSurname.TabIndex = 18;
            // 
            // TbAdditional
            // 
            this.TbAdditional.Location = new System.Drawing.Point(140, 120);
            this.TbAdditional.Margin = new System.Windows.Forms.Padding(2);
            this.TbAdditional.Name = "TbAdditional";
            this.TbAdditional.Size = new System.Drawing.Size(75, 20);
            this.TbAdditional.TabIndex = 17;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(140, 57);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(75, 20);
            this.tbName.TabIndex = 16;
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Location = new System.Drawing.Point(240, 30);
            this.lblRoute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(62, 13);
            this.lblRoute.TabIndex = 15;
            this.lblRoute.Text = "Taxi Route:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(56, 88);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 14;
            this.lblSurname.Text = "Surname:";
            // 
            // lblAdditional
            // 
            this.lblAdditional.AutoSize = true;
            this.lblAdditional.Location = new System.Drawing.Point(52, 120);
            this.lblAdditional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdditional.Name = "lblAdditional";
            this.lblAdditional.Size = new System.Drawing.Size(84, 13);
            this.lblAdditional.TabIndex = 13;
            this.lblAdditional.Text = "Additional Taxis:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(56, 61);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 346);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.lboxResult);
            this.Controls.Add(this.gboxAssociation);
            this.Controls.Add(this.lboxRoute);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.TbAdditional);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblAdditional);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Taxi App";
            this.gboxAssociation.ResumeLayout(false);
            this.gboxAssociation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.ListBox lboxResult;
        private System.Windows.Forms.GroupBox gboxAssociation;
        private System.Windows.Forms.RadioButton rbCATA;
        private System.Windows.Forms.RadioButton rbITA;
        private System.Windows.Forms.RadioButton rbGPTA;
        private System.Windows.Forms.ListBox lboxRoute;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox TbAdditional;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAdditional;
        private System.Windows.Forms.Label lblName;
    }
}


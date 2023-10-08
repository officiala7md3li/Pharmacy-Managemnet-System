namespace Pharmacy_Managemnet_System.GUI.UC
{
    partial class PatientUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientUC));
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Department_Name_TxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Manager_Phone_TxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Department_Phone_TxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ID_TxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Avilable_or_Not = new Bunifu.UI.WinForms.BunifuCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox2
            // 
            this.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(418, 9);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(30, 30);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 389;
            this.PictureBox2.TabStop = false;
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Enabled = false;
            this.Label5.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Gray;
            this.Label5.Location = new System.Drawing.Point(367, 12);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(53, 24);
            this.Label5.TabIndex = 388;
            this.Label5.Text = "العملاء";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Enabled = false;
            this.Label3.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Gray;
            this.Label3.Location = new System.Drawing.Point(274, 146);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(102, 23);
            this.Label3.TabIndex = 387;
            this.Label3.Text = "رقم هاتف العميل";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Department_Name_TxtBox
            // 
            this.Department_Name_TxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Department_Name_TxtBox.AutoRoundedCorners = true;
            this.Department_Name_TxtBox.BorderRadius = 17;
            this.Department_Name_TxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Department_Name_TxtBox.DefaultText = "";
            this.Department_Name_TxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Department_Name_TxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Department_Name_TxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Department_Name_TxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Department_Name_TxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Department_Name_TxtBox.Font = new System.Drawing.Font("Cairo", 9F);
            this.Department_Name_TxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Department_Name_TxtBox.IconRight = ((System.Drawing.Image)(resources.GetObject("Department_Name_TxtBox.IconRight")));
            this.Department_Name_TxtBox.IconRightOffset = new System.Drawing.Point(3, 0);
            this.Department_Name_TxtBox.Location = new System.Drawing.Point(431, 171);
            this.Department_Name_TxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Department_Name_TxtBox.Name = "Department_Name_TxtBox";
            this.Department_Name_TxtBox.PasswordChar = '\0';
            this.Department_Name_TxtBox.PlaceholderText = "ادخل اسم العميل";
            this.Department_Name_TxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Department_Name_TxtBox.SelectedText = "";
            this.Department_Name_TxtBox.Size = new System.Drawing.Size(200, 36);
            this.Department_Name_TxtBox.TabIndex = 381;
            this.Department_Name_TxtBox.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // Manager_Phone_TxtBox
            // 
            this.Manager_Phone_TxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Manager_Phone_TxtBox.AutoRoundedCorners = true;
            this.Manager_Phone_TxtBox.BorderRadius = 17;
            this.Manager_Phone_TxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Manager_Phone_TxtBox.DefaultText = "";
            this.Manager_Phone_TxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Manager_Phone_TxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Manager_Phone_TxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Manager_Phone_TxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Manager_Phone_TxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Manager_Phone_TxtBox.Font = new System.Drawing.Font("Cairo", 9F);
            this.Manager_Phone_TxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Manager_Phone_TxtBox.IconRight = ((System.Drawing.Image)(resources.GetObject("Manager_Phone_TxtBox.IconRight")));
            this.Manager_Phone_TxtBox.IconRightOffset = new System.Drawing.Point(3, 0);
            this.Manager_Phone_TxtBox.Location = new System.Drawing.Point(180, 171);
            this.Manager_Phone_TxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Manager_Phone_TxtBox.Name = "Manager_Phone_TxtBox";
            this.Manager_Phone_TxtBox.PasswordChar = '\0';
            this.Manager_Phone_TxtBox.PlaceholderText = "ادخل رقم هاتف العميل";
            this.Manager_Phone_TxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Manager_Phone_TxtBox.SelectedText = "";
            this.Manager_Phone_TxtBox.Size = new System.Drawing.Size(200, 36);
            this.Manager_Phone_TxtBox.TabIndex = 383;
            this.Manager_Phone_TxtBox.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Enabled = false;
            this.Label4.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Gray;
            this.Label4.Location = new System.Drawing.Point(544, 258);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label4.Size = new System.Drawing.Size(80, 23);
            this.Label4.TabIndex = 386;
            this.Label4.Text = "عنوان العميل";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Department_Phone_TxtBox
            // 
            this.Department_Phone_TxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Department_Phone_TxtBox.AutoRoundedCorners = true;
            this.Department_Phone_TxtBox.BorderRadius = 17;
            this.Department_Phone_TxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Department_Phone_TxtBox.DefaultText = "";
            this.Department_Phone_TxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Department_Phone_TxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Department_Phone_TxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Department_Phone_TxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Department_Phone_TxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Department_Phone_TxtBox.Font = new System.Drawing.Font("Cairo", 9F);
            this.Department_Phone_TxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Department_Phone_TxtBox.IconRight = ((System.Drawing.Image)(resources.GetObject("Department_Phone_TxtBox.IconRight")));
            this.Department_Phone_TxtBox.IconRightOffset = new System.Drawing.Point(3, 0);
            this.Department_Phone_TxtBox.Location = new System.Drawing.Point(180, 283);
            this.Department_Phone_TxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Department_Phone_TxtBox.Name = "Department_Phone_TxtBox";
            this.Department_Phone_TxtBox.PasswordChar = '\0';
            this.Department_Phone_TxtBox.PlaceholderText = "ادخل عنوان العميل";
            this.Department_Phone_TxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Department_Phone_TxtBox.SelectedText = "";
            this.Department_Phone_TxtBox.Size = new System.Drawing.Size(451, 36);
            this.Department_Phone_TxtBox.TabIndex = 382;
            this.Department_Phone_TxtBox.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // ID_TxtBox
            // 
            this.ID_TxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID_TxtBox.AutoRoundedCorners = true;
            this.ID_TxtBox.BorderRadius = 17;
            this.ID_TxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID_TxtBox.DefaultText = "";
            this.ID_TxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ID_TxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ID_TxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ID_TxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ID_TxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ID_TxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ID_TxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ID_TxtBox.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.ID_TxtBox.Location = new System.Drawing.Point(431, 171);
            this.ID_TxtBox.Name = "ID_TxtBox";
            this.ID_TxtBox.PasswordChar = '\0';
            this.ID_TxtBox.PlaceholderText = "Enter Store Name";
            this.ID_TxtBox.SelectedText = "";
            this.ID_TxtBox.Size = new System.Drawing.Size(200, 36);
            this.ID_TxtBox.TabIndex = 385;
            this.ID_TxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID_TxtBox.TextOffset = new System.Drawing.Point(3, 0);
            this.ID_TxtBox.Visible = false;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Enabled = false;
            this.Label1.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.Location = new System.Drawing.Point(543, 146);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(73, 23);
            this.Label1.TabIndex = 384;
            this.Label1.Text = "اسم العميل";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label10
            // 
            this.Label10.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label10.Enabled = false;
            this.Label10.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.Gray;
            this.Label10.Location = new System.Drawing.Point(387, 341);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label10.Size = new System.Drawing.Size(46, 23);
            this.Label10.TabIndex = 391;
            this.Label10.Text = "التأمين";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Avilable_or_Not
            // 
            this.Avilable_or_Not.AllowBindingControlAnimation = true;
            this.Avilable_or_Not.AllowBindingControlColorChanges = false;
            this.Avilable_or_Not.AllowBindingControlLocation = false;
            this.Avilable_or_Not.AllowCheckBoxAnimation = false;
            this.Avilable_or_Not.AllowCheckmarkAnimation = true;
            this.Avilable_or_Not.AllowOnHoverStates = true;
            this.Avilable_or_Not.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Avilable_or_Not.AutoCheck = true;
            this.Avilable_or_Not.BackColor = System.Drawing.Color.Transparent;
            this.Avilable_or_Not.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Avilable_or_Not.BackgroundImage")));
            this.Avilable_or_Not.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Avilable_or_Not.BindingControl = this.Label10;
            this.Avilable_or_Not.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Left;
            this.Avilable_or_Not.BorderRadius = 12;
            this.Avilable_or_Not.Checked = true;
            this.Avilable_or_Not.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.Avilable_or_Not.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Avilable_or_Not.CustomCheckmarkImage = null;
            this.Avilable_or_Not.Location = new System.Drawing.Point(435, 342);
            this.Avilable_or_Not.MinimumSize = new System.Drawing.Size(17, 17);
            this.Avilable_or_Not.Name = "Avilable_or_Not";
            this.Avilable_or_Not.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(188)))), ((int)(((byte)(152)))));
            this.Avilable_or_Not.OnCheck.BorderRadius = 12;
            this.Avilable_or_Not.OnCheck.BorderThickness = 2;
            this.Avilable_or_Not.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(188)))), ((int)(((byte)(152)))));
            this.Avilable_or_Not.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.Avilable_or_Not.OnCheck.CheckmarkThickness = 2;
            this.Avilable_or_Not.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.Avilable_or_Not.OnDisable.BorderRadius = 12;
            this.Avilable_or_Not.OnDisable.BorderThickness = 2;
            this.Avilable_or_Not.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Avilable_or_Not.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.Avilable_or_Not.OnDisable.CheckmarkThickness = 2;
            this.Avilable_or_Not.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(227)))), ((int)(((byte)(212)))));
            this.Avilable_or_Not.OnHoverChecked.BorderRadius = 12;
            this.Avilable_or_Not.OnHoverChecked.BorderThickness = 2;
            this.Avilable_or_Not.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(227)))), ((int)(((byte)(212)))));
            this.Avilable_or_Not.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.Avilable_or_Not.OnHoverChecked.CheckmarkThickness = 2;
            this.Avilable_or_Not.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(227)))), ((int)(((byte)(212)))));
            this.Avilable_or_Not.OnHoverUnchecked.BorderRadius = 12;
            this.Avilable_or_Not.OnHoverUnchecked.BorderThickness = 2;
            this.Avilable_or_Not.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Avilable_or_Not.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(188)))), ((int)(((byte)(152)))));
            this.Avilable_or_Not.OnUncheck.BorderRadius = 12;
            this.Avilable_or_Not.OnUncheck.BorderThickness = 2;
            this.Avilable_or_Not.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Avilable_or_Not.Size = new System.Drawing.Size(20, 20);
            this.Avilable_or_Not.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Round;
            this.Avilable_or_Not.TabIndex = 390;
            this.Avilable_or_Not.ThreeState = false;
            this.Avilable_or_Not.ToolTipText = null;
            // 
            // PatientUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Avilable_or_Not);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Department_Name_TxtBox);
            this.Controls.Add(this.Manager_Phone_TxtBox);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Department_Phone_TxtBox);
            this.Controls.Add(this.ID_TxtBox);
            this.Controls.Add(this.Label1);
            this.Name = "PatientUC";
            this.Controls.SetChildIndex(this.Label1, 0);
            this.Controls.SetChildIndex(this.ID_TxtBox, 0);
            this.Controls.SetChildIndex(this.Department_Phone_TxtBox, 0);
            this.Controls.SetChildIndex(this.Label4, 0);
            this.Controls.SetChildIndex(this.Manager_Phone_TxtBox, 0);
            this.Controls.SetChildIndex(this.Department_Name_TxtBox, 0);
            this.Controls.SetChildIndex(this.Label3, 0);
            this.Controls.SetChildIndex(this.Label5, 0);
            this.Controls.SetChildIndex(this.PictureBox2, 0);
            this.Controls.SetChildIndex(this.Avilable_or_Not, 0);
            this.Controls.SetChildIndex(this.Label10, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label3;
        internal Guna.UI2.WinForms.Guna2TextBox Department_Name_TxtBox;
        internal Guna.UI2.WinForms.Guna2TextBox Manager_Phone_TxtBox;
        private System.Windows.Forms.Label Label4;
        internal Guna.UI2.WinForms.Guna2TextBox Department_Phone_TxtBox;
        internal Guna.UI2.WinForms.Guna2TextBox ID_TxtBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label10;
        internal Bunifu.UI.WinForms.BunifuCheckBox Avilable_or_Not;
    }
}

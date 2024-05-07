
namespace furniture_store.pages
{
    partial class login_register_select_page
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
            select_panel = new System.Windows.Forms.Panel();
            detail_label = new System.Windows.Forms.Label();
            register_button = new System.Windows.Forms.Button();
            login_button = new System.Windows.Forms.Button();
            welcome_label = new System.Windows.Forms.Label();
            select_panel.SuspendLayout();
            SuspendLayout();
            // 
            // select_panel
            // 
            select_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            select_panel.BackColor = System.Drawing.Color.Transparent;
            select_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            select_panel.Controls.Add(detail_label);
            select_panel.Controls.Add(register_button);
            select_panel.Controls.Add(login_button);
            select_panel.Controls.Add(welcome_label);
            select_panel.Location = new System.Drawing.Point(361, 213);
            select_panel.Name = "select_panel";
            select_panel.Size = new System.Drawing.Size(320, 139);
            select_panel.TabIndex = 7;
            // 
            // detail_label
            // 
            detail_label.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            detail_label.ForeColor = System.Drawing.Color.MistyRose;
            detail_label.Location = new System.Drawing.Point(30, 48);
            detail_label.Name = "detail_label";
            detail_label.Size = new System.Drawing.Size(252, 41);
            detail_label.TabIndex = 8;
            detail_label.Text = "Log in to your account, or register one if you don't have one.";
            // 
            // register_button
            // 
            register_button.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            register_button.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            register_button.ForeColor = System.Drawing.Color.MistyRose;
            register_button.Location = new System.Drawing.Point(46, 97);
            register_button.Name = "register_button";
            register_button.Size = new System.Drawing.Size(75, 28);
            register_button.TabIndex = 7;
            register_button.Text = "Register";
            register_button.UseVisualStyleBackColor = false;
            register_button.Click += register_button_Click;
            // 
            // login_button
            // 
            login_button.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            login_button.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            login_button.ForeColor = System.Drawing.Color.MistyRose;
            login_button.Location = new System.Drawing.Point(189, 97);
            login_button.Name = "login_button";
            login_button.Size = new System.Drawing.Size(75, 28);
            login_button.TabIndex = 6;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // welcome_label
            // 
            welcome_label.AutoSize = true;
            welcome_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            welcome_label.ForeColor = System.Drawing.Color.MistyRose;
            welcome_label.Location = new System.Drawing.Point(9, 10);
            welcome_label.Name = "welcome_label";
            welcome_label.Size = new System.Drawing.Size(308, 29);
            welcome_label.TabIndex = 5;
            welcome_label.Text = "Welcome to Furniture Store";
            // 
            // login_register_select_page
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(select_panel);
            Name = "login_register_select_page";
            Padding = new System.Windows.Forms.Padding(3);
            Size = new System.Drawing.Size(1082, 570);
            select_panel.ResumeLayout(false);
            select_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel select_panel;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label detail_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button login_button;
    }
}

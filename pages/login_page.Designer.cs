
namespace furniture_store.pages
{
    partial class login_page
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
            login_button = new System.Windows.Forms.Button();
            username_textbox = new System.Windows.Forms.TextBox();
            password_textbox = new System.Windows.Forms.TextBox();
            username_label = new System.Windows.Forms.Label();
            password_label = new System.Windows.Forms.Label();
            login_label = new System.Windows.Forms.Label();
            login_panel = new System.Windows.Forms.Panel();
            back_button = new System.Windows.Forms.Button();
            login_panel.SuspendLayout();
            SuspendLayout();
            // 
            // login_button
            // 
            login_button.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            login_button.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            login_button.ForeColor = System.Drawing.Color.MistyRose;
            login_button.Location = new System.Drawing.Point(219, 115);
            login_button.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            login_button.MaximumSize = new System.Drawing.Size(816, 489);
            login_button.Name = "login_button";
            login_button.Size = new System.Drawing.Size(75, 28);
            login_button.TabIndex = 0;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_click;
            // 
            // username_textbox
            // 
            username_textbox.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            username_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            username_textbox.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            username_textbox.ForeColor = System.Drawing.Color.MistyRose;
            username_textbox.Location = new System.Drawing.Point(87, 52);
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new System.Drawing.Size(207, 22);
            username_textbox.TabIndex = 1;
            username_textbox.TextChanged += textbox_text_changed;
            // 
            // password_textbox
            // 
            password_textbox.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            password_textbox.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            password_textbox.ForeColor = System.Drawing.Color.MistyRose;
            password_textbox.Location = new System.Drawing.Point(87, 81);
            password_textbox.MaxLength = 50;
            password_textbox.Name = "password_textbox";
            password_textbox.PasswordChar = '*';
            password_textbox.Size = new System.Drawing.Size(207, 22);
            password_textbox.TabIndex = 2;
            password_textbox.TextChanged += textbox_text_changed;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            username_label.ForeColor = System.Drawing.Color.MistyRose;
            username_label.Location = new System.Drawing.Point(20, 54);
            username_label.Name = "username_label";
            username_label.Size = new System.Drawing.Size(61, 14);
            username_label.TabIndex = 3;
            username_label.Text = "Username";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            password_label.ForeColor = System.Drawing.Color.MistyRose;
            password_label.Location = new System.Drawing.Point(20, 83);
            password_label.Name = "password_label";
            password_label.Size = new System.Drawing.Size(59, 14);
            password_label.TabIndex = 4;
            password_label.Text = "Password";
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            login_label.ForeColor = System.Drawing.Color.MistyRose;
            login_label.Location = new System.Drawing.Point(9, 10);
            login_label.Name = "login_label";
            login_label.Size = new System.Drawing.Size(72, 29);
            login_label.TabIndex = 5;
            login_label.Text = "Login";
            // 
            // login_panel
            // 
            login_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            login_panel.BackColor = System.Drawing.Color.Transparent;
            login_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            login_panel.Controls.Add(login_label);
            login_panel.Controls.Add(login_button);
            login_panel.Controls.Add(password_label);
            login_panel.Controls.Add(username_textbox);
            login_panel.Controls.Add(username_label);
            login_panel.Controls.Add(password_textbox);
            login_panel.Location = new System.Drawing.Point(361, 213);
            login_panel.Name = "login_panel";
            login_panel.Size = new System.Drawing.Size(305, 158);
            login_panel.TabIndex = 6;
            // 
            // back_button
            // 
            back_button.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            back_button.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            back_button.ForeColor = System.Drawing.Color.MistyRose;
            back_button.Location = new System.Drawing.Point(6, 6);
            back_button.Name = "back_button";
            back_button.Size = new System.Drawing.Size(75, 28);
            back_button.TabIndex = 7;
            back_button.Text = "Back";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_click;
            // 
            // login_page
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(back_button);
            Controls.Add(login_panel);
            Margin = new System.Windows.Forms.Padding(0);
            Name = "login_page";
            Padding = new System.Windows.Forms.Padding(3);
            Size = new System.Drawing.Size(1082, 570);
            login_panel.ResumeLayout(false);
            login_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Button back_button;
    }
}

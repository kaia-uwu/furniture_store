namespace furniture_store.pages
{
    partial class register_page
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
            back_button = new System.Windows.Forms.Button();
            register_panel = new System.Windows.Forms.Panel();
            e_mail_label = new System.Windows.Forms.Label();
            phone_number_textbox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            password_repeat_textbox = new System.Windows.Forms.TextBox();
            username_label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            password_textbox = new System.Windows.Forms.TextBox();
            last_name_textbox = new System.Windows.Forms.TextBox();
            register_label = new System.Windows.Forms.Label();
            register_button = new System.Windows.Forms.Button();
            password_label = new System.Windows.Forms.Label();
            username_textbox = new System.Windows.Forms.TextBox();
            email_label = new System.Windows.Forms.Label();
            first_name_textbox = new System.Windows.Forms.TextBox();
            register_panel.SuspendLayout();
            SuspendLayout();
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
            back_button.TabIndex = 9;
            back_button.Text = "Back";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // register_panel
            // 
            register_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            register_panel.BackColor = System.Drawing.Color.Transparent;
            register_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            register_panel.Controls.Add(e_mail_label);
            register_panel.Controls.Add(phone_number_textbox);
            register_panel.Controls.Add(label2);
            register_panel.Controls.Add(password_repeat_textbox);
            register_panel.Controls.Add(username_label);
            register_panel.Controls.Add(label1);
            register_panel.Controls.Add(password_textbox);
            register_panel.Controls.Add(last_name_textbox);
            register_panel.Controls.Add(register_label);
            register_panel.Controls.Add(register_button);
            register_panel.Controls.Add(password_label);
            register_panel.Controls.Add(username_textbox);
            register_panel.Controls.Add(email_label);
            register_panel.Controls.Add(first_name_textbox);
            register_panel.Location = new System.Drawing.Point(235, 115);
            register_panel.Name = "register_panel";
            register_panel.Size = new System.Drawing.Size(344, 269);
            register_panel.TabIndex = 10;
            // 
            // e_mail_label
            // 
            e_mail_label.AutoSize = true;
            e_mail_label.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            e_mail_label.ForeColor = System.Drawing.Color.MistyRose;
            e_mail_label.Location = new System.Drawing.Point(20, 139);
            e_mail_label.Name = "e_mail_label";
            e_mail_label.Size = new System.Drawing.Size(86, 14);
            e_mail_label.TabIndex = 13;
            e_mail_label.Text = "Phone number";
            // 
            // phone_number_textbox
            // 
            phone_number_textbox.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            phone_number_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            phone_number_textbox.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            phone_number_textbox.ForeColor = System.Drawing.Color.MistyRose;
            phone_number_textbox.Location = new System.Drawing.Point(127, 137);
            phone_number_textbox.MaxLength = 10;
            phone_number_textbox.Name = "phone_number_textbox";
            phone_number_textbox.Size = new System.Drawing.Size(207, 22);
            phone_number_textbox.TabIndex = 12;
            phone_number_textbox.TextChanged += textbox_text_changed;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.MistyRose;
            label2.Location = new System.Drawing.Point(20, 195);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 14);
            label2.TabIndex = 11;
            label2.Text = "Repeat password";
            // 
            // password_repeat_textbox
            // 
            password_repeat_textbox.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            password_repeat_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            password_repeat_textbox.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            password_repeat_textbox.ForeColor = System.Drawing.Color.MistyRose;
            password_repeat_textbox.Location = new System.Drawing.Point(127, 193);
            password_repeat_textbox.MaxLength = 50;
            password_repeat_textbox.Name = "password_repeat_textbox";
            password_repeat_textbox.PasswordChar = '*';
            password_repeat_textbox.Size = new System.Drawing.Size(207, 22);
            password_repeat_textbox.TabIndex = 10;
            password_repeat_textbox.TextChanged += textbox_text_changed;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            username_label.ForeColor = System.Drawing.Color.MistyRose;
            username_label.Location = new System.Drawing.Point(20, 54);
            username_label.Name = "username_label";
            username_label.Size = new System.Drawing.Size(61, 14);
            username_label.TabIndex = 9;
            username_label.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.MistyRose;
            label1.Location = new System.Drawing.Point(20, 83);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 14);
            label1.TabIndex = 8;
            label1.Text = "First name";
            // 
            // password_textbox
            // 
            password_textbox.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            password_textbox.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            password_textbox.ForeColor = System.Drawing.Color.MistyRose;
            password_textbox.Location = new System.Drawing.Point(127, 165);
            password_textbox.MaxLength = 50;
            password_textbox.Name = "password_textbox";
            password_textbox.PasswordChar = '*';
            password_textbox.Size = new System.Drawing.Size(207, 22);
            password_textbox.TabIndex = 7;
            password_textbox.TextChanged += textbox_text_changed;
            // 
            // last_name_textbox
            // 
            last_name_textbox.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            last_name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            last_name_textbox.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            last_name_textbox.ForeColor = System.Drawing.Color.MistyRose;
            last_name_textbox.Location = new System.Drawing.Point(127, 109);
            last_name_textbox.MaxLength = 50;
            last_name_textbox.Name = "last_name_textbox";
            last_name_textbox.Size = new System.Drawing.Size(207, 22);
            last_name_textbox.TabIndex = 6;
            last_name_textbox.TextChanged += textbox_text_changed;
            // 
            // register_label
            // 
            register_label.AutoSize = true;
            register_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            register_label.ForeColor = System.Drawing.Color.MistyRose;
            register_label.Location = new System.Drawing.Point(9, 10);
            register_label.Name = "register_label";
            register_label.Size = new System.Drawing.Size(104, 29);
            register_label.TabIndex = 5;
            register_label.Text = "Register";
            // 
            // register_button
            // 
            register_button.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            register_button.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            register_button.ForeColor = System.Drawing.Color.MistyRose;
            register_button.Location = new System.Drawing.Point(259, 227);
            register_button.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            register_button.MaximumSize = new System.Drawing.Size(816, 489);
            register_button.Name = "register_button";
            register_button.Size = new System.Drawing.Size(75, 28);
            register_button.TabIndex = 0;
            register_button.Text = "Register";
            register_button.UseVisualStyleBackColor = false;
            register_button.Click += register_button_Click;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            password_label.ForeColor = System.Drawing.Color.MistyRose;
            password_label.Location = new System.Drawing.Point(20, 167);
            password_label.Name = "password_label";
            password_label.Size = new System.Drawing.Size(59, 14);
            password_label.TabIndex = 4;
            password_label.Text = "Password";
            // 
            // username_textbox
            // 
            username_textbox.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            username_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            username_textbox.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            username_textbox.ForeColor = System.Drawing.Color.MistyRose;
            username_textbox.Location = new System.Drawing.Point(127, 52);
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new System.Drawing.Size(207, 22);
            username_textbox.TabIndex = 1;
            username_textbox.TextChanged += textbox_text_changed;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            email_label.ForeColor = System.Drawing.Color.MistyRose;
            email_label.Location = new System.Drawing.Point(20, 111);
            email_label.Name = "email_label";
            email_label.Size = new System.Drawing.Size(62, 14);
            email_label.TabIndex = 3;
            email_label.Text = "Last name";
            // 
            // first_name_textbox
            // 
            first_name_textbox.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            first_name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            first_name_textbox.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            first_name_textbox.ForeColor = System.Drawing.Color.MistyRose;
            first_name_textbox.Location = new System.Drawing.Point(127, 81);
            first_name_textbox.MaxLength = 50;
            first_name_textbox.Name = "first_name_textbox";
            first_name_textbox.Size = new System.Drawing.Size(207, 22);
            first_name_textbox.TabIndex = 2;
            first_name_textbox.TextChanged += textbox_text_changed;
            // 
            // register_page
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(register_panel);
            Controls.Add(back_button);
            Name = "register_page";
            Padding = new System.Windows.Forms.Padding(3);
            Size = new System.Drawing.Size(814, 487);
            register_panel.ResumeLayout(false);
            register_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Panel register_panel;
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox first_name_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_repeat_textbox;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox last_name_textbox;
        private System.Windows.Forms.Label e_mail_label;
        private System.Windows.Forms.TextBox phone_number_textbox;
    }
}

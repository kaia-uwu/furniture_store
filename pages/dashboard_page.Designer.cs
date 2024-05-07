
namespace furniture_store.pages
{
    partial class dashboard_page
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
            this.logout_button = new System.Windows.Forms.Button();
            this.cart_button = new System.Windows.Forms.Button();
            this.items_flow_layout_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.welcome_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logout_button.ForeColor = System.Drawing.Color.MistyRose;
            this.logout_button.Location = new System.Drawing.Point(6, 6);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(75, 28);
            this.logout_button.TabIndex = 2;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_click);
            // 
            // cart_button
            // 
            this.cart_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cart_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cart_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cart_button.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cart_button.ForeColor = System.Drawing.Color.MistyRose;
            this.cart_button.Location = new System.Drawing.Point(735, 6);
            this.cart_button.Name = "cart_button";
            this.cart_button.Size = new System.Drawing.Size(75, 28);
            this.cart_button.TabIndex = 3;
            this.cart_button.Text = "Cart";
            this.cart_button.UseVisualStyleBackColor = false;
            this.cart_button.Click += new System.EventHandler(this.cart_button_click);
            // 
            // items_flow_layout_panel
            // 
            this.items_flow_layout_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.items_flow_layout_panel.AutoScroll = true;
            this.items_flow_layout_panel.BackColor = System.Drawing.Color.Transparent;
            this.items_flow_layout_panel.ForeColor = System.Drawing.Color.MistyRose;
            this.items_flow_layout_panel.Location = new System.Drawing.Point(6, 40);
            this.items_flow_layout_panel.Name = "items_flow_layout_panel";
            this.items_flow_layout_panel.Size = new System.Drawing.Size(804, 443);
            this.items_flow_layout_panel.TabIndex = 6;
            // 
            // welcome_label
            // 
            this.welcome_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcome_label.ForeColor = System.Drawing.Color.MistyRose;
            this.welcome_label.Location = new System.Drawing.Point(202, 3);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(344, 29);
            this.welcome_label.TabIndex = 7;
            this.welcome_label.Text = "Welcome, Firstname Lastname";
            // 
            // dashboard_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.items_flow_layout_panel);
            this.Controls.Add(this.cart_button);
            this.Controls.Add(this.logout_button);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "dashboard_page";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.load);
            this.VisibleChanged += new System.EventHandler(this.visible_changed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button cart_button;
        private System.Windows.Forms.FlowLayoutPanel items_flow_layout_panel;
        private System.Windows.Forms.Label welcome_label;
    }
}

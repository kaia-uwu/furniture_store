
namespace furniture_store.pages
{
    partial class item_page
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
            cart_button = new System.Windows.Forms.Button();
            viewport_1 = new min3d_Forms_Edition_Multipanel_Library.viewport();
            viewport_2 = new min3d_Forms_Edition_Multipanel_Library.viewport();
            viewport_3 = new min3d_Forms_Edition_Multipanel_Library.viewport();
            viewport_4 = new min3d_Forms_Edition_Multipanel_Library.viewport();
            add_to_cart_button = new System.Windows.Forms.Button();
            item_panel = new System.Windows.Forms.Panel();
            parts_flow_layout_panel = new System.Windows.Forms.FlowLayoutPanel();
            price_label = new System.Windows.Forms.Label();
            name_label = new System.Windows.Forms.Label();
            item_panel.SuspendLayout();
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
            back_button.TabIndex = 2;
            back_button.Text = "Back";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_click;
            // 
            // cart_button
            // 
            cart_button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cart_button.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            cart_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cart_button.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cart_button.ForeColor = System.Drawing.Color.MistyRose;
            cart_button.Location = new System.Drawing.Point(739, 6);
            cart_button.Name = "cart_button";
            cart_button.Size = new System.Drawing.Size(75, 28);
            cart_button.TabIndex = 3;
            cart_button.Text = "Cart";
            cart_button.UseVisualStyleBackColor = false;
            cart_button.Click += cart_button_click;
            // 
            // viewport_1
            // 
            viewport_1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            viewport_1.Location = new System.Drawing.Point(3, 3);
            viewport_1.Name = "viewport_1";
            viewport_1.Size = new System.Drawing.Size(462, 302);
            viewport_1.TabIndex = 5;
            viewport_1.Text = "viewport_1";
            // 
            // viewport_2
            // 
            viewport_2.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            viewport_2.Location = new System.Drawing.Point(3, 311);
            viewport_2.Name = "viewport_2";
            viewport_2.Size = new System.Drawing.Size(150, 150);
            viewport_2.TabIndex = 6;
            viewport_2.Text = "viewport_2";
            // 
            // viewport_3
            // 
            viewport_3.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            viewport_3.Location = new System.Drawing.Point(159, 311);
            viewport_3.Name = "viewport_3";
            viewport_3.Size = new System.Drawing.Size(150, 150);
            viewport_3.TabIndex = 7;
            viewport_3.Text = "viewport_3";
            // 
            // viewport_4
            // 
            viewport_4.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            viewport_4.Location = new System.Drawing.Point(315, 311);
            viewport_4.Name = "viewport_4";
            viewport_4.Size = new System.Drawing.Size(150, 150);
            viewport_4.TabIndex = 8;
            viewport_4.Text = "viewport_4";
            // 
            // add_to_cart_button
            // 
            add_to_cart_button.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            add_to_cart_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            add_to_cart_button.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            add_to_cart_button.ForeColor = System.Drawing.Color.MistyRose;
            add_to_cart_button.Location = new System.Drawing.Point(710, 430);
            add_to_cart_button.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            add_to_cart_button.Name = "add_to_cart_button";
            add_to_cart_button.Size = new System.Drawing.Size(90, 28);
            add_to_cart_button.TabIndex = 11;
            add_to_cart_button.Text = "Add to cart";
            add_to_cart_button.UseVisualStyleBackColor = false;
            add_to_cart_button.Click += add_to_cart;
            // 
            // item_panel
            // 
            item_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            item_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            item_panel.Controls.Add(parts_flow_layout_panel);
            item_panel.Controls.Add(price_label);
            item_panel.Controls.Add(name_label);
            item_panel.Controls.Add(viewport_2);
            item_panel.Controls.Add(add_to_cart_button);
            item_panel.Controls.Add(viewport_1);
            item_panel.Controls.Add(viewport_3);
            item_panel.Controls.Add(viewport_4);
            item_panel.ForeColor = System.Drawing.Color.MistyRose;
            item_panel.Location = new System.Drawing.Point(5, 40);
            item_panel.Name = "item_panel";
            item_panel.Padding = new System.Windows.Forms.Padding(3);
            item_panel.Size = new System.Drawing.Size(808, 468);
            item_panel.TabIndex = 12;
            // 
            // parts_flow_layout_panel
            // 
            parts_flow_layout_panel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            parts_flow_layout_panel.AutoScroll = true;
            parts_flow_layout_panel.BackColor = System.Drawing.Color.Transparent;
            parts_flow_layout_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            parts_flow_layout_panel.Location = new System.Drawing.Point(471, 90);
            parts_flow_layout_panel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            parts_flow_layout_panel.MaximumSize = new System.Drawing.Size(329, 331);
            parts_flow_layout_panel.Name = "parts_flow_layout_panel";
            parts_flow_layout_panel.Size = new System.Drawing.Size(329, 331);
            parts_flow_layout_panel.TabIndex = 14;
            parts_flow_layout_panel.WrapContents = false;
            // 
            // price_label
            // 
            price_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            price_label.ForeColor = System.Drawing.Color.MistyRose;
            price_label.Location = new System.Drawing.Point(471, 52);
            price_label.Margin = new System.Windows.Forms.Padding(3);
            price_label.Name = "price_label";
            price_label.Size = new System.Drawing.Size(329, 29);
            price_label.TabIndex = 13;
            price_label.Text = "Price";
            // 
            // name_label
            // 
            name_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            name_label.ForeColor = System.Drawing.Color.MistyRose;
            name_label.Location = new System.Drawing.Point(471, 6);
            name_label.Margin = new System.Windows.Forms.Padding(3);
            name_label.Name = "name_label";
            name_label.Size = new System.Drawing.Size(329, 40);
            name_label.TabIndex = 12;
            name_label.Text = "Name";
            // 
            // item_page
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(item_panel);
            Controls.Add(cart_button);
            Controls.Add(back_button);
            Margin = new System.Windows.Forms.Padding(0);
            Name = "item_page";
            Padding = new System.Windows.Forms.Padding(3);
            Size = new System.Drawing.Size(820, 514);
            Load += load;
            item_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button cart_button;
        public min3d_Forms_Edition_Multipanel_Library.viewport viewport_1;
        public min3d_Forms_Edition_Multipanel_Library.viewport viewport_2;
        public min3d_Forms_Edition_Multipanel_Library.viewport viewport_3;
        public min3d_Forms_Edition_Multipanel_Library.viewport viewport_4;
        private System.Windows.Forms.Button add_to_cart_button;
        private System.Windows.Forms.Panel item_panel;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.FlowLayoutPanel parts_flow_layout_panel;
    }
}

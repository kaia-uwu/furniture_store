namespace furniture_store.pages
{
    partial class cart_page
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
            this.back_button = new System.Windows.Forms.Button();
            this.order_button = new System.Windows.Forms.Button();
            this.total_label = new System.Windows.Forms.Label();
            this.cart_build_flow_layout_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel = new System.Windows.Forms.Panel();
            this.total_text_label = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_button.ForeColor = System.Drawing.Color.MistyRose;
            this.back_button.Location = new System.Drawing.Point(6, 6);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 28);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_click);
            // 
            // order_button
            // 
            this.order_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.order_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order_button.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.order_button.ForeColor = System.Drawing.Color.MistyRose;
            this.order_button.Location = new System.Drawing.Point(711, 412);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(91, 28);
            this.order_button.TabIndex = 5;
            this.order_button.Text = "Place order";
            this.order_button.UseVisualStyleBackColor = false;
            this.order_button.Click += new System.EventHandler(this.place_order);
            // 
            // total_label
            // 
            this.total_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.total_label.ForeColor = System.Drawing.Color.MistyRose;
            this.total_label.Location = new System.Drawing.Point(578, 25);
            this.total_label.Margin = new System.Windows.Forms.Padding(3);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(227, 40);
            this.total_label.TabIndex = 13;
            this.total_label.Text = "Total";
            // 
            // cart_build_flow_layout_panel
            // 
            this.cart_build_flow_layout_panel.AutoScroll = true;
            this.cart_build_flow_layout_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.cart_build_flow_layout_panel.Location = new System.Drawing.Point(3, 3);
            this.cart_build_flow_layout_panel.Name = "cart_build_flow_layout_panel";
            this.cart_build_flow_layout_panel.Size = new System.Drawing.Size(569, 441);
            this.cart_build_flow_layout_panel.TabIndex = 14;
            this.cart_build_flow_layout_panel.WrapContents = false;
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.total_text_label);
            this.panel.Controls.Add(this.cart_build_flow_layout_panel);
            this.panel.Controls.Add(this.total_label);
            this.panel.Controls.Add(this.order_button);
            this.panel.Location = new System.Drawing.Point(6, 40);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(3);
            this.panel.Size = new System.Drawing.Size(810, 448);
            this.panel.TabIndex = 15;
            // 
            // total_text_label
            // 
            this.total_text_label.AutoSize = true;
            this.total_text_label.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total_text_label.ForeColor = System.Drawing.Color.MistyRose;
            this.total_text_label.Location = new System.Drawing.Point(578, 8);
            this.total_text_label.Name = "total_text_label";
            this.total_text_label.Size = new System.Drawing.Size(32, 14);
            this.total_text_label.TabIndex = 15;
            this.total_text_label.Text = "Total";
            // 
            // cart_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.back_button);
            this.Name = "cart_page";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(819, 494);
            this.Load += new System.EventHandler(this.load);
            this.VisibleChanged += new System.EventHandler(this.visible_changed);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.FlowLayoutPanel cart_build_flow_layout_panel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label total_text_label;
    }
}

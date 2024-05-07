namespace furniture_store.support
{
    partial class item_tile
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
            this.viewport = new min3d_Forms_Edition_Multipanel_Library.viewport();
            this.add_to_cart_button = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.materials_flow_layout_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // viewport
            // 
            this.viewport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewport.Location = new System.Drawing.Point(6, 6);
            this.viewport.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.viewport.Name = "viewport";
            this.viewport.Size = new System.Drawing.Size(351, 240);
            this.viewport.TabIndex = 0;
            this.viewport.Text = "viewport";
            this.viewport.Click += new System.EventHandler(this.clicked);
            // 
            // add_to_cart_button
            // 
            this.add_to_cart_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_to_cart_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_to_cart_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_to_cart_button.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_to_cart_button.ForeColor = System.Drawing.Color.MistyRose;
            this.add_to_cart_button.Location = new System.Drawing.Point(269, 360);
            this.add_to_cart_button.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.add_to_cart_button.Name = "add_to_cart_button";
            this.add_to_cart_button.Size = new System.Drawing.Size(90, 28);
            this.add_to_cart_button.TabIndex = 6;
            this.add_to_cart_button.Text = "Add to cart";
            this.add_to_cart_button.UseVisualStyleBackColor = false;
            this.add_to_cart_button.Click += new System.EventHandler(this.add_to_cart_clicked);
            // 
            // name_label
            // 
            this.name_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_label.ForeColor = System.Drawing.Color.MistyRose;
            this.name_label.Location = new System.Drawing.Point(6, 290);
            this.name_label.Margin = new System.Windows.Forms.Padding(3);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(351, 29);
            this.name_label.TabIndex = 7;
            this.name_label.Text = "Name";
            this.name_label.Click += new System.EventHandler(this.clicked);
            // 
            // price_label
            // 
            this.price_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.price_label.ForeColor = System.Drawing.Color.MistyRose;
            this.price_label.Location = new System.Drawing.Point(6, 325);
            this.price_label.Margin = new System.Windows.Forms.Padding(3);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(351, 29);
            this.price_label.TabIndex = 8;
            this.price_label.Text = "Price";
            this.price_label.Click += new System.EventHandler(this.clicked);
            // 
            // materials_flow_layout_panel
            // 
            this.materials_flow_layout_panel.Location = new System.Drawing.Point(6, 249);
            this.materials_flow_layout_panel.Name = "materials_flow_layout_panel";
            this.materials_flow_layout_panel.Size = new System.Drawing.Size(351, 45);
            this.materials_flow_layout_panel.TabIndex = 9;
            this.materials_flow_layout_panel.WrapContents = false;
            this.materials_flow_layout_panel.Click += new System.EventHandler(this.clicked);
            // 
            // item_tile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.materials_flow_layout_panel);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.add_to_cart_button);
            this.Controls.Add(this.viewport);
            this.DoubleBuffered = true;
            this.Name = "item_tile";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(365, 395);
            this.Click += new System.EventHandler(this.clicked);
            this.ResumeLayout(false);

        }

        #endregion

        public min3d_Forms_Edition_Multipanel_Library.viewport viewport;
        private System.Windows.Forms.Button add_to_cart_button;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.FlowLayoutPanel materials_flow_layout_panel;
    }
}

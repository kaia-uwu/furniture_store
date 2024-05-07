
namespace furniture_store.support
{
    partial class cart_build_tile
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
            this.materials_flow_layout_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.name_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.quantity_textbox = new System.Windows.Forms.TextBox();
            this.remove_button = new System.Windows.Forms.Button();
            this.quantity_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materials_flow_layout_panel
            // 
            this.materials_flow_layout_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materials_flow_layout_panel.Location = new System.Drawing.Point(3, 73);
            this.materials_flow_layout_panel.Name = "materials_flow_layout_panel";
            this.materials_flow_layout_panel.Size = new System.Drawing.Size(532, 45);
            this.materials_flow_layout_panel.TabIndex = 10;
            this.materials_flow_layout_panel.WrapContents = false;
            // 
            // name_label
            // 
            this.name_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_label.ForeColor = System.Drawing.Color.MistyRose;
            this.name_label.Location = new System.Drawing.Point(6, 6);
            this.name_label.Margin = new System.Windows.Forms.Padding(3);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(268, 29);
            this.name_label.TabIndex = 11;
            this.name_label.Text = "Name";
            // 
            // price_label
            // 
            this.price_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.price_label.ForeColor = System.Drawing.Color.MistyRose;
            this.price_label.Location = new System.Drawing.Point(6, 41);
            this.price_label.Margin = new System.Windows.Forms.Padding(3);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(317, 29);
            this.price_label.TabIndex = 12;
            this.price_label.Text = "Price";
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantity_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantity_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantity_textbox.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity_textbox.ForeColor = System.Drawing.Color.MistyRose;
            this.quantity_textbox.Location = new System.Drawing.Point(417, 8);
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(46, 22);
            this.quantity_textbox.TabIndex = 13;
            // 
            // remove_button
            // 
            this.remove_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remove_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_button.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remove_button.ForeColor = System.Drawing.Color.MistyRose;
            this.remove_button.Location = new System.Drawing.Point(469, 6);
            this.remove_button.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(66, 28);
            this.remove_button.TabIndex = 14;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.quantity_changed);
            // 
            // quantity_label
            // 
            this.quantity_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity_label.ForeColor = System.Drawing.Color.MistyRose;
            this.quantity_label.Location = new System.Drawing.Point(362, 13);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(52, 14);
            this.quantity_label.TabIndex = 15;
            this.quantity_label.Text = "Quantity";
            // 
            // cart_build_tile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.quantity_textbox);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.materials_flow_layout_panel);
            this.Name = "cart_build_tile";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(541, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel materials_flow_layout_panel;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.TextBox quantity_textbox;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Label quantity_label;
    }
}

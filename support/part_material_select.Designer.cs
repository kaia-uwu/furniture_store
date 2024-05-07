namespace furniture_store.support
{
    partial class part_material_select
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
            name_label = new System.Windows.Forms.Label();
            materials_flow_layout_panel = new System.Windows.Forms.FlowLayoutPanel();
            SuspendLayout();
            // 
            // name_label
            // 
            name_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            name_label.ForeColor = System.Drawing.Color.MistyRose;
            name_label.Location = new System.Drawing.Point(3, 3);
            name_label.Margin = new System.Windows.Forms.Padding(3);
            name_label.Name = "name_label";
            name_label.Size = new System.Drawing.Size(286, 29);
            name_label.TabIndex = 8;
            name_label.Text = "Name";
            // 
            // materials_flow_layout_panel
            // 
            materials_flow_layout_panel.Location = new System.Drawing.Point(6, 38);
            materials_flow_layout_panel.Name = "materials_flow_layout_panel";
            materials_flow_layout_panel.Size = new System.Drawing.Size(283, 45);
            materials_flow_layout_panel.TabIndex = 10;
            materials_flow_layout_panel.WrapContents = false;
            // 
            // part_material_select
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(materials_flow_layout_panel);
            Controls.Add(name_label);
            Name = "part_material_select";
            Padding = new System.Windows.Forms.Padding(3);
            Size = new System.Drawing.Size(294, 82);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.FlowLayoutPanel materials_flow_layout_panel;
    }
}

namespace furniture_store.support
{
    partial class selectable_icon
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
            picture_box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)picture_box).BeginInit();
            SuspendLayout();
            // 
            // picture_box
            // 
            picture_box.BackColor = System.Drawing.Color.Transparent;
            picture_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picture_box.Location = new System.Drawing.Point(2, 2);
            picture_box.Name = "picture_box";
            picture_box.Size = new System.Drawing.Size(30, 30);
            picture_box.TabIndex = 0;
            picture_box.TabStop = false;
            picture_box.Click += select;
            // 
            // selectable_icon
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(picture_box);
            Name = "selectable_icon";
            Size = new System.Drawing.Size(34, 34);
            Click += select;
            ((System.ComponentModel.ISupportInitialize)picture_box).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picture_box;
    }
}

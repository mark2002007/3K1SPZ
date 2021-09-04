
namespace _3K1SPZ
{
    partial class Settings_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Apply_button = new System.Windows.Forms.Button();
            this.Vanish_checkBox = new System.Windows.Forms.CheckBox();
            this.InvertDirection_checkBox = new System.Windows.Forms.CheckBox();
            this.InvertColors_checkBox = new System.Windows.Forms.CheckBox();
            this.DoubleSize_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Apply_button
            // 
            this.Apply_button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Apply_button.Location = new System.Drawing.Point(29, 243);
            this.Apply_button.Name = "Apply_button";
            this.Apply_button.Size = new System.Drawing.Size(235, 69);
            this.Apply_button.TabIndex = 0;
            this.Apply_button.Text = "Apply";
            this.Apply_button.UseVisualStyleBackColor = true;
            this.Apply_button.Click += new System.EventHandler(this.Apply_button_Click);
            // 
            // Vanish_checkBox
            // 
            this.Vanish_checkBox.AutoSize = true;
            this.Vanish_checkBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Vanish_checkBox.Location = new System.Drawing.Point(29, 27);
            this.Vanish_checkBox.Name = "Vanish_checkBox";
            this.Vanish_checkBox.Size = new System.Drawing.Size(130, 45);
            this.Vanish_checkBox.TabIndex = 1;
            this.Vanish_checkBox.Text = "Vanish";
            this.Vanish_checkBox.UseVisualStyleBackColor = true;
            // 
            // InvertDirection_checkBox
            // 
            this.InvertDirection_checkBox.AutoSize = true;
            this.InvertDirection_checkBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InvertDirection_checkBox.Location = new System.Drawing.Point(29, 78);
            this.InvertDirection_checkBox.Name = "InvertDirection_checkBox";
            this.InvertDirection_checkBox.Size = new System.Drawing.Size(247, 45);
            this.InvertDirection_checkBox.TabIndex = 2;
            this.InvertDirection_checkBox.Text = "Invert Direction";
            this.InvertDirection_checkBox.UseVisualStyleBackColor = true;
            // 
            // InvertColors_checkBox
            // 
            this.InvertColors_checkBox.AutoSize = true;
            this.InvertColors_checkBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InvertColors_checkBox.Location = new System.Drawing.Point(29, 129);
            this.InvertColors_checkBox.Name = "InvertColors_checkBox";
            this.InvertColors_checkBox.Size = new System.Drawing.Size(212, 45);
            this.InvertColors_checkBox.TabIndex = 3;
            this.InvertColors_checkBox.Text = "Invert Colors";
            this.InvertColors_checkBox.UseVisualStyleBackColor = true;
            // 
            // DoubleSize_checkBox
            // 
            this.DoubleSize_checkBox.AutoSize = true;
            this.DoubleSize_checkBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoubleSize_checkBox.Location = new System.Drawing.Point(29, 180);
            this.DoubleSize_checkBox.Name = "DoubleSize_checkBox";
            this.DoubleSize_checkBox.Size = new System.Drawing.Size(202, 45);
            this.DoubleSize_checkBox.TabIndex = 4;
            this.DoubleSize_checkBox.Text = "Double Size";
            this.DoubleSize_checkBox.UseVisualStyleBackColor = true;
            // 
            // Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 336);
            this.Controls.Add(this.DoubleSize_checkBox);
            this.Controls.Add(this.InvertColors_checkBox);
            this.Controls.Add(this.InvertDirection_checkBox);
            this.Controls.Add(this.Vanish_checkBox);
            this.Controls.Add(this.Apply_button);
            this.Name = "Settings_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Apply_button;
        private System.Windows.Forms.CheckBox Vanish_checkBox;
        private System.Windows.Forms.CheckBox InvertDirection_checkBox;
        private System.Windows.Forms.CheckBox InvertColors_checkBox;
        private System.Windows.Forms.CheckBox DoubleSize_checkBox;
    }
}
namespace CarDealership
{
    partial class frmCarDealership
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
            this.btnCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(84, 87);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(133, 59);
            this.btnCar.TabIndex = 0;
            this.btnCar.Text = "Car Button";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // frmCarDealership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnCar);
            this.Name = "frmCarDealership";
            this.Text = "Price Quote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCar;
    }
}


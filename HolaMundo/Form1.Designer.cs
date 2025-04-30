namespace HolaMundo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtContraseña1 = new TextBox();
            txtContraseña2 = new TextBox();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // txtContraseña1
            // 
            txtContraseña1.Location = new Point(173, 87);
            txtContraseña1.Name = "txtContraseña1";
            txtContraseña1.Size = new Size(509, 23);
            txtContraseña1.TabIndex = 0;
            // 
            // txtContraseña2
            // 
            txtContraseña2.Location = new Point(173, 164);
            txtContraseña2.Name = "txtContraseña2";
            txtContraseña2.Size = new Size(509, 23);
            txtContraseña2.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(336, 251);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(178, 82);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnValidar);
            Controls.Add(txtContraseña2);
            Controls.Add(txtContraseña1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContraseña1;
        private TextBox txtContraseña2;
        private Button btnValidar;
    }
}

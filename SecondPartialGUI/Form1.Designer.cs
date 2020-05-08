namespace SecondPartialGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttnExercises1 = new System.Windows.Forms.Button();
            this.bttnTheory1 = new System.Windows.Forms.Button();
            this.txtWelcome = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.bttnTheory2 = new System.Windows.Forms.Button();
            this.bttnExercises2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnExercises1
            // 
            this.bttnExercises1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExercises1.Location = new System.Drawing.Point(621, 517);
            this.bttnExercises1.Name = "bttnExercises1";
            this.bttnExercises1.Size = new System.Drawing.Size(230, 65);
            this.bttnExercises1.TabIndex = 10;
            this.bttnExercises1.TabStop = false;
            this.bttnExercises1.Text = "Contestar ejercicios\r\n(Primer Parcial)";
            this.bttnExercises1.UseVisualStyleBackColor = true;
            this.bttnExercises1.Click += new System.EventHandler(this.bttnExercises1_Click);
            // 
            // bttnTheory1
            // 
            this.bttnTheory1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnTheory1.Location = new System.Drawing.Point(621, 436);
            this.bttnTheory1.Name = "bttnTheory1";
            this.bttnTheory1.Size = new System.Drawing.Size(230, 65);
            this.bttnTheory1.TabIndex = 9;
            this.bttnTheory1.TabStop = false;
            this.bttnTheory1.Text = "Revisar la teoría\r\n(Primer Parcial)";
            this.bttnTheory1.UseVisualStyleBackColor = true;
            this.bttnTheory1.Click += new System.EventHandler(this.bttnTheory1_Click);
            // 
            // txtWelcome
            // 
            this.txtWelcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWelcome.CausesValidation = false;
            this.txtWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtWelcome.Location = new System.Drawing.Point(78, 435);
            this.txtWelcome.Multiline = true;
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.ReadOnly = true;
            this.txtWelcome.Size = new System.Drawing.Size(534, 153);
            this.txtWelcome.TabIndex = 8;
            this.txtWelcome.TabStop = false;
            this.txtWelcome.Text = "Este pequeño programa te ayudará a recordar\r\ntodos los conceptos básicos de matem" +
    "áticas\r\ndiscretas, al mismo tiempo que te dejará poner\r\na prueba tus conocimient" +
    "os con dos pequeños \r\nexámenes.";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Bahnschrift SemiBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(351, 289);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(477, 96);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "¡Bienvenido!";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(461, 53);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(257, 251);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 7;
            this.imgLogo.TabStop = false;
            // 
            // bttnTheory2
            // 
            this.bttnTheory2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnTheory2.Location = new System.Drawing.Point(866, 436);
            this.bttnTheory2.Name = "bttnTheory2";
            this.bttnTheory2.Size = new System.Drawing.Size(230, 65);
            this.bttnTheory2.TabIndex = 11;
            this.bttnTheory2.TabStop = false;
            this.bttnTheory2.Text = "Revisar la teoría\r\n(Segundo Parcial)";
            this.bttnTheory2.UseVisualStyleBackColor = true;
            this.bttnTheory2.Click += new System.EventHandler(this.bttnTheory2_Click);
            // 
            // bttnExercises2
            // 
            this.bttnExercises2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExercises2.Location = new System.Drawing.Point(866, 517);
            this.bttnExercises2.Name = "bttnExercises2";
            this.bttnExercises2.Size = new System.Drawing.Size(230, 65);
            this.bttnExercises2.TabIndex = 12;
            this.bttnExercises2.TabStop = false;
            this.bttnExercises2.Text = "Contestar ejercicios\r\n(Segundo Parcial)";
            this.bttnExercises2.UseVisualStyleBackColor = true;
            this.bttnExercises2.Click += new System.EventHandler(this.bttnExercises2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 633);
            this.Controls.Add(this.bttnExercises2);
            this.Controls.Add(this.bttnTheory2);
            this.Controls.Add(this.bttnExercises1);
            this.Controls.Add(this.bttnTheory1);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1150, 680);
            this.MinimumSize = new System.Drawing.Size(1150, 680);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TECHNION - Discrete Mathematics GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnExercises1;
        private System.Windows.Forms.Button bttnTheory1;
        private System.Windows.Forms.TextBox txtWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button bttnTheory2;
        private System.Windows.Forms.Button bttnExercises2;
    }
}


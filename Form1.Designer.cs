namespace AndreBeatriz72BCArro
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
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.btnFrear = new System.Windows.Forms.Button();
            this.lblVelocidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbligar = new System.Windows.Forms.RadioButton();
            this.rdbdesligar = new System.Windows.Forms.RadioButton();
            this.lblMarcha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(157, 331);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(75, 23);
            this.btnAcelerar.TabIndex = 0;
            this.btnAcelerar.Text = "acelerar";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            this.btnAcelerar.Click += new System.EventHandler(this.btnAcelerar_Click);
            // 
            // btnFrear
            // 
            this.btnFrear.Location = new System.Drawing.Point(323, 331);
            this.btnFrear.Name = "btnFrear";
            this.btnFrear.Size = new System.Drawing.Size(75, 23);
            this.btnFrear.TabIndex = 1;
            this.btnFrear.Text = "Frear";
            this.btnFrear.UseVisualStyleBackColor = true;
            // 
            // lblVelocidade
            // 
            this.lblVelocidade.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVelocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidade.Location = new System.Drawing.Point(252, 187);
            this.lblVelocidade.Name = "lblVelocidade";
            this.lblVelocidade.Size = new System.Drawing.Size(100, 50);
            this.lblVelocidade.TabIndex = 2;
            this.lblVelocidade.Text = "0";
            this.lblVelocidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "km/h";
            // 
            // rdbligar
            // 
            this.rdbligar.AutoSize = true;
            this.rdbligar.Location = new System.Drawing.Point(157, 79);
            this.rdbligar.Name = "rdbligar";
            this.rdbligar.Size = new System.Drawing.Size(44, 17);
            this.rdbligar.TabIndex = 4;
            this.rdbligar.Text = "ligar";
            this.rdbligar.UseVisualStyleBackColor = true;
            // 
            // rdbdesligar
            // 
            this.rdbdesligar.AutoSize = true;
            this.rdbdesligar.Checked = true;
            this.rdbdesligar.Location = new System.Drawing.Point(373, 79);
            this.rdbdesligar.Name = "rdbdesligar";
            this.rdbdesligar.Size = new System.Drawing.Size(61, 17);
            this.rdbdesligar.TabIndex = 5;
            this.rdbdesligar.TabStop = true;
            this.rdbdesligar.Text = "desligar";
            this.rdbdesligar.UseVisualStyleBackColor = true;
            // 
            // lblMarcha
            // 
            this.lblMarcha.AutoSize = true;
            this.lblMarcha.Location = new System.Drawing.Point(68, 246);
            this.lblMarcha.Name = "lblMarcha";
            this.lblMarcha.Size = new System.Drawing.Size(35, 13);
            this.lblMarcha.TabIndex = 6;
            this.lblMarcha.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.lblMarcha);
            this.Controls.Add(this.rdbdesligar);
            this.Controls.Add(this.rdbligar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVelocidade);
            this.Controls.Add(this.btnFrear);
            this.Controls.Add(this.btnAcelerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcelerar;
        private System.Windows.Forms.Button btnFrear;
        private System.Windows.Forms.Label lblVelocidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbligar;
        private System.Windows.Forms.RadioButton rdbdesligar;
        private System.Windows.Forms.Label lblMarcha;
    }
}


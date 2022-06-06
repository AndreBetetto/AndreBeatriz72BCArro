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
            this.components = new System.ComponentModel.Container();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.btnFrear = new System.Windows.Forms.Button();
            this.lblVelocidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbligar = new System.Windows.Forms.RadioButton();
            this.rdbdesligar = new System.Windows.Forms.RadioButton();
            this.lblMarcha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMostraMarcha = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblGas = new System.Windows.Forms.Label();
            this.labelGasolina = new System.Windows.Forms.Label();
            this.labelConsumo = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKmRodados = new System.Windows.Forms.Label();
            this.lblVelMax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(157, 331);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(75, 23);
            this.btnAcelerar.TabIndex = 0;
            this.btnAcelerar.Text = "Acelerar";
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
            this.btnFrear.Click += new System.EventHandler(this.btnFrear_Click);
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
            this.rdbligar.CheckedChanged += new System.EventHandler(this.rdbligar_CheckedChanged);
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
            this.lblMarcha.Size = new System.Drawing.Size(13, 13);
            this.lblMarcha.TabIndex = 6;
            this.lblMarcha.Text = "0";
            // 
            // lblMostraMarcha
            // 
            this.lblMostraMarcha.AutoSize = true;
            this.lblMostraMarcha.Location = new System.Drawing.Point(51, 224);
            this.lblMostraMarcha.Name = "lblMostraMarcha";
            this.lblMostraMarcha.Size = new System.Drawing.Size(46, 13);
            this.lblMostraMarcha.TabIndex = 7;
            this.lblMostraMarcha.Text = "Marcha:";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(124, 142);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(19, 13);
            this.lblTempo.TabIndex = 8;
            this.lblTempo.Text = "00";
            // 
            // lblGas
            // 
            this.lblGas.AutoSize = true;
            this.lblGas.Location = new System.Drawing.Point(486, 207);
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(34, 13);
            this.lblGas.TabIndex = 9;
            this.lblGas.Text = "300 L";
            // 
            // labelGasolina
            // 
            this.labelGasolina.AutoSize = true;
            this.labelGasolina.Location = new System.Drawing.Point(481, 177);
            this.labelGasolina.Name = "labelGasolina";
            this.labelGasolina.Size = new System.Drawing.Size(51, 13);
            this.labelGasolina.TabIndex = 10;
            this.labelGasolina.Text = "Gasolina:";
            // 
            // labelConsumo
            // 
            this.labelConsumo.AutoSize = true;
            this.labelConsumo.Location = new System.Drawing.Point(478, 265);
            this.labelConsumo.Name = "labelConsumo";
            this.labelConsumo.Size = new System.Drawing.Size(54, 13);
            this.labelConsumo.TabIndex = 11;
            this.labelConsumo.Text = "Consumo:";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(486, 283);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(43, 13);
            this.lblConsumo.TabIndex = 12;
            this.lblConsumo.Text = "0 L/min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Minutos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Metros rodados:";
            // 
            // lblKmRodados
            // 
            this.lblKmRodados.AutoSize = true;
            this.lblKmRodados.Location = new System.Drawing.Point(294, 26);
            this.lblKmRodados.Name = "lblKmRodados";
            this.lblKmRodados.Size = new System.Drawing.Size(24, 13);
            this.lblKmRodados.TabIndex = 15;
            this.lblKmRodados.Text = "0 m";
            // 
            // lblVelMax
            // 
            this.lblVelMax.AutoSize = true;
            this.lblVelMax.Location = new System.Drawing.Point(229, 242);
            this.lblVelMax.Name = "lblVelMax";
            this.lblVelMax.Size = new System.Drawing.Size(149, 13);
            this.lblVelMax.TabIndex = 16;
            this.lblVelMax.Text = "Velocidade Máxima Atingida!!!";
            this.lblVelMax.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.lblVelMax);
            this.Controls.Add(this.lblKmRodados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.labelConsumo);
            this.Controls.Add(this.labelGasolina);
            this.Controls.Add(this.lblGas);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblMostraMarcha);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMostraMarcha;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.Label labelGasolina;
        private System.Windows.Forms.Label labelConsumo;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKmRodados;
        private System.Windows.Forms.Label lblVelMax;
    }
}


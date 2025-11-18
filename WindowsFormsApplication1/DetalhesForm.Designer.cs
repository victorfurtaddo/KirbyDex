namespace WindowsFormsApplication1
{
    partial class DetalhesForm
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblHabilidade = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblAtaque = new System.Windows.Forms.Label();
            this.lblVelocidade = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.pbHP = new System.Windows.Forms.ProgressBar();
            this.pbVelocidade = new System.Windows.Forms.ProgressBar();
            this.pbAtaque = new System.Windows.Forms.ProgressBar();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.pbMonstro = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonstro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(221, 311);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(99, 33);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "label1";
            // 
            // lblHabilidade
            // 
            this.lblHabilidade.AutoSize = true;
            this.lblHabilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabilidade.Location = new System.Drawing.Point(222, 491);
            this.lblHabilidade.Name = "lblHabilidade";
            this.lblHabilidade.Size = new System.Drawing.Size(70, 25);
            this.lblHabilidade.TabIndex = 1;
            this.lblHabilidade.Text = "label2";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(90, 491);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(131, 25);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Habilidades:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(107, 389);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(114, 25);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Descrição:";
            // 
            // lblAtaque
            // 
            this.lblAtaque.AutoSize = true;
            this.lblAtaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtaque.Location = new System.Drawing.Point(601, 172);
            this.lblAtaque.Name = "lblAtaque";
            this.lblAtaque.Size = new System.Drawing.Size(86, 25);
            this.lblAtaque.TabIndex = 6;
            this.lblAtaque.Text = "Ataque:";
            this.lblAtaque.Visible = false;
            // 
            // lblVelocidade
            // 
            this.lblVelocidade.AutoSize = true;
            this.lblVelocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidade.Location = new System.Drawing.Point(562, 215);
            this.lblVelocidade.Name = "lblVelocidade";
            this.lblVelocidade.Size = new System.Drawing.Size(125, 25);
            this.lblVelocidade.TabIndex = 7;
            this.lblVelocidade.Text = "Velocidade:";
            this.lblVelocidade.Visible = false;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(637, 134);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(47, 25);
            this.lblHP.TabIndex = 8;
            this.lblHP.Text = "HP:";
            this.lblHP.Visible = false;
            // 
            // pbHP
            // 
            this.pbHP.Location = new System.Drawing.Point(690, 139);
            this.pbHP.Name = "pbHP";
            this.pbHP.Size = new System.Drawing.Size(163, 20);
            this.pbHP.TabIndex = 11;
            // 
            // pbVelocidade
            // 
            this.pbVelocidade.Location = new System.Drawing.Point(690, 220);
            this.pbVelocidade.Name = "pbVelocidade";
            this.pbVelocidade.Size = new System.Drawing.Size(163, 20);
            this.pbVelocidade.TabIndex = 12;
            // 
            // pbAtaque
            // 
            this.pbAtaque.Location = new System.Drawing.Point(690, 180);
            this.pbAtaque.Name = "pbAtaque";
            this.pbAtaque.Size = new System.Drawing.Size(163, 20);
            this.pbAtaque.TabIndex = 13;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(222, 389);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(321, 102);
            this.lblDescricao.TabIndex = 15;
            this.lblDescricao.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "HP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(559, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Velocidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(598, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ataque:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Gold;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gbStatus
            // 
            this.gbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(549, 111);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(335, 147);
            this.gbStatus.TabIndex = 20;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // pbMonstro
            // 
            this.pbMonstro.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbMonstro.Location = new System.Drawing.Point(156, 67);
            this.pbMonstro.Name = "pbMonstro";
            this.pbMonstro.Size = new System.Drawing.Size(238, 238);
            this.pbMonstro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMonstro.TabIndex = 3;
            this.pbMonstro.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Kirby_logo;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Kirby_logo;
            this.pictureBox1.Location = new System.Drawing.Point(549, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // DetalhesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(896, 597);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.pbAtaque);
            this.Controls.Add(this.pbVelocidade);
            this.Controls.Add(this.pbHP);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblVelocidade);
            this.Controls.Add(this.lblAtaque);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pbMonstro);
            this.Controls.Add(this.lblHabilidade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.gbStatus);
            this.Name = "DetalhesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes";
            ((System.ComponentModel.ISupportInitialize)(this.pbMonstro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblHabilidade;
        private System.Windows.Forms.PictureBox pbMonstro;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblAtaque;
        private System.Windows.Forms.Label lblVelocidade;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.ProgressBar pbHP;
        private System.Windows.Forms.ProgressBar pbVelocidade;
        private System.Windows.Forms.ProgressBar pbAtaque;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
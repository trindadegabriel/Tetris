namespace Tetris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnIniciarJogo = new System.Windows.Forms.Button();
            this.btnResetarJogo = new System.Windows.Forms.Button();
            this.btnPausarJogo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.btnSalvarJogo = new System.Windows.Forms.Button();
            this.TabuleiroVisual = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarJogo
            // 
            this.btnIniciarJogo.BackColor = System.Drawing.Color.White;
            this.btnIniciarJogo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIniciarJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarJogo.Location = new System.Drawing.Point(819, 484);
            this.btnIniciarJogo.Name = "btnIniciarJogo";
            this.btnIniciarJogo.Size = new System.Drawing.Size(166, 60);
            this.btnIniciarJogo.TabIndex = 0;
            this.btnIniciarJogo.Text = "▶";
            this.btnIniciarJogo.UseVisualStyleBackColor = false;
            this.btnIniciarJogo.Click += new System.EventHandler(this.btnIniciarJogo_Click);
            // 
            // btnResetarJogo
            // 
            this.btnResetarJogo.BackColor = System.Drawing.Color.White;
            this.btnResetarJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetarJogo.Location = new System.Drawing.Point(819, 616);
            this.btnResetarJogo.Name = "btnResetarJogo";
            this.btnResetarJogo.Size = new System.Drawing.Size(166, 60);
            this.btnResetarJogo.TabIndex = 1;
            this.btnResetarJogo.Text = "↺";
            this.btnResetarJogo.UseVisualStyleBackColor = false;
            this.btnResetarJogo.Click += new System.EventHandler(this.btnResetarJogo_Click);
            // 
            // btnPausarJogo
            // 
            this.btnPausarJogo.BackColor = System.Drawing.Color.White;
            this.btnPausarJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausarJogo.Location = new System.Drawing.Point(819, 550);
            this.btnPausarJogo.Name = "btnPausarJogo";
            this.btnPausarJogo.Size = new System.Drawing.Size(166, 60);
            this.btnPausarJogo.TabIndex = 2;
            this.btnPausarJogo.Text = "▎ ▎";
            this.btnPausarJogo.UseVisualStyleBackColor = false;
            this.btnPausarJogo.Click += new System.EventHandler(this.PausarJogo);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(811, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "PONTOS";
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.BackColor = System.Drawing.Color.Transparent;
            this.lblPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.ForeColor = System.Drawing.Color.White;
            this.lblPontos.Location = new System.Drawing.Point(880, 137);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(43, 46);
            this.lblPontos.TabIndex = 6;
            this.lblPontos.Text = "0";
            this.lblPontos.Visible = false;
            // 
            // btnSalvarJogo
            // 
            this.btnSalvarJogo.BackColor = System.Drawing.Color.White;
            this.btnSalvarJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarJogo.Location = new System.Drawing.Point(819, 682);
            this.btnSalvarJogo.Name = "btnSalvarJogo";
            this.btnSalvarJogo.Size = new System.Drawing.Size(166, 60);
            this.btnSalvarJogo.TabIndex = 7;
            this.btnSalvarJogo.Text = "🖫";
            this.btnSalvarJogo.UseVisualStyleBackColor = false;
            this.btnSalvarJogo.Click += new System.EventHandler(this.btnSalvarJogo_Click);
            // 
            // TabuleiroVisual
            // 
            this.TabuleiroVisual.BackColor = System.Drawing.Color.Black;
            this.TabuleiroVisual.ColumnCount = 10;
            this.TabuleiroVisual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabuleiroVisual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabuleiroVisual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabuleiroVisual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabuleiroVisual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabuleiroVisual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabuleiroVisual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabuleiroVisual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabuleiroVisual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabuleiroVisual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabuleiroVisual.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TabuleiroVisual.Location = new System.Drawing.Point(0, 0);
            this.TabuleiroVisual.Name = "TabuleiroVisual";
            this.TabuleiroVisual.RowCount = 20;
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TabuleiroVisual.Size = new System.Drawing.Size(718, 739);
            this.TabuleiroVisual.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TabuleiroVisual);
            this.panel1.Location = new System.Drawing.Point(62, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 739);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1098, 800);
            this.Controls.Add(this.btnSalvarJogo);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPausarJogo);
            this.Controls.Add(this.btnResetarJogo);
            this.Controls.Add(this.btnIniciarJogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TETRIS";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarJogo;
        private System.Windows.Forms.Button btnResetarJogo;
        private System.Windows.Forms.Button btnPausarJogo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Button btnSalvarJogo;
        private System.Windows.Forms.TableLayoutPanel TabuleiroVisual;
        private System.Windows.Forms.Panel panel1;
    }
}


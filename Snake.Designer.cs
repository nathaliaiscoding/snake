
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Snake
{
    partial class Snake
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelScore = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(3)))));
            this.labelScore.Location = new System.Drawing.Point(12, 5);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(77, 20);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "Score: 0";
            // 
            // labelFood
            // 
            this.labelFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(3)))));
            this.labelFood.Location = new System.Drawing.Point(354, 168);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(21, 21);
            this.labelFood.TabIndex = 1;
            this.labelFood.Text = " ";
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(201)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.labelScore);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Snake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        public Label labelScore;
        public Label labelFood;
    }
}


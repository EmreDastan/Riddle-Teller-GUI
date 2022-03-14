
namespace Riddle_Teller
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titlename = new System.Windows.Forms.Label();
            this.Riddlebutton = new System.Windows.Forms.Button();
            this.answerbutton = new System.Windows.Forms.Button();
            this.quitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titlename
            // 
            this.Titlename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Titlename.Font = new System.Drawing.Font("Ravie", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Titlename.Location = new System.Drawing.Point(13, 15);
            this.Titlename.Name = "Titlename";
            this.Titlename.Size = new System.Drawing.Size(348, 135);
            this.Titlename.TabIndex = 0;
            this.Titlename.Text = "Riddle me this";
            this.Titlename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Riddlebutton
            // 
            this.Riddlebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Riddlebutton.Font = new System.Drawing.Font("Jokerman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Riddlebutton.Location = new System.Drawing.Point(12, 166);
            this.Riddlebutton.Name = "Riddlebutton";
            this.Riddlebutton.Size = new System.Drawing.Size(349, 62);
            this.Riddlebutton.TabIndex = 1;
            this.Riddlebutton.Text = "Riddle";
            this.Riddlebutton.UseVisualStyleBackColor = false;
            this.Riddlebutton.Click += new System.EventHandler(this.Riddlebutton_Click);
            // 
            // answerbutton
            // 
            this.answerbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.answerbutton.Font = new System.Drawing.Font("Jokerman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerbutton.Location = new System.Drawing.Point(12, 234);
            this.answerbutton.Name = "answerbutton";
            this.answerbutton.Size = new System.Drawing.Size(349, 62);
            this.answerbutton.TabIndex = 2;
            this.answerbutton.Text = "Answer";
            this.answerbutton.UseVisualStyleBackColor = false;
            this.answerbutton.Click += new System.EventHandler(this.answerbutton_Click);
            // 
            // quitbutton
            // 
            this.quitbutton.BackColor = System.Drawing.Color.Maroon;
            this.quitbutton.Font = new System.Drawing.Font("Jokerman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitbutton.Location = new System.Drawing.Point(12, 302);
            this.quitbutton.Name = "quitbutton";
            this.quitbutton.Size = new System.Drawing.Size(349, 62);
            this.quitbutton.TabIndex = 3;
            this.quitbutton.Text = "Quit";
            this.quitbutton.UseVisualStyleBackColor = false;
            this.quitbutton.Click += new System.EventHandler(this.quitbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(373, 378);
            this.Controls.Add(this.quitbutton);
            this.Controls.Add(this.answerbutton);
            this.Controls.Add(this.Riddlebutton);
            this.Controls.Add(this.Titlename);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Titlename;
        private System.Windows.Forms.Button Riddlebutton;
        private System.Windows.Forms.Button answerbutton;
        private System.Windows.Forms.Button quitbutton;
    }
}


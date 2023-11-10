
namespace LABA_2_FORMA
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CBsugar = new System.Windows.Forms.CheckBox();
            this.CBmilk = new System.Windows.Forms.CheckBox();
            this.RBamericano = new System.Windows.Forms.RadioButton();
            this.RBcappuccino = new System.Windows.Forms.RadioButton();
            this.RBespresso = new System.Windows.Forms.RadioButton();
            this.RBcacao = new System.Windows.Forms.RadioButton();
            this.butOK = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // CBsugar
            // 
            this.CBsugar.AutoSize = true;
            this.CBsugar.Location = new System.Drawing.Point(224, 68);
            this.CBsugar.Margin = new System.Windows.Forms.Padding(4);
            this.CBsugar.Name = "CBsugar";
            this.CBsugar.Size = new System.Drawing.Size(92, 29);
            this.CBsugar.TabIndex = 0;
            this.CBsugar.Text = "Сахар";
            this.CBsugar.UseVisualStyleBackColor = true;
            // 
            // CBmilk
            // 
            this.CBmilk.AutoSize = true;
            this.CBmilk.Location = new System.Drawing.Point(224, 150);
            this.CBmilk.Margin = new System.Windows.Forms.Padding(4);
            this.CBmilk.Name = "CBmilk";
            this.CBmilk.Size = new System.Drawing.Size(109, 29);
            this.CBmilk.TabIndex = 1;
            this.CBmilk.Text = "Молоко";
            this.CBmilk.UseVisualStyleBackColor = true;
            // 
            // RBamericano
            // 
            this.RBamericano.AutoSize = true;
            this.RBamericano.Location = new System.Drawing.Point(17, 66);
            this.RBamericano.Margin = new System.Windows.Forms.Padding(4);
            this.RBamericano.Name = "RBamericano";
            this.RBamericano.Size = new System.Drawing.Size(142, 29);
            this.RBamericano.TabIndex = 2;
            this.RBamericano.TabStop = true;
            this.RBamericano.Text = "Американо";
            this.RBamericano.UseVisualStyleBackColor = true;
            this.RBamericano.CheckedChanged += new System.EventHandler(this.RBamericano_CheckedChanged);
            // 
            // RBcappuccino
            // 
            this.RBcappuccino.AutoSize = true;
            this.RBcappuccino.Location = new System.Drawing.Point(17, 122);
            this.RBcappuccino.Margin = new System.Windows.Forms.Padding(4);
            this.RBcappuccino.Name = "RBcappuccino";
            this.RBcappuccino.Size = new System.Drawing.Size(123, 29);
            this.RBcappuccino.TabIndex = 3;
            this.RBcappuccino.TabStop = true;
            this.RBcappuccino.Text = "Капучино";
            this.RBcappuccino.UseVisualStyleBackColor = true;
            this.RBcappuccino.CheckedChanged += new System.EventHandler(this.RBcappuccino_CheckedChanged);
            // 
            // RBespresso
            // 
            this.RBespresso.AutoSize = true;
            this.RBespresso.Location = new System.Drawing.Point(17, 176);
            this.RBespresso.Margin = new System.Windows.Forms.Padding(4);
            this.RBespresso.Name = "RBespresso";
            this.RBespresso.Size = new System.Drawing.Size(125, 29);
            this.RBespresso.TabIndex = 4;
            this.RBespresso.TabStop = true;
            this.RBespresso.Text = "Эспрессо";
            this.RBespresso.UseVisualStyleBackColor = true;
            this.RBespresso.CheckedChanged += new System.EventHandler(this.RBespresso_CheckedChanged);
            // 
            // RBcacao
            // 
            this.RBcacao.AutoSize = true;
            this.RBcacao.Location = new System.Drawing.Point(17, 231);
            this.RBcacao.Margin = new System.Windows.Forms.Padding(4);
            this.RBcacao.Name = "RBcacao";
            this.RBcacao.Size = new System.Drawing.Size(90, 29);
            this.RBcacao.TabIndex = 5;
            this.RBcacao.TabStop = true;
            this.RBcacao.Text = "Какао";
            this.RBcacao.UseVisualStyleBackColor = true;
            this.RBcacao.CheckedChanged += new System.EventHandler(this.RBcacao_CheckedChanged);
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(77, 294);
            this.butOK.Margin = new System.Windows.Forms.Padding(4);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(239, 45);
            this.butOK.TabIndex = 6;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Visible = false;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(42, 413);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(123, 25);
            this.label.TabIndex = 7;
            this.label.Text = "Ваш выбор?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Стоимость покупки";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(396, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 128);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(396, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 128);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(396, 363);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 128);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 562);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.RBcacao);
            this.Controls.Add(this.RBespresso);
            this.Controls.Add(this.RBcappuccino);
            this.Controls.Add(this.RBamericano);
            this.Controls.Add(this.CBmilk);
            this.Controls.Add(this.CBsugar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Кофейный автомат";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CBsugar;
        private System.Windows.Forms.CheckBox CBmilk;
        private System.Windows.Forms.RadioButton RBamericano;
        private System.Windows.Forms.RadioButton RBcappuccino;
        private System.Windows.Forms.RadioButton RBespresso;
        private System.Windows.Forms.RadioButton RBcacao;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}


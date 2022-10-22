 namespace AppBarber {     partial class Form1     {         private System.ComponentModel.IContainer components = null;          /// <summary>         /// Освободить все используемые ресурсы.         /// </summary>         /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>         protected override void Dispose(bool disposing)         {             if (disposing && (components != null))             {                 components.Dispose();             }             base.Dispose(disposing);         }          #region Код, автоматически созданный конструктором форм Windows          /// <summary>         /// Требуемый метод для поддержки конструктора — не изменяйте          /// содержимое этого метода с помощью редактора кода.         /// </summary>         private void InitializeComponent()         {             this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 158);
            this.label2.MaximumSize = new System.Drawing.Size(500, 40);
            this.label2.MinimumSize = new System.Drawing.Size(48, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "222";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(240, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "333";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(240, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "444";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Перейти к оформлению заказа";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "Список заказов";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 58);
            this.button3.TabIndex = 6;
            this.button3.Text = "Список услуг";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 52);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 463);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(750, 550);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }          #endregion         private System.Windows.Forms.Label label2;         private System.Windows.Forms.Label label3;         private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    } }  
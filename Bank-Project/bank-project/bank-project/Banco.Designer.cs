
namespace bank_project
{
    partial class Banco
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banco));
            this.random = new System.Windows.Forms.Label();
            this.testBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLibre1 = new System.Windows.Forms.Label();
            this.lblCaja1 = new System.Windows.Forms.Label();
            this.lblCaja2 = new System.Windows.Forms.Label();
            this.lblCaja3 = new System.Windows.Forms.Label();
            this.lblCaja4 = new System.Windows.Forms.Label();
            this.lblCaja5 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblConteo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // random
            // 
            this.random.AutoSize = true;
            this.random.Location = new System.Drawing.Point(12, 292);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(86, 13);
            this.random.TabIndex = 0;
            this.random.Text = "numero random: ";
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(12, 308);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 1;
            this.testBtn.Text = "prueba";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Libre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Libre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Libre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(573, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Libre";
            // 
            // lblLibre1
            // 
            this.lblLibre1.AutoSize = true;
            this.lblLibre1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibre1.Location = new System.Drawing.Point(54, 163);
            this.lblLibre1.Name = "lblLibre1";
            this.lblLibre1.Size = new System.Drawing.Size(44, 19);
            this.lblLibre1.TabIndex = 7;
            this.lblLibre1.Text = "Libre";
            // 
            // lblCaja1
            // 
            this.lblCaja1.AutoSize = true;
            this.lblCaja1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja1.Location = new System.Drawing.Point(49, 78);
            this.lblCaja1.Name = "lblCaja1";
            this.lblCaja1.Size = new System.Drawing.Size(61, 19);
            this.lblCaja1.TabIndex = 8;
            this.lblCaja1.Text = "Express";
            this.lblCaja1.Visible = false;
            // 
            // lblCaja2
            // 
            this.lblCaja2.AutoSize = true;
            this.lblCaja2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja2.Location = new System.Drawing.Point(168, 78);
            this.lblCaja2.Name = "lblCaja2";
            this.lblCaja2.Size = new System.Drawing.Size(61, 19);
            this.lblCaja2.TabIndex = 9;
            this.lblCaja2.Text = "Express";
            this.lblCaja2.Visible = false;
            // 
            // lblCaja3
            // 
            this.lblCaja3.AutoSize = true;
            this.lblCaja3.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja3.Location = new System.Drawing.Point(315, 78);
            this.lblCaja3.Name = "lblCaja3";
            this.lblCaja3.Size = new System.Drawing.Size(61, 19);
            this.lblCaja3.TabIndex = 10;
            this.lblCaja3.Text = "Express";
            this.lblCaja3.Visible = false;
            // 
            // lblCaja4
            // 
            this.lblCaja4.AutoSize = true;
            this.lblCaja4.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja4.Location = new System.Drawing.Point(445, 78);
            this.lblCaja4.Name = "lblCaja4";
            this.lblCaja4.Size = new System.Drawing.Size(61, 19);
            this.lblCaja4.TabIndex = 11;
            this.lblCaja4.Text = "Express";
            this.lblCaja4.Visible = false;
            // 
            // lblCaja5
            // 
            this.lblCaja5.AutoSize = true;
            this.lblCaja5.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja5.Location = new System.Drawing.Point(556, 78);
            this.lblCaja5.Name = "lblCaja5";
            this.lblCaja5.Size = new System.Drawing.Size(61, 19);
            this.lblCaja5.TabIndex = 12;
            this.lblCaja5.Text = "Express";
            this.lblCaja5.Visible = false;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(249, 29);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(158, 19);
            this.lbltime.TabIndex = 13;
            this.lbltime.Text = "Tiempo transcurrido: ";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblConteo
            // 
            this.lblConteo.AutoSize = true;
            this.lblConteo.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteo.Location = new System.Drawing.Point(400, 29);
            this.lblConteo.Name = "lblConteo";
            this.lblConteo.Size = new System.Drawing.Size(18, 19);
            this.lblConteo.TabIndex = 14;
            this.lblConteo.Text = "0";
            // 
            // Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 417);
            this.Controls.Add(this.lblConteo);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblCaja5);
            this.Controls.Add(this.lblCaja4);
            this.Controls.Add(this.lblCaja3);
            this.Controls.Add(this.lblCaja2);
            this.Controls.Add(this.lblCaja1);
            this.Controls.Add(this.lblLibre1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.random);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Banco";
            this.ShowIcon = false;
            this.Text = "Banco";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label random;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLibre1;
        private System.Windows.Forms.Label lblCaja1;
        private System.Windows.Forms.Label lblCaja2;
        private System.Windows.Forms.Label lblCaja3;
        private System.Windows.Forms.Label lblCaja4;
        private System.Windows.Forms.Label lblCaja5;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblConteo;
    }
}


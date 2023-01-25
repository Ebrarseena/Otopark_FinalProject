
namespace bil203_Otopark_FinalProject
{
    partial class EditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumberPlate = new System.Windows.Forms.TextBox();
            this.txtBrandd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatuss = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdated = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Plate:";
            // 
            // txtnumberPlate
            // 
            this.txtnumberPlate.Location = new System.Drawing.Point(410, 81);
            this.txtnumberPlate.Name = "txtnumberPlate";
            this.txtnumberPlate.Size = new System.Drawing.Size(181, 19);
            this.txtnumberPlate.TabIndex = 1;
            // 
            // txtBrandd
            // 
            this.txtBrandd.Location = new System.Drawing.Point(410, 120);
            this.txtBrandd.Name = "txtBrandd";
            this.txtBrandd.Size = new System.Drawing.Size(181, 19);
            this.txtBrandd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Brand";
            // 
            // txtModell
            // 
            this.txtModell.Location = new System.Drawing.Point(410, 167);
            this.txtModell.Name = "txtModell";
            this.txtModell.Size = new System.Drawing.Size(181, 19);
            this.txtModell.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model:";
            // 
            // txtStatuss
            // 
            this.txtStatuss.Location = new System.Drawing.Point(410, 214);
            this.txtStatuss.Name = "txtStatuss";
            this.txtStatuss.Size = new System.Drawing.Size(181, 19);
            this.txtStatuss.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status:";
            // 
            // btnUpdated
            // 
            this.btnUpdated.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdated.Font = new System.Drawing.Font("Forte", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdated.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdated.Location = new System.Drawing.Point(288, 292);
            this.btnUpdated.Name = "btnUpdated";
            this.btnUpdated.Size = new System.Drawing.Size(240, 45);
            this.btnUpdated.TabIndex = 8;
            this.btnUpdated.Text = "UPDATED";
            this.btnUpdated.UseVisualStyleBackColor = false;
            this.btnUpdated.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bil203_Otopark_FinalProject.Properties.Resources.istockphoto_1257239366_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(31, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(786, 429);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdated);
            this.Controls.Add(this.txtStatuss);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrandd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumberPlate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumberPlate;
        private System.Windows.Forms.TextBox txtBrandd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStatuss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdated;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
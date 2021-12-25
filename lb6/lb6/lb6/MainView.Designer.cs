namespace lb6
{
    partial class MainView
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
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbModeStay = new System.Windows.Forms.RadioButton();
            this.rbModeSell = new System.Windows.Forms.RadioButton();
            this.rbModeProduce = new System.Windows.Forms.RadioButton();
            this.rbModeBuy = new System.Windows.Forms.RadioButton();
            this.gbResource = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nProduct = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nMaterial = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nWorkshop = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nMoney = new System.Windows.Forms.NumericUpDown();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.gbMode.SuspendLayout();
            this.gbResource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWorkshop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbModeStay);
            this.gbMode.Controls.Add(this.rbModeSell);
            this.gbMode.Controls.Add(this.rbModeProduce);
            this.gbMode.Controls.Add(this.rbModeBuy);
            this.gbMode.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbMode.Location = new System.Drawing.Point(492, 15);
            this.gbMode.Margin = new System.Windows.Forms.Padding(4);
            this.gbMode.Name = "gbMode";
            this.gbMode.Padding = new System.Windows.Forms.Padding(4);
            this.gbMode.Size = new System.Drawing.Size(245, 186);
            this.gbMode.TabIndex = 0;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Режим роботи";
            // 
            // rbModeStay
            // 
            this.rbModeStay.AutoSize = true;
            this.rbModeStay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbModeStay.Location = new System.Drawing.Point(24, 124);
            this.rbModeStay.Margin = new System.Windows.Forms.Padding(4);
            this.rbModeStay.Name = "rbModeStay";
            this.rbModeStay.Size = new System.Drawing.Size(95, 25);
            this.rbModeStay.TabIndex = 0;
            this.rbModeStay.TabStop = true;
            this.rbModeStay.Text = "Простой";
            this.rbModeStay.UseVisualStyleBackColor = true;
            this.rbModeStay.CheckedChanged += new System.EventHandler(this.rbStay_CheckedChanged);
            // 
            // rbModeSell
            // 
            this.rbModeSell.AutoSize = true;
            this.rbModeSell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbModeSell.Location = new System.Drawing.Point(24, 95);
            this.rbModeSell.Margin = new System.Windows.Forms.Padding(4);
            this.rbModeSell.Name = "rbModeSell";
            this.rbModeSell.Size = new System.Drawing.Size(166, 25);
            this.rbModeSell.TabIndex = 0;
            this.rbModeSell.TabStop = true;
            this.rbModeSell.Text = "Продаж продукції";
            this.rbModeSell.UseVisualStyleBackColor = true;
            this.rbModeSell.CheckedChanged += new System.EventHandler(this.rbModeSell_CheckedChanged);
            // 
            // rbModeProduce
            // 
            this.rbModeProduce.AutoSize = true;
            this.rbModeProduce.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbModeProduce.Location = new System.Drawing.Point(24, 68);
            this.rbModeProduce.Margin = new System.Windows.Forms.Padding(4);
            this.rbModeProduce.Name = "rbModeProduce";
            this.rbModeProduce.Size = new System.Drawing.Size(210, 25);
            this.rbModeProduce.TabIndex = 0;
            this.rbModeProduce.TabStop = true;
            this.rbModeProduce.Text = "Виробництво продукції";
            this.rbModeProduce.UseVisualStyleBackColor = true;
            this.rbModeProduce.CheckedChanged += new System.EventHandler(this.rbModeProduce_CheckedChanged);
            // 
            // rbModeBuy
            // 
            this.rbModeBuy.AutoSize = true;
            this.rbModeBuy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbModeBuy.Location = new System.Drawing.Point(24, 39);
            this.rbModeBuy.Margin = new System.Windows.Forms.Padding(4);
            this.rbModeBuy.Name = "rbModeBuy";
            this.rbModeBuy.Size = new System.Drawing.Size(186, 25);
            this.rbModeBuy.TabIndex = 0;
            this.rbModeBuy.TabStop = true;
            this.rbModeBuy.Text = "Закупівля сировини";
            this.rbModeBuy.UseVisualStyleBackColor = true;
            this.rbModeBuy.CheckedChanged += new System.EventHandler(this.rbModeBuy_CheckedChanged);
            // 
            // gbResource
            // 
            this.gbResource.Controls.Add(this.label4);
            this.gbResource.Controls.Add(this.nProduct);
            this.gbResource.Controls.Add(this.label3);
            this.gbResource.Controls.Add(this.nMaterial);
            this.gbResource.Controls.Add(this.label2);
            this.gbResource.Controls.Add(this.nWorkshop);
            this.gbResource.Controls.Add(this.label1);
            this.gbResource.Controls.Add(this.nMoney);
            this.gbResource.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbResource.Location = new System.Drawing.Point(67, 15);
            this.gbResource.Margin = new System.Windows.Forms.Padding(4);
            this.gbResource.Name = "gbResource";
            this.gbResource.Padding = new System.Windows.Forms.Padding(4);
            this.gbResource.Size = new System.Drawing.Size(267, 186);
            this.gbResource.TabIndex = 1;
            this.gbResource.TabStop = false;
            this.gbResource.Text = "Ресурси";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Продукція";
            // 
            // nProduct
            // 
            this.nProduct.Location = new System.Drawing.Point(143, 132);
            this.nProduct.Margin = new System.Windows.Forms.Padding(4);
            this.nProduct.Name = "nProduct";
            this.nProduct.Size = new System.Drawing.Size(91, 29);
            this.nProduct.TabIndex = 0;
            this.nProduct.ValueChanged += new System.EventHandler(this.nProduct_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Сировина";
            // 
            // nMaterial
            // 
            this.nMaterial.Location = new System.Drawing.Point(143, 100);
            this.nMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.nMaterial.Name = "nMaterial";
            this.nMaterial.Size = new System.Drawing.Size(91, 29);
            this.nMaterial.TabIndex = 0;
            this.nMaterial.ValueChanged += new System.EventHandler(this.nMaterial_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кількість цехів";
            // 
            // nWorkshop
            // 
            this.nWorkshop.Location = new System.Drawing.Point(143, 65);
            this.nWorkshop.Margin = new System.Windows.Forms.Padding(4);
            this.nWorkshop.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nWorkshop.Name = "nWorkshop";
            this.nWorkshop.Size = new System.Drawing.Size(91, 29);
            this.nWorkshop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кошти";
            // 
            // nMoney
            // 
            this.nMoney.Location = new System.Drawing.Point(143, 30);
            this.nMoney.Margin = new System.Windows.Forms.Padding(4);
            this.nMoney.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nMoney.Name = "nMoney";
            this.nMoney.Size = new System.Drawing.Size(91, 29);
            this.nMoney.TabIndex = 0;
            this.nMoney.ValueChanged += new System.EventHandler(this.nMoney_ValueChanged);
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(155, 263);
            this.pbProgress.Margin = new System.Windows.Forms.Padding(4);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(582, 27);
            this.pbProgress.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(41, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Прогрес:";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(773, 343);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.gbResource);
            this.Controls.Add(this.gbMode);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.Text = "Завод";
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.gbResource.ResumeLayout(false);
            this.gbResource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWorkshop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbModeSell;
        private System.Windows.Forms.RadioButton rbModeProduce;
        private System.Windows.Forms.RadioButton rbModeBuy;
        private System.Windows.Forms.GroupBox gbResource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nWorkshop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nMoney;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.RadioButton rbModeStay;
        private System.Windows.Forms.Label label5;
    }
}


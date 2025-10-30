namespace lab9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_companyName = new System.Windows.Forms.Label();
            this.lb_orderForm = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_productCode = new System.Windows.Forms.Label();
            this.lb_productName = new System.Windows.Forms.Label();
            this.lb_unitPrice = new System.Windows.Forms.Label();
            this.lb_qty = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.pb_coompangLogo = new System.Windows.Forms.PictureBox();
            this.pb_productImage = new System.Windows.Forms.PictureBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.tb_unitPrice = new System.Windows.Forms.TextBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_cash = new System.Windows.Forms.RadioButton();
            this.rb_visa = new System.Windows.Forms.RadioButton();
            this.cb_freeDelivery = new System.Windows.Forms.CheckBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.lb_outputMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_coompangLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_productImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_companyName
            // 
            this.lb_companyName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_companyName.Location = new System.Drawing.Point(12, 9);
            this.lb_companyName.Name = "lb_companyName";
            this.lb_companyName.Size = new System.Drawing.Size(686, 31);
            this.lb_companyName.TabIndex = 1;
            this.lb_companyName.Text = "Sunshine Order Ltd.";
            // 
            // lb_orderForm
            // 
            this.lb_orderForm.BackColor = System.Drawing.Color.DodgerBlue;
            this.lb_orderForm.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_orderForm.Location = new System.Drawing.Point(12, 52);
            this.lb_orderForm.Name = "lb_orderForm";
            this.lb_orderForm.Size = new System.Drawing.Size(762, 41);
            this.lb_orderForm.TabIndex = 2;
            this.lb_orderForm.Text = "Order Form";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb_coompangLogo);
            this.groupBox1.Controls.Add(this.tb_total);
            this.groupBox1.Controls.Add(this.numQty);
            this.groupBox1.Controls.Add(this.tb_unitPrice);
            this.groupBox1.Controls.Add(this.tb_productName);
            this.groupBox1.Controls.Add(this.cbProduct);
            this.groupBox1.Controls.Add(this.pb_productImage);
            this.groupBox1.Controls.Add(this.lb_total);
            this.groupBox1.Controls.Add(this.lb_qty);
            this.groupBox1.Controls.Add(this.lb_unitPrice);
            this.groupBox1.Controls.Add(this.lb_productName);
            this.groupBox1.Controls.Add(this.lb_productCode);
            this.groupBox1.Location = new System.Drawing.Point(19, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 360);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lb_productCode
            // 
            this.lb_productCode.AutoSize = true;
            this.lb_productCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productCode.Location = new System.Drawing.Point(19, 20);
            this.lb_productCode.Name = "lb_productCode";
            this.lb_productCode.Size = new System.Drawing.Size(153, 19);
            this.lb_productCode.TabIndex = 0;
            this.lb_productCode.Text = "Select Product Code: ";
            // 
            // lb_productName
            // 
            this.lb_productName.AutoSize = true;
            this.lb_productName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productName.Location = new System.Drawing.Point(19, 75);
            this.lb_productName.Name = "lb_productName";
            this.lb_productName.Size = new System.Drawing.Size(113, 19);
            this.lb_productName.TabIndex = 1;
            this.lb_productName.Text = "Product Name: ";
            // 
            // lb_unitPrice
            // 
            this.lb_unitPrice.AutoSize = true;
            this.lb_unitPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_unitPrice.Location = new System.Drawing.Point(19, 130);
            this.lb_unitPrice.Name = "lb_unitPrice";
            this.lb_unitPrice.Size = new System.Drawing.Size(84, 19);
            this.lb_unitPrice.TabIndex = 2;
            this.lb_unitPrice.Text = "Unit Price: ";
            // 
            // lb_qty
            // 
            this.lb_qty.AutoSize = true;
            this.lb_qty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qty.Location = new System.Drawing.Point(19, 185);
            this.lb_qty.Name = "lb_qty";
            this.lb_qty.Size = new System.Drawing.Size(76, 19);
            this.lb_qty.TabIndex = 3;
            this.lb_qty.Text = "Quantity: ";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(19, 240);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(48, 19);
            this.lb_total.TabIndex = 4;
            this.lb_total.Text = "Total:";
            // 
            // pb_coompangLogo
            // 
            this.pb_coompangLogo.Image = ((System.Drawing.Image)(resources.GetObject("pb_coompangLogo.Image")));
            this.pb_coompangLogo.Location = new System.Drawing.Point(553, 17);
            this.pb_coompangLogo.Name = "pb_coompangLogo";
            this.pb_coompangLogo.Size = new System.Drawing.Size(180, 135);
            this.pb_coompangLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_coompangLogo.TabIndex = 5;
            this.pb_coompangLogo.TabStop = false;
            // 
            // pb_productImage
            // 
            this.pb_productImage.Image = ((System.Drawing.Image)(resources.GetObject("pb_productImage.Image")));
            this.pb_productImage.Location = new System.Drawing.Point(469, 158);
            this.pb_productImage.Name = "pb_productImage";
            this.pb_productImage.Size = new System.Drawing.Size(264, 184);
            this.pb_productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_productImage.TabIndex = 6;
            this.pb_productImage.TabStop = false;
            // 
            // cbProduct
            // 
            this.cbProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(19, 39);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(403, 27);
            this.cbProduct.TabIndex = 7;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // tb_productName
            // 
            this.tb_productName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_productName.Location = new System.Drawing.Point(19, 94);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(403, 26);
            this.tb_productName.TabIndex = 8;
            // 
            // tb_unitPrice
            // 
            this.tb_unitPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_unitPrice.Location = new System.Drawing.Point(19, 148);
            this.tb_unitPrice.Name = "tb_unitPrice";
            this.tb_unitPrice.Size = new System.Drawing.Size(403, 26);
            this.tb_unitPrice.TabIndex = 9;
            // 
            // numQty
            // 
            this.numQty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQty.Location = new System.Drawing.Point(22, 204);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(400, 26);
            this.numQty.TabIndex = 10;
            this.numQty.ValueChanged += new System.EventHandler(this.numQty_ValueChanged);
            // 
            // tb_total
            // 
            this.tb_total.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total.Location = new System.Drawing.Point(19, 258);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(403, 26);
            this.tb_total.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.rb_visa);
            this.groupBox2.Controls.Add(this.rb_cash);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Method:";
            // 
            // rb_cash
            // 
            this.rb_cash.AutoSize = true;
            this.rb_cash.Location = new System.Drawing.Point(22, 25);
            this.rb_cash.Name = "rb_cash";
            this.rb_cash.Size = new System.Drawing.Size(70, 23);
            this.rb_cash.TabIndex = 0;
            this.rb_cash.TabStop = true;
            this.rb_cash.Text = "CASH";
            this.rb_cash.UseVisualStyleBackColor = true;
            // 
            // rb_visa
            // 
            this.rb_visa.AutoSize = true;
            this.rb_visa.Location = new System.Drawing.Point(22, 54);
            this.rb_visa.Name = "rb_visa";
            this.rb_visa.Size = new System.Drawing.Size(64, 23);
            this.rb_visa.TabIndex = 1;
            this.rb_visa.TabStop = true;
            this.rb_visa.Text = "VISA";
            this.rb_visa.UseVisualStyleBackColor = true;
            // 
            // cb_freeDelivery
            // 
            this.cb_freeDelivery.AutoSize = true;
            this.cb_freeDelivery.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_freeDelivery.Location = new System.Drawing.Point(19, 595);
            this.cb_freeDelivery.Name = "cb_freeDelivery";
            this.cb_freeDelivery.Size = new System.Drawing.Size(110, 23);
            this.cb_freeDelivery.TabIndex = 5;
            this.cb_freeDelivery.Text = "Free Delivery";
            this.cb_freeDelivery.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(240, 615);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(93, 46);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_order.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.Location = new System.Drawing.Point(401, 615);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(93, 46);
            this.btn_order.TabIndex = 7;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // lb_outputMessage
            // 
            this.lb_outputMessage.AutoSize = true;
            this.lb_outputMessage.Location = new System.Drawing.Point(12, 651);
            this.lb_outputMessage.Name = "lb_outputMessage";
            this.lb_outputMessage.Size = new System.Drawing.Size(0, 13);
            this.lb_outputMessage.TabIndex = 8;
            this.lb_outputMessage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.lb_outputMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.cb_freeDelivery);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lb_orderForm);
            this.Controls.Add(this.lb_companyName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_coompangLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_productImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_companyName;
        private System.Windows.Forms.Label lb_orderForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_productCode;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_qty;
        private System.Windows.Forms.Label lb_unitPrice;
        private System.Windows.Forms.Label lb_productName;
        private System.Windows.Forms.PictureBox pb_productImage;
        private System.Windows.Forms.PictureBox pb_coompangLogo;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.TextBox tb_productName;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.TextBox tb_unitPrice;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_visa;
        private System.Windows.Forms.RadioButton rb_cash;
        private System.Windows.Forms.CheckBox cb_freeDelivery;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label lb_outputMessage;
    }
}


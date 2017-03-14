namespace ADOBinding
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listMessages = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.GroupBox();
            this.GridOrder = new System.Windows.Forms.DataGridView();
            this.OrderDetails = new System.Windows.Forms.GroupBox();
            this.gridOrderDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.Order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridOrder)).BeginInit();
            this.OrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboName);
            this.groupBox1.Controls.Add(this.txtFax);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listMessages);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer :";
            // 
            // comboName
            // 
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(588, 20);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(197, 21);
            this.comboName.TabIndex = 11;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(588, 150);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(197, 20);
            this.txtFax.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(588, 105);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(197, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(588, 60);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(197, 20);
            this.txtContact.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fax : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Prev";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listMessages
            // 
            this.listMessages.Location = new System.Drawing.Point(10, 37);
            this.listMessages.Multiline = true;
            this.listMessages.Name = "listMessages";
            this.listMessages.ReadOnly = true;
            this.listMessages.Size = new System.Drawing.Size(226, 144);
            this.listMessages.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Messages :";
            // 
            // Order
            // 
            this.Order.Controls.Add(this.GridOrder);
            this.Order.Location = new System.Drawing.Point(13, 223);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(809, 184);
            this.Order.TabIndex = 1;
            this.Order.TabStop = false;
            this.Order.Text = "Orders :";
            // 
            // GridOrder
            // 
            this.GridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOrder.Location = new System.Drawing.Point(10, 19);
            this.GridOrder.Name = "GridOrder";
            this.GridOrder.Size = new System.Drawing.Size(775, 150);
            this.GridOrder.TabIndex = 0;
            // 
            // OrderDetails
            // 
            this.OrderDetails.Controls.Add(this.gridOrderDetails);
            this.OrderDetails.Location = new System.Drawing.Point(12, 413);
            this.OrderDetails.Name = "OrderDetails";
            this.OrderDetails.Size = new System.Drawing.Size(809, 202);
            this.OrderDetails.TabIndex = 2;
            this.OrderDetails.TabStop = false;
            this.OrderDetails.Text = "Order Details :";
            // 
            // gridOrderDetails
            // 
            this.gridOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderDetails.Location = new System.Drawing.Point(11, 19);
            this.gridOrderDetails.Name = "gridOrderDetails";
            this.gridOrderDetails.Size = new System.Drawing.Size(775, 177);
            this.gridOrderDetails.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 627);
            this.Controls.Add(this.OrderDetails);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sangkyu Eum, 300857187";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Order.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridOrder)).EndInit();
            this.OrderDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Order;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox listMessages;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.GroupBox OrderDetails;
        private System.Windows.Forms.DataGridView GridOrder;
        private System.Windows.Forms.DataGridView gridOrderDetails;
    }
}


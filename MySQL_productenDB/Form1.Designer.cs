﻿namespace MySQL_productenDB
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.closeConnectionButton = new System.Windows.Forms.Button();
            this.openConnectionButton = new System.Windows.Forms.Button();
            this.serversComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.readTableOrders = new System.Windows.Forms.Button();
            this.printTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.addProductButton = new System.Windows.Forms.Button();
            this.productStockTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productNaamTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.readOrdersButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 320);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.closeConnectionButton);
            this.tabPage1.Controls.Add(this.openConnectionButton);
            this.tabPage1.Controls.Add(this.serversComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(524, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbinding testen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // closeConnectionButton
            // 
            this.closeConnectionButton.Location = new System.Drawing.Point(19, 109);
            this.closeConnectionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeConnectionButton.Name = "closeConnectionButton";
            this.closeConnectionButton.Size = new System.Drawing.Size(199, 50);
            this.closeConnectionButton.TabIndex = 2;
            this.closeConnectionButton.Text = "sluit MySQL verbidning";
            this.closeConnectionButton.UseVisualStyleBackColor = true;
            this.closeConnectionButton.Click += new System.EventHandler(this.closeConnectionButton_Click);
            // 
            // openConnectionButton
            // 
            this.openConnectionButton.Location = new System.Drawing.Point(20, 55);
            this.openConnectionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openConnectionButton.Name = "openConnectionButton";
            this.openConnectionButton.Size = new System.Drawing.Size(198, 50);
            this.openConnectionButton.TabIndex = 1;
            this.openConnectionButton.Text = "open MySQL verbidning";
            this.openConnectionButton.UseVisualStyleBackColor = true;
            this.openConnectionButton.Click += new System.EventHandler(this.openConnectionButton_Click);
            // 
            // serversComboBox
            // 
            this.serversComboBox.FormattingEnabled = true;
            this.serversComboBox.Location = new System.Drawing.Point(19, 30);
            this.serversComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serversComboBox.Name = "serversComboBox";
            this.serversComboBox.Size = new System.Drawing.Size(199, 21);
            this.serversComboBox.TabIndex = 0;
            this.serversComboBox.SelectedIndexChanged += new System.EventHandler(this.serversComboBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.readTableOrders);
            this.tabPage2.Controls.Add(this.printTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(524, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Uitlezen tabel orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // readTableOrders
            // 
            this.readTableOrders.Location = new System.Drawing.Point(5, 227);
            this.readTableOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readTableOrders.Name = "readTableOrders";
            this.readTableOrders.Size = new System.Drawing.Size(173, 58);
            this.readTableOrders.TabIndex = 1;
            this.readTableOrders.Text = "Uitlezen tabel orders";
            this.readTableOrders.UseVisualStyleBackColor = true;
            this.readTableOrders.Click += new System.EventHandler(this.readTableOrders_Click);
            // 
            // printTextBox
            // 
            this.printTextBox.Location = new System.Drawing.Point(5, 6);
            this.printTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.printTextBox.Multiline = true;
            this.printTextBox.Name = "printTextBox";
            this.printTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.printTextBox.Size = new System.Drawing.Size(503, 217);
            this.printTextBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.addProductButton);
            this.tabPage3.Controls.Add(this.productStockTextBox);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.productNaamTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(524, 294);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Toevoegen product";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(6, 155);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(142, 38);
            this.addProductButton.TabIndex = 4;
            this.addProductButton.Text = "product toevoegen";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // productStockTextBox
            // 
            this.productStockTextBox.Location = new System.Drawing.Point(6, 122);
            this.productStockTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productStockTextBox.Multiline = true;
            this.productStockTextBox.Name = "productStockTextBox";
            this.productStockTextBox.Size = new System.Drawing.Size(72, 20);
            this.productStockTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "productstock: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "productnaam: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productNaamTextBox
            // 
            this.productNaamTextBox.Location = new System.Drawing.Point(6, 35);
            this.productNaamTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productNaamTextBox.Multiline = true;
            this.productNaamTextBox.Name = "productNaamTextBox";
            this.productNaamTextBox.Size = new System.Drawing.Size(360, 47);
            this.productNaamTextBox.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.deleteProductButton);
            this.tabPage4.Controls.Add(this.readOrdersButton);
            this.tabPage4.Controls.Add(this.dataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(524, 294);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Beheer tabel producten";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(141, 251);
            this.deleteProductButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(134, 38);
            this.deleteProductButton.TabIndex = 2;
            this.deleteProductButton.Text = "Verwijder product";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // readOrdersButton
            // 
            this.readOrdersButton.Location = new System.Drawing.Point(3, 251);
            this.readOrdersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readOrdersButton.Name = "readOrdersButton";
            this.readOrdersButton.Size = new System.Drawing.Size(134, 38);
            this.readOrdersButton.TabIndex = 1;
            this.readOrdersButton.Text = "Lees tabel producten";
            this.readOrdersButton.UseVisualStyleBackColor = true;
            this.readOrdersButton.Click += new System.EventHandler(this.readOrdersButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.Location = new System.Drawing.Point(3, 13);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(520, 233);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 358);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button closeConnectionButton;
        private System.Windows.Forms.Button openConnectionButton;
        private System.Windows.Forms.ComboBox serversComboBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button readTableOrders;
        private System.Windows.Forms.TextBox printTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.TextBox productStockTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productNaamTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button readOrdersButton;
    }
}


namespace CSharpPrograming
{
    partial class ProductForm
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
            label1 = new Label();
            nametextBox = new TextBox();
            brandnametextBox = new TextBox();
            label2 = new Label();
            counttextBox = new TextBox();
            label3 = new Label();
            pricetextBox = new TextBox();
            label4 = new Label();
            isactivecheckBox = new CheckBox();
            savebutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(97, 17);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(100, 23);
            nametextBox.TabIndex = 9;
            // 
            // brandnametextBox
            // 
            brandnametextBox.Location = new Point(97, 52);
            brandnametextBox.Name = "brandnametextBox";
            brandnametextBox.Size = new Size(100, 23);
            brandnametextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "BrandName";
            // 
            // counttextBox
            // 
            counttextBox.Location = new Point(97, 92);
            counttextBox.Name = "counttextBox";
            counttextBox.Size = new Size(100, 23);
            counttextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Count";
            // 
            // pricetextBox
            // 
            pricetextBox.Location = new Point(97, 135);
            pricetextBox.Name = "pricetextBox";
            pricetextBox.Size = new Size(100, 23);
            pricetextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 143);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 6;
            label4.Text = "Price";
            // 
            // isactivecheckBox
            // 
            isactivecheckBox.AutoSize = true;
            isactivecheckBox.Location = new Point(97, 191);
            isactivecheckBox.Name = "isactivecheckBox";
            isactivecheckBox.Size = new Size(67, 19);
            isactivecheckBox.TabIndex = 8;
            isactivecheckBox.Text = "IsActive";
            isactivecheckBox.UseVisualStyleBackColor = true;
            // 
            // savebutton
            // 
            savebutton.Location = new Point(87, 231);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(75, 23);
            savebutton.TabIndex = 10;
            savebutton.Text = "save";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 450);
            Controls.Add(savebutton);
            Controls.Add(isactivecheckBox);
            Controls.Add(pricetextBox);
            Controls.Add(label4);
            Controls.Add(counttextBox);
            Controls.Add(label3);
            Controls.Add(brandnametextBox);
            Controls.Add(label2);
            Controls.Add(nametextBox);
            Controls.Add(label1);
            Name = "ProductForm";
            Text = "ProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nametextBox;
        private TextBox brandnametextBox;
        private Label label2;
        private TextBox counttextBox;
        private Label label3;
        private TextBox pricetextBox;
        private Label label4;
        private CheckBox isactivecheckBox;
        private Button savebutton;
    }
}
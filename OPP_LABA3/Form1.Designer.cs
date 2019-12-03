namespace OPP_LABA3
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
            this.Clear = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Html = new System.Windows.Forms.Button();
            this.Country = new System.Windows.Forms.CheckBox();
            this.Material = new System.Windows.Forms.CheckBox();
            this.Body = new System.Windows.Forms.CheckBox();
            this.Brand = new System.Windows.Forms.CheckBox();
            this.Sax = new System.Windows.Forms.RadioButton();
            this.Linq = new System.Windows.Forms.RadioButton();
            this.Dom = new System.Windows.Forms.RadioButton();
            this.Type = new System.Windows.Forms.CheckBox();
            this.CountryBox = new System.Windows.Forms.ComboBox();
            this.MaterialBox = new System.Windows.Forms.ComboBox();
            this.BodyBox = new System.Windows.Forms.ComboBox();
            this.BrandBox = new System.Windows.Forms.ComboBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(534, 22);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(234, 344);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Html
            // 
            this.Html.Location = new System.Drawing.Point(517, 391);
            this.Html.Name = "Html";
            this.Html.Size = new System.Drawing.Size(128, 23);
            this.Html.TabIndex = 2;
            this.Html.Text = "Transform to HTML";
            this.Html.UseVisualStyleBackColor = true;
            this.Html.Click += new System.EventHandler(this.Html_Click);
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(65, 267);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(62, 17);
            this.Country.TabIndex = 3;
            this.Country.Text = "Country";
            this.Country.UseVisualStyleBackColor = true;
            // 
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.Location = new System.Drawing.Point(65, 220);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(63, 17);
            this.Material.TabIndex = 4;
            this.Material.Text = "Material";
            this.Material.UseVisualStyleBackColor = true;
            // 
            // Body
            // 
            this.Body.AutoSize = true;
            this.Body.Location = new System.Drawing.Point(65, 179);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(50, 17);
            this.Body.TabIndex = 5;
            this.Body.Text = "Body";
            this.Body.UseVisualStyleBackColor = true;
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Location = new System.Drawing.Point(65, 134);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(54, 17);
            this.Brand.TabIndex = 6;
            this.Brand.Text = "Brand";
            this.Brand.UseVisualStyleBackColor = true;
            // 
            // Sax
            // 
            this.Sax.AutoSize = true;
            this.Sax.Location = new System.Drawing.Point(167, 347);
            this.Sax.Name = "Sax";
            this.Sax.Size = new System.Drawing.Size(46, 17);
            this.Sax.TabIndex = 7;
            this.Sax.TabStop = true;
            this.Sax.Text = "SAX";
            this.Sax.UseVisualStyleBackColor = true;
            // 
            // Linq
            // 
            this.Linq.AutoSize = true;
            this.Linq.Location = new System.Drawing.Point(55, 347);
            this.Linq.Name = "Linq";
            this.Linq.Size = new System.Drawing.Size(50, 17);
            this.Linq.TabIndex = 8;
            this.Linq.TabStop = true;
            this.Linq.Text = "LINQ";
            this.Linq.UseVisualStyleBackColor = true;
            // 
            // Dom
            // 
            this.Dom.AutoSize = true;
            this.Dom.Location = new System.Drawing.Point(111, 347);
            this.Dom.Name = "Dom";
            this.Dom.Size = new System.Drawing.Size(50, 17);
            this.Dom.TabIndex = 9;
            this.Dom.TabStop = true;
            this.Dom.Text = "DOM";
            this.Dom.UseVisualStyleBackColor = true;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(65, 92);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(50, 17);
            this.Type.TabIndex = 10;
            this.Type.Text = "Type";
            this.Type.UseVisualStyleBackColor = true;
            // 
            // CountryBox
            // 
            this.CountryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryBox.FormattingEnabled = true;
            this.CountryBox.Items.AddRange(new object[] {
            "USA",
            "China",
            "Japan",
            "Korea"});
            this.CountryBox.Location = new System.Drawing.Point(177, 265);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(121, 21);
            this.CountryBox.TabIndex = 11;
            // 
            // MaterialBox
            // 
            this.MaterialBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialBox.FormattingEnabled = true;
            this.MaterialBox.Items.AddRange(new object[] {
            "Sapele",
            "Spruce",
            "Mahogany",
            "Cedar"});
            this.MaterialBox.Location = new System.Drawing.Point(177, 216);
            this.MaterialBox.Name = "MaterialBox";
            this.MaterialBox.Size = new System.Drawing.Size(121, 21);
            this.MaterialBox.TabIndex = 12;
            // 
            // BodyBox
            // 
            this.BodyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BodyBox.FormattingEnabled = true;
            this.BodyBox.Items.AddRange(new object[] {
            "Tenor",
            "Concert",
            "Stratocaster",
            "Les Paul",
            "Dreadnought",
            "Jumbo",
            "SG"});
            this.BodyBox.Location = new System.Drawing.Point(177, 177);
            this.BodyBox.Name = "BodyBox";
            this.BodyBox.Size = new System.Drawing.Size(121, 21);
            this.BodyBox.TabIndex = 13;
            // 
            // BrandBox
            // 
            this.BrandBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandBox.FormattingEnabled = true;
            this.BrandBox.Items.AddRange(new object[] {
            "Korala",
            "Hora",
            "Fender",
            "Gibson",
            "Cort",
            "Yamaha",
            "LTD"});
            this.BrandBox.Location = new System.Drawing.Point(177, 132);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(121, 21);
            this.BrandBox.TabIndex = 14;
            // 
            // TypeBox
            // 
            this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Acoustic",
            "Classical",
            "Electric",
            "Ukulele"});
            this.TypeBox.Location = new System.Drawing.Point(177, 90);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(121, 21);
            this.TypeBox.TabIndex = 15;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(354, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(422, 303);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.BrandBox);
            this.Controls.Add(this.BodyBox);
            this.Controls.Add(this.MaterialBox);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Dom);
            this.Controls.Add(this.Linq);
            this.Controls.Add(this.Sax);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.Html);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Clear);
            this.Name = "Form1";
            this.Text = "Guitars @Bendes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Html;
        private System.Windows.Forms.CheckBox Country;
        private System.Windows.Forms.CheckBox Material;
        private System.Windows.Forms.CheckBox Body;
        private System.Windows.Forms.CheckBox Brand;
        private System.Windows.Forms.RadioButton Sax;
        private System.Windows.Forms.RadioButton Linq;
        private System.Windows.Forms.RadioButton Dom;
        private System.Windows.Forms.CheckBox Type;
        private System.Windows.Forms.ComboBox CountryBox;
        private System.Windows.Forms.ComboBox MaterialBox;
        private System.Windows.Forms.ComboBox BodyBox;
        private System.Windows.Forms.ComboBox BrandBox;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


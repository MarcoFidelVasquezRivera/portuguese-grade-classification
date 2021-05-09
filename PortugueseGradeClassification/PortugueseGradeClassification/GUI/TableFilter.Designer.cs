
namespace PortugueseGradeClassification.GUI
{
    partial class TableFilter
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortuTable = new System.Windows.Forms.DataGridView();
            this.BiComboBox = new System.Windows.Forms.ComboBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.FilterText2 = new System.Windows.Forms.TextBox();
            this.FilterText1 = new System.Windows.Forms.TextBox();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PortuTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortuTable
            // 
            this.PortuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PortuTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortuTable.Location = new System.Drawing.Point(0, 0);
            this.PortuTable.Name = "PortuTable";
            this.PortuTable.Size = new System.Drawing.Size(929, 400);
            this.PortuTable.TabIndex = 1;
            // 
            // BiComboBox
            // 
            this.BiComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BiComboBox.FormattingEnabled = true;
            this.BiComboBox.Location = new System.Drawing.Point(373, 17);
            this.BiComboBox.Name = "BiComboBox";
            this.BiComboBox.Size = new System.Drawing.Size(179, 21);
            this.BiComboBox.TabIndex = 10;
            this.BiComboBox.Text = "Pick a value...";
            this.BiComboBox.Visible = false;
            // 
            // FilterButton
            // 
            this.FilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterButton.Location = new System.Drawing.Point(188, 16);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(179, 23);
            this.FilterButton.TabIndex = 9;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            // 
            // FilterText2
            // 
            this.FilterText2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterText2.Location = new System.Drawing.Point(743, 17);
            this.FilterText2.Name = "FilterText2";
            this.FilterText2.Size = new System.Drawing.Size(183, 20);
            this.FilterText2.TabIndex = 8;
            this.FilterText2.Visible = false;
            // 
            // FilterText1
            // 
            this.FilterText1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterText1.Location = new System.Drawing.Point(558, 17);
            this.FilterText1.Name = "FilterText1";
            this.FilterText1.Size = new System.Drawing.Size(179, 20);
            this.FilterText1.TabIndex = 7;
            this.FilterText1.Visible = false;
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "School",
            "Sex",
            "Age",
            "Address",
            "Family size",
            "Parents status",
            "Mother\'s education",
            "Father\'s education",
            "Mother\'s job",
            "Father\'s job",
            "Reason",
            "Guardian",
            "Travel time",
            "Study time",
            "Failures",
            "School support",
            "Family support",
            "Extra paid classes",
            "Extra activities",
            "Nursery",
            "Higher education",
            "Internet access",
            "Romantic relationship",
            "Family relation",
            "Free time",
            "Go out",
            "Weekday alcohol",
            "Weekend alcohol",
            "Health",
            "Absences",
            "Grade 1",
            "Grade 2",
            "Grade 3"});
            this.FilterComboBox.Location = new System.Drawing.Point(3, 17);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(179, 21);
            this.FilterComboBox.TabIndex = 6;
            this.FilterComboBox.Text = "Filter by...";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.FilterComboBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FilterText2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.BiComboBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.FilterText1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.FilterButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 345);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(929, 55);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // TableFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PortuTable);
            this.Name = "TableFilter";
            this.Size = new System.Drawing.Size(929, 400);
            ((System.ComponentModel.ISupportInitialize)(this.PortuTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PortuTable;
        private System.Windows.Forms.ComboBox BiComboBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.TextBox FilterText2;
        private System.Windows.Forms.TextBox FilterText1;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

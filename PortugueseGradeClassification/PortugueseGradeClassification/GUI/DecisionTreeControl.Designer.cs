
namespace PortugueseGradeClassification.GUI
{
    partial class DecisionTreeControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TrainButton = new System.Windows.Forms.Button();
            this.guessesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.schoolComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.absencesTextBox = new System.Windows.Forms.TextBox();
            this.gTwoTextBox = new System.Windows.Forms.TextBox();
            this.gOneTextBox = new System.Windows.Forms.TextBox();
            this.healthTextBox = new System.Windows.Forms.TextBox();
            this.aWeekendTextBox = new System.Windows.Forms.TextBox();
            this.aWeekTextBox = new System.Windows.Forms.TextBox();
            this.goOutTextBox = new System.Windows.Forms.TextBox();
            this.fRelationTextBox = new System.Windows.Forms.TextBox();
            this.fTimeTextBox = new System.Windows.Forms.TextBox();
            this.failTextBox = new System.Windows.Forms.TextBox();
            this.sTimeTextBox = new System.Windows.Forms.TextBox();
            this.tTimeTextBox = new System.Windows.Forms.TextBox();
            this.fEduTextBox = new System.Windows.Forms.TextBox();
            this.mEduTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.romanticComboBox = new System.Windows.Forms.ComboBox();
            this.internetComboBox = new System.Windows.Forms.ComboBox();
            this.hEduComboBox = new System.Windows.Forms.ComboBox();
            this.nurseryComboBox = new System.Windows.Forms.ComboBox();
            this.activityComboBox = new System.Windows.Forms.ComboBox();
            this.paidComboBox = new System.Windows.Forms.ComboBox();
            this.fSuppComboBox = new System.Windows.Forms.ComboBox();
            this.sSupComboBox = new System.Windows.Forms.ComboBox();
            this.GuardianComboBox = new System.Windows.Forms.ComboBox();
            this.reasonComboBox = new System.Windows.Forms.ComboBox();
            this.fJobComboBox = new System.Windows.Forms.ComboBox();
            this.mJobComboBox = new System.Windows.Forms.ComboBox();
            this.pStatusComboBox = new System.Windows.Forms.ComboBox();
            this.fSizeComboBox = new System.Windows.Forms.ComboBox();
            this.addressComboBox = new System.Windows.Forms.ComboBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClasiffyButton = new System.Windows.Forms.Button();
            this.graphViewer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.guessesChart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(746, 25);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(111, 23);
            this.TrainButton.TabIndex = 0;
            this.TrainButton.Text = "Entrenar arbol";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // guessesChart
            // 
            chartArea2.Name = "ChartArea1";
            this.guessesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.guessesChart.Legends.Add(legend2);
            this.guessesChart.Location = new System.Drawing.Point(686, 99);
            this.guessesChart.Name = "guessesChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.guessesChart.Series.Add(series2);
            this.guessesChart.Size = new System.Drawing.Size(249, 211);
            this.guessesChart.TabIndex = 1;
            this.guessesChart.Text = "chart1";
            this.guessesChart.Visible = false;
            // 
            // schoolComboBox
            // 
            this.schoolComboBox.FormattingEnabled = true;
            this.schoolComboBox.Items.AddRange(new object[] {
            "GP",
            "MS"});
            this.schoolComboBox.Location = new System.Drawing.Point(157, 3);
            this.schoolComboBox.Name = "schoolComboBox";
            this.schoolComboBox.Size = new System.Drawing.Size(109, 21);
            this.schoolComboBox.TabIndex = 37;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.absencesTextBox, 3, 13);
            this.tableLayoutPanel1.Controls.Add(this.gTwoTextBox, 3, 15);
            this.tableLayoutPanel1.Controls.Add(this.gOneTextBox, 3, 14);
            this.tableLayoutPanel1.Controls.Add(this.healthTextBox, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.aWeekendTextBox, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.aWeekTextBox, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.goOutTextBox, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.fRelationTextBox, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.fTimeTextBox, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.failTextBox, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.sTimeTextBox, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.tTimeTextBox, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.fEduTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.mEduTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ageTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label32, 2, 15);
            this.tableLayoutPanel1.Controls.Add(this.label31, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.label30, 2, 13);
            this.tableLayoutPanel1.Controls.Add(this.label29, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.label28, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.label27, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.label26, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label25, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label24, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label23, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label22, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label21, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label20, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label19, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label18, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label17, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.romanticComboBox, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.internetComboBox, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.hEduComboBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.nurseryComboBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.activityComboBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.paidComboBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.fSuppComboBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.sSupComboBox, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.GuardianComboBox, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.reasonComboBox, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.fJobComboBox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.mJobComboBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.pStatusComboBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.fSizeComboBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.addressComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.sexComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.schoolComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(617, 604);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // absencesTextBox
            // 
            this.absencesTextBox.Location = new System.Drawing.Point(465, 484);
            this.absencesTextBox.Name = "absencesTextBox";
            this.absencesTextBox.Size = new System.Drawing.Size(109, 20);
            this.absencesTextBox.TabIndex = 50;
            this.absencesTextBox.Text = " Entre 0 y 93";
            // 
            // gTwoTextBox
            // 
            this.gTwoTextBox.Location = new System.Drawing.Point(465, 558);
            this.gTwoTextBox.Name = "gTwoTextBox";
            this.gTwoTextBox.Size = new System.Drawing.Size(109, 20);
            this.gTwoTextBox.TabIndex = 50;
            this.gTwoTextBox.Text = " Entre 0 y 20";
            // 
            // gOneTextBox
            // 
            this.gOneTextBox.Location = new System.Drawing.Point(465, 521);
            this.gOneTextBox.Name = "gOneTextBox";
            this.gOneTextBox.Size = new System.Drawing.Size(109, 20);
            this.gOneTextBox.TabIndex = 50;
            this.gOneTextBox.Text = " Entre 0 y 20";
            // 
            // healthTextBox
            // 
            this.healthTextBox.Location = new System.Drawing.Point(465, 447);
            this.healthTextBox.Name = "healthTextBox";
            this.healthTextBox.Size = new System.Drawing.Size(109, 20);
            this.healthTextBox.TabIndex = 50;
            this.healthTextBox.Text = " Entre 1 y 5";
            // 
            // aWeekendTextBox
            // 
            this.aWeekendTextBox.Location = new System.Drawing.Point(465, 410);
            this.aWeekendTextBox.Name = "aWeekendTextBox";
            this.aWeekendTextBox.Size = new System.Drawing.Size(109, 20);
            this.aWeekendTextBox.TabIndex = 50;
            this.aWeekendTextBox.Text = " Entre 1 y 5";
            // 
            // aWeekTextBox
            // 
            this.aWeekTextBox.Location = new System.Drawing.Point(465, 373);
            this.aWeekTextBox.Name = "aWeekTextBox";
            this.aWeekTextBox.Size = new System.Drawing.Size(109, 20);
            this.aWeekTextBox.TabIndex = 50;
            this.aWeekTextBox.Text = " Entre 1 y 5";
            // 
            // goOutTextBox
            // 
            this.goOutTextBox.Location = new System.Drawing.Point(465, 336);
            this.goOutTextBox.Name = "goOutTextBox";
            this.goOutTextBox.Size = new System.Drawing.Size(109, 20);
            this.goOutTextBox.TabIndex = 49;
            this.goOutTextBox.Text = " Entre 1 y 5";
            // 
            // fRelationTextBox
            // 
            this.fRelationTextBox.Location = new System.Drawing.Point(465, 262);
            this.fRelationTextBox.Name = "fRelationTextBox";
            this.fRelationTextBox.Size = new System.Drawing.Size(109, 20);
            this.fRelationTextBox.TabIndex = 47;
            this.fRelationTextBox.Text = " Entre 1 y 5";
            // 
            // fTimeTextBox
            // 
            this.fTimeTextBox.Location = new System.Drawing.Point(465, 299);
            this.fTimeTextBox.Name = "fTimeTextBox";
            this.fTimeTextBox.Size = new System.Drawing.Size(109, 20);
            this.fTimeTextBox.TabIndex = 48;
            this.fTimeTextBox.Text = " Entre 1 y 5";
            // 
            // failTextBox
            // 
            this.failTextBox.Location = new System.Drawing.Point(157, 521);
            this.failTextBox.Name = "failTextBox";
            this.failTextBox.Size = new System.Drawing.Size(109, 20);
            this.failTextBox.TabIndex = 46;
            this.failTextBox.Text = " Entre 0 y 3";
            // 
            // sTimeTextBox
            // 
            this.sTimeTextBox.Location = new System.Drawing.Point(157, 484);
            this.sTimeTextBox.Name = "sTimeTextBox";
            this.sTimeTextBox.Size = new System.Drawing.Size(109, 20);
            this.sTimeTextBox.TabIndex = 45;
            this.sTimeTextBox.Text = " Entre 1 y 4";
            // 
            // tTimeTextBox
            // 
            this.tTimeTextBox.Location = new System.Drawing.Point(157, 447);
            this.tTimeTextBox.Name = "tTimeTextBox";
            this.tTimeTextBox.Size = new System.Drawing.Size(109, 20);
            this.tTimeTextBox.TabIndex = 44;
            this.tTimeTextBox.Text = " Entre 1 y 4";
            // 
            // fEduTextBox
            // 
            this.fEduTextBox.Location = new System.Drawing.Point(157, 262);
            this.fEduTextBox.Name = "fEduTextBox";
            this.fEduTextBox.Size = new System.Drawing.Size(109, 20);
            this.fEduTextBox.TabIndex = 43;
            this.fEduTextBox.Text = " Entre 0 y 4";
            // 
            // mEduTextBox
            // 
            this.mEduTextBox.Location = new System.Drawing.Point(157, 225);
            this.mEduTextBox.Name = "mEduTextBox";
            this.mEduTextBox.Size = new System.Drawing.Size(109, 20);
            this.mEduTextBox.TabIndex = 42;
            this.mEduTextBox.Text = " Entre 0 y 4";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(157, 77);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(109, 20);
            this.ageTextBox.TabIndex = 41;
            this.ageTextBox.Text = " Entre 15 y 22";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(359, 573);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(51, 13);
            this.label32.TabIndex = 43;
            this.label32.Text = "Grade 2 :";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(359, 530);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(51, 13);
            this.label31.TabIndex = 43;
            this.label31.Text = "Grade 1 :";
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(355, 493);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(60, 13);
            this.label30.TabIndex = 43;
            this.label30.Text = "Absences :";
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(347, 456);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(75, 13);
            this.label29.TabIndex = 43;
            this.label29.Text = "Health status :";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(327, 419);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(115, 13);
            this.label28.TabIndex = 43;
            this.label28.Text = "Alcohol on weekends :";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(326, 382);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(117, 13);
            this.label27.TabIndex = 43;
            this.label27.Text = "Alcohol on week days :";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(362, 345);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 13);
            this.label26.TabIndex = 43;
            this.label26.Text = "Go out :";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(357, 308);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 13);
            this.label25.TabIndex = 43;
            this.label25.Text = "Free time :";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(343, 271);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 13);
            this.label24.TabIndex = 43;
            this.label24.Text = "Family Relation :";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(337, 234);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(95, 13);
            this.label23.TabIndex = 43;
            this.label23.Text = "Romantic relation :";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(342, 197);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 13);
            this.label22.TabIndex = 43;
            this.label22.Text = "Internet access :";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(363, 160);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 13);
            this.label21.TabIndex = 43;
            this.label21.Text = "Higher :";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(360, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Nursery :";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(357, 86);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "Activities :";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(349, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Paid classes :";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(345, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Family support :";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 573);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "School support :";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(52, 530);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Failures :";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 493);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Study time :";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 456);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Travel time :";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 419);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Guardian :";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Study Reason :";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Father\'s job :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Mother\'s job :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Father\'s education :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Mother\'s education :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Parent status :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Family size :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Address :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Age :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Sex :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // romanticComboBox
            // 
            this.romanticComboBox.FormattingEnabled = true;
            this.romanticComboBox.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.romanticComboBox.Location = new System.Drawing.Point(465, 225);
            this.romanticComboBox.Name = "romanticComboBox";
            this.romanticComboBox.Size = new System.Drawing.Size(109, 21);
            this.romanticComboBox.TabIndex = 41;
            // 
            // internetComboBox
            // 
            this.internetComboBox.FormattingEnabled = true;
            this.internetComboBox.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.internetComboBox.Location = new System.Drawing.Point(465, 188);
            this.internetComboBox.Name = "internetComboBox";
            this.internetComboBox.Size = new System.Drawing.Size(109, 21);
            this.internetComboBox.TabIndex = 41;
            // 
            // hEduComboBox
            // 
            this.hEduComboBox.FormattingEnabled = true;
            this.hEduComboBox.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.hEduComboBox.Location = new System.Drawing.Point(465, 151);
            this.hEduComboBox.Name = "hEduComboBox";
            this.hEduComboBox.Size = new System.Drawing.Size(109, 21);
            this.hEduComboBox.TabIndex = 41;
            // 
            // nurseryComboBox
            // 
            this.nurseryComboBox.FormattingEnabled = true;
            this.nurseryComboBox.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.nurseryComboBox.Location = new System.Drawing.Point(465, 114);
            this.nurseryComboBox.Name = "nurseryComboBox";
            this.nurseryComboBox.Size = new System.Drawing.Size(109, 21);
            this.nurseryComboBox.TabIndex = 41;
            // 
            // activityComboBox
            // 
            this.activityComboBox.FormattingEnabled = true;
            this.activityComboBox.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.activityComboBox.Location = new System.Drawing.Point(465, 77);
            this.activityComboBox.Name = "activityComboBox";
            this.activityComboBox.Size = new System.Drawing.Size(109, 21);
            this.activityComboBox.TabIndex = 41;
            // 
            // paidComboBox
            // 
            this.paidComboBox.FormattingEnabled = true;
            this.paidComboBox.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.paidComboBox.Location = new System.Drawing.Point(465, 40);
            this.paidComboBox.Name = "paidComboBox";
            this.paidComboBox.Size = new System.Drawing.Size(109, 21);
            this.paidComboBox.TabIndex = 41;
            // 
            // fSuppComboBox
            // 
            this.fSuppComboBox.FormattingEnabled = true;
            this.fSuppComboBox.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.fSuppComboBox.Location = new System.Drawing.Point(465, 3);
            this.fSuppComboBox.Name = "fSuppComboBox";
            this.fSuppComboBox.Size = new System.Drawing.Size(109, 21);
            this.fSuppComboBox.TabIndex = 41;
            // 
            // sSupComboBox
            // 
            this.sSupComboBox.FormattingEnabled = true;
            this.sSupComboBox.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.sSupComboBox.Location = new System.Drawing.Point(157, 558);
            this.sSupComboBox.Name = "sSupComboBox";
            this.sSupComboBox.Size = new System.Drawing.Size(109, 21);
            this.sSupComboBox.TabIndex = 41;
            // 
            // GuardianComboBox
            // 
            this.GuardianComboBox.FormattingEnabled = true;
            this.GuardianComboBox.Items.AddRange(new object[] {
            "mother",
            "father",
            "other"});
            this.GuardianComboBox.Location = new System.Drawing.Point(157, 410);
            this.GuardianComboBox.Name = "GuardianComboBox";
            this.GuardianComboBox.Size = new System.Drawing.Size(109, 21);
            this.GuardianComboBox.TabIndex = 41;
            // 
            // reasonComboBox
            // 
            this.reasonComboBox.FormattingEnabled = true;
            this.reasonComboBox.Items.AddRange(new object[] {
            "home",
            "reputation",
            "course",
            "other"});
            this.reasonComboBox.Location = new System.Drawing.Point(157, 373);
            this.reasonComboBox.Name = "reasonComboBox";
            this.reasonComboBox.Size = new System.Drawing.Size(109, 21);
            this.reasonComboBox.TabIndex = 41;
            // 
            // fJobComboBox
            // 
            this.fJobComboBox.FormattingEnabled = true;
            this.fJobComboBox.Items.AddRange(new object[] {
            "teacher",
            "health",
            "services",
            "at_home",
            "other"});
            this.fJobComboBox.Location = new System.Drawing.Point(157, 336);
            this.fJobComboBox.Name = "fJobComboBox";
            this.fJobComboBox.Size = new System.Drawing.Size(109, 21);
            this.fJobComboBox.TabIndex = 41;
            // 
            // mJobComboBox
            // 
            this.mJobComboBox.FormattingEnabled = true;
            this.mJobComboBox.Items.AddRange(new object[] {
            "teacher",
            "health",
            "services",
            "at_home",
            "other"});
            this.mJobComboBox.Location = new System.Drawing.Point(157, 299);
            this.mJobComboBox.Name = "mJobComboBox";
            this.mJobComboBox.Size = new System.Drawing.Size(109, 21);
            this.mJobComboBox.TabIndex = 41;
            // 
            // pStatusComboBox
            // 
            this.pStatusComboBox.FormattingEnabled = true;
            this.pStatusComboBox.Items.AddRange(new object[] {
            "T",
            "A"});
            this.pStatusComboBox.Location = new System.Drawing.Point(157, 188);
            this.pStatusComboBox.Name = "pStatusComboBox";
            this.pStatusComboBox.Size = new System.Drawing.Size(109, 21);
            this.pStatusComboBox.TabIndex = 41;
            // 
            // fSizeComboBox
            // 
            this.fSizeComboBox.FormattingEnabled = true;
            this.fSizeComboBox.Items.AddRange(new object[] {
            "LE3",
            "GT3"});
            this.fSizeComboBox.Location = new System.Drawing.Point(157, 151);
            this.fSizeComboBox.Name = "fSizeComboBox";
            this.fSizeComboBox.Size = new System.Drawing.Size(109, 21);
            this.fSizeComboBox.TabIndex = 41;
            // 
            // addressComboBox
            // 
            this.addressComboBox.FormattingEnabled = true;
            this.addressComboBox.Items.AddRange(new object[] {
            "U",
            "R"});
            this.addressComboBox.Location = new System.Drawing.Point(157, 114);
            this.addressComboBox.Name = "addressComboBox";
            this.addressComboBox.Size = new System.Drawing.Size(109, 21);
            this.addressComboBox.TabIndex = 41;
            // 
            // sexComboBox
            // 
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexComboBox.Location = new System.Drawing.Point(157, 40);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(109, 21);
            this.sexComboBox.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "School :";
            // 
            // ClasiffyButton
            // 
            this.ClasiffyButton.Location = new System.Drawing.Point(746, 464);
            this.ClasiffyButton.Name = "ClasiffyButton";
            this.ClasiffyButton.Size = new System.Drawing.Size(111, 23);
            this.ClasiffyButton.TabIndex = 39;
            this.ClasiffyButton.Text = "Clasificar estudiante";
            this.ClasiffyButton.UseVisualStyleBackColor = true;
            this.ClasiffyButton.Click += new System.EventHandler(this.ClasiffyButton_Click);
            // 
            // graphViewer
            // 
            this.graphViewer.FormattingEnabled = true;
            this.graphViewer.Items.AddRange(new object[] {
            "Manual Decision Tree",
            "Library Decision Tree"});
            this.graphViewer.Location = new System.Drawing.Point(736, 62);
            this.graphViewer.Name = "graphViewer";
            this.graphViewer.Size = new System.Drawing.Size(131, 21);
            this.graphViewer.TabIndex = 40;
            this.graphViewer.SelectedIndexChanged += new System.EventHandler(this.UpdateGraph);
            // 
            // DecisionTreeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.graphViewer);
            this.Controls.Add(this.ClasiffyButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.guessesChart);
            this.Controls.Add(this.TrainButton);
            this.Name = "DecisionTreeControl";
            this.Size = new System.Drawing.Size(964, 677);
            ((System.ComponentModel.ISupportInitialize)(this.guessesChart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart guessesChart;
        private System.Windows.Forms.ComboBox schoolComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox romanticComboBox;
        private System.Windows.Forms.ComboBox internetComboBox;
        private System.Windows.Forms.ComboBox hEduComboBox;
        private System.Windows.Forms.ComboBox nurseryComboBox;
        private System.Windows.Forms.ComboBox activityComboBox;
        private System.Windows.Forms.ComboBox paidComboBox;
        private System.Windows.Forms.ComboBox fSuppComboBox;
        private System.Windows.Forms.ComboBox sSupComboBox;
        private System.Windows.Forms.ComboBox GuardianComboBox;
        private System.Windows.Forms.ComboBox reasonComboBox;
        private System.Windows.Forms.ComboBox fJobComboBox;
        private System.Windows.Forms.ComboBox mJobComboBox;
        private System.Windows.Forms.ComboBox pStatusComboBox;
        private System.Windows.Forms.ComboBox fSizeComboBox;
        private System.Windows.Forms.ComboBox addressComboBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Button ClasiffyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox gTwoTextBox;
        private System.Windows.Forms.TextBox gOneTextBox;
        private System.Windows.Forms.TextBox healthTextBox;
        private System.Windows.Forms.TextBox aWeekendTextBox;
        private System.Windows.Forms.TextBox aWeekTextBox;
        private System.Windows.Forms.TextBox goOutTextBox;
        private System.Windows.Forms.TextBox fRelationTextBox;
        private System.Windows.Forms.TextBox fTimeTextBox;
        private System.Windows.Forms.TextBox failTextBox;
        private System.Windows.Forms.TextBox sTimeTextBox;
        private System.Windows.Forms.TextBox tTimeTextBox;
        private System.Windows.Forms.TextBox fEduTextBox;
        private System.Windows.Forms.TextBox mEduTextBox;
        private System.Windows.Forms.TextBox absencesTextBox;
        private System.Windows.Forms.ComboBox graphViewer;
    }
}

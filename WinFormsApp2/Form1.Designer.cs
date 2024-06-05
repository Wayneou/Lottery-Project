namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            dataGridViewSignedNumbers = new DataGridView();
            FirstArea = new DataGridViewTextBoxColumn();
            SecondArea = new DataGridViewTextBoxColumn();
            PrizeStatus = new DataGridViewTextBoxColumn();
            PrizeAmount = new DataGridViewTextBoxColumn();
            signButton = new Button();
            selectnu = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox14 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox15 = new CheckBox();
            checkBox16 = new CheckBox();
            checkBox17 = new CheckBox();
            checkBox18 = new CheckBox();
            checkBox19 = new CheckBox();
            checkBox20 = new CheckBox();
            checkBox21 = new CheckBox();
            checkBox22 = new CheckBox();
            checkBox23 = new CheckBox();
            checkBox24 = new CheckBox();
            checkBox25 = new CheckBox();
            checkBox26 = new CheckBox();
            checkBox27 = new CheckBox();
            checkBox28 = new CheckBox();
            checkBox29 = new CheckBox();
            checkBox30 = new CheckBox();
            checkBox31 = new CheckBox();
            checkBox32 = new CheckBox();
            checkBox33 = new CheckBox();
            checkBox34 = new CheckBox();
            checkBox37 = new CheckBox();
            checkBox38 = new CheckBox();
            checkBox39 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            groupBoxFirstArea = new GroupBox();
            groupBoxSecondArea = new GroupBox();
            packageButton = new Button();
            randomSelectButton = new Button();
            generatePrizeButton = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelFirstAreaPrize = new Label();
            labelSecondAreaPrize = new Label();
            checkPrizeButton = new Button();
            label6 = new Label();
            button1 = new Button();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSignedNumbers).BeginInit();
            groupBoxFirstArea.SuspendLayout();
            groupBoxSecondArea.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.IBeam;
            label1.Location = new Point(75, 579);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "第一區號碼";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.IBeam;
            label2.Location = new Point(75, 657);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 3;
            label2.Text = "第二區號碼";
            // 
            // dataGridViewSignedNumbers
            // 
            dataGridViewSignedNumbers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSignedNumbers.Columns.AddRange(new DataGridViewColumn[] { FirstArea, SecondArea, PrizeStatus, PrizeAmount });
            dataGridViewSignedNumbers.Location = new Point(892, 39);
            dataGridViewSignedNumbers.Name = "dataGridViewSignedNumbers";
            dataGridViewSignedNumbers.RowHeadersWidth = 62;
            dataGridViewSignedNumbers.Size = new Size(712, 981);
            dataGridViewSignedNumbers.TabIndex = 9;
            // 
            // FirstArea
            // 
            FirstArea.HeaderText = "第一區";
            FirstArea.MinimumWidth = 8;
            FirstArea.Name = "FirstArea";
            FirstArea.Width = 150;
            // 
            // SecondArea
            // 
            SecondArea.HeaderText = "第二區";
            SecondArea.MinimumWidth = 8;
            SecondArea.Name = "SecondArea";
            SecondArea.Width = 200;
            // 
            // PrizeStatus
            // 
            PrizeStatus.HeaderText = "兌獎狀況";
            PrizeStatus.MinimumWidth = 8;
            PrizeStatus.Name = "PrizeStatus";
            PrizeStatus.Width = 150;
            // 
            // PrizeAmount
            // 
            PrizeAmount.HeaderText = "中獎金額";
            PrizeAmount.MinimumWidth = 8;
            PrizeAmount.Name = "PrizeAmount";
            PrizeAmount.Width = 150;
            // 
            // signButton
            // 
            signButton.Location = new Point(191, 851);
            signButton.Name = "signButton";
            signButton.Size = new Size(112, 34);
            signButton.TabIndex = 10;
            signButton.Text = "簽牌";
            signButton.UseVisualStyleBackColor = true;
            signButton.Click += signButton_Click;
            // 
            // selectnu
            // 
            selectnu.AutoSize = true;
            selectnu.Location = new Point(6, 29);
            selectnu.Name = "selectnu";
            selectnu.Size = new Size(56, 27);
            selectnu.TabIndex = 11;
            selectnu.Text = "01";
            selectnu.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(79, 29);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(56, 27);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "02";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(141, 29);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(56, 27);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "03";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(575, 29);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(56, 27);
            checkBox8.TabIndex = 19;
            checkBox8.Text = "10";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(513, 29);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(56, 27);
            checkBox9.TabIndex = 20;
            checkBox9.Text = "09";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(451, 29);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(56, 27);
            checkBox10.TabIndex = 21;
            checkBox10.Text = "08";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(389, 29);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(56, 27);
            checkBox11.TabIndex = 22;
            checkBox11.Text = "07";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(327, 29);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(56, 27);
            checkBox12.TabIndex = 23;
            checkBox12.Text = "06";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Location = new Point(265, 29);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(56, 27);
            checkBox13.TabIndex = 24;
            checkBox13.Text = "05";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Location = new Point(203, 29);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(56, 27);
            checkBox14.TabIndex = 25;
            checkBox14.Text = "04";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(203, 77);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(56, 27);
            checkBox3.TabIndex = 35;
            checkBox3.Text = "14";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(265, 77);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(56, 27);
            checkBox4.TabIndex = 34;
            checkBox4.Text = "15";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(327, 77);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(56, 27);
            checkBox5.TabIndex = 33;
            checkBox5.Text = "16";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(389, 77);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(56, 27);
            checkBox6.TabIndex = 32;
            checkBox6.Text = "17";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(451, 77);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(56, 27);
            checkBox7.TabIndex = 31;
            checkBox7.Text = "18";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            checkBox15.AutoSize = true;
            checkBox15.Location = new Point(513, 77);
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size(56, 27);
            checkBox15.TabIndex = 30;
            checkBox15.Text = "19";
            checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Location = new Point(575, 77);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(56, 27);
            checkBox16.TabIndex = 29;
            checkBox16.Text = "20";
            checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            checkBox17.AutoSize = true;
            checkBox17.Location = new Point(141, 77);
            checkBox17.Name = "checkBox17";
            checkBox17.Size = new Size(56, 27);
            checkBox17.TabIndex = 28;
            checkBox17.Text = "13";
            checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            checkBox18.AutoSize = true;
            checkBox18.Location = new Point(79, 77);
            checkBox18.Name = "checkBox18";
            checkBox18.Size = new Size(56, 27);
            checkBox18.TabIndex = 27;
            checkBox18.Text = "12";
            checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            checkBox19.AutoSize = true;
            checkBox19.Location = new Point(6, 77);
            checkBox19.Name = "checkBox19";
            checkBox19.Size = new Size(56, 27);
            checkBox19.TabIndex = 26;
            checkBox19.Text = "11";
            checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            checkBox20.AutoSize = true;
            checkBox20.Location = new Point(203, 123);
            checkBox20.Name = "checkBox20";
            checkBox20.Size = new Size(56, 27);
            checkBox20.TabIndex = 45;
            checkBox20.Text = "24";
            checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            checkBox21.AutoSize = true;
            checkBox21.Location = new Point(265, 123);
            checkBox21.Name = "checkBox21";
            checkBox21.Size = new Size(56, 27);
            checkBox21.TabIndex = 44;
            checkBox21.Text = "25";
            checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            checkBox22.AutoSize = true;
            checkBox22.Location = new Point(327, 123);
            checkBox22.Name = "checkBox22";
            checkBox22.Size = new Size(56, 27);
            checkBox22.TabIndex = 43;
            checkBox22.Text = "26";
            checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            checkBox23.AutoSize = true;
            checkBox23.Location = new Point(389, 123);
            checkBox23.Name = "checkBox23";
            checkBox23.Size = new Size(56, 27);
            checkBox23.TabIndex = 42;
            checkBox23.Text = "27";
            checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox24
            // 
            checkBox24.AutoSize = true;
            checkBox24.Location = new Point(451, 123);
            checkBox24.Name = "checkBox24";
            checkBox24.Size = new Size(56, 27);
            checkBox24.TabIndex = 41;
            checkBox24.Text = "28";
            checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox25
            // 
            checkBox25.AutoSize = true;
            checkBox25.Location = new Point(513, 123);
            checkBox25.Name = "checkBox25";
            checkBox25.Size = new Size(56, 27);
            checkBox25.TabIndex = 40;
            checkBox25.Text = "29";
            checkBox25.UseVisualStyleBackColor = true;
            // 
            // checkBox26
            // 
            checkBox26.AutoSize = true;
            checkBox26.Location = new Point(575, 123);
            checkBox26.Name = "checkBox26";
            checkBox26.Size = new Size(56, 27);
            checkBox26.TabIndex = 39;
            checkBox26.Text = "30";
            checkBox26.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            checkBox27.AutoSize = true;
            checkBox27.Location = new Point(141, 123);
            checkBox27.Name = "checkBox27";
            checkBox27.Size = new Size(56, 27);
            checkBox27.TabIndex = 38;
            checkBox27.Text = "23";
            checkBox27.UseVisualStyleBackColor = true;
            // 
            // checkBox28
            // 
            checkBox28.AutoSize = true;
            checkBox28.Location = new Point(79, 123);
            checkBox28.Name = "checkBox28";
            checkBox28.Size = new Size(56, 27);
            checkBox28.TabIndex = 37;
            checkBox28.Text = "22";
            checkBox28.UseVisualStyleBackColor = true;
            // 
            // checkBox29
            // 
            checkBox29.AutoSize = true;
            checkBox29.Location = new Point(6, 123);
            checkBox29.Name = "checkBox29";
            checkBox29.Size = new Size(56, 27);
            checkBox29.TabIndex = 36;
            checkBox29.Text = "21";
            checkBox29.UseVisualStyleBackColor = true;
            // 
            // checkBox30
            // 
            checkBox30.AutoSize = true;
            checkBox30.Location = new Point(203, 169);
            checkBox30.Name = "checkBox30";
            checkBox30.Size = new Size(56, 27);
            checkBox30.TabIndex = 55;
            checkBox30.Text = "34";
            checkBox30.UseVisualStyleBackColor = true;
            // 
            // checkBox31
            // 
            checkBox31.AutoSize = true;
            checkBox31.Location = new Point(265, 169);
            checkBox31.Name = "checkBox31";
            checkBox31.Size = new Size(56, 27);
            checkBox31.TabIndex = 54;
            checkBox31.Text = "35";
            checkBox31.UseVisualStyleBackColor = true;
            // 
            // checkBox32
            // 
            checkBox32.AutoSize = true;
            checkBox32.Location = new Point(327, 169);
            checkBox32.Name = "checkBox32";
            checkBox32.Size = new Size(56, 27);
            checkBox32.TabIndex = 53;
            checkBox32.Text = "36";
            checkBox32.UseVisualStyleBackColor = true;
            // 
            // checkBox33
            // 
            checkBox33.AutoSize = true;
            checkBox33.Location = new Point(389, 169);
            checkBox33.Name = "checkBox33";
            checkBox33.Size = new Size(56, 27);
            checkBox33.TabIndex = 52;
            checkBox33.Text = "37";
            checkBox33.UseVisualStyleBackColor = true;
            // 
            // checkBox34
            // 
            checkBox34.AutoSize = true;
            checkBox34.Location = new Point(451, 169);
            checkBox34.Name = "checkBox34";
            checkBox34.Size = new Size(56, 27);
            checkBox34.TabIndex = 51;
            checkBox34.Text = "38";
            checkBox34.UseVisualStyleBackColor = true;
            // 
            // checkBox37
            // 
            checkBox37.AutoSize = true;
            checkBox37.Location = new Point(141, 169);
            checkBox37.Name = "checkBox37";
            checkBox37.Size = new Size(56, 27);
            checkBox37.TabIndex = 48;
            checkBox37.Text = "33";
            checkBox37.UseVisualStyleBackColor = true;
            // 
            // checkBox38
            // 
            checkBox38.AutoSize = true;
            checkBox38.Location = new Point(79, 169);
            checkBox38.Name = "checkBox38";
            checkBox38.Size = new Size(56, 27);
            checkBox38.TabIndex = 47;
            checkBox38.Text = "32";
            checkBox38.UseVisualStyleBackColor = true;
            // 
            // checkBox39
            // 
            checkBox39.AutoSize = true;
            checkBox39.Location = new Point(6, 169);
            checkBox39.Name = "checkBox39";
            checkBox39.Size = new Size(56, 27);
            checkBox39.TabIndex = 46;
            checkBox39.Text = "31";
            checkBox39.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 29);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(55, 27);
            radioButton1.TabIndex = 56;
            radioButton1.TabStop = true;
            radioButton1.Text = "01";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(67, 29);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 27);
            radioButton2.TabIndex = 57;
            radioButton2.TabStop = true;
            radioButton2.Text = "02";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(128, 29);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(55, 27);
            radioButton3.TabIndex = 58;
            radioButton3.TabStop = true;
            radioButton3.Text = "03";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(189, 29);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(55, 27);
            radioButton4.TabIndex = 59;
            radioButton4.TabStop = true;
            radioButton4.Text = "04";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(250, 29);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(55, 27);
            radioButton5.TabIndex = 60;
            radioButton5.TabStop = true;
            radioButton5.Text = "05";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(311, 29);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(55, 27);
            radioButton6.TabIndex = 61;
            radioButton6.TabStop = true;
            radioButton6.Text = "06";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(372, 29);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(55, 27);
            radioButton7.TabIndex = 62;
            radioButton7.TabStop = true;
            radioButton7.Text = "07";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(433, 29);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(55, 27);
            radioButton8.TabIndex = 63;
            radioButton8.TabStop = true;
            radioButton8.Text = "08";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // groupBoxFirstArea
            // 
            groupBoxFirstArea.Controls.Add(radioButton1);
            groupBoxFirstArea.Controls.Add(radioButton8);
            groupBoxFirstArea.Controls.Add(radioButton2);
            groupBoxFirstArea.Controls.Add(radioButton7);
            groupBoxFirstArea.Controls.Add(radioButton3);
            groupBoxFirstArea.Controls.Add(radioButton6);
            groupBoxFirstArea.Controls.Add(radioButton4);
            groupBoxFirstArea.Controls.Add(radioButton5);
            groupBoxFirstArea.Location = new Point(191, 556);
            groupBoxFirstArea.Name = "groupBoxFirstArea";
            groupBoxFirstArea.Size = new Size(522, 68);
            groupBoxFirstArea.TabIndex = 64;
            groupBoxFirstArea.TabStop = false;
            // 
            // groupBoxSecondArea
            // 
            groupBoxSecondArea.Controls.Add(selectnu);
            groupBoxSecondArea.Controls.Add(checkBox1);
            groupBoxSecondArea.Controls.Add(checkBox30);
            groupBoxSecondArea.Controls.Add(checkBox2);
            groupBoxSecondArea.Controls.Add(checkBox31);
            groupBoxSecondArea.Controls.Add(checkBox8);
            groupBoxSecondArea.Controls.Add(checkBox32);
            groupBoxSecondArea.Controls.Add(checkBox9);
            groupBoxSecondArea.Controls.Add(checkBox33);
            groupBoxSecondArea.Controls.Add(checkBox10);
            groupBoxSecondArea.Controls.Add(checkBox34);
            groupBoxSecondArea.Controls.Add(checkBox11);
            groupBoxSecondArea.Controls.Add(checkBox37);
            groupBoxSecondArea.Controls.Add(checkBox12);
            groupBoxSecondArea.Controls.Add(checkBox38);
            groupBoxSecondArea.Controls.Add(checkBox13);
            groupBoxSecondArea.Controls.Add(checkBox39);
            groupBoxSecondArea.Controls.Add(checkBox14);
            groupBoxSecondArea.Controls.Add(checkBox20);
            groupBoxSecondArea.Controls.Add(checkBox19);
            groupBoxSecondArea.Controls.Add(checkBox21);
            groupBoxSecondArea.Controls.Add(checkBox18);
            groupBoxSecondArea.Controls.Add(checkBox22);
            groupBoxSecondArea.Controls.Add(checkBox17);
            groupBoxSecondArea.Controls.Add(checkBox23);
            groupBoxSecondArea.Controls.Add(checkBox16);
            groupBoxSecondArea.Controls.Add(checkBox24);
            groupBoxSecondArea.Controls.Add(checkBox15);
            groupBoxSecondArea.Controls.Add(checkBox25);
            groupBoxSecondArea.Controls.Add(checkBox7);
            groupBoxSecondArea.Controls.Add(checkBox26);
            groupBoxSecondArea.Controls.Add(checkBox6);
            groupBoxSecondArea.Controls.Add(checkBox27);
            groupBoxSecondArea.Controls.Add(checkBox5);
            groupBoxSecondArea.Controls.Add(checkBox28);
            groupBoxSecondArea.Controls.Add(checkBox4);
            groupBoxSecondArea.Controls.Add(checkBox29);
            groupBoxSecondArea.Controls.Add(checkBox3);
            groupBoxSecondArea.Location = new Point(191, 630);
            groupBoxSecondArea.Name = "groupBoxSecondArea";
            groupBoxSecondArea.Size = new Size(636, 215);
            groupBoxSecondArea.TabIndex = 65;
            groupBoxSecondArea.TabStop = false;
            // 
            // packageButton
            // 
            packageButton.ForeColor = SystemColors.ControlText;
            packageButton.Location = new Point(326, 851);
            packageButton.Name = "packageButton";
            packageButton.Size = new Size(170, 102);
            packageButton.TabIndex = 66;
            packageButton.Text = "包牌(選第一區號碼進行包牌)*注意共2,760,681種組合，按了會跑很久";
            packageButton.UseVisualStyleBackColor = true;
            packageButton.Click += packageButton_Click;
            // 
            // randomSelectButton
            // 
            randomSelectButton.Location = new Point(326, 961);
            randomSelectButton.Name = "randomSelectButton";
            randomSelectButton.Size = new Size(170, 59);
            randomSelectButton.TabIndex = 67;
            randomSelectButton.Text = "隨機選號(一次新增500組不重複的號碼)";
            randomSelectButton.UseVisualStyleBackColor = true;
            randomSelectButton.Click += randomSelectButton_Click;
            // 
            // generatePrizeButton
            // 
            generatePrizeButton.Location = new Point(691, 286);
            generatePrizeButton.Name = "generatePrizeButton";
            generatePrizeButton.Size = new Size(104, 79);
            generatePrizeButton.TabIndex = 68;
            generatePrizeButton.Text = "產生今日頭獎號碼";
            generatePrizeButton.UseVisualStyleBackColor = true;
            generatePrizeButton.Click += generatePrizeButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 139);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 69;
            label3.Text = "今日頭獎號碼";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 191);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 70;
            label4.Text = "第一區號碼";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(288, 191);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 71;
            label5.Text = "第二區號碼";
            // 
            // labelFirstAreaPrize
            // 
            labelFirstAreaPrize.AutoSize = true;
            labelFirstAreaPrize.Location = new Point(94, 245);
            labelFirstAreaPrize.Name = "labelFirstAreaPrize";
            labelFirstAreaPrize.Size = new Size(64, 23);
            labelFirstAreaPrize.TabIndex = 72;
            labelFirstAreaPrize.Text = "未開獎";
            // 
            // labelSecondAreaPrize
            // 
            labelSecondAreaPrize.AutoSize = true;
            labelSecondAreaPrize.Location = new Point(288, 245);
            labelSecondAreaPrize.Name = "labelSecondAreaPrize";
            labelSecondAreaPrize.Size = new Size(64, 23);
            labelSecondAreaPrize.TabIndex = 73;
            labelSecondAreaPrize.Text = "未開獎";
            // 
            // checkPrizeButton
            // 
            checkPrizeButton.Location = new Point(719, 856);
            checkPrizeButton.Name = "checkPrizeButton";
            checkPrizeButton.Size = new Size(112, 34);
            checkPrizeButton.TabIndex = 74;
            checkPrizeButton.Text = "兌獎";
            checkPrizeButton.UseVisualStyleBackColor = true;
            checkPrizeButton.Click += checkPrizeButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(595, 862);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 75;
            label6.Text = "是否按過兌獎";
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(719, 986);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 34);
            clearButton.TabIndex = 76;
            clearButton.Text = "回到初始狀態";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1630, 1032);
            Controls.Add(clearButton);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(checkPrizeButton);
            Controls.Add(labelSecondAreaPrize);
            Controls.Add(labelFirstAreaPrize);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(generatePrizeButton);
            Controls.Add(randomSelectButton);
            Controls.Add(packageButton);
            Controls.Add(groupBoxSecondArea);
            Controls.Add(groupBoxFirstArea);
            Controls.Add(signButton);
            Controls.Add(dataGridViewSignedNumbers);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSignedNumbers).EndInit();
            groupBoxFirstArea.ResumeLayout(false);
            groupBoxFirstArea.PerformLayout();
            groupBoxSecondArea.ResumeLayout(false);
            groupBoxSecondArea.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridViewSignedNumbers;
        private Button signButton;
        private CheckBox selectnu;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox15;
        private CheckBox checkBox16;
        private CheckBox checkBox17;
        private CheckBox checkBox18;
        private CheckBox checkBox19;
        private CheckBox checkBox20;
        private CheckBox checkBox21;
        private CheckBox checkBox22;
        private CheckBox checkBox23;
        private CheckBox checkBox24;
        private CheckBox checkBox25;
        private CheckBox checkBox26;
        private CheckBox checkBox27;
        private CheckBox checkBox28;
        private CheckBox checkBox29;
        private CheckBox checkBox30;
        private CheckBox checkBox31;
        private CheckBox checkBox32;
        private CheckBox checkBox33;
        private CheckBox checkBox34;
        private CheckBox checkBox37;
        private CheckBox checkBox38;
        private CheckBox checkBox39;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private GroupBox groupBoxFirstArea;
        private GroupBox groupBoxSecondArea;
        private Button packageButton;
        private Button randomSelectButton;
        private DataGridViewTextBoxColumn FirstArea;
        private DataGridViewTextBoxColumn SecondArea;
        private DataGridViewTextBoxColumn PrizeStatus;
        private DataGridViewTextBoxColumn PrizeAmount;
        private Button generatePrizeButton;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelFirstAreaPrize;
        private Label labelSecondAreaPrize;
        private Button checkPrizeButton;
        private Label label6;
        private Button button1;
        private Button clearButton;
    }
}

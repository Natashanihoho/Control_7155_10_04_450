﻿
namespace Control_7155_10_04_450
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
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxY1PA = new System.Windows.Forms.CheckBox();
            this.checkBoxY2PA = new System.Windows.Forms.CheckBox();
            this.checkBoxY3PA = new System.Windows.Forms.CheckBox();
            this.checkBoxY4PA = new System.Windows.Forms.CheckBox();
            this.checkBoxCLKPA = new System.Windows.Forms.CheckBox();
            this.checkBoxCLK_ENA = new System.Windows.Forms.CheckBox();
            this.checkBoxPW_ENA = new System.Windows.Forms.CheckBox();
            this.checkBoxUPR1A = new System.Windows.Forms.CheckBox();
            this.checkBoxUPR2A = new System.Windows.Forms.CheckBox();
            this.checkBoxUPR3A = new System.Windows.Forms.CheckBox();
            this.checkBoxUPR4A = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxUPR4B = new System.Windows.Forms.CheckBox();
            this.checkBoxUPR3B = new System.Windows.Forms.CheckBox();
            this.checkBoxUPR2B = new System.Windows.Forms.CheckBox();
            this.checkBoxUPR1B = new System.Windows.Forms.CheckBox();
            this.checkBoxPW_ENB = new System.Windows.Forms.CheckBox();
            this.checkBoxCLK_ENB = new System.Windows.Forms.CheckBox();
            this.checkBoxCLKPB = new System.Windows.Forms.CheckBox();
            this.checkBoxY4PB = new System.Windows.Forms.CheckBox();
            this.checkBoxY3PB = new System.Windows.Forms.CheckBox();
            this.checkBoxY2PB = new System.Windows.Forms.CheckBox();
            this.checkBoxY1PB = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxDSPDP6 = new System.Windows.Forms.CheckBox();
            this.checkBoxDSPDP5 = new System.Windows.Forms.CheckBox();
            this.checkBoxDSPDP4 = new System.Windows.Forms.CheckBox();
            this.checkBoxDSPDP3 = new System.Windows.Forms.CheckBox();
            this.checkBoxDSPDP2 = new System.Windows.Forms.CheckBox();
            this.checkBoxDSPDP1 = new System.Windows.Forms.CheckBox();
            this.checkBoxDSPDOP4 = new System.Windows.Forms.CheckBox();
            this.checkBoxDSPDOP3 = new System.Windows.Forms.CheckBox();
            this.checkBoxDSPDOP2 = new System.Windows.Forms.CheckBox();
            this.checkBoxDSPDOP1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxIO_TV5S = new System.Windows.Forms.CheckBox();
            this.checkBoxIO_TV3S = new System.Windows.Forms.CheckBox();
            this.checkBoxIO_TV4S = new System.Windows.Forms.CheckBox();
            this.checkBoxIO_TV2S = new System.Windows.Forms.CheckBox();
            this.checkBoxIO_TV1S = new System.Windows.Forms.CheckBox();
            this.checkBoxIO_TV0S = new System.Windows.Forms.CheckBox();
            this.checkBoxIO_TV6S = new System.Windows.Forms.CheckBox();
            this.checkBoxIO_TV7S = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxTV2S_TV3S = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.checkBox29 = new System.Windows.Forms.CheckBox();
            this.checkBox30 = new System.Windows.Forms.CheckBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.ItemHeight = 13;
            this.comboBoxPorts.Location = new System.Drawing.Point(12, 572);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(93, 21);
            this.comboBoxPorts.TabIndex = 0;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxPorts_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxUPR4A);
            this.groupBox1.Controls.Add(this.checkBoxUPR3A);
            this.groupBox1.Controls.Add(this.checkBoxUPR2A);
            this.groupBox1.Controls.Add(this.checkBoxUPR1A);
            this.groupBox1.Controls.Add(this.checkBoxPW_ENA);
            this.groupBox1.Controls.Add(this.checkBoxCLK_ENA);
            this.groupBox1.Controls.Add(this.checkBoxCLKPA);
            this.groupBox1.Controls.Add(this.checkBoxY4PA);
            this.groupBox1.Controls.Add(this.checkBoxY3PA);
            this.groupBox1.Controls.Add(this.checkBoxY2PA);
            this.groupBox1.Controls.Add(this.checkBoxY1PA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connector X1";
            // 
            // checkBoxY1PA
            // 
            this.checkBoxY1PA.AutoSize = true;
            this.checkBoxY1PA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY1PA.Location = new System.Drawing.Point(13, 28);
            this.checkBoxY1PA.Name = "checkBoxY1PA";
            this.checkBoxY1PA.Size = new System.Drawing.Size(61, 20);
            this.checkBoxY1PA.TabIndex = 2;
            this.checkBoxY1PA.Text = "Y1PA";
            this.checkBoxY1PA.UseVisualStyleBackColor = true;
            // 
            // checkBoxY2PA
            // 
            this.checkBoxY2PA.AutoSize = true;
            this.checkBoxY2PA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY2PA.Location = new System.Drawing.Point(13, 51);
            this.checkBoxY2PA.Name = "checkBoxY2PA";
            this.checkBoxY2PA.Size = new System.Drawing.Size(61, 20);
            this.checkBoxY2PA.TabIndex = 2;
            this.checkBoxY2PA.Text = "Y2PA";
            this.checkBoxY2PA.UseVisualStyleBackColor = true;
            // 
            // checkBoxY3PA
            // 
            this.checkBoxY3PA.AutoSize = true;
            this.checkBoxY3PA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY3PA.Location = new System.Drawing.Point(13, 74);
            this.checkBoxY3PA.Name = "checkBoxY3PA";
            this.checkBoxY3PA.Size = new System.Drawing.Size(61, 20);
            this.checkBoxY3PA.TabIndex = 2;
            this.checkBoxY3PA.Text = "Y3PA";
            this.checkBoxY3PA.UseVisualStyleBackColor = true;
            // 
            // checkBoxY4PA
            // 
            this.checkBoxY4PA.AutoSize = true;
            this.checkBoxY4PA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY4PA.Location = new System.Drawing.Point(13, 97);
            this.checkBoxY4PA.Name = "checkBoxY4PA";
            this.checkBoxY4PA.Size = new System.Drawing.Size(61, 20);
            this.checkBoxY4PA.TabIndex = 2;
            this.checkBoxY4PA.Text = "Y4PA";
            this.checkBoxY4PA.UseVisualStyleBackColor = true;
            // 
            // checkBoxCLKPA
            // 
            this.checkBoxCLKPA.AutoSize = true;
            this.checkBoxCLKPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCLKPA.Location = new System.Drawing.Point(13, 120);
            this.checkBoxCLKPA.Name = "checkBoxCLKPA";
            this.checkBoxCLKPA.Size = new System.Drawing.Size(69, 20);
            this.checkBoxCLKPA.TabIndex = 2;
            this.checkBoxCLKPA.Text = "CLKPA";
            this.checkBoxCLKPA.UseVisualStyleBackColor = true;
            // 
            // checkBoxCLK_ENA
            // 
            this.checkBoxCLK_ENA.AutoSize = true;
            this.checkBoxCLK_ENA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCLK_ENA.Location = new System.Drawing.Point(13, 143);
            this.checkBoxCLK_ENA.Name = "checkBoxCLK_ENA";
            this.checkBoxCLK_ENA.Size = new System.Drawing.Size(86, 20);
            this.checkBoxCLK_ENA.TabIndex = 2;
            this.checkBoxCLK_ENA.Text = "CLK_ENA";
            this.checkBoxCLK_ENA.UseVisualStyleBackColor = true;
            // 
            // checkBoxPW_ENA
            // 
            this.checkBoxPW_ENA.AutoSize = true;
            this.checkBoxPW_ENA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPW_ENA.Location = new System.Drawing.Point(13, 166);
            this.checkBoxPW_ENA.Name = "checkBoxPW_ENA";
            this.checkBoxPW_ENA.Size = new System.Drawing.Size(84, 20);
            this.checkBoxPW_ENA.TabIndex = 2;
            this.checkBoxPW_ENA.Text = "PW_ENA";
            this.checkBoxPW_ENA.UseVisualStyleBackColor = true;
            // 
            // checkBoxUPR1A
            // 
            this.checkBoxUPR1A.AutoSize = true;
            this.checkBoxUPR1A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUPR1A.Location = new System.Drawing.Point(13, 189);
            this.checkBoxUPR1A.Name = "checkBoxUPR1A";
            this.checkBoxUPR1A.Size = new System.Drawing.Size(72, 20);
            this.checkBoxUPR1A.TabIndex = 2;
            this.checkBoxUPR1A.Text = "UPR1A";
            this.checkBoxUPR1A.UseVisualStyleBackColor = true;
            // 
            // checkBoxUPR2A
            // 
            this.checkBoxUPR2A.AutoSize = true;
            this.checkBoxUPR2A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUPR2A.Location = new System.Drawing.Point(13, 212);
            this.checkBoxUPR2A.Name = "checkBoxUPR2A";
            this.checkBoxUPR2A.Size = new System.Drawing.Size(72, 20);
            this.checkBoxUPR2A.TabIndex = 2;
            this.checkBoxUPR2A.Text = "UPR2A";
            this.checkBoxUPR2A.UseVisualStyleBackColor = true;
            // 
            // checkBoxUPR3A
            // 
            this.checkBoxUPR3A.AutoSize = true;
            this.checkBoxUPR3A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUPR3A.Location = new System.Drawing.Point(13, 235);
            this.checkBoxUPR3A.Name = "checkBoxUPR3A";
            this.checkBoxUPR3A.Size = new System.Drawing.Size(72, 20);
            this.checkBoxUPR3A.TabIndex = 2;
            this.checkBoxUPR3A.Text = "UPR3A";
            this.checkBoxUPR3A.UseVisualStyleBackColor = true;
            // 
            // checkBoxUPR4A
            // 
            this.checkBoxUPR4A.AutoSize = true;
            this.checkBoxUPR4A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUPR4A.Location = new System.Drawing.Point(13, 258);
            this.checkBoxUPR4A.Name = "checkBoxUPR4A";
            this.checkBoxUPR4A.Size = new System.Drawing.Size(72, 20);
            this.checkBoxUPR4A.TabIndex = 2;
            this.checkBoxUPR4A.Text = "UPR4A";
            this.checkBoxUPR4A.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxUPR4B);
            this.groupBox2.Controls.Add(this.checkBoxUPR3B);
            this.groupBox2.Controls.Add(this.checkBoxUPR2B);
            this.groupBox2.Controls.Add(this.checkBoxUPR1B);
            this.groupBox2.Controls.Add(this.checkBoxPW_ENB);
            this.groupBox2.Controls.Add(this.checkBoxCLK_ENB);
            this.groupBox2.Controls.Add(this.checkBoxCLKPB);
            this.groupBox2.Controls.Add(this.checkBoxY4PB);
            this.groupBox2.Controls.Add(this.checkBoxY3PB);
            this.groupBox2.Controls.Add(this.checkBoxY2PB);
            this.groupBox2.Controls.Add(this.checkBoxY1PB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(142, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connector X5";
            // 
            // checkBoxUPR4B
            // 
            this.checkBoxUPR4B.AutoSize = true;
            this.checkBoxUPR4B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUPR4B.Location = new System.Drawing.Point(13, 258);
            this.checkBoxUPR4B.Name = "checkBoxUPR4B";
            this.checkBoxUPR4B.Size = new System.Drawing.Size(72, 20);
            this.checkBoxUPR4B.TabIndex = 2;
            this.checkBoxUPR4B.Text = "UPR4B";
            this.checkBoxUPR4B.UseVisualStyleBackColor = true;
            // 
            // checkBoxUPR3B
            // 
            this.checkBoxUPR3B.AutoSize = true;
            this.checkBoxUPR3B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUPR3B.Location = new System.Drawing.Point(13, 235);
            this.checkBoxUPR3B.Name = "checkBoxUPR3B";
            this.checkBoxUPR3B.Size = new System.Drawing.Size(72, 20);
            this.checkBoxUPR3B.TabIndex = 2;
            this.checkBoxUPR3B.Text = "UPR3B";
            this.checkBoxUPR3B.UseVisualStyleBackColor = true;
            // 
            // checkBoxUPR2B
            // 
            this.checkBoxUPR2B.AutoSize = true;
            this.checkBoxUPR2B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUPR2B.Location = new System.Drawing.Point(13, 212);
            this.checkBoxUPR2B.Name = "checkBoxUPR2B";
            this.checkBoxUPR2B.Size = new System.Drawing.Size(72, 20);
            this.checkBoxUPR2B.TabIndex = 2;
            this.checkBoxUPR2B.Text = "UPR2B";
            this.checkBoxUPR2B.UseVisualStyleBackColor = true;
            // 
            // checkBoxUPR1B
            // 
            this.checkBoxUPR1B.AutoSize = true;
            this.checkBoxUPR1B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUPR1B.Location = new System.Drawing.Point(13, 189);
            this.checkBoxUPR1B.Name = "checkBoxUPR1B";
            this.checkBoxUPR1B.Size = new System.Drawing.Size(72, 20);
            this.checkBoxUPR1B.TabIndex = 2;
            this.checkBoxUPR1B.Text = "UPR1B";
            this.checkBoxUPR1B.UseVisualStyleBackColor = true;
            // 
            // checkBoxPW_ENB
            // 
            this.checkBoxPW_ENB.AutoSize = true;
            this.checkBoxPW_ENB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPW_ENB.Location = new System.Drawing.Point(13, 166);
            this.checkBoxPW_ENB.Name = "checkBoxPW_ENB";
            this.checkBoxPW_ENB.Size = new System.Drawing.Size(84, 20);
            this.checkBoxPW_ENB.TabIndex = 2;
            this.checkBoxPW_ENB.Text = "PW_ENB";
            this.checkBoxPW_ENB.UseVisualStyleBackColor = true;
            // 
            // checkBoxCLK_ENB
            // 
            this.checkBoxCLK_ENB.AutoSize = true;
            this.checkBoxCLK_ENB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCLK_ENB.Location = new System.Drawing.Point(13, 143);
            this.checkBoxCLK_ENB.Name = "checkBoxCLK_ENB";
            this.checkBoxCLK_ENB.Size = new System.Drawing.Size(86, 20);
            this.checkBoxCLK_ENB.TabIndex = 2;
            this.checkBoxCLK_ENB.Text = "CLK_ENB";
            this.checkBoxCLK_ENB.UseVisualStyleBackColor = true;
            // 
            // checkBoxCLKPB
            // 
            this.checkBoxCLKPB.AutoSize = true;
            this.checkBoxCLKPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCLKPB.Location = new System.Drawing.Point(13, 120);
            this.checkBoxCLKPB.Name = "checkBoxCLKPB";
            this.checkBoxCLKPB.Size = new System.Drawing.Size(69, 20);
            this.checkBoxCLKPB.TabIndex = 2;
            this.checkBoxCLKPB.Text = "CLKPB";
            this.checkBoxCLKPB.UseVisualStyleBackColor = true;
            // 
            // checkBoxY4PB
            // 
            this.checkBoxY4PB.AutoSize = true;
            this.checkBoxY4PB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY4PB.Location = new System.Drawing.Point(13, 97);
            this.checkBoxY4PB.Name = "checkBoxY4PB";
            this.checkBoxY4PB.Size = new System.Drawing.Size(61, 20);
            this.checkBoxY4PB.TabIndex = 2;
            this.checkBoxY4PB.Text = "Y4PB";
            this.checkBoxY4PB.UseVisualStyleBackColor = true;
            // 
            // checkBoxY3PB
            // 
            this.checkBoxY3PB.AutoSize = true;
            this.checkBoxY3PB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY3PB.Location = new System.Drawing.Point(13, 74);
            this.checkBoxY3PB.Name = "checkBoxY3PB";
            this.checkBoxY3PB.Size = new System.Drawing.Size(61, 20);
            this.checkBoxY3PB.TabIndex = 2;
            this.checkBoxY3PB.Text = "Y3PB";
            this.checkBoxY3PB.UseVisualStyleBackColor = true;
            // 
            // checkBoxY2PB
            // 
            this.checkBoxY2PB.AutoSize = true;
            this.checkBoxY2PB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY2PB.Location = new System.Drawing.Point(13, 51);
            this.checkBoxY2PB.Name = "checkBoxY2PB";
            this.checkBoxY2PB.Size = new System.Drawing.Size(61, 20);
            this.checkBoxY2PB.TabIndex = 2;
            this.checkBoxY2PB.Text = "Y2PB";
            this.checkBoxY2PB.UseVisualStyleBackColor = true;
            // 
            // checkBoxY1PB
            // 
            this.checkBoxY1PB.AutoSize = true;
            this.checkBoxY1PB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY1PB.Location = new System.Drawing.Point(13, 28);
            this.checkBoxY1PB.Name = "checkBoxY1PB";
            this.checkBoxY1PB.Size = new System.Drawing.Size(61, 20);
            this.checkBoxY1PB.TabIndex = 2;
            this.checkBoxY1PB.Text = "Y1PB";
            this.checkBoxY1PB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxDSPDP6);
            this.groupBox3.Controls.Add(this.checkBoxDSPDP5);
            this.groupBox3.Controls.Add(this.checkBoxDSPDP4);
            this.groupBox3.Controls.Add(this.checkBoxDSPDP3);
            this.groupBox3.Controls.Add(this.checkBoxDSPDP2);
            this.groupBox3.Controls.Add(this.checkBoxDSPDP1);
            this.groupBox3.Controls.Add(this.checkBoxDSPDOP4);
            this.groupBox3.Controls.Add(this.checkBoxDSPDOP3);
            this.groupBox3.Controls.Add(this.checkBoxDSPDOP2);
            this.groupBox3.Controls.Add(this.checkBoxDSPDOP1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(273, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 288);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connector X2";
            // 
            // checkBoxDSPDP6
            // 
            this.checkBoxDSPDP6.AutoSize = true;
            this.checkBoxDSPDP6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDP6.Location = new System.Drawing.Point(13, 258);
            this.checkBoxDSPDP6.Name = "checkBoxDSPDP6";
            this.checkBoxDSPDP6.Size = new System.Drawing.Size(81, 20);
            this.checkBoxDSPDP6.TabIndex = 2;
            this.checkBoxDSPDP6.Text = "DSPDP6";
            this.checkBoxDSPDP6.UseVisualStyleBackColor = true;
            // 
            // checkBoxDSPDP5
            // 
            this.checkBoxDSPDP5.AutoSize = true;
            this.checkBoxDSPDP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDP5.Location = new System.Drawing.Point(13, 235);
            this.checkBoxDSPDP5.Name = "checkBoxDSPDP5";
            this.checkBoxDSPDP5.Size = new System.Drawing.Size(81, 20);
            this.checkBoxDSPDP5.TabIndex = 2;
            this.checkBoxDSPDP5.Text = "DSPDP5";
            this.checkBoxDSPDP5.UseVisualStyleBackColor = true;
            // 
            // checkBoxDSPDP4
            // 
            this.checkBoxDSPDP4.AutoSize = true;
            this.checkBoxDSPDP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDP4.Location = new System.Drawing.Point(13, 212);
            this.checkBoxDSPDP4.Name = "checkBoxDSPDP4";
            this.checkBoxDSPDP4.Size = new System.Drawing.Size(81, 20);
            this.checkBoxDSPDP4.TabIndex = 2;
            this.checkBoxDSPDP4.Text = "DSPDP4";
            this.checkBoxDSPDP4.UseVisualStyleBackColor = true;
            // 
            // checkBoxDSPDP3
            // 
            this.checkBoxDSPDP3.AutoSize = true;
            this.checkBoxDSPDP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDP3.Location = new System.Drawing.Point(13, 189);
            this.checkBoxDSPDP3.Name = "checkBoxDSPDP3";
            this.checkBoxDSPDP3.Size = new System.Drawing.Size(81, 20);
            this.checkBoxDSPDP3.TabIndex = 2;
            this.checkBoxDSPDP3.Text = "DSPDP3";
            this.checkBoxDSPDP3.UseVisualStyleBackColor = true;
            // 
            // checkBoxDSPDP2
            // 
            this.checkBoxDSPDP2.AutoSize = true;
            this.checkBoxDSPDP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDP2.Location = new System.Drawing.Point(13, 166);
            this.checkBoxDSPDP2.Name = "checkBoxDSPDP2";
            this.checkBoxDSPDP2.Size = new System.Drawing.Size(81, 20);
            this.checkBoxDSPDP2.TabIndex = 2;
            this.checkBoxDSPDP2.Text = "DSPDP2";
            this.checkBoxDSPDP2.UseVisualStyleBackColor = true;
            // 
            // checkBoxDSPDP1
            // 
            this.checkBoxDSPDP1.AutoSize = true;
            this.checkBoxDSPDP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDP1.Location = new System.Drawing.Point(13, 143);
            this.checkBoxDSPDP1.Name = "checkBoxDSPDP1";
            this.checkBoxDSPDP1.Size = new System.Drawing.Size(81, 20);
            this.checkBoxDSPDP1.TabIndex = 2;
            this.checkBoxDSPDP1.Text = "DSPDP1";
            this.checkBoxDSPDP1.UseVisualStyleBackColor = true;
            // 
            // checkBoxDSPDOP4
            // 
            this.checkBoxDSPDOP4.AutoSize = true;
            this.checkBoxDSPDOP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDOP4.Location = new System.Drawing.Point(13, 97);
            this.checkBoxDSPDOP4.Name = "checkBoxDSPDOP4";
            this.checkBoxDSPDOP4.Size = new System.Drawing.Size(91, 20);
            this.checkBoxDSPDOP4.TabIndex = 2;
            this.checkBoxDSPDOP4.Text = "DSPDOP4";
            this.checkBoxDSPDOP4.UseVisualStyleBackColor = true;
            // 
            // checkBoxDSPDOP3
            // 
            this.checkBoxDSPDOP3.AutoSize = true;
            this.checkBoxDSPDOP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDOP3.Location = new System.Drawing.Point(13, 74);
            this.checkBoxDSPDOP3.Name = "checkBoxDSPDOP3";
            this.checkBoxDSPDOP3.Size = new System.Drawing.Size(91, 20);
            this.checkBoxDSPDOP3.TabIndex = 2;
            this.checkBoxDSPDOP3.Text = "DSPDOP3";
            this.checkBoxDSPDOP3.UseVisualStyleBackColor = true;
            // 
            // checkBoxDSPDOP2
            // 
            this.checkBoxDSPDOP2.AutoSize = true;
            this.checkBoxDSPDOP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDOP2.Location = new System.Drawing.Point(13, 51);
            this.checkBoxDSPDOP2.Name = "checkBoxDSPDOP2";
            this.checkBoxDSPDOP2.Size = new System.Drawing.Size(91, 20);
            this.checkBoxDSPDOP2.TabIndex = 2;
            this.checkBoxDSPDOP2.Text = "DSPDOP1";
            this.checkBoxDSPDOP2.UseVisualStyleBackColor = true;
            // 
            // checkBoxDSPDOP1
            // 
            this.checkBoxDSPDOP1.AutoSize = true;
            this.checkBoxDSPDOP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDOP1.Location = new System.Drawing.Point(13, 28);
            this.checkBoxDSPDOP1.Name = "checkBoxDSPDOP1";
            this.checkBoxDSPDOP1.Size = new System.Drawing.Size(91, 20);
            this.checkBoxDSPDOP1.TabIndex = 2;
            this.checkBoxDSPDOP1.Text = "DSPDOP1";
            this.checkBoxDSPDOP1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxIO_TV5S);
            this.groupBox4.Controls.Add(this.checkBoxIO_TV3S);
            this.groupBox4.Controls.Add(this.checkBoxIO_TV4S);
            this.groupBox4.Controls.Add(this.checkBoxIO_TV2S);
            this.groupBox4.Controls.Add(this.checkBoxIO_TV1S);
            this.groupBox4.Controls.Add(this.checkBoxIO_TV0S);
            this.groupBox4.Controls.Add(this.checkBoxIO_TV7S);
            this.groupBox4.Controls.Add(this.checkBoxIO_TV6S);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(403, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(115, 288);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Signals to contact holes";
            // 
            // checkBoxIO_TV5S
            // 
            this.checkBoxIO_TV5S.AutoSize = true;
            this.checkBoxIO_TV5S.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIO_TV5S.Location = new System.Drawing.Point(15, 192);
            this.checkBoxIO_TV5S.Name = "checkBoxIO_TV5S";
            this.checkBoxIO_TV5S.Size = new System.Drawing.Size(85, 20);
            this.checkBoxIO_TV5S.TabIndex = 2;
            this.checkBoxIO_TV5S.Text = "I/O_TV5S";
            this.checkBoxIO_TV5S.UseVisualStyleBackColor = true;
            // 
            // checkBoxIO_TV3S
            // 
            this.checkBoxIO_TV3S.AutoSize = true;
            this.checkBoxIO_TV3S.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIO_TV3S.Location = new System.Drawing.Point(15, 132);
            this.checkBoxIO_TV3S.Name = "checkBoxIO_TV3S";
            this.checkBoxIO_TV3S.Size = new System.Drawing.Size(85, 20);
            this.checkBoxIO_TV3S.TabIndex = 2;
            this.checkBoxIO_TV3S.Text = "I/O_TV3S";
            this.checkBoxIO_TV3S.UseVisualStyleBackColor = true;
            // 
            // checkBoxIO_TV4S
            // 
            this.checkBoxIO_TV4S.AutoSize = true;
            this.checkBoxIO_TV4S.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIO_TV4S.Location = new System.Drawing.Point(15, 162);
            this.checkBoxIO_TV4S.Name = "checkBoxIO_TV4S";
            this.checkBoxIO_TV4S.Size = new System.Drawing.Size(85, 20);
            this.checkBoxIO_TV4S.TabIndex = 2;
            this.checkBoxIO_TV4S.Text = "I/O_TV4S";
            this.checkBoxIO_TV4S.UseVisualStyleBackColor = true;
            // 
            // checkBoxIO_TV2S
            // 
            this.checkBoxIO_TV2S.AutoSize = true;
            this.checkBoxIO_TV2S.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIO_TV2S.Location = new System.Drawing.Point(15, 102);
            this.checkBoxIO_TV2S.Name = "checkBoxIO_TV2S";
            this.checkBoxIO_TV2S.Size = new System.Drawing.Size(85, 20);
            this.checkBoxIO_TV2S.TabIndex = 2;
            this.checkBoxIO_TV2S.Text = "I/O_TV2S";
            this.checkBoxIO_TV2S.UseVisualStyleBackColor = true;
            // 
            // checkBoxIO_TV1S
            // 
            this.checkBoxIO_TV1S.AutoSize = true;
            this.checkBoxIO_TV1S.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIO_TV1S.Location = new System.Drawing.Point(15, 72);
            this.checkBoxIO_TV1S.Name = "checkBoxIO_TV1S";
            this.checkBoxIO_TV1S.Size = new System.Drawing.Size(85, 20);
            this.checkBoxIO_TV1S.TabIndex = 2;
            this.checkBoxIO_TV1S.Text = "I/O_TV1S";
            this.checkBoxIO_TV1S.UseVisualStyleBackColor = true;
            // 
            // checkBoxIO_TV0S
            // 
            this.checkBoxIO_TV0S.AutoSize = true;
            this.checkBoxIO_TV0S.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIO_TV0S.Location = new System.Drawing.Point(15, 42);
            this.checkBoxIO_TV0S.Name = "checkBoxIO_TV0S";
            this.checkBoxIO_TV0S.Size = new System.Drawing.Size(85, 20);
            this.checkBoxIO_TV0S.TabIndex = 2;
            this.checkBoxIO_TV0S.Text = "I/O_TV0S";
            this.checkBoxIO_TV0S.UseVisualStyleBackColor = true;
            // 
            // checkBoxIO_TV6S
            // 
            this.checkBoxIO_TV6S.AutoSize = true;
            this.checkBoxIO_TV6S.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIO_TV6S.Location = new System.Drawing.Point(15, 222);
            this.checkBoxIO_TV6S.Name = "checkBoxIO_TV6S";
            this.checkBoxIO_TV6S.Size = new System.Drawing.Size(85, 20);
            this.checkBoxIO_TV6S.TabIndex = 2;
            this.checkBoxIO_TV6S.Text = "I/O_TV6S";
            this.checkBoxIO_TV6S.UseVisualStyleBackColor = true;
            // 
            // checkBoxIO_TV7S
            // 
            this.checkBoxIO_TV7S.AutoSize = true;
            this.checkBoxIO_TV7S.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIO_TV7S.Location = new System.Drawing.Point(15, 252);
            this.checkBoxIO_TV7S.Name = "checkBoxIO_TV7S";
            this.checkBoxIO_TV7S.Size = new System.Drawing.Size(85, 20);
            this.checkBoxIO_TV7S.TabIndex = 2;
            this.checkBoxIO_TV7S.Text = "I/O_TV7S";
            this.checkBoxIO_TV7S.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox18);
            this.groupBox5.Controls.Add(this.checkBox12);
            this.groupBox5.Controls.Add(this.checkBox17);
            this.groupBox5.Controls.Add(this.checkBox11);
            this.groupBox5.Controls.Add(this.checkBox16);
            this.groupBox5.Controls.Add(this.checkBox9);
            this.groupBox5.Controls.Add(this.checkBox15);
            this.groupBox5.Controls.Add(this.checkBox14);
            this.groupBox5.Controls.Add(this.checkBox3);
            this.groupBox5.Controls.Add(this.checkBox13);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.checkBoxTV2S_TV3S);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(12, 319);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 201);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Signals between DD1_DD3_DD4";
            // 
            // checkBoxTV2S_TV3S
            // 
            this.checkBoxTV2S_TV3S.AutoSize = true;
            this.checkBoxTV2S_TV3S.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTV2S_TV3S.Location = new System.Drawing.Point(13, 39);
            this.checkBoxTV2S_TV3S.Name = "checkBoxTV2S_TV3S";
            this.checkBoxTV2S_TV3S.Size = new System.Drawing.Size(102, 20);
            this.checkBoxTV2S_TV3S.TabIndex = 0;
            this.checkBoxTV2S_TV3S.Text = "TV2S_TV3S";
            this.checkBoxTV2S_TV3S.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(13, 65);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(102, 20);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "TV2S_TV3S";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(13, 91);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(102, 20);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "TV2S_TV3S";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox9.Location = new System.Drawing.Point(13, 117);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(102, 20);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Text = "TV2S_TV3S";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox11.Location = new System.Drawing.Point(13, 143);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(102, 20);
            this.checkBox11.TabIndex = 0;
            this.checkBox11.Text = "TV2S_TV3S";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox12.Location = new System.Drawing.Point(13, 169);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(102, 20);
            this.checkBox12.TabIndex = 0;
            this.checkBox12.Text = "TV2S_TV3S";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox13.Location = new System.Drawing.Point(163, 39);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(102, 20);
            this.checkBox13.TabIndex = 0;
            this.checkBox13.Text = "TV2S_TV3S";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox14.Location = new System.Drawing.Point(163, 65);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(102, 20);
            this.checkBox14.TabIndex = 0;
            this.checkBox14.Text = "TV2S_TV3S";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox15.Location = new System.Drawing.Point(163, 91);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(102, 20);
            this.checkBox15.TabIndex = 0;
            this.checkBox15.Text = "TV2S_TV3S";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox16.Location = new System.Drawing.Point(163, 117);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(102, 20);
            this.checkBox16.TabIndex = 0;
            this.checkBox16.Text = "TV2S_TV3S";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox17.Location = new System.Drawing.Point(163, 143);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(102, 20);
            this.checkBox17.TabIndex = 0;
            this.checkBox17.Text = "TV2S_TV3S";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox18.Location = new System.Drawing.Point(163, 169);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(102, 20);
            this.checkBox18.TabIndex = 0;
            this.checkBox18.Text = "TV2S_TV3S";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox19);
            this.groupBox6.Controls.Add(this.checkBox20);
            this.groupBox6.Controls.Add(this.checkBox21);
            this.groupBox6.Controls.Add(this.checkBox22);
            this.groupBox6.Controls.Add(this.checkBox23);
            this.groupBox6.Controls.Add(this.checkBox24);
            this.groupBox6.Controls.Add(this.checkBox25);
            this.groupBox6.Controls.Add(this.checkBox26);
            this.groupBox6.Controls.Add(this.checkBox27);
            this.groupBox6.Controls.Add(this.checkBox28);
            this.groupBox6.Controls.Add(this.checkBox29);
            this.groupBox6.Controls.Add(this.checkBox30);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(12, 319);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(304, 201);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Signals between DD1_DD3_DD4";
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox19.Location = new System.Drawing.Point(196, 169);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(102, 20);
            this.checkBox19.TabIndex = 0;
            this.checkBox19.Text = "TV2S_TV3S";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox20.Location = new System.Drawing.Point(13, 169);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(102, 20);
            this.checkBox20.TabIndex = 0;
            this.checkBox20.Text = "TV2S_TV3S";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox21.Location = new System.Drawing.Point(196, 143);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(102, 20);
            this.checkBox21.TabIndex = 0;
            this.checkBox21.Text = "TV2S_TV3S";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox22.Location = new System.Drawing.Point(13, 143);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(102, 20);
            this.checkBox22.TabIndex = 0;
            this.checkBox22.Text = "TV2S_TV3S";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox23.Location = new System.Drawing.Point(196, 117);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(102, 20);
            this.checkBox23.TabIndex = 0;
            this.checkBox23.Text = "TV2S_TV3S";
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox24.Location = new System.Drawing.Point(13, 117);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(102, 20);
            this.checkBox24.TabIndex = 0;
            this.checkBox24.Text = "TV2S_TV3S";
            this.checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox25.Location = new System.Drawing.Point(196, 91);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(102, 20);
            this.checkBox25.TabIndex = 0;
            this.checkBox25.Text = "TV2S_TV3S";
            this.checkBox25.UseVisualStyleBackColor = true;
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox26.Location = new System.Drawing.Point(196, 65);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(102, 20);
            this.checkBox26.TabIndex = 0;
            this.checkBox26.Text = "TV2S_TV3S";
            this.checkBox26.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox27.Location = new System.Drawing.Point(13, 91);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(102, 20);
            this.checkBox27.TabIndex = 0;
            this.checkBox27.Text = "TV2S_TV3S";
            this.checkBox27.UseVisualStyleBackColor = true;
            // 
            // checkBox28
            // 
            this.checkBox28.AutoSize = true;
            this.checkBox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox28.Location = new System.Drawing.Point(196, 39);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(102, 20);
            this.checkBox28.TabIndex = 0;
            this.checkBox28.Text = "TV2S_TV3S";
            this.checkBox28.UseVisualStyleBackColor = true;
            // 
            // checkBox29
            // 
            this.checkBox29.AutoSize = true;
            this.checkBox29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox29.Location = new System.Drawing.Point(13, 65);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(102, 20);
            this.checkBox29.TabIndex = 0;
            this.checkBox29.Text = "TV2S_TV3S";
            this.checkBox29.UseVisualStyleBackColor = true;
            // 
            // checkBox30
            // 
            this.checkBox30.AutoSize = true;
            this.checkBox30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox30.Location = new System.Drawing.Point(13, 39);
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Size = new System.Drawing.Size(99, 20);
            this.checkBox30.TabIndex = 0;
            this.checkBox30.Text = "TV2S-TV3S";
            this.checkBox30.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSend.Location = new System.Drawing.Point(403, 550);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(115, 43);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "SEND";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5"});
            this.checkedListBox1.Location = new System.Drawing.Point(353, 337);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 89);
            this.checkedListBox1.TabIndex = 4;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(398, 463);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 46);
            this.buttonTest.TabIndex = 5;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 605);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxPorts);
            this.Name = "Form1";
            this.Text = "7155.10.04.450";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxUPR4A;
        private System.Windows.Forms.CheckBox checkBoxUPR3A;
        private System.Windows.Forms.CheckBox checkBoxUPR2A;
        private System.Windows.Forms.CheckBox checkBoxUPR1A;
        private System.Windows.Forms.CheckBox checkBoxPW_ENA;
        private System.Windows.Forms.CheckBox checkBoxCLK_ENA;
        private System.Windows.Forms.CheckBox checkBoxCLKPA;
        private System.Windows.Forms.CheckBox checkBoxY4PA;
        private System.Windows.Forms.CheckBox checkBoxY3PA;
        private System.Windows.Forms.CheckBox checkBoxY2PA;
        private System.Windows.Forms.CheckBox checkBoxY1PA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxUPR4B;
        private System.Windows.Forms.CheckBox checkBoxUPR3B;
        private System.Windows.Forms.CheckBox checkBoxUPR2B;
        private System.Windows.Forms.CheckBox checkBoxUPR1B;
        private System.Windows.Forms.CheckBox checkBoxPW_ENB;
        private System.Windows.Forms.CheckBox checkBoxCLK_ENB;
        private System.Windows.Forms.CheckBox checkBoxCLKPB;
        private System.Windows.Forms.CheckBox checkBoxY4PB;
        private System.Windows.Forms.CheckBox checkBoxY3PB;
        private System.Windows.Forms.CheckBox checkBoxY2PB;
        private System.Windows.Forms.CheckBox checkBoxY1PB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxDSPDP6;
        private System.Windows.Forms.CheckBox checkBoxDSPDP5;
        private System.Windows.Forms.CheckBox checkBoxDSPDP4;
        private System.Windows.Forms.CheckBox checkBoxDSPDP3;
        private System.Windows.Forms.CheckBox checkBoxDSPDP2;
        private System.Windows.Forms.CheckBox checkBoxDSPDP1;
        private System.Windows.Forms.CheckBox checkBoxDSPDOP4;
        private System.Windows.Forms.CheckBox checkBoxDSPDOP3;
        private System.Windows.Forms.CheckBox checkBoxDSPDOP2;
        private System.Windows.Forms.CheckBox checkBoxDSPDOP1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxIO_TV5S;
        private System.Windows.Forms.CheckBox checkBoxIO_TV3S;
        private System.Windows.Forms.CheckBox checkBoxIO_TV4S;
        private System.Windows.Forms.CheckBox checkBoxIO_TV2S;
        private System.Windows.Forms.CheckBox checkBoxIO_TV1S;
        private System.Windows.Forms.CheckBox checkBoxIO_TV0S;
        private System.Windows.Forms.CheckBox checkBoxIO_TV7S;
        private System.Windows.Forms.CheckBox checkBoxIO_TV6S;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBoxTV2S_TV3S;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.CheckBox checkBox24;
        private System.Windows.Forms.CheckBox checkBox25;
        private System.Windows.Forms.CheckBox checkBox26;
        private System.Windows.Forms.CheckBox checkBox27;
        private System.Windows.Forms.CheckBox checkBox28;
        private System.Windows.Forms.CheckBox checkBox29;
        private System.Windows.Forms.CheckBox checkBox30;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonTest;
    }
}



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
            this.checkBoxUPR4A = new System.Windows.Forms.CheckBox();
            this.checkBoxUPR3A = new System.Windows.Forms.CheckBox();
            this.checkBoxUPR2A = new System.Windows.Forms.CheckBox();
            this.checkBoxUPR1A = new System.Windows.Forms.CheckBox();
            this.checkBoxPW_ENA = new System.Windows.Forms.CheckBox();
            this.checkBoxCLK_ENA = new System.Windows.Forms.CheckBox();
            this.checkBoxCLKPA = new System.Windows.Forms.CheckBox();
            this.checkBoxY4PA = new System.Windows.Forms.CheckBox();
            this.checkBoxY3PA = new System.Windows.Forms.CheckBox();
            this.checkBoxY2PA = new System.Windows.Forms.CheckBox();
            this.checkBoxY1PA = new System.Windows.Forms.CheckBox();
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
            this.checkBoxIO_TV7S = new System.Windows.Forms.CheckBox();
            this.checkBoxIO_TV6S = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBoxTV2S_TV3S = new System.Windows.Forms.CheckBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.comboBoxPorts.Location = new System.Drawing.Point(17, 425);
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
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 330);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connector X1";
            // 
            // checkBoxUPR4A
            // 
            this.checkBoxUPR4A.AutoSize = true;
            this.checkBoxUPR4A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUPR4A.Location = new System.Drawing.Point(13, 297);
            this.checkBoxUPR4A.Name = "checkBoxUPR4A";
            this.checkBoxUPR4A.Size = new System.Drawing.Size(82, 24);
            this.checkBoxUPR4A.TabIndex = 2;
            this.checkBoxUPR4A.Text = "UPR4A";
            this.checkBoxUPR4A.UseVisualStyleBackColor = true;
            this.checkBoxUPR4A.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxUPR3A
            // 
            this.checkBoxUPR3A.AutoSize = true;
            this.checkBoxUPR3A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUPR3A.Location = new System.Drawing.Point(13, 270);
            this.checkBoxUPR3A.Name = "checkBoxUPR3A";
            this.checkBoxUPR3A.Size = new System.Drawing.Size(82, 24);
            this.checkBoxUPR3A.TabIndex = 2;
            this.checkBoxUPR3A.Text = "UPR3A";
            this.checkBoxUPR3A.UseVisualStyleBackColor = true;
            this.checkBoxUPR3A.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxUPR2A
            // 
            this.checkBoxUPR2A.AutoSize = true;
            this.checkBoxUPR2A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUPR2A.Location = new System.Drawing.Point(13, 243);
            this.checkBoxUPR2A.Name = "checkBoxUPR2A";
            this.checkBoxUPR2A.Size = new System.Drawing.Size(82, 24);
            this.checkBoxUPR2A.TabIndex = 2;
            this.checkBoxUPR2A.Text = "UPR2A";
            this.checkBoxUPR2A.UseVisualStyleBackColor = true;
            this.checkBoxUPR2A.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxUPR1A
            // 
            this.checkBoxUPR1A.AutoSize = true;
            this.checkBoxUPR1A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUPR1A.Location = new System.Drawing.Point(13, 216);
            this.checkBoxUPR1A.Name = "checkBoxUPR1A";
            this.checkBoxUPR1A.Size = new System.Drawing.Size(82, 24);
            this.checkBoxUPR1A.TabIndex = 2;
            this.checkBoxUPR1A.Text = "UPR1A";
            this.checkBoxUPR1A.UseVisualStyleBackColor = true;
            this.checkBoxUPR1A.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxPW_ENA
            // 
            this.checkBoxPW_ENA.AutoSize = true;
            this.checkBoxPW_ENA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPW_ENA.Location = new System.Drawing.Point(13, 189);
            this.checkBoxPW_ENA.Name = "checkBoxPW_ENA";
            this.checkBoxPW_ENA.Size = new System.Drawing.Size(95, 24);
            this.checkBoxPW_ENA.TabIndex = 2;
            this.checkBoxPW_ENA.Text = "PW_ENA";
            this.checkBoxPW_ENA.UseVisualStyleBackColor = true;
            this.checkBoxPW_ENA.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxCLK_ENA
            // 
            this.checkBoxCLK_ENA.AutoSize = true;
            this.checkBoxCLK_ENA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCLK_ENA.Location = new System.Drawing.Point(13, 162);
            this.checkBoxCLK_ENA.Name = "checkBoxCLK_ENA";
            this.checkBoxCLK_ENA.Size = new System.Drawing.Size(100, 24);
            this.checkBoxCLK_ENA.TabIndex = 2;
            this.checkBoxCLK_ENA.Text = "CLK_ENA";
            this.checkBoxCLK_ENA.UseVisualStyleBackColor = true;
            this.checkBoxCLK_ENA.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxCLKPA
            // 
            this.checkBoxCLKPA.AutoSize = true;
            this.checkBoxCLKPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCLKPA.Location = new System.Drawing.Point(13, 135);
            this.checkBoxCLKPA.Name = "checkBoxCLKPA";
            this.checkBoxCLKPA.Size = new System.Drawing.Size(79, 24);
            this.checkBoxCLKPA.TabIndex = 2;
            this.checkBoxCLKPA.Text = "CLKPA";
            this.checkBoxCLKPA.UseVisualStyleBackColor = true;
            this.checkBoxCLKPA.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxY4PA
            // 
            this.checkBoxY4PA.AutoSize = true;
            this.checkBoxY4PA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY4PA.Location = new System.Drawing.Point(13, 108);
            this.checkBoxY4PA.Name = "checkBoxY4PA";
            this.checkBoxY4PA.Size = new System.Drawing.Size(69, 24);
            this.checkBoxY4PA.TabIndex = 2;
            this.checkBoxY4PA.Text = "Y4PA";
            this.checkBoxY4PA.UseVisualStyleBackColor = true;
            this.checkBoxY4PA.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxY3PA
            // 
            this.checkBoxY3PA.AutoSize = true;
            this.checkBoxY3PA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY3PA.Location = new System.Drawing.Point(13, 81);
            this.checkBoxY3PA.Name = "checkBoxY3PA";
            this.checkBoxY3PA.Size = new System.Drawing.Size(69, 24);
            this.checkBoxY3PA.TabIndex = 2;
            this.checkBoxY3PA.Text = "Y3PA";
            this.checkBoxY3PA.UseVisualStyleBackColor = true;
            this.checkBoxY3PA.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxY2PA
            // 
            this.checkBoxY2PA.AutoSize = true;
            this.checkBoxY2PA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY2PA.Location = new System.Drawing.Point(13, 54);
            this.checkBoxY2PA.Name = "checkBoxY2PA";
            this.checkBoxY2PA.Size = new System.Drawing.Size(69, 24);
            this.checkBoxY2PA.TabIndex = 2;
            this.checkBoxY2PA.Text = "Y2PA";
            this.checkBoxY2PA.UseVisualStyleBackColor = true;
            this.checkBoxY2PA.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxY1PA
            // 
            this.checkBoxY1PA.AutoSize = true;
            this.checkBoxY1PA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY1PA.Location = new System.Drawing.Point(13, 27);
            this.checkBoxY1PA.Name = "checkBoxY1PA";
            this.checkBoxY1PA.Size = new System.Drawing.Size(69, 24);
            this.checkBoxY1PA.TabIndex = 2;
            this.checkBoxY1PA.Text = "Y1PA";
            this.checkBoxY1PA.UseVisualStyleBackColor = true;
            this.checkBoxY1PA.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
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
            this.groupBox2.Location = new System.Drawing.Point(150, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 330);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connector X5";
            // 
            // checkBoxUPR4B
            // 
            this.checkBoxUPR4B.AutoSize = true;
            this.checkBoxUPR4B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUPR4B.Location = new System.Drawing.Point(13, 297);
            this.checkBoxUPR4B.Name = "checkBoxUPR4B";
            this.checkBoxUPR4B.Size = new System.Drawing.Size(82, 24);
            this.checkBoxUPR4B.TabIndex = 2;
            this.checkBoxUPR4B.Text = "UPR4B";
            this.checkBoxUPR4B.UseVisualStyleBackColor = true;
            this.checkBoxUPR4B.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxUPR3B
            // 
            this.checkBoxUPR3B.AutoSize = true;
            this.checkBoxUPR3B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUPR3B.Location = new System.Drawing.Point(13, 270);
            this.checkBoxUPR3B.Name = "checkBoxUPR3B";
            this.checkBoxUPR3B.Size = new System.Drawing.Size(82, 24);
            this.checkBoxUPR3B.TabIndex = 2;
            this.checkBoxUPR3B.Text = "UPR3B";
            this.checkBoxUPR3B.UseVisualStyleBackColor = true;
            this.checkBoxUPR3B.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxUPR2B
            // 
            this.checkBoxUPR2B.AutoSize = true;
            this.checkBoxUPR2B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUPR2B.Location = new System.Drawing.Point(13, 243);
            this.checkBoxUPR2B.Name = "checkBoxUPR2B";
            this.checkBoxUPR2B.Size = new System.Drawing.Size(82, 24);
            this.checkBoxUPR2B.TabIndex = 2;
            this.checkBoxUPR2B.Text = "UPR2B";
            this.checkBoxUPR2B.UseVisualStyleBackColor = true;
            this.checkBoxUPR2B.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxUPR1B
            // 
            this.checkBoxUPR1B.AutoSize = true;
            this.checkBoxUPR1B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUPR1B.Location = new System.Drawing.Point(13, 216);
            this.checkBoxUPR1B.Name = "checkBoxUPR1B";
            this.checkBoxUPR1B.Size = new System.Drawing.Size(82, 24);
            this.checkBoxUPR1B.TabIndex = 2;
            this.checkBoxUPR1B.Text = "UPR1B";
            this.checkBoxUPR1B.UseVisualStyleBackColor = true;
            this.checkBoxUPR1B.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxPW_ENB
            // 
            this.checkBoxPW_ENB.AutoSize = true;
            this.checkBoxPW_ENB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPW_ENB.Location = new System.Drawing.Point(13, 189);
            this.checkBoxPW_ENB.Name = "checkBoxPW_ENB";
            this.checkBoxPW_ENB.Size = new System.Drawing.Size(95, 24);
            this.checkBoxPW_ENB.TabIndex = 2;
            this.checkBoxPW_ENB.Text = "PW_ENB";
            this.checkBoxPW_ENB.UseVisualStyleBackColor = true;
            this.checkBoxPW_ENB.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxCLK_ENB
            // 
            this.checkBoxCLK_ENB.AutoSize = true;
            this.checkBoxCLK_ENB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCLK_ENB.Location = new System.Drawing.Point(13, 162);
            this.checkBoxCLK_ENB.Name = "checkBoxCLK_ENB";
            this.checkBoxCLK_ENB.Size = new System.Drawing.Size(100, 24);
            this.checkBoxCLK_ENB.TabIndex = 2;
            this.checkBoxCLK_ENB.Text = "CLK_ENB";
            this.checkBoxCLK_ENB.UseVisualStyleBackColor = true;
            this.checkBoxCLK_ENB.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxCLKPB
            // 
            this.checkBoxCLKPB.AutoSize = true;
            this.checkBoxCLKPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCLKPB.Location = new System.Drawing.Point(13, 135);
            this.checkBoxCLKPB.Name = "checkBoxCLKPB";
            this.checkBoxCLKPB.Size = new System.Drawing.Size(79, 24);
            this.checkBoxCLKPB.TabIndex = 2;
            this.checkBoxCLKPB.Text = "CLKPB";
            this.checkBoxCLKPB.UseVisualStyleBackColor = true;
            this.checkBoxCLKPB.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxY4PB
            // 
            this.checkBoxY4PB.AutoSize = true;
            this.checkBoxY4PB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY4PB.Location = new System.Drawing.Point(13, 108);
            this.checkBoxY4PB.Name = "checkBoxY4PB";
            this.checkBoxY4PB.Size = new System.Drawing.Size(69, 24);
            this.checkBoxY4PB.TabIndex = 2;
            this.checkBoxY4PB.Text = "Y4PB";
            this.checkBoxY4PB.UseVisualStyleBackColor = true;
            this.checkBoxY4PB.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxY3PB
            // 
            this.checkBoxY3PB.AutoSize = true;
            this.checkBoxY3PB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY3PB.Location = new System.Drawing.Point(13, 81);
            this.checkBoxY3PB.Name = "checkBoxY3PB";
            this.checkBoxY3PB.Size = new System.Drawing.Size(69, 24);
            this.checkBoxY3PB.TabIndex = 2;
            this.checkBoxY3PB.Text = "Y3PB";
            this.checkBoxY3PB.UseVisualStyleBackColor = true;
            this.checkBoxY3PB.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxY2PB
            // 
            this.checkBoxY2PB.AutoSize = true;
            this.checkBoxY2PB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY2PB.Location = new System.Drawing.Point(13, 54);
            this.checkBoxY2PB.Name = "checkBoxY2PB";
            this.checkBoxY2PB.Size = new System.Drawing.Size(69, 24);
            this.checkBoxY2PB.TabIndex = 2;
            this.checkBoxY2PB.Text = "Y2PB";
            this.checkBoxY2PB.UseVisualStyleBackColor = true;
            this.checkBoxY2PB.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxY1PB
            // 
            this.checkBoxY1PB.AutoSize = true;
            this.checkBoxY1PB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxY1PB.Location = new System.Drawing.Point(13, 27);
            this.checkBoxY1PB.Name = "checkBoxY1PB";
            this.checkBoxY1PB.Size = new System.Drawing.Size(69, 24);
            this.checkBoxY1PB.TabIndex = 2;
            this.checkBoxY1PB.Text = "Y1PB";
            this.checkBoxY1PB.UseVisualStyleBackColor = true;
            this.checkBoxY1PB.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
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
            this.groupBox3.Location = new System.Drawing.Point(285, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 330);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connector X2";
            // 
            // checkBoxDSPDP6
            // 
            this.checkBoxDSPDP6.AutoSize = true;
            this.checkBoxDSPDP6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDP6.Location = new System.Drawing.Point(13, 297);
            this.checkBoxDSPDP6.Name = "checkBoxDSPDP6";
            this.checkBoxDSPDP6.Size = new System.Drawing.Size(92, 24);
            this.checkBoxDSPDP6.TabIndex = 2;
            this.checkBoxDSPDP6.Text = "DSPDP6";
            this.checkBoxDSPDP6.UseVisualStyleBackColor = true;
            this.checkBoxDSPDP6.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxDSPDP5
            // 
            this.checkBoxDSPDP5.AutoSize = true;
            this.checkBoxDSPDP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDP5.Location = new System.Drawing.Point(13, 270);
            this.checkBoxDSPDP5.Name = "checkBoxDSPDP5";
            this.checkBoxDSPDP5.Size = new System.Drawing.Size(92, 24);
            this.checkBoxDSPDP5.TabIndex = 2;
            this.checkBoxDSPDP5.Text = "DSPDP5";
            this.checkBoxDSPDP5.UseVisualStyleBackColor = true;
            this.checkBoxDSPDP5.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxDSPDP4
            // 
            this.checkBoxDSPDP4.AutoSize = true;
            this.checkBoxDSPDP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDP4.Location = new System.Drawing.Point(13, 243);
            this.checkBoxDSPDP4.Name = "checkBoxDSPDP4";
            this.checkBoxDSPDP4.Size = new System.Drawing.Size(92, 24);
            this.checkBoxDSPDP4.TabIndex = 2;
            this.checkBoxDSPDP4.Text = "DSPDP4";
            this.checkBoxDSPDP4.UseVisualStyleBackColor = true;
            this.checkBoxDSPDP4.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxDSPDP3
            // 
            this.checkBoxDSPDP3.AutoSize = true;
            this.checkBoxDSPDP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDP3.Location = new System.Drawing.Point(13, 216);
            this.checkBoxDSPDP3.Name = "checkBoxDSPDP3";
            this.checkBoxDSPDP3.Size = new System.Drawing.Size(92, 24);
            this.checkBoxDSPDP3.TabIndex = 2;
            this.checkBoxDSPDP3.Text = "DSPDP3";
            this.checkBoxDSPDP3.UseVisualStyleBackColor = true;
            this.checkBoxDSPDP3.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxDSPDP2
            // 
            this.checkBoxDSPDP2.AutoSize = true;
            this.checkBoxDSPDP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDP2.Location = new System.Drawing.Point(13, 189);
            this.checkBoxDSPDP2.Name = "checkBoxDSPDP2";
            this.checkBoxDSPDP2.Size = new System.Drawing.Size(92, 24);
            this.checkBoxDSPDP2.TabIndex = 2;
            this.checkBoxDSPDP2.Text = "DSPDP2";
            this.checkBoxDSPDP2.UseVisualStyleBackColor = true;
            this.checkBoxDSPDP2.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxDSPDP1
            // 
            this.checkBoxDSPDP1.AutoSize = true;
            this.checkBoxDSPDP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDP1.Location = new System.Drawing.Point(13, 162);
            this.checkBoxDSPDP1.Name = "checkBoxDSPDP1";
            this.checkBoxDSPDP1.Size = new System.Drawing.Size(92, 24);
            this.checkBoxDSPDP1.TabIndex = 2;
            this.checkBoxDSPDP1.Text = "DSPDP1";
            this.checkBoxDSPDP1.UseVisualStyleBackColor = true;
            this.checkBoxDSPDP1.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxDSPDOP4
            // 
            this.checkBoxDSPDOP4.AutoSize = true;
            this.checkBoxDSPDOP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDOP4.Location = new System.Drawing.Point(13, 108);
            this.checkBoxDSPDOP4.Name = "checkBoxDSPDOP4";
            this.checkBoxDSPDOP4.Size = new System.Drawing.Size(104, 24);
            this.checkBoxDSPDOP4.TabIndex = 2;
            this.checkBoxDSPDOP4.Text = "DSPDOP4";
            this.checkBoxDSPDOP4.UseVisualStyleBackColor = true;
            this.checkBoxDSPDOP4.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxDSPDOP3
            // 
            this.checkBoxDSPDOP3.AutoSize = true;
            this.checkBoxDSPDOP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDOP3.Location = new System.Drawing.Point(13, 81);
            this.checkBoxDSPDOP3.Name = "checkBoxDSPDOP3";
            this.checkBoxDSPDOP3.Size = new System.Drawing.Size(104, 24);
            this.checkBoxDSPDOP3.TabIndex = 2;
            this.checkBoxDSPDOP3.Text = "DSPDOP3";
            this.checkBoxDSPDOP3.UseVisualStyleBackColor = true;
            this.checkBoxDSPDOP3.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxDSPDOP2
            // 
            this.checkBoxDSPDOP2.AutoSize = true;
            this.checkBoxDSPDOP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDOP2.Location = new System.Drawing.Point(13, 54);
            this.checkBoxDSPDOP2.Name = "checkBoxDSPDOP2";
            this.checkBoxDSPDOP2.Size = new System.Drawing.Size(104, 24);
            this.checkBoxDSPDOP2.TabIndex = 2;
            this.checkBoxDSPDOP2.Text = "DSPDOP2";
            this.checkBoxDSPDOP2.UseVisualStyleBackColor = true;
            this.checkBoxDSPDOP2.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxDSPDOP1
            // 
            this.checkBoxDSPDOP1.AutoSize = true;
            this.checkBoxDSPDOP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDSPDOP1.Location = new System.Drawing.Point(13, 27);
            this.checkBoxDSPDOP1.Name = "checkBoxDSPDOP1";
            this.checkBoxDSPDOP1.Size = new System.Drawing.Size(104, 24);
            this.checkBoxDSPDOP1.TabIndex = 2;
            this.checkBoxDSPDOP1.Text = "DSPDOP1";
            this.checkBoxDSPDOP1.UseVisualStyleBackColor = true;
            this.checkBoxDSPDOP1.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
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
            this.groupBox4.Location = new System.Drawing.Point(420, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(120, 330);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Signals to contact holes";
            // 
            // checkBoxIO_TV5S
            // 
            this.checkBoxIO_TV5S.AutoSize = true;
            this.checkBoxIO_TV5S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIO_TV5S.Location = new System.Drawing.Point(13, 226);
            this.checkBoxIO_TV5S.Name = "checkBoxIO_TV5S";
            this.checkBoxIO_TV5S.Size = new System.Drawing.Size(98, 24);
            this.checkBoxIO_TV5S.TabIndex = 2;
            this.checkBoxIO_TV5S.Text = "I/O_TV5S";
            this.checkBoxIO_TV5S.UseVisualStyleBackColor = true;
            this.checkBoxIO_TV5S.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxIO_TV3S
            // 
            this.checkBoxIO_TV3S.AutoSize = true;
            this.checkBoxIO_TV3S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIO_TV3S.Location = new System.Drawing.Point(13, 158);
            this.checkBoxIO_TV3S.Name = "checkBoxIO_TV3S";
            this.checkBoxIO_TV3S.Size = new System.Drawing.Size(98, 24);
            this.checkBoxIO_TV3S.TabIndex = 2;
            this.checkBoxIO_TV3S.Text = "I/O_TV3S";
            this.checkBoxIO_TV3S.UseVisualStyleBackColor = true;
            this.checkBoxIO_TV3S.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxIO_TV4S
            // 
            this.checkBoxIO_TV4S.AutoSize = true;
            this.checkBoxIO_TV4S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIO_TV4S.Location = new System.Drawing.Point(13, 192);
            this.checkBoxIO_TV4S.Name = "checkBoxIO_TV4S";
            this.checkBoxIO_TV4S.Size = new System.Drawing.Size(98, 24);
            this.checkBoxIO_TV4S.TabIndex = 2;
            this.checkBoxIO_TV4S.Text = "I/O_TV4S";
            this.checkBoxIO_TV4S.UseVisualStyleBackColor = true;
            this.checkBoxIO_TV4S.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxIO_TV2S
            // 
            this.checkBoxIO_TV2S.AutoSize = true;
            this.checkBoxIO_TV2S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIO_TV2S.Location = new System.Drawing.Point(13, 124);
            this.checkBoxIO_TV2S.Name = "checkBoxIO_TV2S";
            this.checkBoxIO_TV2S.Size = new System.Drawing.Size(98, 24);
            this.checkBoxIO_TV2S.TabIndex = 2;
            this.checkBoxIO_TV2S.Text = "I/O_TV2S";
            this.checkBoxIO_TV2S.UseVisualStyleBackColor = true;
            this.checkBoxIO_TV2S.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxIO_TV1S
            // 
            this.checkBoxIO_TV1S.AutoSize = true;
            this.checkBoxIO_TV1S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIO_TV1S.Location = new System.Drawing.Point(13, 90);
            this.checkBoxIO_TV1S.Name = "checkBoxIO_TV1S";
            this.checkBoxIO_TV1S.Size = new System.Drawing.Size(98, 24);
            this.checkBoxIO_TV1S.TabIndex = 2;
            this.checkBoxIO_TV1S.Text = "I/O_TV1S";
            this.checkBoxIO_TV1S.UseVisualStyleBackColor = true;
            this.checkBoxIO_TV1S.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxIO_TV0S
            // 
            this.checkBoxIO_TV0S.AutoSize = true;
            this.checkBoxIO_TV0S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIO_TV0S.Location = new System.Drawing.Point(13, 56);
            this.checkBoxIO_TV0S.Name = "checkBoxIO_TV0S";
            this.checkBoxIO_TV0S.Size = new System.Drawing.Size(98, 24);
            this.checkBoxIO_TV0S.TabIndex = 2;
            this.checkBoxIO_TV0S.Text = "I/O_TV0S";
            this.checkBoxIO_TV0S.UseVisualStyleBackColor = true;
            this.checkBoxIO_TV0S.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxIO_TV7S
            // 
            this.checkBoxIO_TV7S.AutoSize = true;
            this.checkBoxIO_TV7S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIO_TV7S.Location = new System.Drawing.Point(13, 294);
            this.checkBoxIO_TV7S.Name = "checkBoxIO_TV7S";
            this.checkBoxIO_TV7S.Size = new System.Drawing.Size(98, 24);
            this.checkBoxIO_TV7S.TabIndex = 2;
            this.checkBoxIO_TV7S.Text = "I/O_TV7S";
            this.checkBoxIO_TV7S.UseVisualStyleBackColor = true;
            this.checkBoxIO_TV7S.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxIO_TV6S
            // 
            this.checkBoxIO_TV6S.AutoSize = true;
            this.checkBoxIO_TV6S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIO_TV6S.Location = new System.Drawing.Point(13, 260);
            this.checkBoxIO_TV6S.Name = "checkBoxIO_TV6S";
            this.checkBoxIO_TV6S.Size = new System.Drawing.Size(98, 24);
            this.checkBoxIO_TV6S.TabIndex = 2;
            this.checkBoxIO_TV6S.Text = "I/O_TV6S";
            this.checkBoxIO_TV6S.UseVisualStyleBackColor = true;
            this.checkBoxIO_TV6S.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.checkBox18);
            this.groupBox5.Controls.Add(this.checkBox12);
            this.groupBox5.Controls.Add(this.checkBox17);
            this.groupBox5.Controls.Add(this.checkBox11);
            this.groupBox5.Controls.Add(this.checkBox16);
            this.groupBox5.Controls.Add(this.checkBox15);
            this.groupBox5.Controls.Add(this.checkBox14);
            this.groupBox5.Controls.Add(this.checkBox3);
            this.groupBox5.Controls.Add(this.checkBox13);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.checkBoxTV2S_TV3S);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(555, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(281, 435);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Signals between DD1_DD3_DD4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Location = new System.Drawing.Point(193, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "ERROR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(193, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "ERROR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(193, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "ERROR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(193, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "ERROR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(193, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "ERROR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(193, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "ERROR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(193, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "ERROR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(193, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ERROR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(193, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ERROR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(193, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ERROR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(193, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ERROR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(193, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ERROR";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(13, 401);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "HOLDN - SN";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox18.Location = new System.Drawing.Point(13, 367);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(89, 24);
            this.checkBox18.TabIndex = 0;
            this.checkBox18.Text = "WN - SN";
            this.checkBox18.UseVisualStyleBackColor = true;
            this.checkBox18.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox12.Location = new System.Drawing.Point(13, 163);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(154, 24);
            this.checkBox12.TabIndex = 0;
            this.checkBox12.Text = "CS_MD - CS_MG";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox17.Location = new System.Drawing.Point(13, 333);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(95, 24);
            this.checkBox17.TabIndex = 0;
            this.checkBox17.Text = "SCK - SN";
            this.checkBox17.UseVisualStyleBackColor = true;
            this.checkBox17.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox11.Location = new System.Drawing.Point(13, 129);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(151, 24);
            this.checkBox11.TabIndex = 0;
            this.checkBox11.Text = "CS_MC - CS_MN";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox16.Location = new System.Drawing.Point(13, 299);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(129, 24);
            this.checkBox16.TabIndex = 0;
            this.checkBox16.Text = "INTP4 - INTP5";
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox16.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox15.Location = new System.Drawing.Point(13, 265);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(129, 24);
            this.checkBox15.TabIndex = 0;
            this.checkBox15.Text = "INTP2 - INTP3";
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox14.Location = new System.Drawing.Point(13, 231);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(129, 24);
            this.checkBox14.TabIndex = 0;
            this.checkBox14.Text = "INTP0 - INTP1";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(13, 95);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(150, 24);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "CS_MB - CS_MF";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox13.Location = new System.Drawing.Point(13, 197);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(177, 24);
            this.checkBox13.TabIndex = 0;
            this.checkBox13.Text = "INTDOP1 - INTDOP2";
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(13, 61);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(151, 24);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "CS_MA - CS_ME";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // checkBoxTV2S_TV3S
            // 
            this.checkBoxTV2S_TV3S.AutoSize = true;
            this.checkBoxTV2S_TV3S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTV2S_TV3S.Location = new System.Drawing.Point(13, 27);
            this.checkBoxTV2S_TV3S.Name = "checkBoxTV2S_TV3S";
            this.checkBoxTV2S_TV3S.Size = new System.Drawing.Size(121, 24);
            this.checkBoxTV2S_TV3S.TabIndex = 0;
            this.checkBoxTV2S_TV3S.Text = "TV2S - TV3S";
            this.checkBoxTV2S_TV3S.UseVisualStyleBackColor = true;
            this.checkBoxTV2S_TV3S.CheckedChanged += new System.EventHandler(this.CheckedChangedEvent);
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSend.Location = new System.Drawing.Point(386, 403);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(115, 43);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "SEND";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(239, 403);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "label13122";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 467);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonSend);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBoxTV2S_TV3S;
        private System.Windows.Forms.Button buttonSend;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label13;
    }
}


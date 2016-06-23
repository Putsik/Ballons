namespace linesk
{
    partial class FormGameSetting
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabControlSetting = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonRhombus = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonColor3 = new System.Windows.Forms.Button();
            this.buttonColr2 = new System.Windows.Forms.Button();
            this.buttonColor1 = new System.Windows.Forms.Button();
            this.labelGraphItemColor3 = new System.Windows.Forms.Label();
            this.labelGraphItemColor2 = new System.Windows.Forms.Label();
            this.labelGraphItemColor1 = new System.Windows.Forms.Label();
            this.tabControlSetting.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(134, 233);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(236, 233);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tabControlSetting
            // 
            this.tabControlSetting.Controls.Add(this.tabPage2);
            this.tabControlSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlSetting.Location = new System.Drawing.Point(0, 0);
            this.tabControlSetting.Name = "tabControlSetting";
            this.tabControlSetting.SelectedIndex = 0;
            this.tabControlSetting.Size = new System.Drawing.Size(445, 224);
            this.tabControlSetting.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(437, 198);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Цвет шаров";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonRhombus);
            this.groupBox2.Controls.Add(this.radioButtonRectangle);
            this.groupBox2.Controls.Add(this.radioButtonEllipse);
            this.groupBox2.Location = new System.Drawing.Point(218, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 109);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вид геометрической фигуры";
            // 
            // radioButtonRhombus
            // 
            this.radioButtonRhombus.AutoSize = true;
            this.radioButtonRhombus.Location = new System.Drawing.Point(14, 66);
            this.radioButtonRhombus.Name = "radioButtonRhombus";
            this.radioButtonRhombus.Size = new System.Drawing.Size(52, 17);
            this.radioButtonRhombus.TabIndex = 0;
            this.radioButtonRhombus.TabStop = true;
            this.radioButtonRhombus.Text = "Ромб";
            this.radioButtonRhombus.UseVisualStyleBackColor = true;
            this.radioButtonRhombus.CheckedChanged += new System.EventHandler(this.radioButtonsGraphTypeItem_CheckedChanged);
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(14, 43);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(105, 17);
            this.radioButtonRectangle.TabIndex = 0;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Прямоугольник";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.radioButtonsGraphTypeItem_CheckedChanged);
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(14, 20);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(46, 17);
            this.radioButtonEllipse.TabIndex = 0;
            this.radioButtonEllipse.TabStop = true;
            this.radioButtonEllipse.Text = "Шар";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            this.radioButtonEllipse.CheckedChanged += new System.EventHandler(this.radioButtonsGraphTypeItem_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonColor3);
            this.groupBox1.Controls.Add(this.buttonColr2);
            this.groupBox1.Controls.Add(this.buttonColor1);
            this.groupBox1.Controls.Add(this.labelGraphItemColor3);
            this.groupBox1.Controls.Add(this.labelGraphItemColor2);
            this.groupBox1.Controls.Add(this.labelGraphItemColor1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор цвета шаров";
            // 
            // buttonColor3
            // 
            this.buttonColor3.Location = new System.Drawing.Point(135, 77);
            this.buttonColor3.Name = "buttonColor3";
            this.buttonColor3.Size = new System.Drawing.Size(50, 23);
            this.buttonColor3.TabIndex = 2;
            this.buttonColor3.Tag = "3";
            this.buttonColor3.Text = "Цвет3";
            this.buttonColor3.UseVisualStyleBackColor = true;
            this.buttonColor3.Click += new System.EventHandler(this.buttonsColors_Click);
            // 
            // buttonColr2
            // 
            this.buttonColr2.Location = new System.Drawing.Point(78, 77);
            this.buttonColr2.Name = "buttonColr2";
            this.buttonColr2.Size = new System.Drawing.Size(50, 23);
            this.buttonColr2.TabIndex = 2;
            this.buttonColr2.Tag = "2";
            this.buttonColr2.Text = "Цвет2";
            this.buttonColr2.UseVisualStyleBackColor = true;
            this.buttonColr2.Click += new System.EventHandler(this.buttonsColors_Click);
            // 
            // buttonColor1
            // 
            this.buttonColor1.Location = new System.Drawing.Point(20, 77);
            this.buttonColor1.Name = "buttonColor1";
            this.buttonColor1.Size = new System.Drawing.Size(50, 23);
            this.buttonColor1.TabIndex = 2;
            this.buttonColor1.Tag = "1";
            this.buttonColor1.Text = "Цвет1";
            this.buttonColor1.UseVisualStyleBackColor = true;
            this.buttonColor1.Click += new System.EventHandler(this.buttonsColors_Click);
            // 
            // labelGraphItemColor3
            // 
            this.labelGraphItemColor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGraphItemColor3.Location = new System.Drawing.Point(135, 20);
            this.labelGraphItemColor3.Name = "labelGraphItemColor3";
            this.labelGraphItemColor3.Size = new System.Drawing.Size(50, 50);
            this.labelGraphItemColor3.TabIndex = 1;
            this.labelGraphItemColor3.Tag = "3";
            this.labelGraphItemColor3.Text = "третий цвет шаров";
            this.labelGraphItemColor3.Paint += new System.Windows.Forms.PaintEventHandler(this.labelBallColor_Paint);
            // 
            // labelGraphItemColor2
            // 
            this.labelGraphItemColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGraphItemColor2.Location = new System.Drawing.Point(78, 20);
            this.labelGraphItemColor2.Name = "labelGraphItemColor2";
            this.labelGraphItemColor2.Size = new System.Drawing.Size(50, 50);
            this.labelGraphItemColor2.TabIndex = 1;
            this.labelGraphItemColor2.Tag = "2";
            this.labelGraphItemColor2.Text = "второй  цвет шаров";
            this.labelGraphItemColor2.Paint += new System.Windows.Forms.PaintEventHandler(this.labelBallColor_Paint);
            // 
            // labelGraphItemColor1
            // 
            this.labelGraphItemColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGraphItemColor1.Location = new System.Drawing.Point(20, 20);
            this.labelGraphItemColor1.Name = "labelGraphItemColor1";
            this.labelGraphItemColor1.Size = new System.Drawing.Size(50, 50);
            this.labelGraphItemColor1.TabIndex = 1;
            this.labelGraphItemColor1.Tag = "1";
            this.labelGraphItemColor1.Text = "первый цвет шаров";
            this.labelGraphItemColor1.Paint += new System.Windows.Forms.PaintEventHandler(this.labelBallColor_Paint);
            // 
            // FormGameSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 266);
            this.Controls.Add(this.tabControlSetting);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGameSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки игры";
            this.Load += new System.EventHandler(this.FormGameSetting_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGameSetting_FormClosed);
            this.tabControlSetting.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TabControl tabControlSetting;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelGraphItemColor1;
        private System.Windows.Forms.Label labelGraphItemColor3;
        private System.Windows.Forms.Label labelGraphItemColor2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonColor3;
        private System.Windows.Forms.Button buttonColr2;
        private System.Windows.Forms.Button buttonColor1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonRhombus;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonEllipse;
    }
}
namespace Task_4
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.labelSetings = new System.Windows.Forms.Label();
            this.tabOption = new System.Windows.Forms.TabPage();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnStileText = new System.Windows.Forms.Button();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabMain);
            this.tabs.Controls.Add(this.tabOption);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(781, 453);
            this.tabs.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.Transparent;
            this.tabMain.Controls.Add(this.labelSetings);
            this.tabMain.Location = new System.Drawing.Point(4, 33);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(773, 416);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            // 
            // labelSetings
            // 
            this.labelSetings.AutoSize = true;
            this.labelSetings.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetings.Location = new System.Drawing.Point(320, 180);
            this.labelSetings.Name = "labelSetings";
            this.labelSetings.Size = new System.Drawing.Size(97, 35);
            this.labelSetings.TabIndex = 0;
            this.labelSetings.Text = "label1";
            // 
            // tabOption
            // 
            this.tabOption.Controls.Add(this.btnSaveSettings);
            this.tabOption.Controls.Add(this.btnStileText);
            this.tabOption.Controls.Add(this.btnTextColor);
            this.tabOption.Controls.Add(this.btnBackgroundColor);
            this.tabOption.Location = new System.Drawing.Point(4, 33);
            this.tabOption.Name = "tabOption";
            this.tabOption.Padding = new System.Windows.Forms.Padding(3);
            this.tabOption.Size = new System.Drawing.Size(773, 416);
            this.tabOption.TabIndex = 1;
            this.tabOption.Text = "Option";
            this.tabOption.UseVisualStyleBackColor = true;
            this.tabOption.Click += new System.EventHandler(this.TabOption_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.Location = new System.Drawing.Point(44, 312);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(685, 60);
            this.btnSaveSettings.TabIndex = 4;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnStileText
            // 
            this.btnStileText.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStileText.Location = new System.Drawing.Point(44, 223);
            this.btnStileText.Name = "btnStileText";
            this.btnStileText.Size = new System.Drawing.Size(685, 60);
            this.btnStileText.TabIndex = 3;
            this.btnStileText.Text = "Choose stile text";
            this.btnStileText.UseVisualStyleBackColor = true;
            // 
            // btnTextColor
            // 
            this.btnTextColor.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextColor.Location = new System.Drawing.Point(44, 134);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(685, 60);
            this.btnTextColor.TabIndex = 1;
            this.btnTextColor.Text = "Choose text color";
            this.btnTextColor.UseVisualStyleBackColor = true;
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackgroundColor.Location = new System.Drawing.Point(44, 45);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(685, 60);
            this.btnBackgroundColor.TabIndex = 0;
            this.btnBackgroundColor.Text = "Choose background color";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 453);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabOption;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnStileText;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.Label labelSetings;
    }
}


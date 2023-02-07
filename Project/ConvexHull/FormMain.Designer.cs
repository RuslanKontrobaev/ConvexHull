
namespace CourseProject
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox_Drawing = new System.Windows.Forms.PictureBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.button_Clean = new System.Windows.Forms.Button();
            this.button_BuildShell = new System.Windows.Forms.Button();
            this.label_CountPoints = new System.Windows.Forms.Label();
            this.textBox_Info = new System.Windows.Forms.TextBox();
            this.label_info = new System.Windows.Forms.Label();
            this.button_NextStep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Drawing)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Drawing
            // 
            this.pictureBox_Drawing.BackColor = System.Drawing.Color.White;
            this.pictureBox_Drawing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Drawing.Location = new System.Drawing.Point(3, 4);
            this.pictureBox_Drawing.Name = "pictureBox_Drawing";
            this.pictureBox_Drawing.Size = new System.Drawing.Size(747, 573);
            this.pictureBox_Drawing.TabIndex = 0;
            this.pictureBox_Drawing.TabStop = false;
            this.pictureBox_Drawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Drawing_MouseDown);
            this.pictureBox_Drawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Drawing_MouseMove);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(756, 531);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(19, 15);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(756, 555);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 15);
            this.labelY.TabIndex = 2;
            this.labelY.Text = "Y:";
            // 
            // button_Clean
            // 
            this.button_Clean.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Clean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Clean.Location = new System.Drawing.Point(759, 123);
            this.button_Clean.Name = "button_Clean";
            this.button_Clean.Size = new System.Drawing.Size(177, 53);
            this.button_Clean.TabIndex = 2;
            this.button_Clean.Text = "Очистить холст";
            this.button_Clean.UseVisualStyleBackColor = false;
            this.button_Clean.Click += new System.EventHandler(this.button_Clean_Click);
            // 
            // button_BuildShell
            // 
            this.button_BuildShell.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_BuildShell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BuildShell.Location = new System.Drawing.Point(759, 4);
            this.button_BuildShell.Name = "button_BuildShell";
            this.button_BuildShell.Size = new System.Drawing.Size(177, 53);
            this.button_BuildShell.TabIndex = 1;
            this.button_BuildShell.Text = "Построить выпуклую оболочку";
            this.button_BuildShell.UseVisualStyleBackColor = false;
            this.button_BuildShell.Click += new System.EventHandler(this.button_BuildShell_Click);
            // 
            // label_CountPoints
            // 
            this.label_CountPoints.AutoSize = true;
            this.label_CountPoints.Location = new System.Drawing.Point(756, 505);
            this.label_CountPoints.Name = "label_CountPoints";
            this.label_CountPoints.Size = new System.Drawing.Size(117, 15);
            this.label_CountPoints.TabIndex = 5;
            this.label_CountPoints.Text = "Количество точек: 0";
            // 
            // textBox_Info
            // 
            this.textBox_Info.Location = new System.Drawing.Point(759, 197);
            this.textBox_Info.Multiline = true;
            this.textBox_Info.Name = "textBox_Info";
            this.textBox_Info.Size = new System.Drawing.Size(177, 305);
            this.textBox_Info.TabIndex = 6;
            this.textBox_Info.Text = resources.GetString("textBox_Info.Text");
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(756, 179);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(81, 15);
            this.label_info.TabIndex = 7;
            this.label_info.Text = "Информация";
            // 
            // button_NextStep
            // 
            this.button_NextStep.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_NextStep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_NextStep.Location = new System.Drawing.Point(759, 63);
            this.button_NextStep.Name = "button_NextStep";
            this.button_NextStep.Size = new System.Drawing.Size(177, 53);
            this.button_NextStep.TabIndex = 8;
            this.button_NextStep.Text = "Начать алгоритм по шагам";
            this.button_NextStep.UseVisualStyleBackColor = false;
            this.button_NextStep.Click += new System.EventHandler(this.button_NextStep_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(943, 579);
            this.Controls.Add(this.button_NextStep);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.textBox_Info);
            this.Controls.Add(this.label_CountPoints);
            this.Controls.Add(this.button_BuildShell);
            this.Controls.Add(this.button_Clean);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.pictureBox_Drawing);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обучающее приложение по геометрическому алгоритму Грэхема";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Drawing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Drawing;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button button_Clean;
        private System.Windows.Forms.Button button_BuildShell;
        private System.Windows.Forms.Label label_CountPoints;
        private System.Windows.Forms.TextBox textBox_Info;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button button_NextStep;
    }
}


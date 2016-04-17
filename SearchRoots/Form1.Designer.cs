namespace SearchRoots
{
    partial class SearchRootsForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.newtonTextLabel = new System.Windows.Forms.Label();
            this.equationTextLabel = new System.Windows.Forms.Label();
            this.equationLabel = new System.Windows.Forms.Label();
            this.intervalFromText = new System.Windows.Forms.Label();
            this.intervalFrom = new System.Windows.Forms.TextBox();
            this.intervalToText = new System.Windows.Forms.Label();
            this.intervalTo = new System.Windows.Forms.TextBox();
            this.bisectionMethodText = new System.Windows.Forms.Label();
            this.newtonResult = new System.Windows.Forms.TextBox();
            this.bisectionResult = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // newtonTextLabel
            // 
            this.newtonTextLabel.AutoSize = true;
            this.newtonTextLabel.Location = new System.Drawing.Point(25, 72);
            this.newtonTextLabel.Name = "newtonTextLabel";
            this.newtonTextLabel.Size = new System.Drawing.Size(87, 13);
            this.newtonTextLabel.TabIndex = 1;
            this.newtonTextLabel.Text = "Метод Ньютона";
            // 
            // equationTextLabel
            // 
            this.equationTextLabel.AutoSize = true;
            this.equationTextLabel.Location = new System.Drawing.Point(25, 13);
            this.equationTextLabel.Name = "equationTextLabel";
            this.equationTextLabel.Size = new System.Drawing.Size(63, 13);
            this.equationTextLabel.TabIndex = 2;
            this.equationTextLabel.Text = "Уравнение";
            // 
            // equationLabel
            // 
            this.equationLabel.AutoSize = true;
            this.equationLabel.Location = new System.Drawing.Point(95, 12);
            this.equationLabel.Name = "equationLabel";
            this.equationLabel.Size = new System.Drawing.Size(68, 13);
            this.equationLabel.TabIndex = 3;
            this.equationLabel.Text = "cos(x)+3*x^2";
            // 
            // intervalFromText
            // 
            this.intervalFromText.AutoSize = true;
            this.intervalFromText.Location = new System.Drawing.Point(25, 37);
            this.intervalFromText.Name = "intervalFromText";
            this.intervalFromText.Size = new System.Drawing.Size(70, 13);
            this.intervalFromText.TabIndex = 4;
            this.intervalFromText.Text = "Интервал от";
            // 
            // intervalFrom
            // 
            this.intervalFrom.Location = new System.Drawing.Point(102, 30);
            this.intervalFrom.Name = "intervalFrom";
            this.intervalFrom.Size = new System.Drawing.Size(35, 20);
            this.intervalFrom.TabIndex = 5;
            // 
            // intervalToText
            // 
            this.intervalToText.AutoSize = true;
            this.intervalToText.Location = new System.Drawing.Point(143, 37);
            this.intervalToText.Name = "intervalToText";
            this.intervalToText.Size = new System.Drawing.Size(19, 13);
            this.intervalToText.TabIndex = 6;
            this.intervalToText.Text = "до";
            // 
            // intervalTo
            // 
            this.intervalTo.Location = new System.Drawing.Point(169, 29);
            this.intervalTo.Name = "intervalTo";
            this.intervalTo.Size = new System.Drawing.Size(45, 20);
            this.intervalTo.TabIndex = 7;
            // 
            // bisectionMethodText
            // 
            this.bisectionMethodText.AutoSize = true;
            this.bisectionMethodText.Location = new System.Drawing.Point(25, 99);
            this.bisectionMethodText.Name = "bisectionMethodText";
            this.bisectionMethodText.Size = new System.Drawing.Size(96, 13);
            this.bisectionMethodText.TabIndex = 8;
            this.bisectionMethodText.Text = "Метод дихотомии";
            // 
            // newtonResult
            // 
            this.newtonResult.Enabled = false;
            this.newtonResult.Location = new System.Drawing.Point(134, 65);
            this.newtonResult.Name = "newtonResult";
            this.newtonResult.Size = new System.Drawing.Size(68, 20);
            this.newtonResult.TabIndex = 9;
            // 
            // bisectionResult
            // 
            this.bisectionResult.Enabled = false;
            this.bisectionResult.Location = new System.Drawing.Point(134, 92);
            this.bisectionResult.Name = "bisectionResult";
            this.bisectionResult.Size = new System.Drawing.Size(68, 20);
            this.bisectionResult.TabIndex = 10;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(190, 137);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // SearchRootsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 170);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.bisectionResult);
            this.Controls.Add(this.newtonResult);
            this.Controls.Add(this.bisectionMethodText);
            this.Controls.Add(this.intervalTo);
            this.Controls.Add(this.intervalToText);
            this.Controls.Add(this.intervalFrom);
            this.Controls.Add(this.intervalFromText);
            this.Controls.Add(this.equationLabel);
            this.Controls.Add(this.equationTextLabel);
            this.Controls.Add(this.newtonTextLabel);
            this.Controls.Add(this.button1);
            this.Name = "SearchRootsForm";
            this.Text = "Нахождение корней численными методами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label newtonTextLabel;
        private System.Windows.Forms.Label equationTextLabel;
        private System.Windows.Forms.Label equationLabel;
        private System.Windows.Forms.Label intervalFromText;
        private System.Windows.Forms.TextBox intervalFrom;
        private System.Windows.Forms.Label intervalToText;
        private System.Windows.Forms.TextBox intervalTo;
        private System.Windows.Forms.Label bisectionMethodText;
        private System.Windows.Forms.TextBox newtonResult;
        private System.Windows.Forms.TextBox bisectionResult;
        private System.Windows.Forms.Button startButton;
    }
}


namespace dz_7
{
    partial class MainForm
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
            this.buttonPlusOne = new System.Windows.Forms.Button();
            this.buttonMulti2 = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.NumberBox = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.TextCounter = new System.Windows.Forms.Label();
            this.NumberText = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.Final = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlusOne
            // 
            this.buttonPlusOne.Location = new System.Drawing.Point(406, 7);
            this.buttonPlusOne.Name = "buttonPlusOne";
            this.buttonPlusOne.Size = new System.Drawing.Size(89, 38);
            this.buttonPlusOne.TabIndex = 0;
            this.buttonPlusOne.Text = "+1";
            this.buttonPlusOne.UseVisualStyleBackColor = true;
            this.buttonPlusOne.Click += new System.EventHandler(this.OnPlusOneClick);
            // 
            // buttonMulti2
            // 
            this.buttonMulti2.Location = new System.Drawing.Point(406, 57);
            this.buttonMulti2.Name = "buttonMulti2";
            this.buttonMulti2.Size = new System.Drawing.Size(89, 38);
            this.buttonMulti2.TabIndex = 0;
            this.buttonMulti2.Text = "*2";
            this.buttonMulti2.UseVisualStyleBackColor = true;
            this.buttonMulti2.Click += new System.EventHandler(this.OnMulti2Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(406, 107);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(89, 38);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.OnResetClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(406, 151);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 38);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberBox.Location = new System.Drawing.Point(12, 9);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(374, 62);
            this.NumberBox.TabIndex = 2;
            this.NumberBox.Text = "0";
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Location = new System.Drawing.Point(186, 174);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(18, 20);
            this.Counter.TabIndex = 3;
            this.Counter.Text = "0";
            // 
            // TextCounter
            // 
            this.TextCounter.AutoSize = true;
            this.TextCounter.Location = new System.Drawing.Point(12, 174);
            this.TextCounter.Name = "TextCounter";
            this.TextCounter.Size = new System.Drawing.Size(153, 20);
            this.TextCounter.TabIndex = 4;
            this.TextCounter.Text = "Количество ходов:";
            // 
            // NumberText
            // 
            this.NumberText.AutoSize = true;
            this.NumberText.Location = new System.Drawing.Point(12, 151);
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(61, 20);
            this.NumberText.TabIndex = 5;
            this.NumberText.Text = "Число:";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(186, 151);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(18, 20);
            this.Number.TabIndex = 6;
            this.Number.Text = "0";
            // 
            // Final
            // 
            this.Final.AutoSize = true;
            this.Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Final.Location = new System.Drawing.Point(20, 74);
            this.Final.Name = "Final";
            this.Final.Size = new System.Drawing.Size(0, 40);
            this.Final.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 201);
            this.Controls.Add(this.Final);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.NumberText);
            this.Controls.Add(this.TextCounter);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonMulti2);
            this.Controls.Add(this.buttonPlusOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Удвоитель";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosedClick);
            this.Load += new System.EventHandler(this.OnMainFormLoad);
            this.Click += new System.EventHandler(this.OnMulti2Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlusOne;
        private System.Windows.Forms.Button buttonMulti2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label NumberBox;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Label TextCounter;
        private System.Windows.Forms.Label NumberText;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Final;
    }
}


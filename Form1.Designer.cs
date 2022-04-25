
namespace LINQ
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
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.finalTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.wielkaLiteraCheckBox = new System.Windows.Forms.CheckBox();
            this.dlugoscCheckBox = new System.Windows.Forms.CheckBox();
            this.parzystaCheckBox = new System.Windows.Forms.CheckBox();
            this.sortowanieButton = new System.Windows.Forms.Button();
            this.sortowanieCheckBox = new System.Windows.Forms.CheckBox();
            this.maleLiteryButton = new System.Windows.Forms.Button();
            this.wielkieLiteryButton = new System.Windows.Forms.Button();
            this.UsuwanieButton = new System.Windows.Forms.Button();
            this.zawieraButton = new System.Windows.Forms.Button();
            this.spolgloskiButton = new System.Windows.Forms.Button();
            this.zawieranapisButton = new System.Windows.Forms.Button();
            this.napistextBox = new System.Windows.Forms.TextBox();
            this.sredniaButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.sumaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(13, 13);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(775, 80);
            this.contentTextBox.TabIndex = 0;
            // 
            // finalTextBox
            // 
            this.finalTextBox.Location = new System.Drawing.Point(12, 99);
            this.finalTextBox.Multiline = true;
            this.finalTextBox.Name = "finalTextBox";
            this.finalTextBox.Size = new System.Drawing.Size(775, 80);
            this.finalTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Filtrowanie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wielkaLiteraCheckBox
            // 
            this.wielkaLiteraCheckBox.AutoSize = true;
            this.wielkaLiteraCheckBox.Location = new System.Drawing.Point(123, 206);
            this.wielkaLiteraCheckBox.Name = "wielkaLiteraCheckBox";
            this.wielkaLiteraCheckBox.Size = new System.Drawing.Size(107, 21);
            this.wielkaLiteraCheckBox.TabIndex = 3;
            this.wielkaLiteraCheckBox.Text = "Wielka litera";
            this.wielkaLiteraCheckBox.UseVisualStyleBackColor = true;
            // 
            // dlugoscCheckBox
            // 
            this.dlugoscCheckBox.AutoSize = true;
            this.dlugoscCheckBox.Location = new System.Drawing.Point(233, 206);
            this.dlugoscCheckBox.Name = "dlugoscCheckBox";
            this.dlugoscCheckBox.Size = new System.Drawing.Size(173, 21);
            this.dlugoscCheckBox.TabIndex = 4;
            this.dlugoscCheckBox.Text = "Maksymalna dlugosc 5";
            this.dlugoscCheckBox.UseVisualStyleBackColor = true;
            // 
            // parzystaCheckBox
            // 
            this.parzystaCheckBox.AutoSize = true;
            this.parzystaCheckBox.Location = new System.Drawing.Point(412, 206);
            this.parzystaCheckBox.Name = "parzystaCheckBox";
            this.parzystaCheckBox.Size = new System.Drawing.Size(152, 21);
            this.parzystaCheckBox.TabIndex = 5;
            this.parzystaCheckBox.Text = "Prazysta liczba liter";
            this.parzystaCheckBox.UseVisualStyleBackColor = true;
            // 
            // sortowanieButton
            // 
            this.sortowanieButton.Location = new System.Drawing.Point(13, 273);
            this.sortowanieButton.Name = "sortowanieButton";
            this.sortowanieButton.Size = new System.Drawing.Size(104, 23);
            this.sortowanieButton.TabIndex = 6;
            this.sortowanieButton.Text = "Sortowanie";
            this.sortowanieButton.UseVisualStyleBackColor = true;
            this.sortowanieButton.Click += new System.EventHandler(this.sortowanieButton_Click);
            // 
            // sortowanieCheckBox
            // 
            this.sortowanieCheckBox.AutoSize = true;
            this.sortowanieCheckBox.Location = new System.Drawing.Point(123, 275);
            this.sortowanieCheckBox.Name = "sortowanieCheckBox";
            this.sortowanieCheckBox.Size = new System.Drawing.Size(86, 21);
            this.sortowanieCheckBox.TabIndex = 7;
            this.sortowanieCheckBox.Text = "Rosnaco";
            this.sortowanieCheckBox.UseVisualStyleBackColor = true;
            // 
            // maleLiteryButton
            // 
            this.maleLiteryButton.Location = new System.Drawing.Point(13, 323);
            this.maleLiteryButton.Name = "maleLiteryButton";
            this.maleLiteryButton.Size = new System.Drawing.Size(104, 23);
            this.maleLiteryButton.TabIndex = 8;
            this.maleLiteryButton.Text = "Male litery";
            this.maleLiteryButton.UseVisualStyleBackColor = true;
            this.maleLiteryButton.Click += new System.EventHandler(this.maleLiteryButton_Click);
            // 
            // wielkieLiteryButton
            // 
            this.wielkieLiteryButton.Location = new System.Drawing.Point(123, 323);
            this.wielkieLiteryButton.Name = "wielkieLiteryButton";
            this.wielkieLiteryButton.Size = new System.Drawing.Size(104, 23);
            this.wielkieLiteryButton.TabIndex = 9;
            this.wielkieLiteryButton.Text = "Wielkie litery";
            this.wielkieLiteryButton.UseVisualStyleBackColor = true;
            this.wielkieLiteryButton.Click += new System.EventHandler(this.wielkieLiteryButton_Click);
            // 
            // UsuwanieButton
            // 
            this.UsuwanieButton.Location = new System.Drawing.Point(233, 323);
            this.UsuwanieButton.Name = "UsuwanieButton";
            this.UsuwanieButton.Size = new System.Drawing.Size(104, 23);
            this.UsuwanieButton.TabIndex = 10;
            this.UsuwanieButton.Text = "Usuwanie";
            this.UsuwanieButton.UseVisualStyleBackColor = true;
            this.UsuwanieButton.Click += new System.EventHandler(this.UsuwanieButton_Click);
            // 
            // zawieraButton
            // 
            this.zawieraButton.Location = new System.Drawing.Point(12, 365);
            this.zawieraButton.Name = "zawieraButton";
            this.zawieraButton.Size = new System.Drawing.Size(197, 23);
            this.zawieraButton.TabIndex = 11;
            this.zawieraButton.Text = "Czy zawiera samogloski";
            this.zawieraButton.UseVisualStyleBackColor = true;
            this.zawieraButton.Click += new System.EventHandler(this.zawieraButton_Click);
            // 
            // spolgloskiButton
            // 
            this.spolgloskiButton.Location = new System.Drawing.Point(215, 365);
            this.spolgloskiButton.Name = "spolgloskiButton";
            this.spolgloskiButton.Size = new System.Drawing.Size(197, 23);
            this.spolgloskiButton.TabIndex = 12;
            this.spolgloskiButton.Text = "Czy dlugosc wieksza niz 5";
            this.spolgloskiButton.UseVisualStyleBackColor = true;
            this.spolgloskiButton.Click += new System.EventHandler(this.spolgloskiButton_Click);
            // 
            // zawieranapisButton
            // 
            this.zawieranapisButton.Location = new System.Drawing.Point(418, 365);
            this.zawieranapisButton.Name = "zawieranapisButton";
            this.zawieranapisButton.Size = new System.Drawing.Size(197, 23);
            this.zawieranapisButton.TabIndex = 13;
            this.zawieranapisButton.Text = "Zaczyna sie od";
            this.zawieranapisButton.UseVisualStyleBackColor = true;
            this.zawieranapisButton.Click += new System.EventHandler(this.zawieranapisButton_Click);
            // 
            // napistextBox
            // 
            this.napistextBox.Location = new System.Drawing.Point(622, 365);
            this.napistextBox.Name = "napistextBox";
            this.napistextBox.Size = new System.Drawing.Size(100, 22);
            this.napistextBox.TabIndex = 14;
            // 
            // sredniaButton
            // 
            this.sredniaButton.Location = new System.Drawing.Point(12, 404);
            this.sredniaButton.Name = "sredniaButton";
            this.sredniaButton.Size = new System.Drawing.Size(104, 23);
            this.sredniaButton.TabIndex = 15;
            this.sredniaButton.Text = "Srednia dlugosciej";
            this.sredniaButton.UseVisualStyleBackColor = true;
            this.sredniaButton.Click += new System.EventHandler(this.sredniaButton_Click);
            // 
            // minButton
            // 
            this.minButton.Location = new System.Drawing.Point(122, 404);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(104, 23);
            this.minButton.TabIndex = 16;
            this.minButton.Text = "MIN";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.Location = new System.Drawing.Point(233, 404);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(104, 23);
            this.maxButton.TabIndex = 17;
            this.maxButton.Text = "MAX";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // sumaButton
            // 
            this.sumaButton.Location = new System.Drawing.Point(343, 404);
            this.sumaButton.Name = "sumaButton";
            this.sumaButton.Size = new System.Drawing.Size(104, 23);
            this.sumaButton.TabIndex = 18;
            this.sumaButton.Text = "SUMA";
            this.sumaButton.UseVisualStyleBackColor = true;
            this.sumaButton.Click += new System.EventHandler(this.sumaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sumaButton);
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.sredniaButton);
            this.Controls.Add(this.napistextBox);
            this.Controls.Add(this.zawieranapisButton);
            this.Controls.Add(this.spolgloskiButton);
            this.Controls.Add(this.zawieraButton);
            this.Controls.Add(this.UsuwanieButton);
            this.Controls.Add(this.wielkieLiteryButton);
            this.Controls.Add(this.maleLiteryButton);
            this.Controls.Add(this.sortowanieCheckBox);
            this.Controls.Add(this.sortowanieButton);
            this.Controls.Add(this.parzystaCheckBox);
            this.Controls.Add(this.dlugoscCheckBox);
            this.Controls.Add(this.wielkaLiteraCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.finalTextBox);
            this.Controls.Add(this.contentTextBox);
            this.Name = "Form1";
            this.Text = "LINQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.TextBox finalTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox wielkaLiteraCheckBox;
        private System.Windows.Forms.CheckBox dlugoscCheckBox;
        private System.Windows.Forms.CheckBox parzystaCheckBox;
        private System.Windows.Forms.Button sortowanieButton;
        private System.Windows.Forms.CheckBox sortowanieCheckBox;
        private System.Windows.Forms.Button maleLiteryButton;
        private System.Windows.Forms.Button wielkieLiteryButton;
        private System.Windows.Forms.Button UsuwanieButton;
        private System.Windows.Forms.Button zawieraButton;
        private System.Windows.Forms.Button spolgloskiButton;
        private System.Windows.Forms.Button zawieranapisButton;
        private System.Windows.Forms.TextBox napistextBox;
        private System.Windows.Forms.Button sredniaButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Button sumaButton;
    }
}


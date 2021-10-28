
namespace JustClickXTime
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextKoordinateX = new System.Windows.Forms.TextBox();
            this.TextKoordinateY = new System.Windows.Forms.TextBox();
            this.TextWaitingTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextClickAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboStartStopKey = new System.Windows.Forms.ComboBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TimerClick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Just Click X Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coordinate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(110, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(200, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Y";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextKoordinateX
            // 
            this.TextKoordinateX.Location = new System.Drawing.Point(140, 40);
            this.TextKoordinateX.Margin = new System.Windows.Forms.Padding(0);
            this.TextKoordinateX.Name = "TextKoordinateX";
            this.TextKoordinateX.Size = new System.Drawing.Size(60, 29);
            this.TextKoordinateX.TabIndex = 5;
            this.TextKoordinateX.Text = "0";
            this.TextKoordinateX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextKoordinateX.TextChanged += new System.EventHandler(this.TextKoordinateX_TextChanged);
            // 
            // TextKoordinateY
            // 
            this.TextKoordinateY.Location = new System.Drawing.Point(230, 40);
            this.TextKoordinateY.Margin = new System.Windows.Forms.Padding(0);
            this.TextKoordinateY.Name = "TextKoordinateY";
            this.TextKoordinateY.Size = new System.Drawing.Size(60, 29);
            this.TextKoordinateY.TabIndex = 6;
            this.TextKoordinateY.Text = "0";
            this.TextKoordinateY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextKoordinateY.TextChanged += new System.EventHandler(this.TextKoordinateY_TextChanged);
            // 
            // TextWaitingTime
            // 
            this.TextWaitingTime.Location = new System.Drawing.Point(200, 75);
            this.TextWaitingTime.Margin = new System.Windows.Forms.Padding(0);
            this.TextWaitingTime.Name = "TextWaitingTime";
            this.TextWaitingTime.Size = new System.Drawing.Size(60, 29);
            this.TextWaitingTime.TabIndex = 8;
            this.TextWaitingTime.Text = "5000";
            this.TextWaitingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextWaitingTime.TextChanged += new System.EventHandler(this.TextWaitingTime_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Waiting Time (ms)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Click Amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextClickAmount
            // 
            this.TextClickAmount.Location = new System.Drawing.Point(200, 110);
            this.TextClickAmount.Margin = new System.Windows.Forms.Padding(0);
            this.TextClickAmount.Name = "TextClickAmount";
            this.TextClickAmount.Size = new System.Drawing.Size(60, 29);
            this.TextClickAmount.TabIndex = 10;
            this.TextClickAmount.Text = "1";
            this.TextClickAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextClickAmount.TextChanged += new System.EventHandler(this.TextClickAmount_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "Start-Stop Key";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboStartStopKey
            // 
            this.ComboStartStopKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboStartStopKey.FormattingEnabled = true;
            this.ComboStartStopKey.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10"});
            this.ComboStartStopKey.Location = new System.Drawing.Point(200, 145);
            this.ComboStartStopKey.Margin = new System.Windows.Forms.Padding(0);
            this.ComboStartStopKey.Name = "ComboStartStopKey";
            this.ComboStartStopKey.Size = new System.Drawing.Size(60, 32);
            this.ComboStartStopKey.TabIndex = 12;
            this.ComboStartStopKey.SelectedIndexChanged += new System.EventHandler(this.ComboStartStopKey_SelectedIndexChanged);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(100, 180);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(100, 39);
            this.ButtonStart.TabIndex = 13;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(10, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(280, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Learn Coordinate with Space";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerClick
            // 
            this.TimerClick.Tick += new System.EventHandler(this.TimerClick_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(299, 261);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ComboStartStopKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextClickAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextWaitingTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextKoordinateY);
            this.Controls.Add(this.TextKoordinateX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Just Click X Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextKoordinateX;
        private System.Windows.Forms.TextBox TextKoordinateY;
        private System.Windows.Forms.TextBox TextWaitingTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextClickAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboStartStopKey;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer TimerClick;
    }
}


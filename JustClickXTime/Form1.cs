using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace JustClickXTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            clickButton.hookedKeys.Add(Keys.Space);
            clickButton.hookedKeys.Add(Keys.F1);
            clickButton.KeyDown += new KeyEventHandler(KullanilanTuslar);

            TimerClick.Interval = 5000;
            ComboStartStopKey.Text = "F1";
        }
        #region Panel Degislikleri
        private int koordinat_X = 0;
        private int koordinat_Y = 0;
        private int waitingTime = 5000;
        private int clickAmount = 1;
        private int clickAmountNext = 0;
        private int clickKey = 0;
        private bool started = false;
        ClickButton clickButton = new ClickButton();
        Point clickPoint = new Point();
        private void TextKoordinateX_TextChanged(object sender, EventArgs e)
        {
            if (TextKoordinateX.Text != "")
            {
                if (int.TryParse(TextKoordinateX.Text, out int deger))
                {
                    koordinat_X = deger;
                }
                else
                {
                    MessageBox.Show("Lütfen rakam giriniz.");
                }
            }
        }
        private void TextKoordinateY_TextChanged(object sender, EventArgs e)
        {
            if (TextKoordinateY.Text != "")
            {
                if (int.TryParse(TextKoordinateY.Text, out int deger))
                {
                    koordinat_Y = deger;
                }
                else
                {
                    MessageBox.Show("Lütfen rakam giriniz.");
                }
            }
        }
        private void TextWaitingTime_TextChanged(object sender, EventArgs e)
        {
            if (TextWaitingTime.Text != "")
            {
                if (int.TryParse(TextWaitingTime.Text, out int deger))
                {
                    waitingTime = deger;
                }
                else
                {
                    MessageBox.Show("Lütfen rakam giriniz.");
                }
            }
        }
        private void TextClickAmount_TextChanged(object sender, EventArgs e)
        {
            if (TextClickAmount.Text != "")
            {
                if (int.TryParse(TextClickAmount.Text, out int deger))
                {
                    clickAmount = deger;
                }
                else
                {
                    MessageBox.Show("Lütfen rakam giriniz.");
                }
            }
        }
        private void ComboStartStopKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            clickKey = ComboStartStopKey.SelectedIndex;
            clickButton.hookedKeys.RemoveAt(1);
            clickButton.hookedKeys.Add((Keys)(clickKey + 112));
            //MessageBox.Show((clickKey + 112).ToString());
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            ClickStart();
        }
        private void TimerClick_Tick(object sender, EventArgs e)
        {
            clickAmountNext++;
            clickPoint.X = koordinat_X;
            clickPoint.Y = koordinat_Y;

            clickButton.LeftDownClick(clickPoint);
            Thread.Sleep(100);
            clickButton.LeftUpClick();
            if (clickAmountNext == clickAmount)
            {
                ClickStart();
            }
        }
        private void ClickStart()
        {
            TextKoordinateX.Enabled = started;
            TextKoordinateY.Enabled = started;
            TextWaitingTime.Enabled = started;
            TextClickAmount.Enabled = started;
            ComboStartStopKey.Enabled = started;

            started = !started;
            if (started)
            {
                clickAmountNext = 0;
                TimerClick.Start();
            }
            else
            {
                TimerClick.Stop();
            }
        }
        #endregion

        #region Dinlenecek Tuslar
        private void KullanilanTuslar(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.KeyCode == Keys.Space)
            {
                koordinat_X = Cursor.Position.X;
                koordinat_Y = Cursor.Position.Y;

                TextKoordinateX.Text = koordinat_X.ToString();
                TextKoordinateY.Text = koordinat_Y.ToString();
            }
            else if (keyEventArgs.KeyCode == (Keys)(clickKey + 112))
            {
                //TextKoordinateX.Text = (clickKey + 112).ToString();
                ClickStart();
            }
        }
        #endregion
    }
}
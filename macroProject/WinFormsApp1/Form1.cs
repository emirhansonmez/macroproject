using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
   
    public partial class Form1 : Form
    {
        private bool isQButtonActive = false;
        private bool isRButtonActive = false;
        private bool is2ButtonActive = false;
        private bool isTButtonActive = false;
        private bool isArrowPress = false;
        private int TButtonTimer = 0;
        int sayac = 0;
        private bool TCooldown = true;
        byte VK_Q = 0x51;// q tuşu
        byte VK_Caps = 0x14;//capslock
        byte VK_ESC = 0x1B;//ESC
        byte VK_Zero = 48;//0
        byte VK_R = 0x52;//R
        byte VK_Left = 0x25;// sol ok tuşu
        byte VK_Right = 0x27;// sağ ok tuşu
        byte VK_2 = 50;// 2 tuşu
        byte VK_Tab = 0x9;//tab
        byte VK_Enter = 0xD;//enter
        byte VK_Down = 0x28;//alt yön tus
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeColor(Button btn,bool isActive)
        {
            if (isActive)
            {
               btn.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                btn.BackColor = SystemColors.ControlDarkDark;
            }
        }
        private void StartProcess()
        {
            if (isQButtonActive)
            {
                Keyboard.KeyDown(VK_Left);
                Keyboard.KeyDown(VK_Right);
                if (!isArrowPress)
                    isArrowPress = true;
                Keyboard.KeyPress(VK_Q, 1);
                Keyboard.KeyPress(VK_2, 1);
            }
            if (isRButtonActive)
            {
                Keyboard.KeyPress(VK_R, 50);
            }
            if (is2ButtonActive)
            {
                Keyboard.KeyPress(VK_2, 50);
            }
            if (isTButtonActive)
            {
                if (TCooldown)
                {
                    Keyboard.KeyPress(VK_ESC, 25);
                    Keyboard.KeyPress(VK_Zero, 25);
                    Keyboard.KeyPress(VK_Zero, 25);
                    Keyboard.KeyPress(VK_Tab, 25);
                    Keyboard.KeyPress(VK_Down, 25);
                    Keyboard.KeyPress(VK_Enter, 25);
                    Keyboard.KeyPress(VK_Enter, 25);
                    TCooldown = false;
                }
               
            }
           
        }
        private void btn_Q_Click(object sender, EventArgs e)
        {
            isQButtonActive = !isQButtonActive;
            ChangeColor(btn_Q, isQButtonActive);
        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            isRButtonActive = !isRButtonActive;
            ChangeColor(btn_R, isRButtonActive);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            is2ButtonActive = !is2ButtonActive;
            ChangeColor(btn_2, is2ButtonActive);
        }

        private void btn_T_Click(object sender, EventArgs e)
        {
            isTButtonActive = !isTButtonActive;
            ChangeColor(btn_T, isTButtonActive);
        }

       


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += timer1_Tick;
            timer1.Start();
            StartProcess();
        }
        private bool checkCapslockStatus() {
            return  (((ushort)GetKeyState(0x14)) & 0xffff) != 0;
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac >= 32)
            {
                TButtonTimer++;
                sayac = 0;
            }
            if (TButtonTimer >= 30)
            {
                TCooldown = true;
                TButtonTimer = 0;
                sayac = 0;
            }
            if (checkCapslockStatus()) {
                ChangeColor(btn_start, true);
                StartProcess();
            }
            else
            {
                ChangeColor(btn_start, false);
                if (isArrowPress)
                {
                   Keyboard.KeyUp(VK_Left);
                   Keyboard.KeyUp(VK_Right);
                    isArrowPress = false;
                }
                sayac = 0;
                TButtonTimer = 0;
                TCooldown = true;
            }
        }
    }
}

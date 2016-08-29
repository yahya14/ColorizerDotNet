using System;
using System.Windows.Forms;
using System.Drawing;

namespace Colorizer
{
    public partial class MainForm : Form
    {

        public GeckoDotNet.TCPGecko Gecko;

        float coloraR, coloraG, coloraB, coloraA;
        float colorbR, colorbG, colorbB, colorbA;
        float colornR, colornG, colornB, colornA;

        uint colorstart = 0x12D28180;
        uint diff = 0x0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void SetAlphaColor(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Get colors and poke.
                coloraR = colorDialog1.Color.R;
                coloraG = colorDialog1.Color.G;
                coloraB = colorDialog1.Color.B;
                coloraA = colorDialog1.Color.A;
                try {
                    Gecko.poke(colorstart, float2Hex(coloraR / 256.0F));
                    Gecko.poke(colorstart + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(colorstart + 0x8, float2Hex(coloraB / 256.0F));
                }catch (GeckoDotNet.ETCPGeckoException exc)
                {
                    MessageBox.Show("Failed to write color data to memory.\n\n" + exc, "Operation failed.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            ColorALabel.Text = coloraR.ToString() + "," + coloraG.ToString() + "," + coloraB.ToString();
                AlphaShowBox.BackColor = colorDialog1.Color;
            }
        }

        private void SetBravoColor(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Get colors and poke.
                colorbR = colorDialog1.Color.R;
                colorbG = colorDialog1.Color.G;
                colorbB = colorDialog1.Color.B;
                colorbA = colorDialog1.Color.A;
                try {
                Gecko.poke(colorstart + 0x10, float2Hex(colorbR / 256.0F));
                Gecko.poke(colorstart + 0x14, float2Hex(colorbG / 256.0F));
                Gecko.poke(colorstart + 0x18, float2Hex(colorbB / 256.0F));
                }catch (GeckoDotNet.ETCPGeckoException exc)
                {
                    MessageBox.Show("Failed to write color data to memory.\n\n" + exc, "Operation failed.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                ColorBLabel.Text = colorbR.ToString() + "," + colorbG.ToString() + "," + colorbB.ToString();
                BravoShowBox.BackColor = colorDialog1.Color;
            }
        }

        private void SetNeutralColor(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Get colors and poke.
                colornR = colorDialog1.Color.R;
                colornG = colorDialog1.Color.G;
                colornB = colorDialog1.Color.B;
                colornA = colorDialog1.Color.A;
                try {
                    Gecko.poke(colorstart + 0x20, float2Hex(colornR / 256.0F));
                    Gecko.poke(colorstart + 0x24, float2Hex(colornG / 256.0F));
                    Gecko.poke(colorstart + 0x28, float2Hex(colornB / 256.0F));
                }catch(GeckoDotNet.ETCPGeckoException exc)
                {
                    MessageBox.Show("Failed to write color data to memory.\n\n" + exc, "Operation failed.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                ColorNLabel.Text = colornR.ToString() + "," + colornG.ToString() + "," + colornB.ToString();
                NeutralShowBox.BackColor = colorDialog1.Color;
            }
        }

        private void GetColors(object sender, EventArgs e)
        {
            try
            {
                coloraR = hexToFloat(Gecko.peek(colorstart)) * 256;
                coloraG = hexToFloat(Gecko.peek(colorstart + 0x4)) * 256;
                coloraB = hexToFloat(Gecko.peek(colorstart + 0x8)) * 256;

                colorbR = hexToFloat(Gecko.peek(colorstart + 0x10)) * 256;
                colorbG = hexToFloat(Gecko.peek(colorstart + 0x14)) * 256;
                colorbB = hexToFloat(Gecko.peek(colorstart + 0x18)) * 256;

                colornR = hexToFloat(Gecko.peek(colorstart + 0x20)) * 256;
                colornG = hexToFloat(Gecko.peek(colorstart + 0x24)) * 256;
                colornB = hexToFloat(Gecko.peek(colorstart + 0x28)) * 256;

                if (coloraR > 255) { coloraR = 255; } //Nintendo uses color values >255 sometimes, so we gotta do that
                if (coloraG > 255) { coloraG = 255; }
                if (coloraB > 255) { coloraB = 255; }

                if (colorbR > 255) { colorbR = 255; }
                if (colorbG > 255) { colorbG = 255; }
                if (colorbB > 255) { colorbB = 255; }

                if (colornR > 255) { colornR = 255; }
                if (colornG > 255) { colornG = 255; }
                if (colornB > 255) { colornB = 255; }

            }
            catch (GeckoDotNet.ETCPGeckoException exc)
            {
                MessageBox.Show("Failed to read color data from memory.\n\n" + exc, "Operation failed.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            ColorALabel.Text = Math.Round(coloraR).ToString() + ", " + Math.Round(coloraG).ToString() + ", " + Math.Round(coloraB).ToString()/* + "\n" + String.Format("{0:x2}", Gecko.peek(colorstart)) + ", " + String.Format("{0:x2}", Gecko.peek(colorstart + 0x4)) + "\n" + String.Format("{0:x2}", Gecko.peek(colorstart + 0x8))*/;
            ColorBLabel.Text = Math.Round(colorbR).ToString() + ", " + Math.Round(colorbG).ToString() + ", " + Math.Round(colorbB).ToString()/* + "\n" + String.Format("{0:x2}", Gecko.peek(colorstart + 0x10)) + ", " + String.Format("{0:x2}", Gecko.peek(colorstart + 0x14)) + "\n" + String.Format("{0:x2}", Gecko.peek(colorstart + 0x18))*/;
            ColorNLabel.Text = Math.Round(colornR).ToString() + ", " + Math.Round(colornG).ToString() + ", " + Math.Round(colornB).ToString()/* + "\n" + String.Format("{0:x2}", Gecko.peek(colorstart + 0x20)) + ", "+ String.Format("{0:x2}", Gecko.peek(colorstart + 0x24)) + "\n" + String.Format("{0:x2}", Gecko.peek(colorstart + 0x28))*/;

            Color colorA = Color.FromArgb(Convert.ToInt32(coloraR), Convert.ToInt32(coloraG), Convert.ToInt32(coloraB));
            Color colorB = Color.FromArgb(Convert.ToInt32(colorbR), Convert.ToInt32(colorbG), Convert.ToInt32(colorbB));
            Color colorN = Color.FromArgb(Convert.ToInt32(colornR), Convert.ToInt32(colornG), Convert.ToInt32(colornB));

            AlphaShowBox.BackColor = colorA;
            BravoShowBox.BackColor = colorB;
            NeutralShowBox.BackColor = colorN;
        }

        public static uint float2Hex(float fNum) //made by lean because he's cool
        {
            byte[] buffer = BitConverter.GetBytes(fNum);
            uint t1 = (uint)buffer[3];
            t1 <<= 8;
            t1 += buffer[2];
            t1 <<= 8;
            t1 += buffer[1];
            t1 <<= 8;
            t1 += buffer[0];
            return t1;
        }

        public static float hexToFloat(uint val)
        {
            return BitConverter.ToSingle(BitConverter.GetBytes(val), 0);
        }

        private void ConnectClick(object sender, EventArgs e)
        {
            Gecko = new GeckoDotNet.TCPGecko(IPBox.Text, 7331);
            try
            {
                Gecko.Connect();
            }
            catch (GeckoDotNet.ETCPGeckoException exc)
            {
                MessageBox.Show("Connection to the TCPGecko failed: \n\n" + exc.Message + "\n\nCheck your network connection/firewall.", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            Gecko.poke(0x10014cfc, 0x00000001);
            Gecko.poke(0x10613C2C, 0x5F476573);
            Gecko.poke(0x10613C3C, 0x756C6174);
            Gecko.poke(0x10613C4C, 0x68650000);
            Gecko.poke(0x10613C88, 0x63650000);

            SettingsGroupBox.Enabled = true;
            DisconnButton.Enabled = true;
            ConnectButton.Enabled = false;
        }

        private void DisconnClick(object sender, EventArgs e)
        {
            Gecko.Disconnect();
            SettingsGroupBox.Enabled = false;
            DisconnButton.Enabled = false;
            ConnectButton.Enabled = true;
        }
    }
}

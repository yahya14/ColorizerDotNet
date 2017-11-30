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

        uint diff;

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
                    //current colors
                    Gecko.poke(0x12D1F180 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12D1F180 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12D1F180 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Msn_Green_Default
                    Gecko.poke(0x12674F74 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12674F74 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12674F74 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Msn_Yellow
                    Gecko.poke(0x12675334 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12675334 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12675334 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Msn_Turquoise
                    Gecko.poke(0x126756F4 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x126756F4 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x126756F4 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Msn_DarkBlue
                    Gecko.poke(0x12675AB4 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12675AB4 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12675AB4 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Msn_Marigold
                    Gecko.poke(0x12675E74 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12675E74 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12675E74 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Msn_Soda
                    Gecko.poke(0x126765F4 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x126765F4 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x126765F4 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Msn_Lilac
                    Gecko.poke(0x126769B4 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x126769B4 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x126769B4 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Msn_LumiGreen
                    Gecko.poke(0x12676D74 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12676D74 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12676D74 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Msn_Orange
                    Gecko.poke(0x12677134 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12677134 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12677134 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Msn_NightLumiGreen
                    Gecko.poke(0x126774F4 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x126774F4 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x126774F4 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Msn_NightMarigold
                    Gecko.poke(0x126778B4 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x126778B4 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x126778B4 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Vss_Regular_OrangeBlue_Default
                    Gecko.poke(0x12683F84 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12683F84 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12683F84 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Vss_Regular_GreenPurple
                    Gecko.poke(0x12684344 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12684344 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12684344 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Vss_Regular_PinkBlue
                    Gecko.poke(0x12684704 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12684704 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12684704 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Vss_Regular_PinkOrange
                    Gecko.poke(0x12684AC4 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12684AC4 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12684AC4 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Vss_Regular_BlueLime
                    Gecko.poke(0x12684E84 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12684E84 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12684E84 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Vss_Regular_PinkGreen
                    Gecko.poke(0x12685244 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12685244 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12685244 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Vss_Regular_TurquoiseOrange
                    Gecko.poke(0x12685604 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12685604 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12685604 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Vss_Regular_LightBlueDarkBlue
                    Gecko.poke(0x126859C4 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x126859C4 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x126859C4 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Vss_Gachi_YellowLilac_Default
                    Gecko.poke(0x12692F94 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12692F94 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12692F94 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Vss_Gachi_GreenMazenta
                    Gecko.poke(0x12693354 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12693354 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12693354 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Vss_Gachi_GreenOrange
                    Gecko.poke(0x12693714 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12693714 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12693714 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Vss_Gachi_SodaPink
                    Gecko.poke(0x12693AD4 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12693AD4 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12693AD4 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Vss_Gachi_LightgreenBlue
                    Gecko.poke(0x12693E94 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12693E94 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12693E94 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Vss_Gachi_LumigreenPurple
                    Gecko.poke(0x12694254 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12694254 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12694254 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Vss_Gachi_DarkblueYellow
                    Gecko.poke(0x12694614 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x12694614 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x12694614 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Msn_Option_Yellow
                    Gecko.poke(0x126A1FA4 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x126A1FA4 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x126A1FA4 + diff + 0x8, float2Hex(coloraB / 256.0F));
                    //GfxSetting_Vss_Option_BlueOrange
                    Gecko.poke(0x126B0FB4 + diff, float2Hex(coloraR / 256.0F));
                    Gecko.poke(0x126B0FB4 + diff + 0x4, float2Hex(coloraG / 256.0F));
                    Gecko.poke(0x126B0FB4 + diff + 0x8, float2Hex(coloraB / 256.0F));
                }
                catch (GeckoDotNet.ETCPGeckoException exc)
                {
                    MessageBox.Show("Failed to write color data to memory.\n\n" + exc, "Operation failed.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                ColorALabel.Text = coloraR.ToString() + ", " + coloraG.ToString() + ", " + coloraB.ToString();
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
                    //current colors
                    Gecko.poke(0x12D1F180 + diff + 0x10, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12D1F180 + diff + 0x14, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12D1F180 + diff + 0x18, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Msn_Green_Default
                    Gecko.poke(0x12674F74 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12674F74 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12674F74 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Msn_Yellow
                    Gecko.poke(0x12675334 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12675334 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12675334 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Msn_Turquoise
                    Gecko.poke(0x126756F4 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x126756F4 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x126756F4 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Msn_DarkBlue
                    Gecko.poke(0x12675AB4 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12675AB4 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12675AB4 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Msn_Marigold
                    Gecko.poke(0x12675E74 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12675E74 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12675E74 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Msn_Soda
                    Gecko.poke(0x126765F4 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x126765F4 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x126765F4 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Msn_Lilac
                    Gecko.poke(0x126769B4 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x126769B4 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x126769B4 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Msn_LumiGreen
                    Gecko.poke(0x12676D74 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12676D74 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12676D74 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Msn_Orange
                    Gecko.poke(0x12677134 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12677134 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12677134 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Msn_NightLumiGreen
                    Gecko.poke(0x126774F4 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x126774F4 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x126774F4 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Msn_NightMarigold
                    Gecko.poke(0x126778B4 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x126778B4 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x126778B4 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Vss_Regular_OrangeBlue_Default
                    Gecko.poke(0x12683F84 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12683F84 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12683F84 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Vss_Regular_GreenPurple
                    Gecko.poke(0x12684344 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12684344 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12684344 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Vss_Regular_PinkBlue
                    Gecko.poke(0x12684704 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12684704 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12684704 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Vss_Regular_PinkOrange
                    Gecko.poke(0x12684AC4 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12684AC4 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12684AC4 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Vss_Regular_BlueLime
                    Gecko.poke(0x12684E84 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12684E84 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12684E84 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Vss_Regular_PinkGreen
                    Gecko.poke(0x12685244 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12685244 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12685244 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Vss_Regular_TurquoiseOrange
                    Gecko.poke(0x12685604 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12685604 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12685604 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Vss_Regular_LightBlueDarkBlue
                    Gecko.poke(0x126859C4 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x126859C4 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x126859C4 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Vss_Gachi_YellowLilac_Default
                    Gecko.poke(0x12692F94 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12692F94 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12692F94 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Vss_Gachi_GreenMazenta
                    Gecko.poke(0x12693354 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12693354 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12693354 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Vss_Gachi_GreenOrange
                    Gecko.poke(0x12693714 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12693714 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12693714 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Vss_Gachi_SodaPink
                    Gecko.poke(0x12693AD4 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12693AD4 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12693AD4 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Vss_Gachi_LightgreenBlue
                    Gecko.poke(0x12693E94 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12693E94 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12693E94 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Vss_Gachi_LumigreenPurple
                    Gecko.poke(0x12694254 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12694254 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12694254 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Vss_Gachi_DarkblueYellow
                    Gecko.poke(0x12694614 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x12694614 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x12694614 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Msn_Option_Yellow
                    Gecko.poke(0x126A1FA4 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x126A1FA4 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x126A1FA4 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                    //GfxSetting_Vss_Option_BlueOrange
                    Gecko.poke(0x126B0FB4 + diff + 0x64, float2Hex(colorbR / 256.0F));
                    Gecko.poke(0x126B0FB4 + diff + 0x68, float2Hex(colorbG / 256.0F));
                    Gecko.poke(0x126B0FB4 + diff + 0x6C, float2Hex(colorbB / 256.0F));
                }
                catch (GeckoDotNet.ETCPGeckoException exc)
                {
                    MessageBox.Show("Failed to write color data to memory.\n\n" + exc, "Operation failed.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                ColorBLabel.Text = colorbR.ToString() + ", " + colorbG.ToString() + ", " + colorbB.ToString();
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
                    //current colors
                    Gecko.poke(0x12D1F180 + diff + 0x20, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12D1F180 + diff + 0x24, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12D1F180 + diff + 0x28, float2Hex(colornB / 256.0F));
                    //GfxSetting_Msn_Green_Default
                    Gecko.poke(0x12674F74 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12674F74 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12674F74 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Msn_Yellow
                    Gecko.poke(0x12675334 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12675334 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12675334 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Msn_Turquoise
                    Gecko.poke(0x126756F4 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x126756F4 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x126756F4 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Msn_DarkBlue
                    Gecko.poke(0x12675AB4 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12675AB4 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12675AB4 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Msn_Marigold
                    Gecko.poke(0x12675E74 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12675E74 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12675E74 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Msn_Soda
                    Gecko.poke(0x126765F4 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x126765F4 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x126765F4 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Msn_Lilac
                    Gecko.poke(0x126769B4 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x126769B4 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x126769B4 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Msn_LumiGreen
                    Gecko.poke(0x12676D74 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12676D74 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12676D74 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Msn_Orange
                    Gecko.poke(0x12677134 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12677134 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12677134 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Msn_NightLumiGreen
                    Gecko.poke(0x126774F4 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x126774F4 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x126774F4 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Msn_NightMarigold
                    Gecko.poke(0x126778B4 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x126778B4 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x126778B4 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Vss_Regular_OrangeBlue_Default
                    Gecko.poke(0x12683F84 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12683F84 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12683F84 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Vss_Regular_GreenPurple
                    Gecko.poke(0x12684344 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12684344 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12684344 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Vss_Regular_PinkBlue
                    Gecko.poke(0x12684704 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12684704 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12684704 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Vss_Regular_PinkOrange
                    Gecko.poke(0x12684AC4 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12684AC4 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12684AC4 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Vss_Regular_BlueLime
                    Gecko.poke(0x12684E84 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12684E84 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12684E84 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Vss_Regular_PinkGreen
                    Gecko.poke(0x12685244 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12685244 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12685244 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Vss_Regular_TurquoiseOrange
                    Gecko.poke(0x12685604 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12685604 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12685604 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Vss_Regular_LightBlueDarkBlue
                    Gecko.poke(0x126859C4 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x126859C4 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x126859C4 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Vss_Gachi_YellowLilac_Default
                    Gecko.poke(0x12692F94 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12692F94 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12692F94 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Vss_Gachi_GreenMazenta
                    Gecko.poke(0x12693354 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12693354 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12693354 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Vss_Gachi_GreenOrange
                    Gecko.poke(0x12693714 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12693714 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12693714 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Vss_Gachi_SodaPink
                    Gecko.poke(0x12693AD4 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12693AD4 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12693AD4 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Vss_Gachi_LightgreenBlue
                    Gecko.poke(0x12693E94 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12693E94 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12693E94 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Vss_Gachi_LumigreenPurple
                    Gecko.poke(0x12694254 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12694254 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12694254 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Vss_Gachi_DarkblueYellow
                    Gecko.poke(0x12694614 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x12694614 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x12694614 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Msn_Option_Yellow
                    Gecko.poke(0x126A1FA4 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x126A1FA4 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x126A1FA4 + diff + 0xD0, float2Hex(colornB / 256.0F));
                    //GfxSetting_Vss_Option_BlueOrange
                    Gecko.poke(0x126B0FB4 + diff + 0xC8, float2Hex(colornR / 256.0F));
                    Gecko.poke(0x126B0FB4 + diff + 0xCC, float2Hex(colornG / 256.0F));
                    Gecko.poke(0x126B0FB4 + diff + 0xD0, float2Hex(colornB / 256.0F));
                }
                catch(GeckoDotNet.ETCPGeckoException exc)
                {
                    MessageBox.Show("Failed to write color data to memory.\n\n" + exc, "Operation failed.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                ColorNLabel.Text = colornR.ToString() + ", " + colornG.ToString() + ", " + colornB.ToString();
                NeutralShowBox.BackColor = colorDialog1.Color;
            }
        }

        private void GetColors(object sender, EventArgs e)
        {
            try
            {
                coloraR = hexToFloat(Gecko.peek(0x12D1F180 + diff)) * 256;
                coloraG = hexToFloat(Gecko.peek(0x12D1F180 + diff + 0x4)) * 256;
                coloraB = hexToFloat(Gecko.peek(0x12D1F180 + diff + 0x8)) * 256;

                colorbR = hexToFloat(Gecko.peek(0x12D1F180 + diff + 0x10)) * 256;
                colorbG = hexToFloat(Gecko.peek(0x12D1F180 + diff + 0x14)) * 256;
                colorbB = hexToFloat(Gecko.peek(0x12D1F180 + diff + 0x18)) * 256;

                colornR = hexToFloat(Gecko.peek(0x12D1F180 + diff + 0x20)) * 256;
                colornG = hexToFloat(Gecko.peek(0x12D1F180 + diff + 0x24)) * 256;
                colornB = hexToFloat(Gecko.peek(0x12D1F180 + diff + 0x28)) * 256;

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

            ColorALabel.Text = Math.Round(coloraR).ToString() + ", " + Math.Round(coloraG).ToString() + ", " + Math.Round(coloraB).ToString()/* + "\n" + String.Format("{0:x2}", Gecko.peek(0x12D1F180 + diff)) + ", " + String.Format("{0:x2}", Gecko.peek(0x12D1F180 + diff + 0x4)) + "\n" + String.Format("{0:x2}", Gecko.peek(0x12D1F180 + diff + 0x8))*/;
            ColorBLabel.Text = Math.Round(colorbR).ToString() + ", " + Math.Round(colorbG).ToString() + ", " + Math.Round(colorbB).ToString()/* + "\n" + String.Format("{0:x2}", Gecko.peek(0x12D1F180 + diff + 0x10)) + ", " + String.Format("{0:x2}", Gecko.peek(0x12D1F180 + diff + 0x14)) + "\n" + String.Format("{0:x2}", Gecko.peek(0x12D1F180 + diff + 0x18))*/;
            ColorNLabel.Text = Math.Round(colornR).ToString() + ", " + Math.Round(colornG).ToString() + ", " + Math.Round(colornB).ToString()/* + "\n" + String.Format("{0:x2}", Gecko.peek(0x12D1F180 + diff + 0x20)) + ", "+ String.Format("{0:x2}", Gecko.peek(0x12D1F180 + diff + 0x24)) + "\n" + String.Format("{0:x2}", Gecko.peek(0x12D1F180 + diff + 0x28))*/;

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
                MessageBox.Show("Connection to the TCPGecko failed: \n\n" + exc + "\n\nCheck your network connection/firewall.", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            //offset difference checker
            uint JRAddr = Gecko.peek(0x106E975C) + 0x92D8;
            if (Gecko.peek(JRAddr) == 0x000003F2)
            {
                diff = JRAddr - 0x12CDADA0;
            }
            else
            {
                MessageBox.Show("Could not find the Splattershot Jr. in memory. Try using TCPGecko from loadiine.ovh. If that does not work, the tool might need to be updated for a newer version of Splatoon.");

                Gecko.Disconnect();
                return;
            }

            //check for "_Fes" indicating the offsets used by the online disabler haven't moved
            if (Gecko.peek(0x1061484C) == 0x5F466573)
            {
                //disables online because Nintendo detects color changing
                Gecko.poke(0x1061484C, 0x5F476573);
                Gecko.poke(0x10614854, 0x756C6174);
                Gecko.poke(0x10614868, 0x68650000);
                Gecko.poke(0x106148A0, 0x63650000);
                Gecko.poke(0x10614890, 0x73656372);
                Gecko.poke(0x10614884, 0x65742074);
                Gecko.poke(0x12AEF24C + diff, 0x65787421);
                Gecko.poke(0x12B4D45C + diff, 0xDEADCAFE);
            }
            else
            {
                MessageBox.Show("This ColorizerDotNet version isn't compatible with your Splatoon version. Check to see if there is a new ColorizerDotNet version available.");

                Gecko.Disconnect();
                return;
            }

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

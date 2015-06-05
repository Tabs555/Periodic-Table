using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Periodic_GUI
{
    public partial class Form1 : Form
    {
        static double dang;
        static int count;
        static double molar;
        static int count2 = 1;

        static double MM1;
        static double MM2;
        static double MM3;
        static double MM4;
        static double MM5;
        static double MM6;

        public Form1()
        {
            InitializeComponent();


            this.mmReactant1.SelectionFont =
            this.mmReactant2.SelectionFont =
            this.mmReactant3.SelectionFont =
            this.mmProduct1.SelectionFont =
            this.mmProduct2.SelectionFont =
            this.mmProduct3.SelectionFont = new Font("Verdana", 13);
            this.mmEquation1.SelectionFont =
            this.mmEquation2.SelectionFont =
            this.mmEquation3.SelectionFont =
            this.mmEquation4.SelectionFont =
            this.mmEquation5.SelectionFont =
            this.mmEquation6.SelectionFont = new Font("Verdana", 15);

            this.mmProduct1.SelectedText = "0g";
            this.mmProduct2.SelectedText = "0g";
            this.mmProduct3.SelectedText = "0g";
            this.mmReactant1.SelectedText = "0g";
            this.mmReactant2.SelectedText = "0g";
            this.mmReactant3.SelectedText = "0g";
        }

        public void setDang(double a)
        {
            dang = a;
            this.addMass();

        }

        private void addMass()
        {
            molar += dang;
            Console.WriteLine(molar);

        }

        //<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
        //================================================================================================================================
        //--------------------------------------------------------------------------------------------------------------------------------
        //                                      Molar Mass Set/Remove/get Method
        //--------------------------------------------------------------------------------------------------------------------------------
        //================================================================================================================================
        //<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>


        //Gets molar mass
        public double getMM1()
        {
            return MM1;
        }
        public double getMM2()
        {
            return MM2;
        }
        public double getMM3()
        {
            return MM3;
        }
        public double getMM4()
        {
            return MM4;
        }
        public double getMM5()
        {
            return MM5;
        }
        public double getMM6()
        {
            return MM6;
        }
        
        //Sets molar masses
        public void setMM1(double mass)
        {
            MM1 += mass;
        }
        public void setMM2(double mass)
        {
            MM2 += mass;
        }
        public void setMM3(double mass)
        {
            MM3 += mass;
        }
        public void setMM4(double mass)
        {
            MM4 += mass;
        }
        public void setMM5(double mass)
        {
            MM5 += mass;
        }
        public void setMM6(double mass)
        {
            MM6 += mass;
        }

        //removes molar mass
        public void delMM1()
        {
            MM1 = 0;
        }
        public void delMM2()
        {
            MM2 = 0;
        }
        public void delMM3()
        {
            MM3 = 0;
        }
        public void delMM4()
        {
            MM4 = 0;
        }
        public void delMM5()
        {
            MM5 = 0;
        }
        public void delMM6()
        {
            MM6 = 0;
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
        //================================================================================================================================
        //--------------------------------------------------------------------------------------------------------------------------------
        //                                      Element Atomic Number
        //--------------------------------------------------------------------------------------------------------------------------------
        //================================================================================================================================
        //<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>


        const int HydrogenN = 1;
        const int NiobiumN = 41;
        const int ThalliumN = 81;
        const int HeliumN = 2;
        const int LeadN = 82;
        const int molybdenumN = 42;
        const int LithiumN = 3;
        const int TechnetiumN = 43;
        const int BismuthN = 83;
        const int BerylliumN = 4;
        const int RutheniumN = 44;
        const int PoloniumN = 84;
        const int BoronN = 5;
        const int RhodiumN = 45;
        const int AstatineN = 85;
        const int CarbonN = 6;
        const int PalladiumN = 46;
        const int RadonN = 86;
        const int NitrogenN = 7;
        const int SilverN = 47;
        const int FranciumN = 87;
        const int OxygenN = 8;
        const int CadmiumN = 48;
        const int RadiumN = 88;
        const int FluorineN = 9;
        const int IndiumN = 49;
        const int ActiniumN = 89;
        const int NeonN = 10;
        const int TinN = 50;
        const int ThoriumN = 90;
        const int SodiumN = 11;
        const int AntimonyN = 51;
        const int ProtactiniumN = 91;
        const int MagnesiumN = 12;
        const int TelluriumN = 52;
        const int UraniumN = 92;
        const int AluminumN = 13;
        const int IodineN = 53;
        const int NeptuniumN = 93;
        const int SiliconN = 14;
        const int XenonN = 54;
        const int PlutoniumN = 94;
        const int PhosphorusN = 15;
        const int CesiumN = 55;
        const int AmericiumN = 95;
        const int SulfurN = 16;
        const int BariumN = 56;
        const int CuriumN = 96;
        const int ChlorineN = 17;
        const int LanthanumN = 57;
        const int BerkeliumN = 97;
        const int ArgonN = 18;
        const int CeriumN = 58;
        const int CaliforniumN = 98;
        const int PotassiumN = 19;
        const int PraseodymiumN = 59;
        const int EinsteiniumN = 99;
        const int CalciumN = 20;
        const int NeodymiumN = 60;
        const int FermiumN = 100;
        const int ScandiumN = 21;
        const int PromethiumN = 61;
        const int MendeleviumN = 101;
        const int TitaniumN = 22;
        const int SamariumN = 62;
        const int NobeliumN = 102;
        const int VanadiumN = 23;
        const int EuropiumN = 63;
        const int LawrenciumN = 103;
        const int ChromiumN = 24;
        const int GadoliniumN = 64;
        const int RutherfordiumN = 104;
        const int ManganeseN = 25;
        const int TerbiumN = 65;
        const int DubniumN = 105;
        const int IronN = 26;
        const int DysprosiumN = 66;
        const int SeaborgiumN = 106;
        const int CobaltN = 27;
        const int HolmiumN = 67;
        const int BohriumN = 107;
        const int NickelN = 28;
        const int ErbiumN = 68;
        const int HassiumN = 108;
        const int CoppeNr = 29;
        const int ThuliumN = 69;
        const int MeitneriumN = 109;
        const int ZincN = 30;
        const int YtterbiumN = 70;
        const int DarmstadtiumN = 110;
        const int GalliumN = 31;
        const int LutetiumN = 71;
        const int RoentgeniumN = 111;
        const int GermaniumN = 32;
        const int HafniumN = 72;
        const int CoperniciumN = 112;
        const int ArsenicN = 33;
        const int TantalumN = 73;
        const int UnuntriumN = 113;
        const int SeleniumN = 34;
        const int TungstenN = 74;
        const int FlervoviumN = 114;
        const int BromineN = 35;
        const int RheniumN = 75;
        const int UnunpentiumN = 115;
        const int KryptonN = 36;
        const int OsmiumN = 76;
        const int LivermoriumN = 116;
        const int RubidiumN = 37;
        const int IridiumN = 77;
        const int UnunseptiumN = 117;
        const int StrontiumN = 38;
        const int PlatinumN = 78;
        const int UnunoctiumN = 118;
        const int YttriumN = 39;
        const int GoldN = 79;
        const int ZirconiumN = 40;
        const int MercuryN = 80;



        //<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
        //================================================================================================================================
        //--------------------------------------------------------------------------------------------------------------------------------
        //                                      Element Molar Mass
        //--------------------------------------------------------------------------------------------------------------------------------
        //================================================================================================================================
        //<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

        const double HydrogenMM = 1.008;
        const double HeliumMM = 4.003;
        const double LithiumMM = 6.941;
        const double BerylliumMM = 9.012;
        const double BoronMM = 10.811;
        const double CarbonMM = 12.011;
        const double NitrogenMM = 14.007;
        const double OxygenMM = 15.999;
        const double FluorineMM = 18.998;
        const double NeonMM = 20.18;
        const double SodiumMM = 22.99;
        const double MagnesiumMM = 24.305;
        const double AluminiumMM = 26.982;
        const double SiliconMM = 28.086;
        const double PhosphorusMM = 30.974;
        const double SulfurMM = 32.066;
        const double ChlorineMM = 35.453;
        const double ArgonMM = 39.948;
        const double PotassiumMM = 39.098;
        const double CalciumMM = 40.078;
        const double ScandiumMM = 44.956;
        const double TitaniumMM = 47.88;
        const double VanadiumMM = 51.942;
        const double ChromiumMM = 51.996;
        const double ManganeseMM = 54.938;
        const double IronMM = 55.933;
        const double CobaltMM = 58.933;
        const double NickelMM = 58.693;
        const double CopperMM = 63.546;
        const double ZincMM = 65.39;
        const double GalliumMM = 69.732;
        const double GermaniumMM = 72.61;
        const double ArsenicMM = 74.922;
        const double SeleniumMM = 78.09;
        const double BromineMM = 79.904;
        const double KryptonMM = 84.8;
        const double RubidiumMM = 84.468;
        const double StrontiumMM = 87.62;
        const double YttriumMM = 88.906;
        const double ZirconiumMM = 91.224;
        const double NiobiumMM = 92.906;
        const double MolybdenumMM = 95.94;
        const double TechnetiumMM = 98.907;
        const double RutheniumMM = 101.07;
        const double RhodiumMM = 102.906;
        const double PalladiumMM = 106.42;
        const double SilverMM = 107.868;
        const double CadmiumMM = 112.411;
        const double IndiumMM = 114.818;
        const double TinMM = 118.71;
        const double AntimonyMM = 121.76;
        const double TelluriumMM = 127.6;
        const double IodineMM = 126.904;
        const double XenonMM = 131.29;
        const double CesiumMM = 132.905;
        const double BariumMM = 137.327;
        const double LanthanumMM = 138.906;
        const double CeriumMM = 140.115;
        const double PraseodymiumMM = 140.908;
        const double NeodymiumMM = 144.24;
        const double PromethiumMM = 144.913;
        const double SamariumMM = 150.36;
        const double EuropiumMM = 151.966;
        const double GadoliniumMM = 157.25;
        const double TerbiumMM = 158.925;
        const double DysprosiumMM = 162.5;
        const double HolmiumMM = 164.93;
        const double ErbiumMM = 167.26;
        const double ThuliumMM = 168.934;
        const double YtterbiumMM = 173.04;
        const double LutetiumMM = 174.967;
        const double HafniumMM = 178.49;
        const double TantalumMM = 180.948;
        const double TungstenMM = 183.85;
        const double RheniumMM = 186.207;
        const double OsmiumMM = 190.23;
        const double IridiumMM = 192.22;
        const double PlatinumMM = 195.08;
        const double GoldMM = 196.967;
        const double MercuryMM = 200.59;
        const double ThalliumMM = 204.383;
        const double LeadMM = 207.2;
        const double BismuthMM = 208.98;
        const double PoloniumMM = 208.982;
        const double AstatineMM = 209.987;
        const double RadonMM = 222.018;
        const double FranciumMM = 223.02;
        const double RadiumMM = 226.025;
        const double ActiniumMM = 227.028;
        const double ThoriumMM = 232.038;
        const double ProtactiniumMM = 231.036;
        const double UraniumMM = 238.029;
        const double NeptuniumMM = 237.048;
        const double PlutoniumMM = 244;
        const double AmericiumMM = 243;
        const double CuriumMM = 247;
        const double BerkeliumMM = 247;
        const double CaliforniumMM = 251;
        const double EinsteiniumMM = 252;
        const double FermiumMM = 257;
        const double MendeleviumMM = 258;
        const double NobeliumMM = 259;
        const double LawrenciumMM = 262;
        const double RutherfordiumMM = 261;
        const double DubniumMM = 262;
        const double SeaborgiumMM = 266;
        const double BohriumMM = 264;
        const double HassiumMM = 277;
        const double MeitneriumMM = 268;
        const double DarmstadtiumMM = 281;
        const double RoentgeniumMM = 280;
        const double CoperniciumMM = 285;
        const double UnuntriumMM = 284;
        const double FleroviumMM = 289;
        const double UnunpentiumMM = 288;
        const double LivermoriumMM = 293;
        const double UnunseptiumMM = 294;
        const double UnunoctiumMM = 294;

        static Boolean Magclick = false;
        static Boolean Hydclick = false;
        static Boolean Chlorclick = false;

        static int hyd;
        static int mag;
        static int chlor;


        //<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
        //================================================================================================================================
        //--------------------------------------------------------------------------------------------------------------------------------
        //                                      Element Buttons
        //--------------------------------------------------------------------------------------------------------------------------------
        //================================================================================================================================
        //<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>


        private void hydrogen_Click(object sender, EventArgs e)
        {
            buttonSelect test;
          
            if (Hydclick == true)
            {
                 test = new buttonSelect(HydrogenMM, 1);
                
            }
            else
            {
                hyd = count2;
                test = new buttonSelect(HydrogenMM, 1);
                //count2+=2;
                Hydclick = true;
                Console.WriteLine(count2);
            }
           
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + hydrogen.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText += hydrogen.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }
        }

        private void cesium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CesiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + cesium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + cesium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }


        }

        private void nobelium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(NobeliumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + nobelium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + nobelium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void lutetium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(LutetiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lutetium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lutetium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void ytterbium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(YtterbiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ytterbium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ytterbium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void mendelevium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(MendeleviumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + mendelevium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + mendelevium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void fermium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(FermiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + fermium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + fermium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void thulium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ThuliumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + thulium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + thulium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void erbium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ErbiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + erbium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + erbium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void einsteinium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(EinsteiniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + einsteinium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + einsteinium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void californium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CaliforniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + californium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + californium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void holmium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(HolmiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + holmium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + holmium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void dysprosium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(DysprosiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + dysprosium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + dysprosium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void berkelium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(BerkeliumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + berkelium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + berkelium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void curium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CuriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + curium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + curium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void terbium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(TerbiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + terbium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + terbium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void gadolinium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(GadoliniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + gadolinium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + gadolinium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void americium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(AmericiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + americium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + americium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void plutonium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(PlutoniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + plutonium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + plutonium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void europium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(EuropiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + europium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + europium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void samarium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(SamariumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + samarium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + samarium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void neptunium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(NeptuniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + neptunium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + neptunium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void uranium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(UraniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + uranium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + uranium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void promethium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(PromethiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + promethium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + promethium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void neondymium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(NeodymiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + neodymium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + neodymium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void protactinium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ProtactiniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + protactinium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + protactinium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void thorium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ThoriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + thorium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + thorium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void prasedymium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(PraseodymiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + praseodymium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + praseodymium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void cerium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CeriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + cerium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + cerium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void actinium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ActiniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + actinium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + actinium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void lanthanum_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(LanthanumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lanthanum.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lanthanum.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void helium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(HeliumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + helium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + helium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void ununoctium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(UnunoctiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ununoctium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ununoctium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void ununseptium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(UnunseptiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ununseptium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ununseptium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void radon_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(RadonMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + radon.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + radon.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void astatine_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(AstatineMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + astatine.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + astatine.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void xenon_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(XenonMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + xenon.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + xenon.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void iodine_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(IodineMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + iodine.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + iodine.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void livermorium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(LivermoriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + livermorium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + livermorium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void ununpentium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(UnunpentiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ununpentium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ununpentium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void polonium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(PoloniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + polonium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + polonium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void bismuth_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(BismuthMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Bismuth.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Bismuth.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void tellurium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(TelluriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + tellurium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + tellurium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void antimony_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(AntimonyMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + antimony.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + antimony.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void flerovium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(FleroviumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Flerovium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Flerovium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void ununtrium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(UnuntriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ununtrium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ununtrium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void lead_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(LeadMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lead.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lead.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }
        }

        private void thallium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ThalliumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + thallium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + thallium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void tin_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(TinMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + tin.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + tin.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void indium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(IndiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + indium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + indium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void krypton_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(KryptonMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + krypton.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + krypton.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void bromine_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(BromineMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + bromine.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + bromine.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void argon_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ArgonMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + argon.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + argon.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void chlorine_Click(object sender, EventArgs e)
        {
            buttonSelect test;

            if (Chlorclick == true)
            {
                test = new buttonSelect(ChlorineMM, 1);

            }
            else
            {
                chlor = count2;
                test = new buttonSelect(ChlorineMM, 1);
                //count2+=2;
                Chlorclick = true;
                Console.WriteLine(count2);
            }
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + chlorine.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + chlorine.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void neon_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(NeonMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + neon.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + neon.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void flourine_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(FluorineMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + flourine.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + flourine.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void selenium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(SeleniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + selenium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + selenium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void arsenic_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ArsenicMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + arsenic.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + arsenic.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void sulfur_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(SulfurMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + sulfur.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + sulfur.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void phosporous_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(PhosphorusMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + phosporous.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + phosporous.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void oxygen_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(OxygenMM,1);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + oxygen.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + oxygen.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void nitrogen_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(NitrogenMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + nitrogen.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + nitrogen.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void germanium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(GermaniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + germanium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + germanium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void gallium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(GalliumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + gallium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + gallium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void silicon_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(SiliconMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + silicon.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + silicon.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void aluminum_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(AluminiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + aluminum.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + aluminum.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void carbon_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CarbonMM,1);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + carbon.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + carbon.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void boron_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(BoronMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + boron.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + boron.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void copernicium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CoperniciumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + copernicium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + copernicium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void roentgenium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(RoentgeniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + roentgenium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + roentgenium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void mercury_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(MercuryMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + mercury.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + mercury.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void gold_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(GoldMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + gold.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + gold.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void cadium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CadmiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + cadium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + cadium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void silver_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(SilverMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + silver.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + silver.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void zinc_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ZincMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + zinc.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + zinc.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void copper_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CopperMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + copper.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + copper.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void darmstadtium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(DarmstadtiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + darmstadtium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + darmstadtium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void meitnerium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(MeitneriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + meitnerium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + meitnerium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void platinum_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(PlatinumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + platinum.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + platinum.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void iridium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(IridiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + iridium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + iridium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void palladium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(PalladiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + palladium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + palladium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void Rhodium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(RhodiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Rhodium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Rhodium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void nickel_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(NickelMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + nickel.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + nickel.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void cobalt_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CobaltMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + cobalt.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + cobalt.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void hassium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(HassiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + hassium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + hassium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void bohrium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(BohriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + bohrium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + bohrium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void osmium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(OsmiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + osmium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + osmium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void rhenium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(RheniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + rhenium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + rhenium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void ruthenium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(RutheniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Ruthenium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Ruthenium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void technetium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(TechnetiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + technetium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + technetium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void iron_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(IronMM,1);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + iron.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + iron.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void manganese_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ManganeseMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + manganese.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + manganese.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void seaborgium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(SeaborgiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + seaborgium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + seaborgium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void dubnium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(DubniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + dubnium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + dubnium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void tungsten_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(TungstenMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + tungsten.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + tungsten.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void tantalum_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(TantalumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + tantlum.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + tantlum.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void molybdenum_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(MolybdenumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Molybdenum.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Molybdenum.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void niobium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(NiobiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Niobium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Niobium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void chromium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ChromiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + chromium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + chromium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void vanadium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(VanadiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + vanadium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + vanadium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void rutherfordium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(RutherfordiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + rutherfordium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + rutherfordium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void hafnium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(HafniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + hafnium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + hafnium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void zicronium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ZirconiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Zirconium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Zirconium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void yittrium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(YttriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + yittrium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + yittrium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void titanium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(TitaniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + titanium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + titanium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void scandium_Click_1(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ScandiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + scandium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + scandium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void radium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(RadiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + radium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + radium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void francium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(FranciumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + francium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + francium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void barium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(BariumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + barium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + barium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void lawrencium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(LawrenciumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lawrencium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lawrencium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void stronium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(StrontiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + stronium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + stronium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void rubidium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(RubidiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + rubidium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + rubidium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void calcium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CalciumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + calcium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + calcium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void potassium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(PotassiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + potassium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + potassium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void magnesium_Click(object sender, EventArgs e)
        {
            buttonSelect test;

            if (Magclick == true)
            {
                test = new buttonSelect(MagnesiumMM, 1);

            }
            else
            {
                mag = count2;
                test = new buttonSelect(MagnesiumMM, 1);
                //count2+=2;
                Magclick = true;
            }
            
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + magnesium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + magnesium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void sodium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(SodiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + sodium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + sodium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void beryllium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(BerylliumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + beryllium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + beryllium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void lithium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(LithiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lithium.Text;
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lithium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }
        //<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
        //================================================================================================================================
        //--------------------------------------------------------------------------------------------------------------------------------
        //                                      On Hover Event
        //--------------------------------------------------------------------------------------------------------------------------------
        //================================================================================================================================
        //<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

        private void resetHover(object sender, EventArgs e)
        {
            elementHover.Text = "";
            elementHover.BackColor = Color.LightGray;

        }

         



        public void hydrogen_MouseHover(object sender, EventArgs e)
        {
            elementHover.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            elementHover.BackColor = hydrogen.BackColor;

            elementHover.Text = "\n"+  hydrogen.Text  + "\n" +
                                         "Hydrogen\n" +            
                                    "Atomic # " + HydrogenN + "\n"+
                                        HydrogenMM + "g\n";            
        }

        













        //<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
        //================================================================================================================================
        //--------------------------------------------------------------------------------------------------------------------------------
        //                                      Balance Buttons
        //--------------------------------------------------------------------------------------------------------------------------------
        //================================================================================================================================
        //<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>


        //Add function
        private void add_Click(object sender, EventArgs e)
        {
            //sorts through each box as items are added
            Color c = Color.LightGray;

            mmReactant1.SelectionFont = 
            mmReactant2.SelectionFont = 
            mmReactant3.SelectionFont = 
            mmProduct1.SelectionFont  = 
            mmProduct2.SelectionFont  = 
            mmProduct3.SelectionFont  = new Font("Verdana", 13);
            mmEquation1.SelectionFont =
            mmEquation2.SelectionFont =
            mmEquation3.SelectionFont =
            mmEquation4.SelectionFont =
            mmEquation5.SelectionFont =
            mmEquation6.SelectionFont = new Font("Verdana", 15);
            count++;
            Console.WriteLine(count);
            if (count == 1)
            {
                balanceBox1.Rtf = compoundBuilder.Rtf;
                balanceBox1.BackColor = c;
                balanceBox2.BackColor = Color.WhiteSmoke;
                balanceBox3.BackColor = c;
                balanceBox4.BackColor = c;
                balanceBox5.BackColor = c;
                balanceBox6.BackColor = c;
                setMM1(molar);
                mmReactant1.Text = molar.ToString() + "g";
                mmEquation1.Rtf = compoundBuilder.Rtf;
                reactant1.Rtf = compoundBuilder.Rtf;
            }
            else if (count == 2)
            {
                balanceBox2.Rtf = compoundBuilder.Rtf;
                balanceBox1.BackColor = c;
                balanceBox2.BackColor = c;
                balanceBox3.BackColor = Color.WhiteSmoke;
                balanceBox4.BackColor = c;
                balanceBox5.BackColor = c;
                balanceBox6.BackColor = c;
                setMM2(molar);
                mmReactant2.Text = molar.ToString() + "g";                
                mmEquation2.Rtf = compoundBuilder.Rtf;
                reactant2.Rtf = compoundBuilder.Rtf;
            }
            else if (count == 3)
            {
                balanceBox3.Rtf = compoundBuilder.Rtf;
                balanceBox1.BackColor = c;
                balanceBox2.BackColor = c;
                balanceBox3.BackColor = c;
                balanceBox4.BackColor = Color.WhiteSmoke;
                balanceBox5.BackColor = c;
                balanceBox6.BackColor = c;
                setMM3(molar);
                mmReactant3.Text = molar.ToString() + "g";
                mmEquation3.Rtf = compoundBuilder.Rtf;
                reactant3.Rtf = compoundBuilder.Rtf;
            }
            else if (count == 4)
            {
                balanceBox4.Rtf = compoundBuilder.Rtf;
                balanceBox1.BackColor = c;
                balanceBox2.BackColor = c;
                balanceBox3.BackColor = c;
                balanceBox4.BackColor = c;
                balanceBox5.BackColor = Color.WhiteSmoke;
                balanceBox6.BackColor = c;
                setMM4(molar);
                mmProduct1.Text= molar.ToString() + "g";
                mmEquation4.Rtf = compoundBuilder.Rtf;
                product1.Rtf = compoundBuilder.Rtf;
            }
            else if (count == 5)
            {
                balanceBox5.Rtf = compoundBuilder.Rtf;
                balanceBox1.BackColor = c;
                balanceBox2.BackColor = c;
                balanceBox3.BackColor = c;
                balanceBox4.BackColor = c;
                balanceBox5.BackColor = c;
                balanceBox6.BackColor = Color.WhiteSmoke;
                setMM5(molar);
                mmProduct2.Text = molar.ToString() + "g";
                mmEquation5.Rtf = compoundBuilder.Rtf;
                product2.Rtf = compoundBuilder.Rtf;
            }
            else if (count == 6)
            {
                balanceBox6.Rtf = compoundBuilder.Rtf;
                balanceBox1.BackColor = c;
                balanceBox2.BackColor = c;
                balanceBox3.BackColor = c;
                balanceBox4.BackColor = c;
                balanceBox5.BackColor = c;
                balanceBox6.BackColor = c;
                setMM6(molar);
                mmProduct3.Text = molar.ToString() + "g";
                mmEquation1.Rtf = compoundBuilder.Rtf;
                product3.Rtf = compoundBuilder.Rtf;
            }
            compoundBuilder.Rtf = "";
            molar = 0;

        }

        //switches sides of the equation
        private void yeild_Click(object sender, EventArgs e)
        {
            if (count < 3)
            {
                Color c = Color.LightGray;
                if (count == 0)
                {
                    balanceBox1.Rtf = compoundBuilder.Rtf;
                    setMM1(molar);
                    mmReactant1.Text = molar.ToString() + "g";
                    mmEquation1.Rtf = compoundBuilder.Rtf;
                    reactant1.Rtf = compoundBuilder.Rtf;
                }
                else if (count == 1)
                {
                    balanceBox2.Rtf = compoundBuilder.Rtf;
                    setMM2(molar);
                    mmReactant2.Text = molar.ToString() + "g";
                    mmEquation2.Rtf = compoundBuilder.Rtf;
                    reactant2.Rtf = compoundBuilder.Rtf;
                }
                else if (count == 2)
                {
                    balanceBox3.Rtf = compoundBuilder.Rtf;
                    setMM3(molar);
                    mmReactant3.Text = molar.ToString() + "g";
                    mmEquation3.Rtf = compoundBuilder.Rtf;
                    reactant3.Rtf = compoundBuilder.Rtf;
                }

                balanceBox1.BackColor = c;
                balanceBox2.BackColor = c;
                balanceBox3.BackColor = c;
                balanceBox4.BackColor = Color.WhiteSmoke;
                balanceBox5.BackColor = c;
                balanceBox6.BackColor = c;

                compoundBuilder.Rtf = "";
                count = 3;                
            }
            molar = 0;
        }

        //balances the equation
        static int var1;
        static int var2;
        static int var3;
        static int var4;
        static int var5;
        static int var6;
        public static int[] balance(int terms)
        {
            double t1 = MM3;
            double t2 = MM2;
            double t3 = MM1;
            double t4 = MM4;
            double t5 = MM5;
            double t6 = MM6;
            int[] list = new int[terms];
            for (int a = 1; a < 100; a++)
            {
                for (int b = 1; b < 100; b++)
                {
                    for (int c = 1; c < 100; c++)
                    {
                        for (int d = 1; d < 100; d++)
                        {
                            for (int e = 1; e < 100; e++)
                            {
                                for (int f = 1; f < 100; f++)
                                {
                                    if (a * t1 + b * t2 + c * t3 == d * t4 + e * t5 + f * t6)
                                    {
                                        list[0] = a;
                                        list[1] = b;
                                        list[2] = c;
                                        list[3] = d;
                                        list[4] = e;
                                        list[5] = f;
                                        return list;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return list;
        }
        public static int modulus(int[] next)
        {
            for (int i = 0; i < balance(6).Length; i++)
            {
                int counter = 0;
                for (int k = 2; k < 100; k++)
                {
                    if (counter == balance(6).Length)
                        return k;
                    if (next[i] % k == 0)
                        counter++;
                }
            }
            return 1;
        }

        private void balanceEquation_Click(object sender, EventArgs e)
        {
            Color c = Color.LightGray;
            //finalizes equation with gui
           if (count == 0)
            {
                balanceBox1.Rtf = compoundBuilder.Rtf;
                setMM1(molar);
                mmReactant1.Text = molar.ToString() + "g";
                mmEquation1.Rtf = compoundBuilder.Rtf;
                reactant1.Rtf = compoundBuilder.Rtf;
            }
            else if (count == 1)
            {
                balanceBox2.Rtf = compoundBuilder.Rtf;
                setMM2(molar);
                mmReactant2.Text = molar.ToString() + "g";
                mmEquation2.Rtf = compoundBuilder.Rtf;
                reactant2.Rtf = compoundBuilder.Rtf;
            }
            else if (count == 2)
            {
                balanceBox3.Text = compoundBuilder.Rtf;
                setMM3(molar);
                mmReactant3.Text = molar.ToString() + "g";
                mmEquation3.Rtf = compoundBuilder.Rtf;
                reactant3.Rtf = compoundBuilder.Rtf;
            }
            else if (count == 3)
            {
                balanceBox4.Rtf = compoundBuilder.Rtf;
                setMM4(molar);
                mmProduct1.Text = molar.ToString() + "g";
                mmEquation4.Rtf = compoundBuilder.Rtf;
                product1.Rtf = compoundBuilder.Rtf;
            }
            else if (count == 4)
            {
                balanceBox5.Rtf = compoundBuilder.Rtf;
                setMM5(molar);
                mmProduct2.Text = molar.ToString() + "g";
                mmEquation5.Rtf = compoundBuilder.Rtf;
                product2.Rtf = compoundBuilder.Rtf;
            }
            else if (count == 5)
            {
                balanceBox6.Rtf = compoundBuilder.Rtf;
                setMM6(molar);
                mmProduct3.Text = molar.ToString() + "g";
                mmEquation6.Rtf = compoundBuilder.Rtf;
                product3.Rtf = compoundBuilder.Rtf;
            }

            balanceBox1.BackColor = c;
            balanceBox2.BackColor = c;
            balanceBox3.BackColor = c;
            balanceBox4.BackColor = c;
            balanceBox5.BackColor = c;
            balanceBox6.BackColor = c;

            compoundBuilder.Rtf = "";
           molar = 0;

            //TODO: implement Lucas' balance code
            int[] list = balance(6);    
            int[] list2= new int[6];
            int div = modulus(list);
            for (int i = 0; i < list.Length; i++)
            {
               int divided = list[i];
               list2[i] = divided / div;
               Console.WriteLine(list2[i]);
            }
            var1 = list2[2];
            var2 = list2[1];
            var3 = list2[0];
            var4 = list2[3];
            var5 = list2[4];
            var6 = list2[5];

            setBalanced(var1);
            setBalanced2(var2);
            setBalanced3(var3);
            setBalanced4(var4);
            setBalanced5(var5);
            setBalanced6(var6);
        }
        private void setBalanced(int var1)
        {
            if (var1 == 1 && var1 == 0)
            {
                balanced1.Text = balanceBox1.Text;
            }
            else
            {
                
                String Var1 = Convert.ToString(var1);
                balanced1.Text = Var1 + balanceBox1.Text;
            }
        }
        private void setBalanced2(int var2)
        {
            if (var2 == 1 && var2 == 0)
            {
                balanced2.Text = balanceBox2.Text;
            }
            else
            {
                String Var2 = Convert.ToString(var2);
                balanced2.Text = Var2 + balanceBox2.Text;
            }
        }
        private void setBalanced3(int var3)
        {
            if (var3 == 1&& var3 == 0)
            {
                balanced3.Text = balanceBox3.Text;
            }
            else
            {
                String Var3 = Convert.ToString(var3);
                balanced3.Text = Var3 + balanceBox3.Text;
            }
        }
        private void setBalanced4(int var4)
        {
            if (var4 == 1 && var4 == 0)
            {
                balanced4.Text = balanceBox4.Text;
            }
            else
            {
                String Var4 = Convert.ToString(var4);
               balanced4.Text = Var4 + balanceBox4.Text;
            }
        }
        private void setBalanced5(int var5)
        {
            if (var5 == 1 && var5 == 0)
            {
                balanced5.Text = balanceBox5.Text;
            }
            else
            {
                String Var5 = Convert.ToString(var5);
               balanced5.Text = Var5 + balanceBox5.Text;
            }
        }
        private void setBalanced6(int var6)
        {
            if (var6 == 1 && var6 == 0)
            {
                balanced6.Text = balanceBox6.Text;
            }
            else
            {
                String Var6 = Convert.ToString(var6);
                balanced6.Text = Var6 + balanceBox6.Text;
            }
        }
        private void clearBuilder_Click(object sender, EventArgs e)
        {
            compoundBuilder.Rtf = "";

        }

        //clears the equations
        private void clearEquation_Click(object sender, EventArgs e)
        {
            compoundBuilder.Rtf =
            balanceBox1.Rtf =
            balanceBox2.Rtf =
            balanceBox3.Rtf =
            balanceBox4.Rtf =
            balanceBox5.Rtf =
            balanceBox6.Rtf =
            product1.Rtf =
            product2.Rtf =
            product3.Rtf =
            reactant1.Rtf =
            reactant2.Rtf =
            reactant3.Rtf =
            mmEquation1.Rtf =
            mmEquation2.Rtf =
            mmEquation3.Rtf =
            mmEquation4.Rtf =
            mmEquation5.Rtf =
            mmEquation6.Rtf = "";
            mmReactant1.Text =
            mmReactant2.Text =
            mmReactant3.Text =
            mmProduct1.Text =
            mmProduct2.Text =
            mmProduct3.Text = "0g";

            delMM1();
            delMM2();
            delMM3();
            delMM4();
            delMM5();
            delMM6();
           // Console.WriteLine(MM1 + MM2 + MM3 + MM4 + MM5 + MM6);


        }


        ////<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
        //================================================================================================================================
        //--------------------------------------------------------------------------------------------------------------------------------
        //                                      Balance Boxes
        //--------------------------------------------------------------------------------------------------------------------------------
        //================================================================================================================================
        ////<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>


        //compound builder next to the add sign
        private void compoundBuilder_TextChanged(object sender, EventArgs e)
        {

        }

        //background for equation
        private void button1_Click(object sender, EventArgs e)
        {

        }

       

        //background of equation box
        private void backgroundTextBox_Click(object sender, EventArgs e)
        {

        }

        private void balanceBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void balanceBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void balanceBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void balanceBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void balanceBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void balanceBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayElement_Click(object sender, EventArgs e)
        {

        }






        //<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
        //================================================================================================================================
        //--------------------------------------------------------------------------------------------------------------------------------
        //                                      Molar Mass Page
        //--------------------------------------------------------------------------------------------------------------------------------
        //================================================================================================================================
        //<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>



        private void mmEquation1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mmEquation2_TextChanged(object sender, EventArgs e)
        {

        }

        private void mmEquation3_TextChanged(object sender, EventArgs e)
        {

        }

        private void mmEquation4_TextChanged(object sender, EventArgs e)
        {

        }

        private void mmEquation5_TextChanged(object sender, EventArgs e)
        {

        }

        private void mmEquation6_TextChanged(object sender, EventArgs e)
        {

        }

        private void reactant1_TextChanged(object sender, EventArgs e)
        {

        }

        private void reactant2_TextChanged(object sender, EventArgs e)
        {

        }

        private void reactant3_TextChanged(object sender, EventArgs e)
        {

        }

        private void product1_TextChanged(object sender, EventArgs e)
        {

        }

        private void product2_TextChanged(object sender, EventArgs e)
        {

        }

        private void product3_TextChanged(object sender, EventArgs e)
        {

        }

        private void mmReactant1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mmReactant2_TextChanged(object sender, EventArgs e)
        {

        }

        private void mmReactant3_TextChanged(object sender, EventArgs e)
        {

        }

        private void mmProduct1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mmProduct2_TextChanged(object sender, EventArgs e)
        {

        }

        private void mmProduct3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, TabControlEventArgs e)
        {

        }

        private void mmPageName_TextChanged(object sender, EventArgs e)
        {

        }

        private void mmPageName2_TextChanged(object sender, EventArgs e)
        {

        }

        //-------------------------------------------
        //-------Balanced Page-----------------------
        //-------------------------------------------
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }


        //<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
        //================================================================================================================================
        //--------------------------------------------------------------------------------------------------------------------------------
        //                                      Molarity Page
        //--------------------------------------------------------------------------------------------------------------------------------
        //================================================================================================================================
        //<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>


        private void litersMolarity_TextChanged(object sender, EventArgs e)
        {

        }

        private void molarityAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void molarityConvert_TextChanged(object sender, EventArgs e)
        {

        }

        private void molalityConvert_TextChanged(object sender, EventArgs e)
        {

        }

        private void density_TextChanged(object sender, EventArgs e)
        {

        }

        private void molarMassConvert_TextChanged(object sender, EventArgs e)
        {

        }

        private void molesMolality_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void kgMolality_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void molalityAnswer_TextChanged_1(object sender, EventArgs e)
        {

        }



        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void molesMolarity_TextChanged(object sender, EventArgs e)
        {

        }

        //detects if a keyPress is numerical - only allows 1 . and no letters
        private void num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as RichTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        double moles = 0;
        double liters = 0;
        double molarity = 0;

        private void molaritySolve_Click(object sender, EventArgs e)
        {
            //finds numbers
            if(molesMolarity.Text != "" && moles == 0)
                moles  = Convert.ToDouble(molesMolarity.Text);
            if (litersMolarity.Text != "" && liters == 0)
                liters = Convert.ToDouble(litersMolarity.Text);
            if (molarityAnswer.Text != "" && molarity == 0)
                 molarity = Convert.ToDouble(molarityAnswer.Text);

            //find molarity
            if(moles > 0 && liters >0 && molarity == 0)
            {
                molarity = Math.Round( (moles / liters) , 3);
                molarityAnswer.Text = molarity.ToString();
            }

            //find moles
            if (moles == 0 && liters > 0 && molarity > 0)
            {
                moles = Math.Round( (molarity * liters) , 3);
                molesMolarity.Text = moles.ToString();                
            }


            //find liters
            if (moles > 0 && liters == 0 && molarity > 0)
            {
                liters = Math.Round( (1/(moles * molarity)) , 3);
                litersMolarity.Text = liters.ToString();                
            }

            molarity = 0;
            moles    = 0;
            liters   = 0;
        }

        double molarityConv = 0;
        double molalityConv = 0;
        double massConv = 0;
        double densityConv = 0;
        private void conversion_Click(object sender, EventArgs e)
        {
            //finds numbers
            if (molarityConvert.Text != "")
                molarityConv = Convert.ToDouble(molarityConvert.Text);
            if (molalityConvert.Text != "")
                molalityConv = Convert.ToDouble(molalityConvert.Text);
            if (molarMassConvert.Text != "")
                massConv = Convert.ToDouble(molarMassConvert.Text);
            if (densityConvert.Text != "")
                densityConv = Convert.ToDouble(densityConvert.Text);

            double mL = 1000;
            double gramsSolution = 0;
            double gramsSolute = 0;

            //find molality
            if(molalityConv == 0 && molarityConv > 0 && massConv > 0 && densityConv > 0)
            {
                gramsSolution = mL * densityConv;
                gramsSolute = molarityConv * massConv;
                molalityConv = Math.Round(((molarityConv * 1000) / (gramsSolution - gramsSolute)), 3);

                molalityConvert.Text = molalityConv.ToString();
            }

            //find molarity
            else if(molarityConv == 0 && molalityConv > 0 && densityConv > 0)
            {
                gramsSolute = molalityConv * massConv;
                gramsSolution = mL + gramsSolute;
                molarityConv = (gramsSolution * (1 / densityConv)) / 1000;
                molarityConv = Math.Round((molalityConv / molarityConv) , 3);

                molarityConvert.Text = molarityConv.ToString();
            }

            //find density
            else if(densityConv == 0 && molarityConv > 0 && molalityConv > 0 && massConv > 0)
            {
                densityConv = (molarityConv / molalityConv) + ((molarityConv * massConv) / 1000);
                densityConvert.Text = Math.Round(densityConv, 3).ToString();

            }

            //solves for molar mass
            else if(massConv == 0 && molarityConv > 0 && molalityConv > 0 && densityConv > 0)
            {
                massConv = ((1000 * (densityConv - (molarityConv / molalityConv))) / molarityConv);
                molarMassConvert.Text = Math.Round(massConv, 3).ToString();
            }
            

            //resets numbers
            molarityConv  = 0;
            molalityConv  = 0;
            massConv      = 0;
            densityConv   = 0;
            gramsSolution = 0;
            gramsSolute   = 0;
        }



        double molesMolal = 0;
        double solventMolal = 0;
        double molalityMolal = 0;

        private void molalitySolve_Click(object sender, EventArgs e)
        {
            //finds numbers
            if (molesMolality.Text != "")
                molesMolal = Convert.ToDouble(molesMolality.Text);
            if (kgMolality.Text != "")
                solventMolal = Convert.ToDouble(kgMolality.Text);
            if (molalityAnswer.Text != "")
                molalityMolal = Convert.ToDouble(molalityAnswer.Text);

            //finds molality
            if (molesMolal > 0 && solventMolal > 0 && molalityMolal == 0)
            {
                molalityMolal = Math.Round((molesMolal / solventMolal), 3);
                molalityAnswer.Text = molalityMolal.ToString(); 
            }

            //finds solvent
            if (molesMolal > 0 && solventMolal == 0 && molalityMolal > 0)
            {
                solventMolal = Math.Round((molalityMolal * solventMolal), 3);
                kgMolality.Text = solventMolal.ToString();

            }

            //finds moles
            if (molesMolal == 0 && solventMolal > 0 && molarity > 0)
            {
                molesMolal = Math.Round((1 /(molesMolal * molalityMolal) ), 3);
                molesMolality.Text = molesMolal.ToString();
            }

            molesMolal = 0;
            solventMolal = 0;
            molalityMolal = 0;
        

        }

        //Clears the specific equations
        private void clearMolarity_Click(object sender, EventArgs e)
        {
            molesMolarity.Text = 
            litersMolarity.Text = 
            molarityAnswer.Text = "";
        }
        private void clearConversion_Click(object sender, EventArgs e)
        {
            molalityConvert.Text =
            molalityConvert.Text =
            densityConvert.Text =
            molarMassConvert.Text = "";
        }
        private void clearMolality_Click(object sender, EventArgs e)
        {
            molesMolality.Text =
            kgMolality.Text =
            molalityAnswer.Text = "";
        }

        



    }
}

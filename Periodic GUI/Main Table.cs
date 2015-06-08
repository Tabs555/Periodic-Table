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
        static int count = 0;
        static double molar;

        static Boolean hasBal = false;
        static double MM1;
        static double MM2;
        static double MM3;
        static double MM4;
        static double MM5;
        static double MM6;

        public Form1()
        {
            InitializeComponent();

            #region Initialize Text

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

#endregion
        }


        #region setDang/Addmass/Less Lag
        //makes less lag
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        public void setDang(double a)
        {
            dang = a;
            this.addMass();

        }

        private void addMass()
        {
            molar += dang;

        }


        static Boolean first = true;
        List<int[]> bad = new List<int[]>();
        static int[] a = new int[118];
        static int[] b = new int[118];
        static int[] c = new int[118];
        static int[] d = new int[118];
        static int[] e1 = new int[118];
        static int[] f = new int[118];
        List<int> tracker = new List<int>();


        #endregion


         
        //================================================================================================================================
        // --
        //                                      Molar Mass Set/Remove/get Method
        // --
        //================================================================================================================================
         

        #region Molar Mass Setters/Getters

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

        #endregion

         



        //================================================================================================================================
        // --
        //                                      Element Atomic Number
        // --
        //================================================================================================================================
         

        #region Element Atomic Number

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

#endregion




         
        //================================================================================================================================
        // --
        //                                      Element Molar Mass
        // --
        //================================================================================================================================
         

        #region Element Molar Mass

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


        #endregion

         



        //================================================================================================================================
        // --
        //                                      Solving Matrix
        // --
        //================================================================================================================================
         

        #region Matrix



        public int[][] matrix()
        {
            int[] termCount = new int[6];
            //how many terms? this determines how many of a, b, and c are being used
            if (balanceBox1.Text != "")
            {
                check(a);
                bad.Add(a);
            }
            if (balanceBox2.Text != "")
            {
                check(b);
                bad.Add(b);
            }
            if (balanceBox3.Text != "")
            {
                check(c);
                bad.Add(c);
            }
            if (balanceBox4.Text != "")
            {
                check(d);
                bad.Add(d);
            }
            if (balanceBox5.Text != "")
            {
                check(e1);
                bad.Add(e1);
            }
            if (balanceBox6.Text != "")
            {
                check(f);
                bad.Add(f);
            }
            //converts the products to negatives
            makeNegative();
            //overall counter of how many elements in the equation, this will be the part in the jagged array that changes from the video the amount of rows
            int elementCount = tracker.Count;
            int[][] matrix = new int[elementCount][];
            //check how many of each element
            for (int i = 0; i < tracker.Count; i++) //as long as i is less than the amount of elements in tracker
            {
                if (bad.Count == 1)
                {
                    int[] temp = bad[0];
                    int tempy = tracker[i];
                    matrix[i] = new int[] { temp[tempy] };
                }
                if (bad.Count == 2)
                {
                    int[] temp = bad[0];
                    int[] temp2 = bad[1];
                    int tempy = tracker[i];
                    matrix[i] = new int[] { temp[tempy], temp2[tempy] };

                }
                if (bad.Count == 3)
                {
                    int[] temp = bad[0];
                    int[] temp2 = bad[1];
                    int[] temp3 = bad[2];
                    int tempy = tracker[i];
                    matrix[i] = new int[] { temp[tempy], temp2[tempy], temp3[tempy] };

                }
                if (bad.Count == 4)
                {
                    int[] temp = bad[0];
                    int[] temp2 = bad[1];
                    int[] temp3 = bad[2];
                    int[] temp4 = bad[3];
                    int tempy = tracker[i];
                    matrix[i] = new int[] { temp[tempy], temp2[tempy], temp3[tempy], temp4[tempy] };

                }
                if (bad.Count == 5)
                {
                    int[] temp = bad[0];
                    int[] temp2 = bad[1];
                    int[] temp3 = bad[2];
                    int[] temp4 = bad[3];
                    int[] temp5 = bad[4];
                    int tempy = tracker[i];
                    matrix[i] = new int[] { temp[tempy], temp2[tempy], temp3[tempy], temp4[tempy], temp5[tempy] };

                }
                if (bad.Count == 6)
                {
                    int[] temp = bad[0];
                    int[] temp2 = bad[1];
                    int[] temp3 = bad[2];
                    int[] temp4 = bad[3];
                    int[] temp5 = bad[4];
                    int[] temp6 = bad[5];
                    int tempy = tracker[i];
                    matrix[i] = new int[] { temp[tempy], temp2[tempy], temp3[tempy], temp4[tempy], temp5[tempy], temp6[tempy] };
                }
            }
            return matrix;
        }
        public void check(int[] array) //checks for how many elements used
        {
            for (int i = 0; i < 118; i++)
            {
                if (array[i] > 0)
                    addIndex(i);
            }
        }
        public void makeNegative()
        {
            for (int i = 0; i < 118; i++)
            {
                d[i] *= -1;
                e1[i] *= -1;
                f[i] *= -1;
            }
        }

        public int addIndex(int index) //prevents repeat indexes
        {
            if (first)
            {
                tracker.Add(index);
                first = false;
            }
            else
            {
                for (int k = 0; k < tracker.Count; k++) //checks the tracker list for repeat indexes
                {
                    if (tracker[k] == index)
                        return -1; //ends the method if it finds a repeat index
                }
                tracker.Add(index);
                return 1;
            }
            return -2;
        }

        #endregion





        //================================================================================================================================
        // --
        //                                      Buttons
        // --
        //================================================================================================================================



        #region Buttons


        private void hydrogen_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(HydrogenMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + hydrogen.Text;
                if (count == 0)
                {
                    a[0]++;
                }
                if (count == 1)
                {
                    b[0]++;
                }
                if (count == 2)
                {
                    c[0]++;
                }
                if (count == 3)
                {
                    d[0]++;
                }
                if (count == 4)
                {
                    e1[0]++;
                }
                if (count == 5)
                {
                    f[0]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[0] += myInt;
                }
                if (count == 1)
                {
                    b[0] += myInt;
                }
                if (count == 2)
                {
                    c[0] += myInt;
                }
                if (count == 3)
                {
                    d[0] += myInt;
                }
                if (count == 4)
                {
                    e1[0] += myInt;
                }
                if (count == 5)
                {
                    f[0] += myInt;
                }

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
            {
                if (count == 0)
                {
                    a[54]++;
                }
                if (count == 1)
                {
                    b[54]++;
                }
                if (count == 2)
                {
                    c[54]++;
                }
                if (count == 3)
                {
                    d[54]++;
                }
                if (count == 4)
                {
                    e1[54]++;
                }
                if (count == 5)
                {
                    f[54]++;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + cesium.Text;
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[54] += myInt;
                }
                if (count == 1)
                {
                    b[54] += myInt;
                }
                if (count == 2)
                {
                    c[54] += myInt;
                }
                if (count == 3)
                {
                    d[54] += myInt;
                }
                if (count == 4)
                {
                    e1[54] += myInt;
                }
                if (count == 5)
                {
                    f[54] += myInt;
                }

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
            {
                if (count == 0)
                {
                    a[101]++;
                }
                if (count == 1)
                {
                    b[101]++;
                }
                if (count == 2)
                {
                    c[101]++;
                }
                if (count == 3)
                {
                    d[101]++;
                }
                if (count == 4)
                {
                    e1[101]++;
                }
                if (count == 5)
                {
                    f[101]++;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + nobelium.Text;
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[101] += myInt;
                }
                if (count == 1)
                {
                    b[101] += myInt;
                }
                if (count == 2)
                {
                    c[101] += myInt;
                }
                if (count == 3)
                {
                    d[101] += myInt;
                }
                if (count == 4)
                {
                    e1[101] += myInt;
                }
                if (count == 5)
                {
                    f[101] += myInt;
                }
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
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lutetium.Text;
                if (count == 0)
                {
                    a[70]++;
                }
                if (count == 1)
                {
                    b[70]++;
                }
                if (count == 2)
                {
                    c[70]++;
                }
                if (count == 3)
                {
                    d[70]++;
                }
                if (count == 4)
                {
                    e1[70]++;
                }
                if (count == 5)
                {
                    f[70]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[70] += myInt;
                }
                if (count == 1)
                {
                    b[70] += myInt;
                }
                if (count == 2)
                {
                    c[70] += myInt;
                }
                if (count == 3)
                {
                    d[70] += myInt;
                }
                if (count == 4)
                {
                    e1[70] += myInt;
                }
                if (count == 5)
                {
                    f[70] += myInt;
                }

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
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ytterbium.Text;
                if (count == 0)
                {
                    a[69]++;
                }
                if (count == 1)
                {
                    b[69]++;
                }
                if (count == 2)
                {
                    c[69]++;
                }
                if (count == 3)
                {
                    d[69]++;
                }
                if (count == 4)
                {
                    e1[69]++;
                }
                if (count == 5)
                {
                    f[69]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[69] += myInt;
                }
                if (count == 1)
                {
                    b[69] += myInt;
                }
                if (count == 2)
                {
                    c[69] += myInt;
                }
                if (count == 3)
                {
                    d[69] += myInt;
                }
                if (count == 4)
                {
                    e1[69] += myInt;
                }
                if (count == 5)
                {
                    f[69] += myInt;
                }

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
            {
                if (count == 0)
                {
                    a[100]++;
                }
                if (count == 1)
                {
                    b[100]++;
                }
                if (count == 2)
                {
                    c[100]++;
                }
                if (count == 3)
                {
                    d[100]++;
                }
                if (count == 4)
                {
                    e1[100]++;
                }
                if (count == 5)
                {
                    f[100]++;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + mendelevium.Text;
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[100] += myInt;
                }
                if (count == 1)
                {
                    b[100] += myInt;
                }
                if (count == 2)
                {
                    c[100] += myInt;
                }
                if (count == 3)
                {
                    d[100] += myInt;
                }
                if (count == 4)
                {
                    e1[100] += myInt;
                }
                if (count == 5)
                {
                    f[100] += myInt;
                }

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
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + fermium.Text;
                if (count == 0)
                {
                    a[99]++;
                }
                if (count == 1)
                {
                    b[99]++;
                }
                if (count == 2)
                {
                    c[99]++;
                }
                if (count == 3)
                {
                    d[99]++;
                }
                if (count == 4)
                {
                    e1[99]++;
                }
                if (count == 5)
                {
                    f[99]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + fermium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[99] += myInt;
                }
                if (count == 1)
                {
                    b[99] += myInt;
                }
                if (count == 2)
                {
                    c[99] += myInt;
                }
                if (count == 3)
                {
                    d[99] += myInt;
                }
                if (count == 4)
                {
                    e1[99] += myInt;
                }
                if (count == 5)
                {
                    f[99] += myInt;
                }


            }

        }

        private void thulium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ThuliumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + thulium.Text;
                if (count == 0)
                {
                    a[68]++;
                }
                if (count == 1)
                {
                    b[68]++;
                }
                if (count == 2)
                {
                    c[68]++;
                }
                if (count == 3)
                {
                    d[68]++;
                }
                if (count == 4)
                {
                    e1[68]++;
                }
                if (count == 5)
                {
                    f[68]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[68] += myInt;
                }
                if (count == 1)
                {
                    b[68] += myInt;
                }
                if (count == 2)
                {
                    c[68] += myInt;
                }
                if (count == 3)
                {
                    d[68] += myInt;
                }
                if (count == 4)
                {
                    e1[68] += myInt;
                }
                if (count == 5)
                {
                    f[68] += myInt;
                }


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
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + erbium.Text;
                if (count == 0)
                {
                    a[67]++;
                }
                if (count == 1)
                {
                    b[67]++;
                }
                if (count == 2)
                {
                    c[67]++;
                }
                if (count == 3)
                {
                    d[67]++;
                }
                if (count == 4)
                {
                    e1[67]++;
                }
                if (count == 5)
                {
                    f[67]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[67] += myInt;
                }
                if (count == 1)
                {
                    b[67] += myInt;
                }
                if (count == 2)
                {
                    c[67] += myInt;
                }
                if (count == 3)
                {
                    d[67] += myInt;
                }
                if (count == 4)
                {
                    e1[67] += myInt;
                }
                if (count == 5)
                {
                    f[67] += myInt;
                }


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
            {
                if (count == 0)
                {
                    a[98]++;
                }
                if (count == 1)
                {
                    b[98]++;
                }
                if (count == 2)
                {
                    c[98]++;
                }
                if (count == 3)
                {
                    d[98]++;
                }
                if (count == 4)
                {
                    e1[98]++;
                }
                if (count == 5)
                {
                    f[98]++;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + einsteinium.Text;
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + einsteinium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[98] += myInt;
                }
                if (count == 1)
                {
                    b[98] += myInt;
                }
                if (count == 2)
                {
                    c[98] += myInt;
                }
                if (count == 3)
                {
                    d[98] += myInt;
                }
                if (count == 4)
                {
                    e1[98] += myInt;
                }
                if (count == 5)
                {
                    f[98] += myInt;
                }


            }

        }

        private void californium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CaliforniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                if (count == 0)
                {
                    a[97]++;
                }
                if (count == 1)
                {
                    b[97]++;
                }
                if (count == 2)
                {
                    c[97]++;
                }
                if (count == 3)
                {
                    d[97]++;
                }
                if (count == 4)
                {
                    e1[97]++;
                }
                if (count == 5)
                {
                    f[97]++;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + californium.Text;
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + californium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[97] += myInt;
                }
                if (count == 1)
                {
                    b[97] += myInt;
                }
                if (count == 2)
                {
                    c[97] += myInt;
                }
                if (count == 3)
                {
                    d[97] += myInt;
                }
                if (count == 4)
                {
                    e1[97] += myInt;
                }
                if (count == 5)
                {
                    f[97] += myInt;
                }
            }

        }

        private void holmium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(HolmiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + holmium.Text;
                if (count == 0)
                {
                    a[66]++;
                }
                if (count == 1)
                {
                    b[66]++;
                }
                if (count == 2)
                {
                    c[66]++;
                }
                if (count == 3)
                {
                    d[66]++;
                }
                if (count == 4)
                {
                    e1[66]++;
                }
                if (count == 5)
                {
                    f[66]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + holmium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[66] += myInt;
                }
                if (count == 1)
                {
                    b[66] += myInt;
                }
                if (count == 2)
                {
                    c[66] += myInt;
                }
                if (count == 3)
                {
                    d[66] += myInt;
                }
                if (count == 4)
                {
                    e1[66] += myInt;
                }
                if (count == 5)
                {
                    f[66] += myInt;
                }
            }

        }

        private void dysprosium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(DysprosiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + dysprosium.Text;
                if (count == 0)
                {
                    a[65]++;
                }
                if (count == 1)
                {
                    b[65]++;
                }
                if (count == 2)
                {
                    c[65]++;
                }
                if (count == 3)
                {
                    d[65]++;
                }
                if (count == 4)
                {
                    e1[65]++;
                }
                if (count == 5)
                {
                    f[65]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + dysprosium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[65] += myInt;
                }
                if (count == 1)
                {
                    b[65] += myInt;
                }
                if (count == 2)
                {
                    c[65] += myInt;
                }
                if (count == 3)
                {
                    d[65] += myInt;
                }
                if (count == 4)
                {
                    e1[65] += myInt;
                }
                if (count == 5)
                {
                    f[65] += myInt;
                }
            }

        }

        private void berkelium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(BerkeliumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + berkelium.Text;
                if (count == 0)
                {
                    a[96]++;
                }
                if (count == 1)
                {
                    b[96]++;
                }
                if (count == 2)
                {
                    c[96]++;
                }
                if (count == 3)
                {
                    d[96]++;
                }
                if (count == 4)
                {
                    e1[96]++;
                }
                if (count == 5)
                {
                    f[96]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + berkelium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[96] += myInt;
                }
                if (count == 1)
                {
                    b[96] += myInt;
                }
                if (count == 2)
                {
                    c[96] += myInt;
                }
                if (count == 3)
                {
                    d[96] += myInt;
                }
                if (count == 4)
                {
                    e1[96] += myInt;
                }
                if (count == 5)
                {
                    f[96] += myInt;
                }
            }

        }

        private void curium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CuriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + curium.Text;
                if (count == 0)
                {
                    a[95]++;
                }
                if (count == 1)
                {
                    b[95]++;
                }
                if (count == 2)
                {
                    c[95]++;
                }
                if (count == 3)
                {
                    d[95]++;
                }
                if (count == 4)
                {
                    e1[95]++;
                }
                if (count == 5)
                {
                    f[95]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + curium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[95] += myInt;
                }
                if (count == 1)
                {
                    b[95] += myInt;
                }
                if (count == 2)
                {
                    c[95] += myInt;
                }
                if (count == 3)
                {
                    d[95] += myInt;
                }
                if (count == 4)
                {
                    e1[95] += myInt;
                }
                if (count == 5)
                {
                    f[95] += myInt;
                }
            }

        }

        private void terbium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(TerbiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + terbium.Text;
                if (count == 0)
                {
                    a[64]++;
                }
                if (count == 1)
                {
                    b[64]++;
                }
                if (count == 2)
                {
                    c[64]++;
                }
                if (count == 3)
                {
                    d[64]++;
                }
                if (count == 4)
                {
                    e1[64]++;
                }
                if (count == 5)
                {
                    f[64]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + terbium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[64] += myInt;
                }
                if (count == 1)
                {
                    b[64] += myInt;
                }
                if (count == 2)
                {
                    c[64] += myInt;
                }
                if (count == 3)
                {
                    d[64] += myInt;
                }
                if (count == 4)
                {
                    e1[64] += myInt;
                }
                if (count == 5)
                {
                    f[64] += myInt;
                }
            }

        }

        private void gadolinium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(GadoliniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + gadolinium.Text;
                if (count == 0)
                {
                    a[63]++;
                }
                if (count == 1)
                {
                    b[63]++;
                }
                if (count == 2)
                {
                    c[63]++;
                }
                if (count == 3)
                {
                    d[63]++;
                }
                if (count == 4)
                {
                    e1[63]++;
                }
                if (count == 5)
                {
                    f[63]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + gadolinium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[63] += myInt;
                }
                if (count == 1)
                {
                    b[63] += myInt;
                }
                if (count == 2)
                {
                    c[63] += myInt;
                }
                if (count == 3)
                {
                    d[63] += myInt;
                }
                if (count == 4)
                {
                    e1[63] += myInt;
                }
                if (count == 5)
                {
                    f[63] += myInt;
                }

            }

        }

        private void americium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(AmericiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + americium.Text;
                if (count == 0)
                {
                    a[94]++;
                }
                if (count == 1)
                {
                    b[94]++;
                }
                if (count == 2)
                {
                    c[94]++;
                }
                if (count == 3)
                {
                    d[94]++;
                }
                if (count == 4)
                {
                    e1[94]++;
                }
                if (count == 5)
                {
                    f[94]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + americium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[94] += myInt;
                }
                if (count == 1)
                {
                    b[94] += myInt;
                }
                if (count == 2)
                {
                    c[94] += myInt;
                }
                if (count == 3)
                {
                    d[94] += myInt;
                }
                if (count == 4)
                {
                    e1[94] += myInt;
                }
                if (count == 5)
                {
                    f[94] += myInt;
                }

            }

        }

        private void plutonium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(PlutoniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + plutonium.Text;
                if (count == 0)
                {
                    a[93]++;
                }
                if (count == 1)
                {
                    b[93]++;
                }
                if (count == 2)
                {
                    c[93]++;
                }
                if (count == 3)
                {
                    d[93]++;
                }
                if (count == 4)
                {
                    e1[93]++;
                }
                if (count == 5)
                {
                    f[93]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + plutonium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[93] += myInt;
                }
                if (count == 1)
                {
                    b[93] += myInt;
                }
                if (count == 2)
                {
                    c[93] += myInt;
                }
                if (count == 3)
                {
                    d[93] += myInt;
                }
                if (count == 4)
                {
                    e1[93] += myInt;
                }
                if (count == 5)
                {
                    f[93] += myInt;
                }
            }

        }

        private void europium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(EuropiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + europium.Text;
                if (count == 0)
                {
                    a[62]++;
                }
                if (count == 1)
                {
                    b[62]++;
                }
                if (count == 2)
                {
                    c[62]++;
                }
                if (count == 3)
                {
                    d[62]++;
                }
                if (count == 4)
                {
                    e1[62]++;
                }
                if (count == 5)
                {
                    f[62]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + europium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[62] += myInt;
                }
                if (count == 1)
                {
                    b[62] += myInt;
                }
                if (count == 2)
                {
                    c[62] += myInt;
                }
                if (count == 3)
                {
                    d[62] += myInt;
                }
                if (count == 4)
                {
                    e1[62] += myInt;
                }
                if (count == 5)
                {
                    f[62] += myInt;
                }
            }

        }

        private void samarium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(SamariumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + samarium.Text;
                if (count == 0)
                {
                    a[61]++;
                }
                if (count == 1)
                {
                    b[61]++;
                }
                if (count == 2)
                {
                    c[61]++;
                }
                if (count == 3)
                {
                    d[61]++;
                }
                if (count == 4)
                {
                    e1[61]++;
                }
                if (count == 5)
                {
                    f[61]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + samarium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[61] += myInt;
                }
                if (count == 1)
                {
                    b[61] += myInt;
                }
                if (count == 2)
                {
                    c[61] += myInt;
                }
                if (count == 3)
                {
                    d[61] += myInt;
                }
                if (count == 4)
                {
                    e1[61] += myInt;
                }
                if (count == 5)
                {
                    f[61] += myInt;
                }
            }

        }

        private void neptunium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(NeptuniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + neptunium.Text;
                if (count == 0)
                {
                    a[92]++;
                }
                if (count == 1)
                {
                    b[92]++;
                }
                if (count == 2)
                {
                    c[92]++;
                }
                if (count == 3)
                {
                    d[92]++;
                }
                if (count == 4)
                {
                    e1[92]++;
                }
                if (count == 5)
                {
                    f[92]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + neptunium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[92] += myInt;
                }
                if (count == 1)
                {
                    b[92] += myInt;
                }
                if (count == 2)
                {
                    c[92] += myInt;
                }
                if (count == 3)
                {
                    d[92] += myInt;
                }
                if (count == 4)
                {
                    e1[92] += myInt;
                }
                if (count == 5)
                {
                    f[92] += myInt;
                }
            }

        }

        private void uranium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(UraniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + uranium.Text;
                if (count == 0)
                {
                    a[91]++;
                }
                if (count == 1)
                {
                    b[91]++;
                }
                if (count == 2)
                {
                    c[91]++;
                }
                if (count == 3)
                {
                    d[91]++;
                }
                if (count == 4)
                {
                    e1[91]++;
                }
                if (count == 5)
                {
                    f[91]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + uranium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[91] += myInt;
                }
                if (count == 1)
                {
                    b[91] += myInt;
                }
                if (count == 2)
                {
                    c[91] += myInt;
                }
                if (count == 3)
                {
                    d[91] += myInt;
                }
                if (count == 4)
                {
                    e1[91] += myInt;
                }
                if (count == 5)
                {
                    f[91] += myInt;
                }

            }

        }

        private void promethium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(PromethiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + promethium.Text;
                if (count == 0)
                {
                    a[60]++;
                }
                if (count == 1)
                {
                    b[60]++;
                }
                if (count == 2)
                {
                    c[60]++;
                }
                if (count == 3)
                {
                    d[60]++;
                }
                if (count == 4)
                {
                    e1[60]++;
                }
                if (count == 5)
                {
                    f[60]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + promethium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[60] += myInt;
                }
                if (count == 1)
                {
                    b[60] += myInt;
                }
                if (count == 2)
                {
                    c[60] += myInt;
                }
                if (count == 3)
                {
                    d[60] += myInt;
                }
                if (count == 4)
                {
                    e1[60] += myInt;
                }
                if (count == 5)
                {
                    f[60] += myInt;
                }
            }

        }

        private void neondymium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(NeodymiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + neodymium.Text;
                if (count == 0)
                {
                    a[59]++;
                }
                if (count == 1)
                {
                    b[59]++;
                }
                if (count == 2)
                {
                    c[59]++;
                }
                if (count == 3)
                {
                    d[59]++;
                }
                if (count == 4)
                {
                    e1[59]++;
                }
                if (count == 5)
                {
                    f[59]++;
                }

            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + neodymium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);

                if (count == 0)
                {
                    a[59] += myInt;
                }
                if (count == 1)
                {
                    b[59] += myInt;
                }
                if (count == 2)
                {
                    c[59] += myInt;
                }
                if (count == 3)
                {
                    d[59] += myInt;
                }
                if (count == 4)
                {
                    e1[59] += myInt;
                }
                if (count == 5)
                {
                    f[59] += myInt;
                }
            }

        }

        private void protactinium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ProtactiniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + protactinium.Text;
                if (count == 0)
                {
                    a[90]++;
                }
                if (count == 1)
                {
                    b[90]++;
                }
                if (count == 2)
                {
                    c[90]++;
                }
                if (count == 3)
                {
                    d[90]++;
                }
                if (count == 4)
                {
                    e1[90]++;
                }
                if (count == 5)
                {
                    f[90]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + protactinium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[90] += myInt;
                }
                if (count == 1)
                {
                    b[90] += myInt;
                }
                if (count == 2)
                {
                    c[90] += myInt;
                }
                if (count == 3)
                {
                    d[90] += myInt;
                }
                if (count == 4)
                {
                    e1[90] += myInt;
                }
                if (count == 5)
                {
                    f[90] += myInt;
                }
            }

        }

        private void thorium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ThoriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + thorium.Text;
                if (count == 0)
                {
                    a[89]++;
                }
                if (count == 1)
                {
                    b[89]++;
                }
                if (count == 2)
                {
                    c[89]++;
                }
                if (count == 3)
                {
                    d[89]++;
                }
                if (count == 4)
                {
                    e1[89]++;
                }
                if (count == 5)
                {
                    f[89]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + thorium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[89] += myInt;
                }
                if (count == 1)
                {
                    b[89] += myInt;
                }
                if (count == 2)
                {
                    c[89] += myInt;
                }
                if (count == 3)
                {
                    d[89] += myInt;
                }
                if (count == 4)
                {
                    e1[89] += myInt;
                }
                if (count == 5)
                {
                    f[89] += myInt;
                }
            }

        }

        private void prasedymium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(PraseodymiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + praseodymium.Text;
                if (count == 0)
                {
                    a[58]++;
                }
                if (count == 1)
                {
                    b[58]++;
                }
                if (count == 2)
                {
                    c[58]++;
                }
                if (count == 3)
                {
                    d[58]++;
                }
                if (count == 4)
                {
                    e1[58]++;
                }
                if (count == 5)
                {
                    f[58]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + praseodymium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[58] += myInt;
                }
                if (count == 1)
                {
                    b[58] += myInt;
                }
                if (count == 2)
                {
                    c[58] += myInt;
                }
                if (count == 3)
                {
                    d[58] += myInt;
                }
                if (count == 4)
                {
                    e1[58] += myInt;
                }
                if (count == 5)
                {
                    f[58] += myInt;
                }
            }

        }

        private void cerium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CeriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + cerium.Text;
                if (count == 0)
                {
                    a[57]++;
                }
                if (count == 1)
                {
                    b[57]++;
                }
                if (count == 2)
                {
                    c[57]++;
                }
                if (count == 3)
                {
                    d[57]++;
                }
                if (count == 4)
                {
                    e1[57]++;
                }
                if (count == 5)
                {
                    f[57]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + cerium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[57] += myInt;
                }
                if (count == 1)
                {
                    b[57] += myInt;
                }
                if (count == 2)
                {
                    c[57] += myInt;
                }
                if (count == 3)
                {
                    d[57] += myInt;
                }
                if (count == 4)
                {
                    e1[57] += myInt;
                }
                if (count == 5)
                {
                    f[57] += myInt;
                }
            }

        }

        private void actinium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ActiniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + actinium.Text;
                if (count == 0)
                {
                    a[88]++;
                }
                if (count == 1)
                {
                    b[88]++;
                }
                if (count == 2)
                {
                    c[88]++;
                }
                if (count == 3)
                {
                    d[88]++;
                }
                if (count == 4)
                {
                    e1[88]++;
                }
                if (count == 5)
                {
                    f[88]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + actinium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[88] += myInt;
                }
                if (count == 1)
                {
                    b[88] += myInt;
                }
                if (count == 2)
                {
                    c[88] += myInt;
                }
                if (count == 3)
                {
                    d[88] += myInt;
                }
                if (count == 4)
                {
                    e1[88] += myInt;
                }
                if (count == 5)
                {
                    f[88] += myInt;
                }
            }

        }

        private void lanthanum_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(LanthanumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lanthanum.Text;
                if (count == 0)
                {
                    a[56]++;
                }
                if (count == 1)
                {
                    b[56]++;
                }
                if (count == 2)
                {
                    c[56]++;
                }
                if (count == 3)
                {
                    d[56]++;
                }
                if (count == 4)
                {
                    e1[56]++;
                }
                if (count == 5)
                {
                    f[56]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lanthanum.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[56] += myInt;
                }
                if (count == 1)
                {
                    b[56] += myInt;
                }
                if (count == 2)
                {
                    c[56] += myInt;
                }
                if (count == 3)
                {
                    d[56] += myInt;
                }
                if (count == 4)
                {
                    e1[56] += myInt;
                }
                if (count == 5)
                {
                    f[56] += myInt;
                }
            }

        }

        private void helium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(HeliumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + helium.Text;
                if (count == 0)
                {
                    a[1]++;
                }
                if (count == 1)
                {
                    b[1]++;
                }
                if (count == 2)
                {
                    c[1]++;
                }
                if (count == 3)
                {
                    d[1]++;
                }
                if (count == 4)
                {
                    e1[1]++;
                }
                if (count == 5)
                {
                    f[1]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + helium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[1] += myInt;
                }
                if (count == 1)
                {
                    b[1] += myInt;
                }
                if (count == 2)
                {
                    c[1] += myInt;
                }
                if (count == 3)
                {
                    d[1] += myInt;
                }
                if (count == 4)
                {
                    e1[1] += myInt;
                }
                if (count == 5)
                {
                    f[1] += myInt;
                }
            }

        }

        private void ununoctium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(UnunoctiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ununoctium.Text;
                if (count == 0)
                {
                    a[117]++;
                }
                if (count == 1)
                {
                    b[117]++;
                }
                if (count == 2)
                {
                    c[117]++;
                }
                if (count == 3)
                {
                    d[117]++;
                }
                if (count == 4)
                {
                    e1[117]++;
                }
                if (count == 5)
                {
                    f[117]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ununoctium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[117] += myInt;
                }
                if (count == 1)
                {
                    b[117] += myInt;
                }
                if (count == 2)
                {
                    c[117] += myInt;
                }
                if (count == 3)
                {
                    d[117] += myInt;
                }
                if (count == 4)
                {
                    e1[117] += myInt;
                }
                if (count == 5)
                {
                    f[117] += myInt;
                }
            }

        }

        private void ununseptium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(UnunseptiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ununseptium.Text;
                if (count == 0)
                {
                    a[116]++;
                }
                if (count == 1)
                {
                    b[116]++;
                }
                if (count == 2)
                {
                    c[116]++;
                }
                if (count == 3)
                {
                    d[116]++;
                }
                if (count == 4)
                {
                    e1[116]++;
                }
                if (count == 5)
                {
                    f[116]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ununseptium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[116] += myInt;
                }
                if (count == 1)
                {
                    b[116] += myInt;
                }
                if (count == 2)
                {
                    c[116] += myInt;
                }
                if (count == 3)
                {
                    d[116] += myInt;
                }
                if (count == 4)
                {
                    e1[116] += myInt;
                }
                if (count == 5)
                {
                    f[116] += myInt;
                }
            }

        }

        private void radon_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(RadonMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + radon.Text;
                if (count == 0)
                {
                    a[85]++;
                }
                if (count == 1)
                {
                    b[85]++;
                }
                if (count == 2)
                {
                    c[85]++;
                }
                if (count == 3)
                {
                    d[85]++;
                }
                if (count == 4)
                {
                    e1[85]++;
                }
                if (count == 5)
                {
                    f[85]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + radon.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[85] += myInt;
                }
                if (count == 1)
                {
                    b[85] += myInt;
                }
                if (count == 2)
                {
                    c[85] += myInt;
                }
                if (count == 3)
                {
                    d[85] += myInt;
                }
                if (count == 4)
                {
                    e1[85] += myInt;
                }
                if (count == 5)
                {
                    f[85] += myInt;
                }
            }

        }

        private void astatine_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(AstatineMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + astatine.Text;
                if (count == 0)
                {
                    a[84]++;
                }
                if (count == 1)
                {
                    b[84]++;
                }
                if (count == 2)
                {
                    c[84]++;
                }
                if (count == 3)
                {
                    d[84]++;
                }
                if (count == 4)
                {
                    e1[84]++;
                }
                if (count == 5)
                {
                    f[84]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + astatine.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[84] += myInt;
                }
                if (count == 1)
                {
                    b[84] += myInt;
                }
                if (count == 2)
                {
                    c[84] += myInt;
                }
                if (count == 3)
                {
                    d[84] += myInt;
                }
                if (count == 4)
                {
                    e1[84] += myInt;
                }
                if (count == 5)
                {
                    f[84] += myInt;
                }
            }

        }

        private void xenon_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(XenonMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + xenon.Text;
                if (count == 0)
                {
                    a[53]++;
                }
                if (count == 1)
                {
                    b[53]++;
                }
                if (count == 2)
                {
                    c[53]++;
                }
                if (count == 3)
                {
                    d[53]++;
                }
                if (count == 4)
                {
                    e1[53]++;
                }
                if (count == 5)
                {
                    f[53]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Molybdenum.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[53] += myInt;
                }
                if (count == 1)
                {
                    b[53] += myInt;
                }
                if (count == 2)
                {
                    c[53] += myInt;
                }
                if (count == 3)
                {
                    d[53] += myInt;
                }
                if (count == 4)
                {
                    e1[53] += myInt;
                }
                if (count == 5)
                {
                    f[53] += myInt;
                }

            }

        }

        private void iodine_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(IodineMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + iodine.Text;
                if (count == 0)
                {
                    a[52]++;
                }
                if (count == 1)
                {
                    b[52]++;
                }
                if (count == 2)
                {
                    c[52]++;
                }
                if (count == 3)
                {
                    d[52]++;
                }
                if (count == 4)
                {
                    e1[52]++;
                }
                if (count == 5)
                {
                    f[52]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + iodine.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[52] += myInt;
                }
                if (count == 1)
                {
                    b[52] += myInt;
                }
                if (count == 2)
                {
                    c[52] += myInt;
                }
                if (count == 3)
                {
                    d[52] += myInt;
                }
                if (count == 4)
                {
                    e1[52] += myInt;
                }
                if (count == 5)
                {
                    f[52] += myInt;
                }

            }

        }

        private void livermorium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(LivermoriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + livermorium.Text;
                if (count == 0)
                {
                    a[115]++;
                }
                if (count == 1)
                {
                    b[115]++;
                }
                if (count == 2)
                {
                    c[115]++;
                }
                if (count == 3)
                {
                    d[115]++;
                }
                if (count == 4)
                {
                    e1[115]++;
                }
                if (count == 5)
                {
                    f[115]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + livermorium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[115] += myInt;
                }
                if (count == 1)
                {
                    b[115] += myInt;
                }
                if (count == 2)
                {
                    c[115] += myInt;
                }
                if (count == 3)
                {
                    d[115] += myInt;
                }
                if (count == 4)
                {
                    e1[115] += myInt;
                }
                if (count == 5)
                {
                    f[115] += myInt;
                }

            }

        }

        private void ununpentium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(UnunpentiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ununpentium.Text;
                if (count == 0)
                {
                    a[114]++;
                }
                if (count == 1)
                {
                    b[114]++;
                }
                if (count == 2)
                {
                    c[114]++;
                }
                if (count == 3)
                {
                    d[114]++;
                }
                if (count == 4)
                {
                    e1[114]++;
                }
                if (count == 5)
                {
                    f[114]++;
                }

            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ununpentium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[114] += myInt;
                }
                if (count == 1)
                {
                    b[114] += myInt;
                }
                if (count == 2)
                {
                    c[114] += myInt;
                }
                if (count == 3)
                {
                    d[114] += myInt;
                }
                if (count == 4)
                {
                    e1[114] += myInt;
                }
                if (count == 5)
                {
                    f[114] += myInt;
                }
            }

        }

        private void polonium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(PoloniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + polonium.Text;
                if (count == 0)
                {
                    a[83]++;
                }
                if (count == 1)
                {
                    b[83]++;
                }
                if (count == 2)
                {
                    c[83]++;
                }
                if (count == 3)
                {
                    d[83]++;
                }
                if (count == 4)
                {
                    e1[83]++;
                }
                if (count == 5)
                {
                    f[83]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + polonium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[83] += myInt;
                }
                if (count == 1)
                {
                    b[83] += myInt;
                }
                if (count == 2)
                {
                    c[83] += myInt;
                }
                if (count == 3)
                {
                    d[83] += myInt;
                }
                if (count == 4)
                {
                    e1[83] += myInt;
                }
                if (count == 5)
                {
                    f[83] += myInt;
                }
            }

        }

        private void bismuth_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(BismuthMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Bismuth.Text;
                if (count == 0)
                {
                    a[82]++;
                }
                if (count == 1)
                {
                    b[82]++;
                }
                if (count == 2)
                {
                    c[82]++;
                }
                if (count == 3)
                {
                    d[82]++;
                }
                if (count == 4)
                {
                    e1[82]++;
                }
                if (count == 5)
                {
                    f[82]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Bismuth.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[82] += myInt;
                }
                if (count == 1)
                {
                    b[82] += myInt;
                }
                if (count == 2)
                {
                    c[82] += myInt;
                }
                if (count == 3)
                {
                    d[82] += myInt;
                }
                if (count == 4)
                {
                    e1[82] += myInt;
                }
                if (count == 5)
                {
                    f[82] += myInt;
                }

            }

        }

        private void tellurium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(TelluriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + tellurium.Text;
                if (count == 0)
                {
                    a[51]++;
                }
                if (count == 1)
                {
                    b[51]++;
                }
                if (count == 2)
                {
                    c[51]++;
                }
                if (count == 3)
                {
                    d[51]++;
                }
                if (count == 4)
                {
                    e1[51]++;
                }
                if (count == 5)
                {
                    f[51]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + tellurium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[51] += myInt;
                }
                if (count == 1)
                {
                    b[51] += myInt;
                }
                if (count == 2)
                {
                    c[51] += myInt;
                }
                if (count == 3)
                {
                    d[51] += myInt;
                }
                if (count == 4)
                {
                    e1[51] += myInt;
                }
                if (count == 5)
                {
                    f[51] += myInt;
                }

            }

        }

        private void antimony_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(AntimonyMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + antimony.Text;
                if (count == 0)
                {
                    a[50]++;
                }
                if (count == 1)
                {
                    b[50]++;
                }
                if (count == 2)
                {
                    c[50]++;
                }
                if (count == 3)
                {
                    d[50]++;
                }
                if (count == 4)
                {
                    e1[50]++;
                }
                if (count == 5)
                {
                    f[50]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + antimony.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[50] += myInt;
                }
                if (count == 1)
                {
                    b[50] += myInt;
                }
                if (count == 2)
                {
                    c[50] += myInt;
                }
                if (count == 3)
                {
                    d[50] += myInt;
                }
                if (count == 4)
                {
                    e1[50] += myInt;
                }
                if (count == 5)
                {
                    f[50] += myInt;
                }
            }

        }

        private void flerovium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(FleroviumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Flerovium.Text;
                if (count == 0)
                {
                    a[113]++;
                }
                if (count == 1)
                {
                    b[113]++;
                }
                if (count == 2)
                {
                    c[113]++;
                }
                if (count == 3)
                {
                    d[113]++;
                }
                if (count == 4)
                {
                    e1[113]++;
                }
                if (count == 5)
                {
                    f[113]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Flerovium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[113] += myInt;
                }
                if (count == 1)
                {
                    b[113] += myInt;
                }
                if (count == 2)
                {
                    c[113] += myInt;
                }
                if (count == 3)
                {
                    d[113] += myInt;
                }
                if (count == 4)
                {
                    e1[113] += myInt;
                }
                if (count == 5)
                {
                    f[113] += myInt;
                }
            }

        }

        private void ununtrium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(UnuntriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ununtrium.Text;
                if (count == 0)
                {
                    a[112]++;
                }
                if (count == 1)
                {
                    b[112]++;
                }
                if (count == 2)
                {
                    c[112]++;
                }
                if (count == 3)
                {
                    d[112]++;
                }
                if (count == 4)
                {
                    e1[112]++;
                }
                if (count == 5)
                {
                    f[112]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + ununtrium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[112] += myInt;
                }
                if (count == 1)
                {
                    b[112] += myInt;
                }
                if (count == 2)
                {
                    c[112] += myInt;
                }
                if (count == 3)
                {
                    d[112] += myInt;
                }
                if (count == 4)
                {
                    e1[112] += myInt;
                }
                if (count == 5)
                {
                    f[112] += myInt;
                }
            }

        }

        private void lead_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(LeadMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lead.Text;

            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lead.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[81] += myInt;
                }
                if (count == 1)
                {
                    b[81] += myInt;
                }
                if (count == 2)
                {
                    c[81] += myInt;
                }
                if (count == 3)
                {
                    d[81] += myInt;
                }
                if (count == 4)
                {
                    e1[81] += myInt;
                }
                if (count == 5)
                {
                    f[81] += myInt;
                }
            }
        }

        private void thallium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ThalliumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + thallium.Text;
                if (count == 0)
                {
                    a[80]++;
                }
                if (count == 1)
                {
                    b[80]++;
                }
                if (count == 2)
                {
                    c[80]++;
                }
                if (count == 3)
                {
                    d[80]++;
                }
                if (count == 4)
                {
                    e1[80]++;
                }
                if (count == 5)
                {
                    f[80]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + thallium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[80] += myInt;
                }
                if (count == 1)
                {
                    b[80] += myInt;
                }
                if (count == 2)
                {
                    c[80] += myInt;
                }
                if (count == 3)
                {
                    d[80] += myInt;
                }
                if (count == 4)
                {
                    e1[80] += myInt;
                }
                if (count == 5)
                {
                    f[80] += myInt;
                }
            }

        }

        private void tin_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(TinMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + tin.Text;
                if (count == 0)
                {
                    a[49]++;
                }
                if (count == 1)
                {
                    b[49]++;
                }
                if (count == 2)
                {
                    c[49]++;
                }
                if (count == 3)
                {
                    d[49]++;
                }
                if (count == 4)
                {
                    e1[49]++;
                }
                if (count == 5)
                {
                    f[49]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + tin.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[49] += myInt;
                }
                if (count == 1)
                {
                    b[49] += myInt;
                }
                if (count == 2)
                {
                    c[49] += myInt;
                }
                if (count == 3)
                {
                    d[49] += myInt;
                }
                if (count == 4)
                {
                    e1[49] += myInt;
                }
                if (count == 5)
                {
                    f[49] += myInt;
                }

            }

        }

        private void indium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(IndiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + indium.Text;
                if (count == 0)
                {
                    a[48]++;
                }
                if (count == 1)
                {
                    b[48]++;
                }
                if (count == 2)
                {
                    c[48]++;
                }
                if (count == 3)
                {
                    d[48]++;
                }
                if (count == 4)
                {
                    e1[48]++;
                }
                if (count == 5)
                {
                    f[48]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + indium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[48] += myInt;
                }
                if (count == 1)
                {
                    b[48] += myInt;
                }
                if (count == 2)
                {
                    c[48] += myInt;
                }
                if (count == 3)
                {
                    d[48] += myInt;
                }
                if (count == 4)
                {
                    e1[48] += myInt;
                }
                if (count == 5)
                {
                    f[48] += myInt;
                }

            }

        }

        private void krypton_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(KryptonMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + krypton.Text;
                if (count == 0)
                {
                    a[35]++;
                }
                if (count == 1)
                {
                    b[35]++;
                }
                if (count == 2)
                {
                    c[35]++;
                }
                if (count == 3)
                {
                    d[35]++;
                }
                if (count == 4)
                {
                    e1[35]++;
                }
                if (count == 5)
                {
                    f[35]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + krypton.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[35] += myInt;
                }
                if (count == 1)
                {
                    b[35] += myInt;
                }
                if (count == 2)
                {
                    c[35] += myInt;
                }
                if (count == 3)
                {
                    d[35] += myInt;
                }
                if (count == 4)
                {
                    e1[35] += myInt;
                }
                if (count == 5)
                {
                    f[35] += myInt;
                }
            }

        }

        private void bromine_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(BromineMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + bromine.Text;
                if (count == 0)
                {
                    a[34]++;
                }
                if (count == 1)
                {
                    b[34]++;
                }
                if (count == 2)
                {
                    c[34]++;
                }
                if (count == 3)
                {
                    d[34]++;
                }
                if (count == 4)
                {
                    e1[34]++;
                }
                if (count == 5)
                {
                    f[34]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + bromine.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[34] += myInt;
                }
                if (count == 1)
                {
                    b[34] += myInt;
                }
                if (count == 2)
                {
                    c[34] += myInt;
                }
                if (count == 3)
                {
                    d[34] += myInt;
                }
                if (count == 4)
                {
                    e1[34] += myInt;
                }
                if (count == 5)
                {
                    f[34] += myInt;
                }
            }

        }

        private void argon_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ArgonMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + argon.Text;
                if (count == 0)
                {
                    a[17]++;
                }
                if (count == 1)
                {
                    b[17]++;
                }
                if (count == 2)
                {
                    c[17]++;
                }
                if (count == 3)
                {
                    d[17]++;
                }
                if (count == 4)
                {
                    e1[17]++;
                }
                if (count == 5)
                {
                    f[17]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + argon.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[17] += myInt;
                }
                if (count == 1)
                {
                    b[17] += myInt;
                }
                if (count == 2)
                {
                    c[17] += myInt;
                }
                if (count == 3)
                {
                    d[17] += myInt;
                }
                if (count == 4)
                {
                    e1[17] += myInt;
                }
                if (count == 5)
                {
                    f[17] += myInt;
                }
            }

        }

        private void chlorine_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ChlorineMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + chlorine.Text;
                if (count == 0)
                {
                    a[16]++;
                }
                if (count == 1)
                {
                    b[16]++;
                }
                if (count == 2)
                {
                    c[16]++;
                }
                if (count == 3)
                {
                    d[16]++;
                }
                if (count == 4)
                {
                    e1[16]++;
                }
                if (count == 5)
                {
                    f[16]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + chlorine.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[16] += myInt;
                }
                if (count == 1)
                {
                    b[16] += myInt;
                }
                if (count == 2)
                {
                    c[16] += myInt;
                }
                if (count == 3)
                {
                    d[16] += myInt;
                }
                if (count == 4)
                {
                    e1[16] += myInt;
                }
                if (count == 5)
                {
                    f[16] += myInt;
                }
            }

        }

        private void neon_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(NeonMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + neon.Text;
                if (count == 0)
                {
                    a[9]++;
                }
                if (count == 1)
                {
                    b[9]++;
                }
                if (count == 2)
                {
                    c[9]++;
                }
                if (count == 3)
                {
                    d[9]++;
                }
                if (count == 4)
                {
                    e1[9]++;
                }
                if (count == 5)
                {
                    f[9]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + neon.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[9] += myInt;
                }
                if (count == 1)
                {
                    b[9] += myInt;
                }
                if (count == 2)
                {
                    c[9] += myInt;
                }
                if (count == 3)
                {
                    d[9] += myInt;
                }
                if (count == 4)
                {
                    e1[9] += myInt;
                }
                if (count == 5)
                {
                    f[9] += myInt;
                }
            }

        }

        private void flourine_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(FluorineMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + flourine.Text;
                if (count == 0)
                {
                    a[8]++;
                }
                if (count == 1)
                {
                    b[8]++;
                }
                if (count == 2)
                {
                    c[8]++;
                }
                if (count == 3)
                {
                    d[8]++;
                }
                if (count == 4)
                {
                    e1[8]++;
                }
                if (count == 5)
                {
                    f[8]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + flourine.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[8] += myInt;
                }
                if (count == 1)
                {
                    b[8] += myInt;
                }
                if (count == 2)
                {
                    c[8] += myInt;
                }
                if (count == 3)
                {
                    d[8] += myInt;
                }
                if (count == 4)
                {
                    e1[8] += myInt;
                }
                if (count == 5)
                {
                    f[8] += myInt;
                }
            }

        }

        private void selenium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(SeleniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + selenium.Text;
                if (count == 0)
                {
                    a[33]++;
                }
                if (count == 1)
                {
                    b[33]++;
                }
                if (count == 2)
                {
                    c[33]++;
                }
                if (count == 3)
                {
                    d[33]++;
                }
                if (count == 4)
                {
                    e1[33]++;
                }
                if (count == 5)
                {
                    f[33]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + selenium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[33] += myInt;
                }
                if (count == 1)
                {
                    b[33] += myInt;
                }
                if (count == 2)
                {
                    c[33] += myInt;
                }
                if (count == 3)
                {
                    d[33] += myInt;
                }
                if (count == 4)
                {
                    e1[33] += myInt;
                }
                if (count == 5)
                {
                    f[33] += myInt;
                }

            }

        }

        private void arsenic_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ArsenicMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + arsenic.Text;
                if (count == 0)
                {
                    a[32]++;
                }
                if (count == 1)
                {
                    b[32]++;
                }
                if (count == 2)
                {
                    c[32]++;
                }
                if (count == 3)
                {
                    d[32]++;
                }
                if (count == 4)
                {
                    e1[32]++;
                }
                if (count == 5)
                {
                    f[32]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + arsenic.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[32] += myInt;
                }
                if (count == 1)
                {
                    b[32] += myInt;
                }
                if (count == 2)
                {
                    c[32] += myInt;
                }
                if (count == 3)
                {
                    d[32] += myInt;
                }
                if (count == 4)
                {
                    e1[32] += myInt;
                }
                if (count == 5)
                {
                    f[32] += myInt;
                }

            }

        }

        private void sulfur_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(SulfurMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + sulfur.Text;
                if (count == 0)
                {
                    a[7]++;
                }
                if (count == 1)
                {
                    b[7]++;
                }
                if (count == 2)
                {
                    c[7]++;
                }
                if (count == 3)
                {
                    d[7]++;
                }
                if (count == 4)
                {
                    e1[7]++;
                }
                if (count == 5)
                {
                    f[7]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + sulfur.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[7] += myInt;
                }
                if (count == 1)
                {
                    b[7] += myInt;
                }
                if (count == 2)
                {
                    c[7] += myInt;
                }
                if (count == 3)
                {
                    d[7] += myInt;
                }
                if (count == 4)
                {
                    e1[7] += myInt;
                }
                if (count == 5)
                {
                    f[7] += myInt;
                }
            }

        }

        private void phosporous_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(PhosphorusMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + phosporous.Text;
                if (count == 0)
                {
                    a[14]++;
                }
                if (count == 1)
                {
                    b[14]++;
                }
                if (count == 2)
                {
                    c[14]++;
                }
                if (count == 3)
                {
                    d[14]++;
                }
                if (count == 4)
                {
                    e1[14]++;
                }
                if (count == 5)
                {
                    f[14]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + phosporous.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[14] += myInt;
                }
                if (count == 1)
                {
                    b[14] += myInt;
                }
                if (count == 2)
                {
                    c[14] += myInt;
                }
                if (count == 3)
                {
                    d[14] += myInt;
                }
                if (count == 4)
                {
                    e1[14] += myInt;
                }
                if (count == 5)
                {
                    f[14] += myInt;
                }
            }

        }

        private void oxygen_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(OxygenMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + oxygen.Text;
                if (count == 0)
                {
                    a[7]++;
                }
                if (count == 1)
                {
                    b[7]++;
                }
                if (count == 2)
                {
                    c[7]++;
                }
                if (count == 3)
                {
                    d[7]++;
                }
                if (count == 4)
                {
                    e1[7]++;
                }
                if (count == 5)
                {
                    f[7]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + oxygen.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[7] += myInt;
                }
                if (count == 1)
                {
                    b[7] += myInt;
                }
                if (count == 2)
                {
                    c[7] += myInt;
                }
                if (count == 3)
                {
                    d[7] += myInt;
                }
                if (count == 4)
                {
                    e1[7] += myInt;
                }
                if (count == 5)
                {
                    f[7] += myInt;
                }
            }

        }

        private void nitrogen_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(NitrogenMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + nitrogen.Text;
                if (count == 0)
                {
                    a[6]++;
                }
                if (count == 1)
                {
                    b[6]++;
                }
                if (count == 2)
                {
                    c[6]++;
                }
                if (count == 3)
                {
                    d[6]++;
                }
                if (count == 4)
                {
                    e1[6]++;
                }
                if (count == 5)
                {
                    f[6]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + nitrogen.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[6] += myInt;
                }
                if (count == 1)
                {
                    b[6] += myInt;
                }
                if (count == 2)
                {
                    c[6] += myInt;
                }
                if (count == 3)
                {
                    d[6] += myInt;
                }
                if (count == 4)
                {
                    e1[6] += myInt;
                }
                if (count == 5)
                {
                    f[6] += myInt;
                }
            }

        }

        private void germanium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(GermaniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + germanium.Text;
                if (count == 0)
                {
                    a[31]++;
                }
                if (count == 1)
                {
                    b[31]++;
                }
                if (count == 2)
                {
                    c[31]++;
                }
                if (count == 3)
                {
                    d[31]++;
                }
                if (count == 4)
                {
                    e1[31]++;
                }
                if (count == 5)
                {
                    f[31]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + germanium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[31] += myInt;
                }
                if (count == 1)
                {
                    b[31] += myInt;
                }
                if (count == 2)
                {
                    c[31] += myInt;
                }
                if (count == 3)
                {
                    d[31] += myInt;
                }
                if (count == 4)
                {
                    e1[31] += myInt;
                }
                if (count == 5)
                {
                    f[31] += myInt;
                }
            }

        }

        private void gallium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(GalliumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + gallium.Text;
                if (count == 0)
                {
                    a[30]++;
                }
                if (count == 1)
                {
                    b[30]++;
                }
                if (count == 2)
                {
                    c[30]++;
                }
                if (count == 3)
                {
                    d[30]++;
                }
                if (count == 4)
                {
                    e1[30]++;
                }
                if (count == 5)
                {
                    f[30]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + gallium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[30] += myInt;
                }
                if (count == 1)
                {
                    b[30] += myInt;
                }
                if (count == 2)
                {
                    c[30] += myInt;
                }
                if (count == 3)
                {
                    d[30] += myInt;
                }
                if (count == 4)
                {
                    e1[30] += myInt;
                }
                if (count == 5)
                {
                    f[30] += myInt;
                }
            }

        }

        private void silicon_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(SiliconMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + silicon.Text;
                if (count == 0)
                {
                    a[13]++;
                }
                if (count == 1)
                {
                    b[13]++;
                }
                if (count == 2)
                {
                    c[13]++;
                }
                if (count == 3)
                {
                    d[13]++;
                }
                if (count == 4)
                {
                    e1[13]++;
                }
                if (count == 5)
                {
                    f[13]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + silicon.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[13] += myInt;
                }
                if (count == 1)
                {
                    b[13] += myInt;
                }
                if (count == 2)
                {
                    c[13] += myInt;
                }
                if (count == 3)
                {
                    d[13] += myInt;
                }
                if (count == 4)
                {
                    e1[13] += myInt;
                }
                if (count == 5)
                {
                    f[13] += myInt;
                }
            }

        }

        private void aluminum_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(AluminiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + aluminum.Text;
                if (count == 0)
                {
                    a[12]++;
                }
                if (count == 1)
                {
                    b[12]++;
                }
                if (count == 2)
                {
                    c[12]++;
                }
                if (count == 3)
                {
                    d[12]++;
                }
                if (count == 4)
                {
                    e1[12]++;
                }
                if (count == 5)
                {
                    f[12]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + aluminum.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[12] += myInt;
                }
                if (count == 1)
                {
                    b[12] += myInt;
                }
                if (count == 2)
                {
                    c[12] += myInt;
                }
                if (count == 3)
                {
                    d[12] += myInt;
                }
                if (count == 4)
                {
                    e1[12] += myInt;
                }
                if (count == 5)
                {
                    f[12] += myInt;
                }
            }

        }

        private void carbon_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CarbonMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + carbon.Text;
                if (count == 0)
                {
                    a[5]++;
                }
                if (count == 1)
                {
                    b[5]++;
                }
                if (count == 2)
                {
                    c[5]++;
                }
                if (count == 3)
                {
                    d[5]++;
                }
                if (count == 4)
                {
                    e1[5]++;
                }
                if (count == 5)
                {
                    f[5]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + carbon.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[5] += myInt;
                }
                if (count == 1)
                {
                    b[5] += myInt;
                }
                if (count == 2)
                {
                    c[5] += myInt;
                }
                if (count == 3)
                {
                    d[5] += myInt;
                }
                if (count == 4)
                {
                    e1[5] += myInt;
                }
                if (count == 5)
                {
                    f[5] += myInt;
                }
            }

        }

        private void boron_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(BoronMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + boron.Text;
                if (count == 0)
                {
                    a[4]++;
                }
                if (count == 1)
                {
                    b[4]++;
                }
                if (count == 2)
                {
                    c[4]++;
                }
                if (count == 3)
                {
                    d[4]++;
                }
                if (count == 4)
                {
                    e1[4]++;
                }
                if (count == 5)
                {
                    f[4]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + boron.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[4] += myInt;
                }
                if (count == 1)
                {
                    b[4] += myInt;
                }
                if (count == 2)
                {
                    c[4] += myInt;
                }
                if (count == 3)
                {
                    d[4] += myInt;
                }
                if (count == 4)
                {
                    e1[4] += myInt;
                }
                if (count == 5)
                {
                    f[4] += myInt;
                }
            }

        }

        private void copernicium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CoperniciumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + copernicium.Text;
                if (count == 0)
                {
                    a[111]++;
                }
                if (count == 1)
                {
                    b[111]++;
                }
                if (count == 2)
                {
                    c[111]++;
                }
                if (count == 3)
                {
                    d[111]++;
                }
                if (count == 4)
                {
                    e1[111]++;
                }
                if (count == 5)
                {
                    f[111]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + copernicium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[111] += myInt;
                }
                if (count == 1)
                {
                    b[111] += myInt;
                }
                if (count == 2)
                {
                    c[111] += myInt;
                }
                if (count == 3)
                {
                    d[111] += myInt;
                }
                if (count == 4)
                {
                    e1[111] += myInt;
                }
                if (count == 5)
                {
                    f[111] += myInt;
                }
            }

        }

        private void roentgenium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(RoentgeniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + roentgenium.Text;
                if (count == 0)
                {
                    a[110]++;
                }
                if (count == 1)
                {
                    b[110]++;
                }
                if (count == 2)
                {
                    c[110]++;
                }
                if (count == 3)
                {
                    d[110]++;
                }
                if (count == 4)
                {
                    e1[110]++;
                }
                if (count == 5)
                {
                    f[110]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + roentgenium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[110] += myInt;
                }
                if (count == 1)
                {
                    b[110] += myInt;
                }
                if (count == 2)
                {
                    c[110] += myInt;
                }
                if (count == 3)
                {
                    d[110] += myInt;
                }
                if (count == 4)
                {
                    e1[110] += myInt;
                }
                if (count == 5)
                {
                    f[110] += myInt;
                }
            }

        }

        private void mercury_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(MercuryMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + mercury.Text;
                if (count == 0)
                {
                    a[79]++;
                }
                if (count == 1)
                {
                    b[79]++;
                }
                if (count == 2)
                {
                    c[79]++;
                }
                if (count == 3)
                {
                    d[79]++;
                }
                if (count == 4)
                {
                    e1[79]++;
                }
                if (count == 5)
                {
                    f[79]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + mercury.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[79] += myInt;
                }
                if (count == 1)
                {
                    b[79] += myInt;
                }
                if (count == 2)
                {
                    c[79] += myInt;
                }
                if (count == 3)
                {
                    d[79] += myInt;
                }
                if (count == 4)
                {
                    e1[79] += myInt;
                }
                if (count == 5)
                {
                    f[79] += myInt;
                }
            }

        }

        private void gold_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(GoldMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + gold.Text;
                if (count == 0)
                {
                    a[78]++;
                }
                if (count == 1)
                {
                    b[78]++;
                }
                if (count == 2)
                {
                    c[78]++;
                }
                if (count == 3)
                {
                    d[78]++;
                }
                if (count == 4)
                {
                    e1[78]++;
                }
                if (count == 5)
                {
                    f[78]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + gold.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[78] += myInt;
                }
                if (count == 1)
                {
                    b[78] += myInt;
                }
                if (count == 2)
                {
                    c[78] += myInt;
                }
                if (count == 3)
                {
                    d[78] += myInt;
                }
                if (count == 4)
                {
                    e1[78] += myInt;
                }
                if (count == 5)
                {
                    f[78] += myInt;
                }
            }

        }

        private void cadium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CadmiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + cadium.Text;
                if (count == 0)
                {
                    a[47]++;
                }
                if (count == 1)
                {
                    b[47]++;
                }
                if (count == 2)
                {
                    c[47]++;
                }
                if (count == 3)
                {
                    d[47]++;
                }
                if (count == 4)
                {
                    e1[47]++;
                }
                if (count == 5)
                {
                    f[47]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + cadium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[47] += myInt;
                }
                if (count == 1)
                {
                    b[47] += myInt;
                }
                if (count == 2)
                {
                    c[47] += myInt;
                }
                if (count == 3)
                {
                    d[47] += myInt;
                }
                if (count == 4)
                {
                    e1[47] += myInt;
                }
                if (count == 5)
                {
                    f[47] += myInt;
                }

            }

        }

        private void silver_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(SilverMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + silver.Text;
                if (count == 0)
                {
                    a[46]++;
                }
                if (count == 1)
                {
                    b[46]++;
                }
                if (count == 2)
                {
                    c[46]++;
                }
                if (count == 3)
                {
                    d[46]++;
                }
                if (count == 4)
                {
                    e1[46]++;
                }
                if (count == 5)
                {
                    f[46]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + silver.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[46] += myInt;
                }
                if (count == 1)
                {
                    b[46] += myInt;
                }
                if (count == 2)
                {
                    c[46] += myInt;
                }
                if (count == 3)
                {
                    d[46] += myInt;
                }
                if (count == 4)
                {
                    e1[46] += myInt;
                }
                if (count == 5)
                {
                    f[46] += myInt;
                }

            }

        }

        private void zinc_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ZincMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + zinc.Text;
                if (count == 0)
                {
                    a[29]++;
                }
                if (count == 1)
                {
                    b[29]++;
                }
                if (count == 2)
                {
                    c[29]++;
                }
                if (count == 3)
                {
                    d[29]++;
                }
                if (count == 4)
                {
                    e1[29]++;
                }
                if (count == 5)
                {
                    f[29]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + zinc.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[29] += myInt;
                }
                if (count == 1)
                {
                    b[29] += myInt;
                }
                if (count == 2)
                {
                    c[29] += myInt;
                }
                if (count == 3)
                {
                    d[29] += myInt;
                }
                if (count == 4)
                {
                    e1[29] += myInt;
                }
                if (count == 5)
                {
                    f[29] += myInt;
                }

            }

        }

        private void copper_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CopperMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + copper.Text;
                if (count == 0)
                {
                    a[28]++;
                }
                if (count == 1)
                {
                    b[28]++;
                }
                if (count == 2)
                {
                    c[28]++;
                }
                if (count == 3)
                {
                    d[28]++;
                }
                if (count == 4)
                {
                    e1[28]++;
                }
                if (count == 5)
                {
                    f[28]++;
                }

            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + copper.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[28] += myInt;
                }
                if (count == 1)
                {
                    b[28] += myInt;
                }
                if (count == 2)
                {
                    c[28] += myInt;
                }
                if (count == 3)
                {
                    d[28] += myInt;
                }
                if (count == 4)
                {
                    e1[28] += myInt;
                }
                if (count == 5)
                {
                    f[28] += myInt;
                }

            }

        }

        private void darmstadtium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(DarmstadtiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + darmstadtium.Text;
                if (count == 0)
                {
                    a[109]++;
                }
                if (count == 1)
                {
                    b[109]++;
                }
                if (count == 2)
                {
                    c[109]++;
                }
                if (count == 3)
                {
                    d[109]++;
                }
                if (count == 4)
                {
                    e1[109]++;
                }
                if (count == 5)
                {
                    f[109]++;
                }

            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + darmstadtium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[109] += myInt;
                }
                if (count == 1)
                {
                    b[109] += myInt;
                }
                if (count == 2)
                {
                    c[109] += myInt;
                }
                if (count == 3)
                {
                    d[109] += myInt;
                }
                if (count == 4)
                {
                    e1[109] += myInt;
                }
                if (count == 5)
                {
                    f[109] += myInt;
                }
            }

        }

        private void meitnerium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(MeitneriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + meitnerium.Text;
                if (count == 0)
                {
                    a[108]++;
                }
                if (count == 1)
                {
                    b[108]++;
                }
                if (count == 2)
                {
                    c[108]++;
                }
                if (count == 3)
                {
                    d[108]++;
                }
                if (count == 4)
                {
                    e1[108]++;
                }
                if (count == 5)
                {
                    f[108]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + meitnerium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[108] += myInt;
                }
                if (count == 1)
                {
                    b[108] += myInt;
                }
                if (count == 2)
                {
                    c[108] += myInt;
                }
                if (count == 3)
                {
                    d[108] += myInt;
                }
                if (count == 4)
                {
                    e1[108] += myInt;
                }
                if (count == 5)
                {
                    f[108] += myInt;
                }
            }

        }

        private void platinum_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(PlatinumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + platinum.Text;
                if (count == 0)
                {
                    a[77]++;
                }
                if (count == 1)
                {
                    b[77]++;
                }
                if (count == 2)
                {
                    c[77]++;
                }
                if (count == 3)
                {
                    d[77]++;
                }
                if (count == 4)
                {
                    e1[77]++;
                }
                if (count == 5)
                {
                    f[77]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + platinum.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[77] += myInt;
                }
                if (count == 1)
                {
                    b[77] += myInt;
                }
                if (count == 2)
                {
                    c[77] += myInt;
                }
                if (count == 3)
                {
                    d[77] += myInt;
                }
                if (count == 4)
                {
                    e1[77] += myInt;
                }
                if (count == 5)
                {
                    f[77] += myInt;
                }
            }

        }

        private void iridium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(IridiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + iridium.Text;
                if (count == 0)
                {
                    a[76]++;
                }
                if (count == 1)
                {
                    b[76]++;
                }
                if (count == 2)
                {
                    c[76]++;
                }
                if (count == 3)
                {
                    d[76]++;
                }
                if (count == 4)
                {
                    e1[76]++;
                }
                if (count == 5)
                {
                    f[76]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + iridium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[76] += myInt;
                }
                if (count == 1)
                {
                    b[76] += myInt;
                }
                if (count == 2)
                {
                    c[76] += myInt;
                }
                if (count == 3)
                {
                    d[76] += myInt;
                }
                if (count == 4)
                {
                    e1[76] += myInt;
                }
                if (count == 5)
                {
                    f[76] += myInt;
                }
            }

        }

        private void palladium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(PalladiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + palladium.Text;
                if (count == 0)
                {
                    a[45]++;
                }
                if (count == 1)
                {
                    b[45]++;
                }
                if (count == 2)
                {
                    c[45]++;
                }
                if (count == 3)
                {
                    d[45]++;
                }
                if (count == 4)
                {
                    e1[45]++;
                }
                if (count == 5)
                {
                    f[45]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + palladium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[45] += myInt;
                }
                if (count == 1)
                {
                    b[45] += myInt;
                }
                if (count == 2)
                {
                    c[45] += myInt;
                }
                if (count == 3)
                {
                    d[45] += myInt;
                }
                if (count == 4)
                {
                    e1[45] += myInt;
                }
                if (count == 5)
                {
                    f[45] += myInt;
                }
            }

        }

        private void Rhodium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(RhodiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Rhodium.Text;
                if (count == 0)
                {
                    a[44]++;
                }
                if (count == 1)
                {
                    b[44]++;
                }
                if (count == 2)
                {
                    c[44]++;
                }
                if (count == 3)
                {
                    d[44]++;
                }
                if (count == 4)
                {
                    e1[44]++;
                }
                if (count == 5)
                {
                    f[44]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Rhodium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[44] += myInt;
                }
                if (count == 1)
                {
                    b[44] += myInt;
                }
                if (count == 2)
                {
                    c[44] += myInt;
                }
                if (count == 3)
                {
                    d[44] += myInt;
                }
                if (count == 4)
                {
                    e1[44] += myInt;
                }
                if (count == 5)
                {
                    f[44] += myInt;
                }
            }

        }

        private void nickel_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(NickelMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + nickel.Text;
                if (count == 0)
                {
                    a[27]++;
                }
                if (count == 1)
                {
                    b[27]++;
                }
                if (count == 2)
                {
                    c[27]++;
                }
                if (count == 3)
                {
                    d[27]++;
                }
                if (count == 4)
                {
                    e1[27]++;
                }
                if (count == 5)
                {
                    f[27]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + nickel.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[27] += myInt;
                }
                if (count == 1)
                {
                    b[27] += myInt;
                }
                if (count == 2)
                {
                    c[27] += myInt;
                }
                if (count == 3)
                {
                    d[27] += myInt;
                }
                if (count == 4)
                {
                    e1[27] += myInt;
                }
                if (count == 5)
                {
                    f[27] += myInt;
                }
            }

        }

        private void cobalt_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(CobaltMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + cobalt.Text;
                if (count == 0)
                {
                    a[26]++;
                }
                if (count == 1)
                {
                    b[26]++;
                }
                if (count == 2)
                {
                    c[26]++;
                }
                if (count == 3)
                {
                    d[26]++;
                }
                if (count == 4)
                {
                    e1[26]++;
                }
                if (count == 5)
                {
                    f[26]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + cobalt.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[26] += myInt;
                }
                if (count == 1)
                {
                    b[26] += myInt;
                }
                if (count == 2)
                {
                    c[26] += myInt;
                }
                if (count == 3)
                {
                    d[26] += myInt;
                }
                if (count == 4)
                {
                    e1[26] += myInt;
                }
                if (count == 5)
                {
                    f[26] += myInt;
                }
            }

        }

        private void hassium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(HassiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + hassium.Text;
                if (count == 0)
                {
                    a[107]++;
                }
                if (count == 1)
                {
                    b[107]++;
                }
                if (count == 2)
                {
                    c[107]++;
                }
                if (count == 3)
                {
                    d[107]++;
                }
                if (count == 4)
                {
                    e1[107]++;
                }
                if (count == 5)
                {
                    f[107]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + hassium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[107] += myInt;
                }
                if (count == 1)
                {
                    b[107] += myInt;
                }
                if (count == 2)
                {
                    c[107] += myInt;
                }
                if (count == 3)
                {
                    d[107] += myInt;
                }
                if (count == 4)
                {
                    e1[107] += myInt;
                }
                if (count == 5)
                {
                    f[107] += myInt;
                }
            }

        }

        private void bohrium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(BohriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + bohrium.Text;
                if (count == 0)
                {
                    a[106]++;
                }
                if (count == 1)
                {
                    b[106]++;
                }
                if (count == 2)
                {
                    c[106]++;
                }
                if (count == 3)
                {
                    d[106]++;
                }
                if (count == 4)
                {
                    e1[106]++;
                }
                if (count == 5)
                {
                    f[106]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + bohrium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[106] += myInt;
                }
                if (count == 1)
                {
                    b[106] += myInt;
                }
                if (count == 2)
                {
                    c[106] += myInt;
                }
                if (count == 3)
                {
                    d[106] += myInt;
                }
                if (count == 4)
                {
                    e1[106] += myInt;
                }
                if (count == 5)
                {
                    f[106] += myInt;
                }
            }

        }

        private void osmium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(OsmiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + osmium.Text;
                if (count == 0)
                {
                    a[75]++;
                }
                if (count == 1)
                {
                    b[75]++;
                }
                if (count == 2)
                {
                    c[75]++;
                }
                if (count == 3)
                {
                    d[75]++;
                }
                if (count == 4)
                {
                    e1[75]++;
                }
                if (count == 5)
                {
                    f[75]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + osmium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[75] += myInt;
                }
                if (count == 1)
                {
                    b[75] += myInt;
                }
                if (count == 2)
                {
                    c[75] += myInt;
                }
                if (count == 3)
                {
                    d[75] += myInt;
                }
                if (count == 4)
                {
                    e1[75] += myInt;
                }
                if (count == 5)
                {
                    f[75] += myInt;
                }
            }

        }

        private void rhenium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(RheniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + rhenium.Text;
                if (count == 0)
                {
                    a[74]++;
                }
                if (count == 1)
                {
                    b[74]++;
                }
                if (count == 2)
                {
                    c[74]++;
                }
                if (count == 3)
                {
                    d[74]++;
                }
                if (count == 4)
                {
                    e1[74]++;
                }
                if (count == 5)
                {
                    f[74]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + rhenium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[74] += myInt;
                }
                if (count == 1)
                {
                    b[74] += myInt;
                }
                if (count == 2)
                {
                    c[74] += myInt;
                }
                if (count == 3)
                {
                    d[74] += myInt;
                }
                if (count == 4)
                {
                    e1[74] += myInt;
                }
                if (count == 5)
                {
                    f[74] += myInt;
                }
            }

        }

        private void ruthenium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(RutheniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Ruthenium.Text;
                if (count == 0)
                {
                    a[43]++;
                }
                if (count == 1)
                {
                    b[43]++;
                }
                if (count == 2)
                {
                    c[43]++;
                }
                if (count == 3)
                {
                    d[43]++;
                }
                if (count == 4)
                {
                    e1[43]++;
                }
                if (count == 5)
                {
                    f[43]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Ruthenium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[43] += myInt;
                }
                if (count == 1)
                {
                    b[43] += myInt;
                }
                if (count == 2)
                {
                    c[43] += myInt;
                }
                if (count == 3)
                {
                    d[43] += myInt;
                }
                if (count == 4)
                {
                    e1[43] += myInt;
                }
                if (count == 5)
                {
                    f[43] += myInt;
                }
            }

        }

        private void technetium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(TechnetiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + technetium.Text;
                if (count == 0)
                {
                    a[42]++;
                }
                if (count == 1)
                {
                    b[42]++;
                }
                if (count == 2)
                {
                    c[42]++;
                }
                if (count == 3)
                {
                    d[42]++;
                }
                if (count == 4)
                {
                    e1[42]++;
                }
                if (count == 5)
                {
                    f[42]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + technetium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[42] += myInt;
                }
                if (count == 1)
                {
                    b[42] += myInt;
                }
                if (count == 2)
                {
                    c[42] += myInt;
                }
                if (count == 3)
                {
                    d[42] += myInt;
                }
                if (count == 4)
                {
                    e1[42] += myInt;
                }
                if (count == 5)
                {
                    f[42] += myInt;
                }
            }

        }

        private void iron_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(IronMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + iron.Text;
                if (count == 0)
                {
                    a[25]++;
                }
                if (count == 1)
                {
                    b[25]++;
                }
                if (count == 2)
                {
                    c[25]++;
                }
                if (count == 3)
                {
                    d[25]++;
                }
                if (count == 4)
                {
                    e1[25]++;
                }
                if (count == 5)
                {
                    f[25]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + iron.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[25] += myInt;
                }
                if (count == 1)
                {
                    b[25] += myInt;
                }
                if (count == 2)
                {
                    c[25] += myInt;
                }
                if (count == 3)
                {
                    d[25] += myInt;
                }
                if (count == 4)
                {
                    e1[25] += myInt;
                }
                if (count == 5)
                {
                    f[25] += myInt;
                }
            }

        }

        private void manganese_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ManganeseMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + manganese.Text;
                if (count == 0)
                {
                    a[24]++;
                }
                if (count == 1)
                {
                    b[24]++;
                }
                if (count == 2)
                {
                    c[24]++;
                }
                if (count == 3)
                {
                    d[24]++;
                }
                if (count == 4)
                {
                    e1[24]++;
                }
                if (count == 5)
                {
                    f[24]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + manganese.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[24] += myInt;
                }
                if (count == 1)
                {
                    b[24] += myInt;
                }
                if (count == 2)
                {
                    c[24] += myInt;
                }
                if (count == 3)
                {
                    d[24] += myInt;
                }
                if (count == 4)
                {
                    e1[24] += myInt;
                }
                if (count == 5)
                {
                    f[24] += myInt;
                }
            }

        }

        private void seaborgium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(SeaborgiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + seaborgium.Text;
                if (count == 0)
                {
                    a[105]++;
                }
                if (count == 1)
                {
                    b[105]++;
                }
                if (count == 2)
                {
                    c[105]++;
                }
                if (count == 3)
                {
                    d[105]++;
                }
                if (count == 4)
                {
                    e1[105]++;
                }
                if (count == 5)
                {
                    f[105]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + seaborgium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[105] += myInt;
                }
                if (count == 1)
                {
                    b[105] += myInt;
                }
                if (count == 2)
                {
                    c[105] += myInt;
                }
                if (count == 3)
                {
                    d[105] += myInt;
                }
                if (count == 4)
                {
                    e1[105] += myInt;
                }
                if (count == 5)
                {
                    f[105] += myInt;
                }
            }

        }




        private void dubnium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(DubniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + dubnium.Text;
                if (count == 0)
                {
                    a[104]++;
                }
                if (count == 1)
                {
                    b[104]++;
                }
                if (count == 2)
                {
                    c[104]++;
                }
                if (count == 3)
                {
                    d[104]++;
                }
                if (count == 4)
                {
                    e1[104]++;
                }
                if (count == 5)
                {
                    f[104]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + dubnium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[104] += myInt;
                }
                if (count == 1)
                {
                    b[104] += myInt;
                }
                if (count == 2)
                {
                    c[104] += myInt;
                }
                if (count == 3)
                {
                    d[104] += myInt;
                }
                if (count == 4)
                {
                    e1[104] += myInt;
                }
                if (count == 5)
                {
                    f[104] += myInt;
                }
            }

        }

        private void tungsten_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(TungstenMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + tungsten.Text;
                if (count == 0)
                {
                    a[73]++;
                }
                if (count == 1)
                {
                    b[73]++;
                }
                if (count == 2)
                {
                    c[73]++;
                }
                if (count == 3)
                {
                    d[73]++;
                }
                if (count == 4)
                {
                    e1[73]++;
                }
                if (count == 5)
                {
                    f[73]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + tungsten.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[73] += myInt;
                }
                if (count == 1)
                {
                    b[73] += myInt;
                }
                if (count == 2)
                {
                    c[73] += myInt;
                }
                if (count == 3)
                {
                    d[73] += myInt;
                }
                if (count == 4)
                {
                    e1[73] += myInt;
                }
                if (count == 5)
                {
                    f[73] += myInt;
                }
            }

        }

        private void tantalum_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(TantalumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + tantlum.Text;
                if (count == 0)
                {
                    a[72]++;
                }
                if (count == 1)
                {
                    b[72]++;
                }
                if (count == 2)
                {
                    c[72]++;
                }
                if (count == 3)
                {
                    d[72]++;
                }
                if (count == 4)
                {
                    e1[72]++;
                }
                if (count == 5)
                {
                    f[72]++;
                }

            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + tantlum.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[72] += myInt;
                }
                if (count == 1)
                {
                    b[72] += myInt;
                }
                if (count == 2)
                {
                    c[72] += myInt;
                }
                if (count == 3)
                {
                    d[72] += myInt;
                }
                if (count == 4)
                {
                    e1[72] += myInt;
                }
                if (count == 5)
                {
                    f[72] += myInt;
                }
            }

        }

        private void molybdenum_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(MolybdenumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Molybdenum.Text;
                if (count == 0)
                {
                    a[41]++;
                }
                if (count == 1)
                {
                    b[41]++;
                }
                if (count == 2)
                {
                    c[41]++;
                }
                if (count == 3)
                {
                    d[41]++;
                }
                if (count == 4)
                {
                    e1[41]++;
                }
                if (count == 5)
                {
                    f[41]++;
                }

            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Molybdenum.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[41] += myInt;
                }
                if (count == 1)
                {
                    b[41] += myInt;
                }
                if (count == 2)
                {
                    c[41] += myInt;
                }
                if (count == 3)
                {
                    d[41] += myInt;
                }
                if (count == 4)
                {
                    e1[41] += myInt;
                }
                if (count == 5)
                {
                    f[41] += myInt;
                }
            }

        }

        private void niobium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(NiobiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Niobium.Text;
                if (count == 0)
                {
                    a[40]++;
                }
                if (count == 1)
                {
                    b[40]++;
                }
                if (count == 2)
                {
                    c[40]++;
                }
                if (count == 3)
                {
                    d[40]++;
                }
                if (count == 4)
                {
                    e1[40]++;
                }
                if (count == 5)
                {
                    f[40]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Niobium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[40] += myInt;
                }
                if (count == 1)
                {
                    b[40] += myInt;
                }
                if (count == 2)
                {
                    c[40] += myInt;
                }
                if (count == 3)
                {
                    d[40] += myInt;
                }
                if (count == 4)
                {
                    e1[40] += myInt;
                }
                if (count == 5)
                {
                    f[40] += myInt;
                }
            }

        }

        private void chromium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ChromiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + chromium.Text;
                if (count == 0)
                {
                    a[23]++;
                }
                if (count == 1)
                {
                    b[23]++;
                }
                if (count == 2)
                {
                    c[23]++;
                }
                if (count == 3)
                {
                    d[23]++;
                }
                if (count == 4)
                {
                    e1[23]++;
                }
                if (count == 5)
                {
                    f[23]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + chromium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[23] += myInt;
                }
                if (count == 1)
                {
                    b[23] += myInt;
                }
                if (count == 2)
                {
                    c[23] += myInt;
                }
                if (count == 3)
                {
                    d[23] += myInt;
                }
                if (count == 4)
                {
                    e1[23] += myInt;
                }
                if (count == 5)
                {
                    f[23] += myInt;
                }
            }

        }

        private void vanadium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(VanadiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + vanadium.Text;
                if (count == 0)
                {
                    a[22]++;
                }
                if (count == 1)
                {
                    b[22]++;
                }
                if (count == 2)
                {
                    c[22]++;
                }
                if (count == 3)
                {
                    d[22]++;
                }
                if (count == 4)
                {
                    e1[22]++;
                }
                if (count == 5)
                {
                    f[22]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + vanadium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[22] += myInt;
                }
                if (count == 1)
                {
                    b[22] += myInt;
                }
                if (count == 2)
                {
                    c[22] += myInt;
                }
                if (count == 3)
                {
                    d[22] += myInt;
                }
                if (count == 4)
                {
                    e1[22] += myInt;
                }
                if (count == 5)
                {
                    f[22] += myInt;
                }
            }

        }

        private void rutherfordium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(RutherfordiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + rutherfordium.Text;
                if (count == 0)
                {
                    a[103]++;
                }
                if (count == 1)
                {
                    b[103]++;
                }
                if (count == 2)
                {
                    c[103]++;
                }
                if (count == 3)
                {
                    d[103]++;
                }
                if (count == 4)
                {
                    e1[103]++;
                }
                if (count == 5)
                {
                    f[103]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + rutherfordium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[103] += myInt;
                }
                if (count == 1)
                {
                    b[103] += myInt;
                }
                if (count == 2)
                {
                    c[103] += myInt;
                }
                if (count == 3)
                {
                    d[103] += myInt;
                }
                if (count == 4)
                {
                    e1[103] += myInt;
                }
                if (count == 5)
                {
                    f[103] += myInt;
                }
            }

        }

        private void hafnium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(HafniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + hafnium.Text;
                if (count == 0)
                {
                    a[71]++;
                }
                if (count == 1)
                {
                    b[71]++;
                }
                if (count == 2)
                {
                    c[71]++;
                }
                if (count == 3)
                {
                    d[71]++;
                }
                if (count == 4)
                {
                    e1[71]++;
                }
                if (count == 5)
                {
                    f[71]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + hafnium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[71] += myInt;
                }
                if (count == 1)
                {
                    b[71] += myInt;
                }
                if (count == 2)
                {
                    c[71] += myInt;
                }
                if (count == 3)
                {
                    d[71] += myInt;
                }
                if (count == 4)
                {
                    e1[71] += myInt;
                }
                if (count == 5)
                {
                    f[71] += myInt;
                }
            }

        }

        private void zicronium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ZirconiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Zirconium.Text;
                if (count == 0)
                {
                    a[39]++;
                }
                if (count == 1)
                {
                    b[39]++;
                }
                if (count == 2)
                {
                    c[39]++;
                }
                if (count == 3)
                {
                    d[39]++;
                }
                if (count == 4)
                {
                    e1[39]++;
                }
                if (count == 5)
                {
                    f[39]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + Zirconium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[39] += myInt;
                }
                if (count == 1)
                {
                    b[39] += myInt;
                }
                if (count == 2)
                {
                    c[39] += myInt;
                }
                if (count == 3)
                {
                    d[39] += myInt;
                }
                if (count == 4)
                {
                    e1[39] += myInt;
                }
                if (count == 5)
                {
                    f[39] += myInt;
                }
            }

        }

        private void yittrium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(YttriumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + yittrium.Text;
                if (count == 0)
                {
                    a[38]++;
                }
                if (count == 1)
                {
                    b[38]++;
                }
                if (count == 2)
                {
                    c[38]++;
                }
                if (count == 3)
                {
                    d[38]++;
                }
                if (count == 4)
                {
                    e1[38]++;
                }
                if (count == 5)
                {
                    f[38]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + yittrium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[38] += myInt;
                }
                if (count == 1)
                {
                    b[38] += myInt;
                }
                if (count == 2)
                {
                    c[38] += myInt;
                }
                if (count == 3)
                {
                    d[38] += myInt;
                }
                if (count == 4)
                {
                    e1[38] += myInt;
                }
                if (count == 5)
                {
                    f[38] += myInt;
                }

            }

        }

        private void titanium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(TitaniumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + titanium.Text;
                if (count == 0)
                {
                    a[21]++;
                }
                if (count == 1)
                {
                    b[21]++;
                }
                if (count == 2)
                {
                    c[21]++;
                }
                if (count == 3)
                {
                    d[21]++;
                }
                if (count == 4)
                {
                    e1[21]++;
                }
                if (count == 5)
                {
                    f[21]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + titanium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[21] += myInt;
                }
                if (count == 1)
                {
                    b[21] += myInt;
                }
                if (count == 2)
                {
                    c[21] += myInt;
                }
                if (count == 3)
                {
                    d[21] += myInt;
                }
                if (count == 4)
                {
                    e1[21] += myInt;
                }
                if (count == 5)
                {
                    f[21] += myInt;
                }
            }

        }

        private void scandium_Click_1(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(ScandiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + scandium.Text;
                if (count == 0)
                {
                    a[20]++;
                }
                if (count == 1)
                {
                    b[20]++;
                }
                if (count == 2)
                {
                    c[20]++;
                }
                if (count == 3)
                {
                    d[20]++;
                }
                if (count == 4)
                {
                    e1[20]++;
                }
                if (count == 5)
                {
                    f[20]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + scandium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[20] += myInt;
                }
                if (count == 1)
                {
                    b[20] += myInt;
                }
                if (count == 2)
                {
                    c[20] += myInt;
                }
                if (count == 3)
                {
                    d[20] += myInt;
                }
                if (count == 4)
                {
                    e1[20] += myInt;
                }
                if (count == 5)
                {
                    f[20] += myInt;
                }
            }

        }

        private void radium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(RadiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + radium.Text;
                if (count == 0)
                {
                    a[87]++;
                }
                if (count == 1)
                {
                    b[87]++;
                }
                if (count == 2)
                {
                    c[87]++;
                }
                if (count == 3)
                {
                    d[87]++;
                }
                if (count == 4)
                {
                    e1[87]++;
                }
                if (count == 5)
                {
                    f[87]++;
                }
            }
            else if (isNumerical && myInt != 0)
            {
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + radium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    a[87] += myInt;
                }
                if (count == 1)
                {
                    b[87] += myInt;
                }
                if (count == 2)
                {
                    c[87] += myInt;
                }
                if (count == 3)
                {
                    d[87] += myInt;
                }
                if (count == 4)
                {
                    e1[87] += myInt;
                }
                if (count == 5)
                {
                    f[87] += myInt;
                }
            }

        }

        private void francium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(FranciumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                if (count == 0)
                {
                    a[86]++;
                }
                if (count == 1)
                {
                    b[86]++;
                }
                if (count == 2)
                {
                    c[86]++;
                }
                if (count == 3)
                {
                    d[86]++;
                }
                if (count == 4)
                {
                    e1[86]++;
                }
                if (count == 5)
                {
                    f[86]++;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + francium.Text;
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[86] += myInt;
                }
                if (count == 1)
                {
                    b[86] += myInt;
                }
                if (count == 2)
                {
                    c[86] += myInt;
                }
                if (count == 3)
                {
                    d[86] += myInt;
                }
                if (count == 4)
                {
                    e1[86] += myInt;
                }
                if (count == 5)
                {
                    f[86] += myInt;
                }

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
            {
                if (count == 0)
                {
                    a[55]++;
                }
                if (count == 1)
                {
                    b[55]++;
                }
                if (count == 2)
                {
                    c[55]++;
                }
                if (count == 3)
                {
                    d[55]++;
                }
                if (count == 4)
                {
                    e1[55]++;
                }
                if (count == 5)
                {
                    f[55]++;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + barium.Text;
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[55] += myInt;
                }
                if (count == 1)
                {
                    b[55] += myInt;
                }
                if (count == 2)
                {
                    c[55] += myInt;
                }
                if (count == 3)
                {
                    d[55] += myInt;
                }
                if (count == 4)
                {
                    e1[55] += myInt;
                }
                if (count == 5)
                {
                    f[55] += myInt;
                }

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
            {
                if (count == 0)
                {
                    a[102]++;
                }
                if (count == 1)
                {
                    b[102]++;
                }
                if (count == 2)
                {
                    c[102]++;
                }
                if (count == 3)
                {
                    d[102]++;
                }
                if (count == 4)
                {
                    e1[102]++;
                }
                if (count == 5)
                {
                    f[102]++;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lawrencium.Text;
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[102] += myInt;
                }
                if (count == 1)
                {
                    b[102] += myInt;
                }
                if (count == 2)
                {
                    c[102] += myInt;
                }
                if (count == 3)
                {
                    d[102] += myInt;
                }
                if (count == 4)
                {
                    e1[102] += myInt;
                }
                if (count == 5)
                {
                    f[102] += myInt;
                }
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
            {
                if (count == 0)
                {
                    a[37]++;
                }
                if (count == 1)
                {
                    b[37]++;
                }
                if (count == 2)
                {
                    c[37]++;
                }
                if (count == 3)
                {
                    d[37]++;
                }
                if (count == 4)
                {
                    e1[37]++;
                }
                if (count == 5)
                {
                    f[37]++;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + stronium.Text;
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[37] += myInt;
                }
                if (count == 1)
                {
                    b[37] += myInt;
                }
                if (count == 2)
                {
                    c[37] += myInt;
                }
                if (count == 3)
                {
                    d[37] += myInt;
                }
                if (count == 4)
                {
                    e1[37] += myInt;
                }
                if (count == 5)
                {
                    f[37] += myInt;
                }

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
            {
                if (count == 0)
                {
                    a[36]++;
                }
                if (count == 1)
                {
                    b[36]++;
                }
                if (count == 2)
                {
                    c[36]++;
                }
                if (count == 3)
                {
                    d[36]++;
                }
                if (count == 4)
                {
                    e1[36]++;
                }
                if (count == 5)
                {
                    f[36]++;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + rubidium.Text;
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[36] += myInt;
                }
                if (count == 1)
                {
                    b[36] += myInt;
                }
                if (count == 2)
                {
                    c[36] += myInt;
                }
                if (count == 3)
                {
                    d[36] += myInt;
                }
                if (count == 4)
                {
                    e1[36] += myInt;
                }
                if (count == 5)
                {
                    f[36] += myInt;
                }
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
            {
                if (count == 0)
                {
                    a[19]++;
                }
                if (count == 1)
                {
                    b[19]++;
                }
                if (count == 2)
                {
                    c[19]++;
                }
                if (count == 3)
                {
                    d[19]++;
                }
                if (count == 4)
                {
                    e1[19]++;
                }
                if (count == 5)
                {
                    f[19]++;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + calcium.Text;
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[19] += myInt;
                }
                if (count == 1)
                {
                    b[19] += myInt;
                }
                if (count == 2)
                {
                    c[19] += myInt;
                }
                if (count == 3)
                {
                    d[19] += myInt;
                }
                if (count == 4)
                {
                    e1[19] += myInt;
                }
                if (count == 5)
                {
                    f[19] += myInt;
                }
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
            {
                if (count == 0)
                {
                    a[18]++;
                }
                if (count == 1)
                {
                    b[18]++;
                }
                if (count == 2)
                {
                    c[18]++;
                }
                if (count == 3)
                {
                    d[18]++;
                }
                if (count == 4)
                {
                    e1[18]++;
                }
                if (count == 5)
                {
                    f[18]++;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + potassium.Text;
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[18] += myInt;
                }
                if (count == 1)
                {
                    b[18] += myInt;
                }
                if (count == 2)
                {
                    c[18] += myInt;
                }
                if (count == 3)
                {
                    d[18] += myInt;
                }
                if (count == 4)
                {
                    e1[18] += myInt;
                }
                if (count == 5)
                {
                    f[18] += myInt;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + potassium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }

        private void magnesium_Click(object sender, EventArgs e)
        {
            buttonSelect test = new buttonSelect(MagnesiumMM);
            test.ShowDialog();
            int myInt;
            bool isNumerical = int.TryParse(test.comboBox1.Text, out myInt);
            if (isNumerical && myInt == 1)
            {
                if (count == 0)
                {
                    a[11]++;
                }
                if (count == 1)
                {
                    b[11]++;
                }
                if (count == 2)
                {
                    c[11]++;
                }
                if (count == 3)
                {
                    d[11]++;
                }
                if (count == 4)
                {
                    e1[11]++;
                }
                if (count == 5)
                {
                    f[11]++;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + magnesium.Text;
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[11] += myInt;
                }
                if (count == 1)
                {
                    b[11] += myInt;
                }
                if (count == 2)
                {
                    c[11] += myInt;
                }
                if (count == 3)
                {
                    d[11] += myInt;
                }
                if (count == 4)
                {
                    e1[11] += myInt;
                }
                if (count == 5)
                {
                    f[11] += myInt;
                }
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
            {
                if (count == 0)
                {
                    a[10]++;
                }
                if (count == 1)
                {
                    b[10]++;
                }
                if (count == 2)
                {
                    c[10]++;
                }
                if (count == 3)
                {
                    d[10]++;
                }
                if (count == 4)
                {
                    e1[10]++;
                }
                if (count == 5)
                {
                    f[10]++;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + sodium.Text;
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[10] += myInt;
                }
                if (count == 1)
                {
                    b[10] += myInt;
                }
                if (count == 2)
                {
                    c[10] += myInt;
                }
                if (count == 3)
                {
                    d[10] += myInt;
                }
                if (count == 4)
                {
                    e1[10] += myInt;
                }
                if (count == 5)
                {
                    f[10] += myInt;
                }
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
            {
                if (count == 0)
                {
                    a[3]++;
                }
                if (count == 1)
                {
                    b[3]++;
                }
                if (count == 2)
                {
                    c[3]++;
                }
                if (count == 3)
                {
                    d[3]++;
                }
                if (count == 4)
                {
                    e1[3]++;
                }
                if (count == 5)
                {
                    f[3]++;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + beryllium.Text;
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[3] += myInt;
                }
                if (count == 1)
                {
                    b[3] += myInt;
                }
                if (count == 2)
                {
                    c[3] += myInt;
                }
                if (count == 3)
                {
                    d[3] += myInt;
                }
                if (count == 4)
                {
                    e1[3] += myInt;
                }
                if (count == 5)
                {
                    f[3] += myInt;
                }
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
            {
                if (count == 0)
                {
                    a[2]++;
                }
                if (count == 1)
                {
                    b[2]++;
                }
                if (count == 2)
                {
                    c[2]++;
                }
                if (count == 3)
                {
                    d[2]++;
                }
                if (count == 4)
                {
                    e1[2]++;
                }
                if (count == 5)
                {
                    f[2]++;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lithium.Text;
            }
            else if (isNumerical && myInt != 0)
            {
                if (count == 0)
                {
                    a[2] += myInt;
                }
                if (count == 1)
                {
                    b[2] += myInt;
                }
                if (count == 2)
                {
                    c[2] += myInt;
                }
                if (count == 3)
                {
                    d[2] += myInt;
                }
                if (count == 4)
                {
                    e1[2] += myInt;
                }
                if (count == 5)
                {
                    f[2] += myInt;
                }
                compoundBuilder.SelectedText = compoundBuilder.SelectedText + lithium.Text;
                compoundBuilder.SelectionFont = new Font("Verdana", 7);
                compoundBuilder.SelectedText = myInt.ToString();
                compoundBuilder.SelectionFont = new Font("Verdana", 15);
            }

        }




        #endregion

         



        //================================================================================================================================
        // --
        //                                      On Hover Event
        // --
        //================================================================================================================================
         

        #region Hover Events
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













        #endregion

         



        //================================================================================================================================
        // --
        //                                      Balance Buttons
        // --
        //================================================================================================================================
         

        #region Balance Buttons
        //Add function
        private void add_Click(object sender, EventArgs e)
        {
            if (compoundBuilder.Text != "")
            {
                //sorts through each box as items are added
                Color c = Color.LightGray;

                mmReactant1.SelectionFont =
                mmReactant2.SelectionFont =
                mmReactant3.SelectionFont =
                mmProduct1.SelectionFont =
                mmProduct2.SelectionFont =
                mmProduct3.SelectionFont = new Font("Verdana", 13);
                mmEquation1.SelectionFont =
                mmEquation2.SelectionFont =
                mmEquation3.SelectionFont =
                mmEquation4.SelectionFont =
                mmEquation5.SelectionFont =
                mmEquation6.SelectionFont = new Font("Verdana", 15); 
                if (count == 0)
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
                else if (count == 1)
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
                else if (count == 2)
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
                else if (count == 3)
                {
                    balanceBox4.Rtf = compoundBuilder.Rtf;
                    balanceBox1.BackColor = c;
                    balanceBox2.BackColor = c;
                    balanceBox3.BackColor = c;
                    balanceBox4.BackColor = c;
                    balanceBox5.BackColor = Color.WhiteSmoke;
                    balanceBox6.BackColor = c;
                    setMM4(molar);
                    mmProduct1.Text = molar.ToString() + "g";
                    mmEquation4.Rtf = compoundBuilder.Rtf;
                    product1.Rtf = compoundBuilder.Rtf;
                }
                else if (count == 4)
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
                else if (count == 5)
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
                count++;
                compoundBuilder.Rtf = "";
                molar = 0;
            }
        }

        private static List<double> solveMat(int[][] rows)
        {


            List<double> values = new List<double>();

            int length = rows[0].Length;
            for (int i = 0; i < rows.Length - 1; i++)
            {
                for (int j = i; j < rows.Length; j++)
                {
                    int[] d = new int[length];
                    for (int x = 0; x < length; x++)
                    {
                        if (i == j && rows[j][i] == 0)
                        {
                            bool changed = false;
                            for (int z = rows.Length - 1; z > i; z--)
                            {
                                if (rows[z][i] != 0)
                                {
                                    int[] temp = new int[length];
                                    temp = rows[z];
                                    rows[z] = rows[j];
                                    rows[j] = temp;
                                    changed = true;
                                }
                            }
                            if (!changed)
                            {
                                //textBox2.Text += "No Solution\r\n";
                                //return;
                            }
                        }
                        if (rows[j][i] != 0)
                        {
                            d[x] = rows[j][x] / rows[j][i];
                        }
                        else
                        {
                            d[x] = rows[j][x];
                        }
                    }
                    rows[j] = d;
                }
                for (int y = i + 1; y < rows.Length; y++)
                {
                    int[] f = new int[length];
                    for (int g = 0; g < length; g++)
                    {
                        if (rows[y][i] != 0)
                        {
                            f[g] = rows[y][g] - rows[i][g];
                        }
                        else
                        {
                            f[g] = rows[y][g];
                        }
                    }
                    rows[y] = f;
                }
            }
            double val = 0;
            int k = length - 2;
            double[] result = new double[rows.Length];
            for (int i = rows.Length - 1; i >= 0; i--)
            {
                val = rows[i][length - 1];
                for (int x = length - 2; x > k; x--)
                {
                    val -= rows[i][x] * result[x];
                }
                result[i] = val / rows[i][i];
                if (result[i].ToString() == "NaN" || result[i].ToString().Contains("Infinity"))
                {
                    //textBox2.Text += "No Solution Found!\n";
                    //return;
                }
                k--;
            }
            for (int i = 0; i < result.Length; i++)
            {
                values.Add(Math.Round(result[i], 10));
            }
            return values;
        }





        static double num1;
        static double num2;
        static Boolean isWhole = false;
        private static double simple(List<double> dang)
        {

            for (int j = 0; j < dang.Count; j++)
            {
                if (dang[j] % 1 == 0)
                {
                    if (j == dang.Count - 1)
                    {
                        return 1;
                    }
                }
                else
                {
                    break;
                }
            }

            double mult = 1;

            for (double i = 2.0; i < 100; i++)
            {
                mult = i;
                num1 = dang[0] * mult;
                string nums = Convert.ToString(num1);
                int dec = nums.IndexOf(".");
                if (dec > -1)
                {
                    string Lenth = nums.Substring(dec);
                    if (Lenth.Length > 3)
                    {
                        string lenth = nums.Substring(dec + 1, 3);
                        if (lenth.CompareTo("000") == 0)
                        {
                            int numFix = Convert.ToInt32(num1);
                            num1 = Convert.ToDouble(numFix);

                        }
                    }
                }
                if (num1 % 1 == 0)
                {

                    for (int k = 0; k < dang.Count; k++)
                    {
                        num2 = dang[k] * i;
                        string nums2 = Convert.ToString(num2);
                        int dec2 = nums2.IndexOf(".");

                        if (dec2 > -1)
                        {

                            string Lenth2 = nums2.Substring(dec2);

                            if (Lenth2.Length > 3)
                            {

                                string lenth2 = nums2.Substring(dec2 + 1, 3);
                                if (lenth2.CompareTo("000") == 0)
                                {
                                    int numFix2 = Convert.ToInt32(num2);
                                    num2 = Convert.ToDouble(numFix2);


                                }
                            }
                        }
                        if (num2 % 1 == 0)
                        {
                            if (k == dang.Count - 1)
                            {

                                return mult;
                            }
                        }
                        else
                        {
                            break;

                        }
                    }
                }


            }
            return 1;
        }

        //switches sides of the equation
        private void yeild_Click(object sender, EventArgs e)
        {
            if (compoundBuilder.Text != "" || balanceBox1.Text != "")
            {
                //sorts through each box as items are added
                Color c = Color.LightGray;

                mmReactant1.SelectionFont =
                mmReactant2.SelectionFont =
                mmReactant3.SelectionFont =
                mmProduct1.SelectionFont =
                mmProduct2.SelectionFont =
                mmProduct3.SelectionFont = new Font("Verdana", 13);
                mmEquation1.SelectionFont =
                mmEquation2.SelectionFont =
                mmEquation3.SelectionFont =
                mmEquation4.SelectionFont =
                mmEquation5.SelectionFont =
                mmEquation6.SelectionFont = new Font("Verdana", 15);
                if (count == 0)
                {
                    balanceBox1.Rtf = compoundBuilder.Rtf;
                    balanceBox1.BackColor = c;
                    balanceBox2.BackColor = c;
                    balanceBox3.BackColor = c;
                    balanceBox4.BackColor = Color.WhiteSmoke;
                    balanceBox5.BackColor = c;
                    balanceBox6.BackColor = c;
                    setMM1(molar);
                    mmReactant1.Text = molar.ToString() + "g";
                    mmEquation1.Rtf = compoundBuilder.Rtf;
                    reactant1.Rtf = compoundBuilder.Rtf;
                }
                else if (count == 1)
                {
                    balanceBox2.Rtf = compoundBuilder.Rtf;
                    balanceBox1.BackColor = c;
                    balanceBox2.BackColor = c;
                    balanceBox3.BackColor = c;
                    balanceBox4.BackColor = Color.WhiteSmoke;
                    balanceBox5.BackColor = c;
                    balanceBox6.BackColor = c;
                    setMM2(molar);
                    mmReactant2.Text = molar.ToString() + "g";
                    mmEquation2.Rtf = compoundBuilder.Rtf;
                    reactant2.Rtf = compoundBuilder.Rtf;
                }
                else if (count == 2)
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
                else if (count == 3)
                {
                    balanceBox4.Rtf = compoundBuilder.Rtf;
                    balanceBox1.BackColor = c;
                    balanceBox2.BackColor = c;
                    balanceBox3.BackColor = c;
                    balanceBox4.BackColor = Color.WhiteSmoke;
                    balanceBox5.BackColor = c;
                    balanceBox6.BackColor = c;
                    setMM4(molar);
                    mmProduct1.Text = molar.ToString() + "g";
                    mmEquation4.Rtf = compoundBuilder.Rtf;
                    product1.Rtf = compoundBuilder.Rtf;
                }
                else if (count == 4)
                {
                    balanceBox5.Rtf = compoundBuilder.Rtf;
                    balanceBox1.BackColor = c;
                    balanceBox2.BackColor = c;
                    balanceBox3.BackColor = c;
                    balanceBox4.BackColor = Color.WhiteSmoke;
                    balanceBox5.BackColor = c;
                    balanceBox6.BackColor = c;
                    setMM5(molar);
                    mmProduct2.Text = molar.ToString() + "g";
                    mmEquation5.Rtf = compoundBuilder.Rtf;
                    product2.Rtf = compoundBuilder.Rtf;
                }
                else if (count == 5)
                {
                    balanceBox6.Rtf = compoundBuilder.Rtf;
                    balanceBox1.BackColor = c;
                    balanceBox2.BackColor = c;
                    balanceBox3.BackColor = c;
                    balanceBox4.BackColor = Color.WhiteSmoke;
                    balanceBox5.BackColor = c;
                    balanceBox6.BackColor = c;
                    setMM6(molar);
                    mmProduct3.Text = molar.ToString() + "g";
                    mmEquation1.Rtf = compoundBuilder.Rtf;
                    product3.Rtf = compoundBuilder.Rtf;
                }

                compoundBuilder.Rtf = "";
                count = 3;
                molar = 0;
            }
            

            
        }

        
        private void balanceEquation_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < 118; i++ )
            {
                sum += a[i] + b[i] + c[i] + d[i] + e1[i] + f[i];
            }

            Console.Write("Tracker");

            for (int i = 0; i < tracker.Count; i++)
                Console.Write(tracker[i] + " ");

            Console.Write("bad");

            for (int i = 0; i < bad.Count; i++)
                Console.Write(bad[i] + " ");
            Console.Write("\nSum = " + sum);



                if (hasBal == false)
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
                }

                int onLeft = 0;
                int onRight = 0;

                if (balanceBox1.Text != "")
                    onLeft++;
                if (balanceBox2.Text != "")
                    onLeft++;
                if (balanceBox3.Text != "")
                    onLeft++;
                if (balanceBox4.Text != "")
                    onRight++;
                if (balanceBox5.Text != "")
                    onRight++;
                if (balanceBox6.Text != "")
                    onRight++;

                if (hasBal == false && onLeft > 0 && onRight > 0)
                {
                  /*  int[][] jagged = this.matrix();
                    for (int i = 0; i < jagged.Length; i++)
                    {
                        int[] innerArray = jagged[i];
                        for (int a = 0; a < innerArray.Length; a++)
                        {
                            Console.Write(innerArray[a] + " ");
                        }
                        Console.WriteLine();
                    }
                    */

                   List<double> print = solveMat(this.matrix());
                    double simple2 = simple(print);
                    for (int i = 0; i < print.Count; i++)
                    {
                        print[i] = print[i] * simple2;
                    }

                    print.Add((int)simple2);

                    for (int i = 0; i < print.Count; i++)
                    {
                        print[i] = Math.Abs((print[i]));
                    }

                    balanceBox1.SelectionFont =
                    balanceBox1.SelectionFont =
                    balanceBox1.SelectionFont =
                    balanceBox1.SelectionFont =
                    balanceBox1.SelectionFont =
                    balanceBox1.SelectionFont = new Font("Verdana", 16);

                    if (onLeft == 1)
                    {
                        balanceBox1.SelectedText = print[0] + " " + balanceBox1.SelectedText;
                    }
                    if (onLeft == 2)
                    {
                        balanceBox1.SelectedText = print[0] + " " + balanceBox1.SelectedText;
                        balanceBox2.SelectedText = print[1] + " " + balanceBox2.SelectedText;
                    }
                    if (onLeft == 3)
                    {
                        balanceBox1.SelectedText = print[0] + " " + balanceBox1.SelectedText;
                        balanceBox2.SelectedText = print[1] + " " + balanceBox2.SelectedText;
                        balanceBox3.SelectedText = print[2] + " " + balanceBox3.SelectedText;
                    }

                    if (onRight == 1)
                    {
                        balanceBox4.SelectedText = print[3 - (3 - onLeft)] + " " + balanceBox4.SelectedText;
                    }
                    if (onRight == 2)
                    {
                        balanceBox4.SelectedText = print[3 - (3 - onLeft)] + " " + balanceBox4.SelectedText;
                        balanceBox5.SelectedText = print[4 - (3 - onLeft)] + " " + balanceBox5.SelectedText;
                    }
                    if (onRight == 3)
                    {
                        balanceBox4.SelectedText = print[3 - (3 - onLeft)] + " " + balanceBox4.SelectedText;
                        balanceBox5.SelectedText = print[4 - (3 - onLeft)] + " " + balanceBox5.SelectedText;
                        balanceBox6.SelectedText = print[5 - (3 - onLeft)] + " " + balanceBox6.SelectedText;
                    }

                }



                hasBal = true;
        }

        
        private void clearBuilder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 118; i++)
            {
                if (count == 0)
                    a[i] = 0;
                if (count == 1)
                    b[i] = 0;
                if (count == 2)
                    c[i] = 0;
                if (count == 3)
                    d[i] = 0;
                if (count == 4)
                    e1[i] = 0;
                if (count == 5)
                    f[i] = 0;
            }
                compoundBuilder.Rtf = "";

        }

        //clears the equations
        private void clearEquation_Click(object sender, EventArgs e)
        {
            
            hasBal = false;
            for (int i = 0; i < 118; i++)
            {
                a[i] = 0;
                b[i] = 0;
                c[i] = 0;
                d[i] = 0;
                e1[i] = 0;
                f[i] = 0;
            }

            bad.Clear();
            tracker.Clear();     
            first = true;  

            count = 0;
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


            int sum = 0;
            for (int i = 0; i < 118; i++)
            {
                sum += a[i] + b[i] + c[i] + d[i] + e1[i] + f[i];
            }

            Console.Write("\nTracker");

            for (int i = 0; i < tracker.Count; i++)
                Console.Write(tracker[i] + " ");

            Console.Write("bad");

            for (int i = 0; i < bad.Count; i++)
                Console.Write(bad[i] + " ");
            Console.Write("\nSum = " + sum);


        }

        #endregion

        


        //================================================================================================================================
        // --
        //                                      Balance Boxes
        // --
        //================================================================================================================================
        // 

        #region Balance Boxes (Text)
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



        #endregion




         
        //================================================================================================================================
        // --
        //                                      Molar Mass Page
        // --
        //================================================================================================================================
         

        #region Molar Mass Page (Text)

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

        #endregion




         
        //================================================================================================================================
        // --
        //                                      Balanced Page
        // --
        //================================================================================================================================
         

        #region Balanced Page

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
        #endregion




         
        //================================================================================================================================
        // --
        //                                      Molarity Page
        // --
        //================================================================================================================================
         

        #region MolarityPage

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


        #endregion





    }
}

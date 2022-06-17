using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class SC_58029_WorkPanel : Form
    {
        public static SC_58029_WorkPanel sc_58029_WorkPanel;
        SC_58029_Controls sc_58029_Ctrl = new SC_58029_Controls();
        public SC_58029_WorkPanel()
        {
            InitializeComponent();
            sc_58029_WorkPanel = this;
            this.Width = (int)(1000);
            this.Height = (int)(600);
            SC_58029_LoadControlls();
        }
        void SC_58029_LoadControlls()
        {
            GroupBox SC_58029_Gb001 = sc_58029_Ctrl.SC_58029_Create_GroupBox(15, 5, 825, 450, "Work Panel", "SC_58029_GbWorkPanel");
            sc_58029_WorkPanel.Controls.Add(SC_58029_Gb001);
            GroupBox SC_58029_Gb002 = sc_58029_Ctrl.SC_58029_Create_GroupBox(850, 5, 120, 450, "Arragement", "SC_58029_GbArragement"); 
            sc_58029_WorkPanel.Controls.Add(SC_58029_Gb002);
            GroupBox SC_58029_Gb003 = sc_58029_Ctrl.SC_58029_Create_GroupBox(15, 455, 955, 87, "Parameters", "SC_58029_GbParameters");
            sc_58029_WorkPanel.Controls.Add(SC_58029_Gb003);

            Font sc_58029_Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            Color sc_58029_ForeColor = Color.Black;
            Color sc_58029_BackColor = Color.FromKnownColor(KnownColor.Control);
            string SC_58029_Text;


            Button sc_58029_BtAutoGenerate = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_BtAutoGenerate", 12, 25, 95, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "AUTO");
            sc_58029_BtAutoGenerate.Click += new EventHandler(SC_58029_BtAutoGenerate_Click);
            sc_58029_BtAutoGenerate.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_BtAutoGenerate.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_BtAutoGenerate);

            Button sc_58029_BtManualGenerate = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Manual", 12, 90, 95, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "MANUAL");
            sc_58029_BtManualGenerate.Click += new EventHandler(sc_58029_BtManualGenerate_Click);
            sc_58029_BtManualGenerate.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_BtManualGenerate.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_BtManualGenerate);

            Button sc_58029_Exit = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Exit", 12, 390, 95, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "EXIT");
            sc_58029_Exit.Click += new EventHandler(sc_58029_Exit_Click);
            sc_58029_Exit.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Exit.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Exit);

            Button sc_58029_Clear = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_Clear", 12, 330, 95, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, SC_58029_Text = "CLEAR");
            sc_58029_Clear.Click += new EventHandler(SC_58029_Clear_Click);
            sc_58029_Clear.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_Clear.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            SC_58029_Gb002.Controls.Add(sc_58029_Clear);


        }

        void SC_58029_Clear_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            GroupBox sc_58029_Gb = (GroupBox)this.Controls.Find("SC_58029_GbWorkPanel", true)[0];
            if (sc_58029_Gb.Controls.Count > 0)
                sc_58029_Gb.Controls.Clear();
            sc_58029_Gb = (GroupBox)this.Controls.Find("SC_58029_GbParameters", true)[0];          
            if (sc_58029_Gb.Controls.Count > 0)
            {
                sc_58029_Gb.Controls.Clear();
            }
        }


        void sc_58029_Exit_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            Application.Exit();                                               
        }



        void sc_58029_BtManualGenerate_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            GroupBox sc_58029_Gb = (GroupBox)this.Controls.Find("SC_58029_GbWorkPanel", true)[0];
            if (sc_58029_Gb.Controls.Count > 0)
                sc_58029_Gb.Controls.Clear();                                                      

            sc_58029_Gb = (GroupBox)this.Controls.Find("SC_58029_GbParameters", true)[0];
            SC_58029_Manual(sc_58029_Gb);

        }

        void SC_58029_Manual(GroupBox sc_58029_Gb)
        {
            Font sc_58029_Font = new Font("Arial", 10, FontStyle.Bold);
            Color sc_58029_ForeColor = Color.Black;
            Color sc_58029_BackColor = Color.FromKnownColor(KnownColor.Control); 
            Color sc_58029_TextBoxColor = Color.White;
            Point sc_58029_Location = new Point();


  
            sc_58029_Location.X = 10;
            sc_58029_Location.Y = 20;
            CheckBox sc_58029_LabelCheck = sc_58029_Ctrl.SC_58029_Create_CheckBox("SC_58029_LabelCheck", sc_58029_Location, 100, sc_58029_Font, sc_58029_ForeColor, false, "Label");
            sc_58029_LabelCheck.CheckedChanged += new EventHandler(sc_58029_LabelChecked);
            sc_58029_LabelCheck.Checked = true;
            sc_58029_Gb.Controls.Add(sc_58029_LabelCheck);


            sc_58029_Location.X = 10;
            sc_58029_Location.Y = 50;
            CheckBox sc_58029_Box = sc_58029_Ctrl.SC_58029_Create_CheckBox("SC_58029_TextBoxCheck", sc_58029_Location, 100, sc_58029_Font, sc_58029_ForeColor, false, "TextBox");
            sc_58029_Box.CheckedChanged += new EventHandler(sc_58029_BoxChecked);
            sc_58029_Box.Checked = true;
            sc_58029_Gb.Controls.Add(sc_58029_Box);

            sc_58029_Location.X = 120;
            sc_58029_Location.Y = 20;
            Label sc_58029_WidthLabel = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_WidthLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 60, 25, "Width: ");
            sc_58029_Gb.Controls.Add(sc_58029_WidthLabel);

            sc_58029_Location.X = sc_58029_Location.X + 65;
            sc_58029_Location.Y = 20;
            TextBox sc_58029_WidthBox = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_Width", sc_58029_Location, 60, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            sc_58029_WidthBox.Leave += new EventHandler(SC_58029_ValueProtectorWidth);
            sc_58029_WidthBox.Text = "60";
            sc_58029_Gb.Controls.Add(sc_58029_WidthBox);

            sc_58029_Location.X = 120;
            sc_58029_Location.Y = 50;
            Label sc_58029_HeightLabel = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_HeightLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 60, 25, "Height: ");
            sc_58029_Gb.Controls.Add(sc_58029_HeightLabel);

            sc_58029_Location.X = sc_58029_Location.X + 65;
            sc_58029_Location.Y = 50;
            TextBox sc_58029_HeightBox = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_Height", sc_58029_Location, 60, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            sc_58029_HeightBox.Leave += new EventHandler(SC_58029_ValueProtectorHeight);
            sc_58029_HeightBox.Text = "25";
            sc_58029_Gb.Controls.Add(sc_58029_HeightBox);


            sc_58029_Location.X = 255;
            sc_58029_Location.Y = 20;
            Label sc_58029_BackColorLabel = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_BackColorLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 110, 25, "Back Color: ");
            sc_58029_Gb.Controls.Add(sc_58029_BackColorLabel);

            sc_58029_Location.X = sc_58029_Location.X + 115;
            sc_58029_Location.Y = 20;
            sc_58029_BackColor = Color.BurlyWood;
            Label sc_58029_BackColorChange = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_BackColorChangeLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 60, 25, "");
            sc_58029_BackColorChange.Click += new EventHandler(SC_58029_BackColorChange_Click);
            sc_58029_Gb.Controls.Add(sc_58029_BackColorChange);


            sc_58029_BackColor = Color.FromKnownColor(KnownColor.Control);
            sc_58029_Location.X = 255;
            sc_58029_Location.Y = 50;
            Label sc_58029_ForeColorLabel = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_ForeColorLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 110, 25, "Fore Color: ");
            sc_58029_Gb.Controls.Add(sc_58029_ForeColorLabel);

            sc_58029_Location.X = sc_58029_Location.X + 115;
            sc_58029_Location.Y = 50;
            sc_58029_BackColor = Color.Silver;
            Label sc_58029_ForeColorChange = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_ForeColorChangeLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 60, 25, "");
            sc_58029_ForeColorChange.Click += new EventHandler(SC_58029_ForeColorChange_Click);
            sc_58029_Gb.Controls.Add(sc_58029_ForeColorChange);
            sc_58029_BackColor = Color.FromKnownColor(KnownColor.Control);

            sc_58029_Location.X = 440;
            sc_58029_Location.Y = 20;
            Label sc_58029_TopMarginLabel = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_TopMarginLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 111, 25, "Top margin: ");
            sc_58029_Gb.Controls.Add(sc_58029_TopMarginLabel);
            sc_58029_Location.X = sc_58029_Location.X + 113;
            sc_58029_Location.Y = 20;
            TextBox sc_58029_TopMarginBox = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_TopMargin", sc_58029_Location, 60, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            sc_58029_TopMarginBox.Leave += new EventHandler(SC_58029_ValueProtectorTopMargin);
            sc_58029_TopMarginBox.Text = "25";
            sc_58029_Gb.Controls.Add(sc_58029_TopMarginBox);


            sc_58029_Location.X = 440;
            sc_58029_Location.Y = 50;
            Label sc_58029_LeftMarginLabel = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_LeftMarginLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 111, 25, "Left margin: ");
            sc_58029_Gb.Controls.Add(sc_58029_LeftMarginLabel);
            sc_58029_Location.X = sc_58029_Location.X + 113;
            sc_58029_Location.Y = 50;
            TextBox sc_58029_LeftMarginBox = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_LeftMargin", sc_58029_Location, 60, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            sc_58029_LeftMarginBox.Leave += new EventHandler(SC_58029_ValueProtectorLeftMargin);
            sc_58029_LeftMarginBox.Text = "25";

            sc_58029_Gb.Controls.Add(sc_58029_LeftMarginBox);

            sc_58029_Location.X = 620;
            sc_58029_Location.Y = 20;
            Label sc_58029_ColumnShiftLabel = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_ColumnShiftLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 125, 25, "Column shift: ");
            sc_58029_Gb.Controls.Add(sc_58029_ColumnShiftLabel);
            sc_58029_Location.X = sc_58029_Location.X + 130;
            sc_58029_Location.Y = 20;
            TextBox sc_58029_ColumnShiftBox = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_ColumnShift", sc_58029_Location, 60, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            sc_58029_ColumnShiftBox.Leave += new EventHandler(SC_58029_ValueProtectorColumnShift);
            sc_58029_ColumnShiftBox.Text = "10";
            sc_58029_Gb.Controls.Add(sc_58029_ColumnShiftBox);


            sc_58029_Location.X = 620;
            sc_58029_Location.Y = 50;
            Label rowShiftLabel = sc_58029_Ctrl.SC_58029_Create_Label("SC_58029_RowShiftLabel", sc_58029_Location, sc_58029_Font, sc_58029_BackColor, sc_58029_ForeColor, 125, 25, "Row Shift: ");
            sc_58029_Gb.Controls.Add(rowShiftLabel);
            sc_58029_Location.X = sc_58029_Location.X + 130;
            sc_58029_Location.Y = 50;
            TextBox sc_58029_RowShiftBox = sc_58029_Ctrl.SC_58029_Create_TextBox("SC_58029_RowShift", sc_58029_Location, 60, 25, sc_58029_Font, sc_58029_TextBoxColor, sc_58029_ForeColor);
            sc_58029_RowShiftBox.Leave += new EventHandler(SC_58029_ValueProtectorRowShift);
            sc_58029_RowShiftBox.Text = "10";
            sc_58029_Gb.Controls.Add(sc_58029_RowShiftBox);

            Button sc_58029_GeneratePanel = sc_58029_Ctrl.SC_58029_Create_Button("SC_58029_GeneratePanel", 820, 20, 120, 50, sc_58029_Font, sc_58029_ForeColor, sc_58029_BackColor, "GENERATE");
            sc_58029_GeneratePanel.Click += new EventHandler(SC_58029_GeneratePanel_Click);
            sc_58029_GeneratePanel.MouseHover += new EventHandler(SC_58029_BtColor_MouseHover);
            sc_58029_GeneratePanel.MouseLeave += new EventHandler(SC_58029_BtDefault_MouseLeave);
            sc_58029_Gb.Controls.Add(sc_58029_GeneratePanel);

        }

        void SC_58029_Protector(ref string sc_58029_X, ref int sc_58029_Y, int sc_58029_Min, int sc_58029_Max)
        {
            TextBox sc_58029_Z = (TextBox)this.Controls.Find(sc_58029_X, true)[0]; 
            try
            {
                sc_58029_Y = Int32.Parse(sc_58029_Z.Text); 
            }
            catch (Exception)
            {


                sc_58029_Timer.Interval = 3500;
                sc_58029_Timer.Enabled = true;
                MessageBox.Show("Obsługiwane są tylko cyfry.\nWidth: 20-250;\nHeight: 20-100;\nTop Margin: 20-100;\nLeft Margin: 20-100;\nColumn Shift: 10-100;\nRow Shift: 10-100.");
                sc_58029_Z.Clear();
            }
        
            if (sc_58029_Y < sc_58029_Min || sc_58029_Y > sc_58029_Max)
            {
                sc_58029_Timer.Interval = 3500;
                sc_58029_Timer.Enabled = true;
                MessageBox.Show("Obsługiwane są tylko cyfry.\nWidth: 20-250;\nHeight: 20-100;\nTop Margin: 20-100;\nLeft Margin: 20-100;\nColumn Shift: 10-100;\nRow Shift: 10-100.");
                sc_58029_Z.Clear();
            }
        }
      
        private void SC_58029_ValueProtectorWidth(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            int sc_58029_Z = 25;
            string sc_58029_X = "SC_58029_Width";
            int sc_58029_Min = 20;
            int sc_58029_Max = 250;
            SC_58029_Protector(ref sc_58029_X, ref sc_58029_Z, sc_58029_Min, sc_58029_Max);
        }
        private void SC_58029_ValueProtectorTopMargin(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            int sc_58029_Z = 25;
            string sc_58029_X = "SC_58029_TopMargin";
            int sc_58029_Min = 20;
            int sc_58029_Max = 100;
            SC_58029_Protector(ref sc_58029_X, ref sc_58029_Z, sc_58029_Min, sc_58029_Max);
        }
        private void SC_58029_ValueProtectorLeftMargin(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            int sc_58029_Z = 25;
            string sc_58029_X = "SC_58029_LeftMargin";
            int sc_58029_Min = 20;
            int sc_58029_Max = 100;
            SC_58029_Protector(ref sc_58029_X, ref sc_58029_Z, sc_58029_Min, sc_58029_Max);
        }
        private void SC_58029_ValueProtectorHeight(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            int sc_58029_Z = 25;
            string sc_58029_X = "SC_58029_Height";
            int sc_58029_Min = 20;
            int sc_58029_Max = 100;
            SC_58029_Protector(ref sc_58029_X, ref sc_58029_Z, sc_58029_Min, sc_58029_Max);
        }
        private void SC_58029_ValueProtectorColumnShift(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            int sc_58029_Z = 25;
            string sc_58029_X = "SC_58029_ColumnShift";
            int sc_58029_Min = 10;
            int sc_58029_Max = 100;
            SC_58029_Protector(ref sc_58029_X, ref sc_58029_Z, sc_58029_Min, sc_58029_Max);
        }
        private void SC_58029_ValueProtectorRowShift(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            int sc_58029_Z = 25;
            string sc_58029_X = "SC_58029_RowShift";
            int sc_58029_Min = 10;
            int sc_58029_Max = 100;
            SC_58029_Protector(ref sc_58029_X, ref sc_58029_Z, sc_58029_Min, sc_58029_Max);
        }

    
        void SC_58029_ForeColorChange_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            ColorDialog sc_58029_ColorChange = new ColorDialog();
            if (sc_58029_ColorChange.ShowDialog() == DialogResult.OK)
            {
                Control sc_58029_FindLabel = this.Controls.Find("SC_58029_ForeColorChangeLabel", true)[0]; 
                sc_58029_FindLabel.BackColor = sc_58029_ColorChange.Color; 
            }
        }

        void SC_58029_BackColorChange_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            ColorDialog sc_58029_ColorChange = new ColorDialog();
            if (sc_58029_ColorChange.ShowDialog() == DialogResult.OK)
            {
                Control sc_58029_FindLabel = this.Controls.Find("SC_58029_BackColorChangeLabel", true)[0];
                sc_58029_FindLabel.BackColor = sc_58029_ColorChange.Color;
            }

        }
       

        void SC_58029_GeneratePanel_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            GroupBox sc_58029_Gb = (GroupBox)this.Controls.Find("SC_58029_GbWorkPanel", true)[0];
            if (sc_58029_Gb.Controls.Count > 0)
                sc_58029_Gb.Controls.Clear();
            SC_58029_ManualGenerate(sc_58029_Gb);
        }


        private void SC_58029_ManualGenerate(GroupBox sc_58029_Gb)
        {
            int sc_58029_TopMargin = 0;
            int sc_58029_LeftMargin = 0;
            int sc_58029_BoxWidth = 0;                 
            int sc_58029_BoxHeight = 0;
            int sc_58029_ColumnShift = 0;
            int sc_58029_RowShift = 0;
            Control sc_58029_FindForeColor = this.Controls.Find("SC_58029_ForeColorChangeLabel", true)[0];
            Control sc_58029_FindBackColor = this.Controls.Find("SC_58029_BackColorChangeLabel", true)[0];
            Control sc_58029_FindTopMargin = this.Controls.Find("SC_58029_TopMargin", true)[0];
            Control sc_58029_FindLeftMargin = this.Controls.Find("SC_58029_LeftMargin", true)[0];
            Control sc_58029_FindHeight = this.Controls.Find("SC_58029_Height", true)[0];                         
            Control sc_58029_FindWidth = this.Controls.Find("SC_58029_Width", true)[0];
            Control sc_58029_FindColumnShift = this.Controls.Find("SC_58029_ColumnShift", true)[0];
            Control sc_58029_FindRowShift = this.Controls.Find("SC_58029_RowShift", true)[0];
            try
            {
                sc_58029_TopMargin = Int32.Parse(sc_58029_FindTopMargin.Text);
                sc_58029_LeftMargin = Int32.Parse(sc_58029_FindLeftMargin.Text);
                sc_58029_BoxWidth = Int32.Parse(sc_58029_FindWidth.Text);
                sc_58029_BoxHeight = Int32.Parse(sc_58029_FindHeight.Text);                               
                sc_58029_ColumnShift = Int32.Parse(sc_58029_FindColumnShift.Text);
                sc_58029_RowShift = Int32.Parse(sc_58029_FindRowShift.Text);

            }
            catch (Exception)
            {
                sc_58029_Timer.Interval = 3500;
                sc_58029_Timer.Enabled = true;
                MessageBox.Show("Obsługiwane są tylko cyfry.\nWidth: 20-250;\nHeight: 20-100;\nTop Margin: 20-100;\nLeft Margin: 20-100;\nColumn Shift: 10-100;\nRow Shift: 10-100.");

            }
            int sc_58029_NbOfControlls = 150;
            string sc_58029_ControlName = "";
            Point sc_58029_ControllPoint = new Point(sc_58029_LeftMargin, sc_58029_TopMargin);  
            Font sc_58029_LabelFont = new Font("Arial", 12, FontStyle.Bold);
            Font sc_58029_TextBoxFont = new Font("Arial", 8, FontStyle.Bold);                        
            Color sc_58029_LabelColor = Color.FromKnownColor(KnownColor.Control);
            Color sc_58029_TextBoxColor = sc_58029_FindBackColor.BackColor;
            Color sc_58029_ForeColor = sc_58029_FindForeColor.BackColor;                       


            int sc_58029_LabelWidth = 50;
            int sc_58029_LabelHeight = sc_58029_BoxHeight;                 




         

            for (int sc_58029_I = 1; sc_58029_I <= sc_58029_NbOfControlls; sc_58029_I++)
            {
           
                sc_58029_ControlName = "SC_58029_Lb" + sc_58029_I.ToString();
                Label sc_58029_NewLabel = sc_58029_Ctrl.SC_58029_Create_Label(sc_58029_ControlName, sc_58029_ControllPoint, sc_58029_LabelFont, sc_58029_LabelColor, sc_58029_ForeColor, sc_58029_LabelWidth, sc_58029_LabelHeight, sc_58029_I.ToString());
                sc_58029_Gb.Controls.Add(sc_58029_NewLabel);
                sc_58029_ControllPoint.X = sc_58029_ControllPoint.X + 50;
                sc_58029_ControllPoint.Y = sc_58029_ControllPoint.Y + 0;
             
                sc_58029_ControlName = "SC_58029_Tb" + sc_58029_I.ToString();
                TextBox sc_58029_NewTextBox = sc_58029_Ctrl.SC_58029_Create_TextBox(sc_58029_ControlName, sc_58029_ControllPoint, sc_58029_BoxWidth, sc_58029_BoxHeight, sc_58029_TextBoxFont, sc_58029_TextBoxColor, sc_58029_ForeColor);
                sc_58029_Gb.Controls.Add(sc_58029_NewTextBox);
                sc_58029_ControllPoint.X = sc_58029_LeftMargin;
               
                if (sc_58029_ControllPoint.Y + sc_58029_RowShift + (2 * sc_58029_BoxHeight) > sc_58029_Gb.Height)
                {
                    sc_58029_LeftMargin = sc_58029_LeftMargin + sc_58029_LabelWidth + sc_58029_BoxWidth + sc_58029_ColumnShift;
                    sc_58029_ControllPoint.X = sc_58029_LeftMargin;
                    sc_58029_ControllPoint.Y = sc_58029_TopMargin;
                }
                else
                    sc_58029_ControllPoint.Y = sc_58029_ControllPoint.Y + sc_58029_RowShift + sc_58029_BoxHeight;
             
                if (sc_58029_ControllPoint.X + sc_58029_LabelWidth + sc_58029_BoxWidth > sc_58029_Gb.Width)
                    sc_58029_I = sc_58029_NbOfControlls;
            }
        }
       
        void sc_58029_BoxChecked(object sc_58029_Sender, EventArgs sc_58029_E)
        {

            GroupBox sc_58029_Gb = (GroupBox)this.Controls.Find("SC_58029_GbWorkPanel", true)[0]; 
            CheckBox sc_58029_Cb = sc_58029_Sender as CheckBox;
            if (sc_58029_Cb.Checked)
            {
                foreach (var sc_58029_Box in sc_58029_Gb.Controls.OfType<TextBox>()) 
                    sc_58029_Box.Show();
            }
            else
                foreach (var sc_58029_Box in sc_58029_Gb.Controls.OfType<TextBox>())
                    sc_58029_Box.Hide(); 
            return;

        }
      
        private void sc_58029_LabelChecked(object sc_58029_Sender, EventArgs sc_58029_E)
        {

            GroupBox sc_58029_Gb = (GroupBox)this.Controls.Find("SC_58029_GbWorkPanel", true)[0];
            CheckBox sc_58029_Cb = sc_58029_Sender as CheckBox;
            if (sc_58029_Cb.Checked)
            {
                foreach (var sc_58029_Label in sc_58029_Gb.Controls.OfType<Label>()) 
                    sc_58029_Label.Show();
            }
            else
                foreach (var sc_58029_Label in sc_58029_Gb.Controls.OfType<Label>())
                    sc_58029_Label.Hide();
            return;
        }

        void SC_58029_BtAutoGenerate_Click(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            GroupBox sc_58029_Gb = (GroupBox)this.Controls.Find("SC_58029_GbWorkPanel", true)[0]; 
            if (sc_58029_Gb.Controls.Count > 0)                                                   
                sc_58029_Gb.Controls.Clear();                                                    

            SC_58029_AutoGenerateControlls(sc_58029_Gb);                                     
        }



        void SC_58029_BtDefault_MouseLeave(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            SC_58029_ChangeColor(sc_58029_Sender, 2);
        }

        void SC_58029_BtColor_MouseHover(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            SC_58029_ChangeColor(sc_58029_Sender, 1);
        }

        void SC_58029_ChangeColor(object sc_58029_Sender, int sc_58029_Mode)
        {
            Button sc_58029_Button = sc_58029_Sender as Button;
            switch (sc_58029_Mode)
            {
                case 1:
                    sc_58029_Button.BackColor = Color.GreenYellow;
                    break;
                case 2:
                    sc_58029_Button.BackColor = Color.FromKnownColor(KnownColor.Control);
                    break;
            }
        }

        void SC_58029_AutoGenerateControlls(GroupBox sc_58029_Gb)
        {

         
            int sc_58029_TopMargin = 20;
            int sc_58029_LeftMargin = 15;
            int sc_58029_LabelWidth = 50;
            int sc_58029_LabelHeight = 25;
            int sc_58029_NbOfControlls = 110;
            string sc_58029_ControlName = "";
            Point sc_58029_ControllPoint = new Point(sc_58029_LeftMargin, sc_58029_TopMargin);
            Font sc_58029_LabelFont = new Font("Tahoma", 12, FontStyle.Bold);
            Font sc_58029_TextBoxFont = new Font("Tahoma", 8, FontStyle.Bold);
            Color sc_58029_LabelColor = Color.FromKnownColor(KnownColor.Control);
            Color sc_58029_TextBoxColor = Color.Bisque;
            Color sc_58029_ForeColor = Color.Red;
       
            for (int sc_58029_I = 1; sc_58029_I <= sc_58029_NbOfControlls; sc_58029_I++)
            {

                sc_58029_ControlName = "SC_58029_Lb" + sc_58029_I.ToString();
                Label sc_58029_NewLabel = sc_58029_Ctrl.SC_58029_Create_Label(sc_58029_ControlName, sc_58029_ControllPoint, sc_58029_LabelFont, sc_58029_LabelColor, sc_58029_ForeColor, sc_58029_LabelWidth, sc_58029_LabelHeight, sc_58029_I.ToString());
                sc_58029_Gb.Controls.Add(sc_58029_NewLabel);
                sc_58029_ControllPoint.X = sc_58029_ControllPoint.X + 50;
                sc_58029_ControllPoint.Y = sc_58029_ControllPoint.Y + 0;
       
                sc_58029_ControlName = "SC_58029_Tb" + sc_58029_I.ToString();
                TextBox sc_58029_NewTextBox = sc_58029_Ctrl.SC_58029_Create_TextBox(sc_58029_ControlName, sc_58029_ControllPoint, 60, 20, sc_58029_TextBoxFont, sc_58029_TextBoxColor, sc_58029_ForeColor);
                sc_58029_Gb.Controls.Add(sc_58029_NewTextBox);
                sc_58029_ControllPoint.X = sc_58029_LeftMargin;
           
                if (sc_58029_ControllPoint.Y + 35 > sc_58029_Gb.Height)
                {
                    sc_58029_LeftMargin = sc_58029_LeftMargin + 130;
                    sc_58029_ControllPoint.X = sc_58029_LeftMargin;
                    sc_58029_ControllPoint.Y = sc_58029_TopMargin;
                }
                else
                    sc_58029_ControllPoint.Y = sc_58029_ControllPoint.Y + 25;
              
                if (sc_58029_ControllPoint.X + 125 > sc_58029_Gb.Width)
                    sc_58029_I = sc_58029_NbOfControlls;

            }
        }
       
        private void sc_58029_Timer_Tick(object sc_58029_Sender, EventArgs sc_58029_E)
        {
            sc_58029_Timer.Enabled = false;
            SendKeys.Send("{ESC}");
        }
    }
}

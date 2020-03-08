using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace Task_4
{
    public partial class Form1 : Form
    {
        private ColorDialog chooseColorDialog = new ColorDialog();
        private FontDialog chooseFontDialog = new FontDialog();
        public Form1()
        {
            InitializeComponent();

            btnBackgroundColor.Click += new EventHandler(OnClickbtnBackgroundColor);
            btnTextColor.Click += new EventHandler(OnClickbtnTextColor);
            btnStileText.Click += new EventHandler(OnClickbtnStileText);
            try 
            { 
                if (ReadSettings() == false)
                {
                    this.labelSetings.Text =("No settings");
                }
                else
                {
                    this.labelSetings.Text=("Settings uploaded successfully");
                }
            }
            catch (Exception e)
            {
                
                this.labelSetings.Text = ("ERROR"+e.Message);
            }


        }

        private bool ReadSettings()
        {
            // Загрузка настроек по парам [ключ]-[значение].
            NameValueCollection allAppSettings = ConfigurationManager.AppSettings;
            if (allAppSettings.Count < 1) { return (false); }
            

            //1. Цвет фона.
            int red = Convert.ToInt32(allAppSettings["BackGroundColor.R"]);
            int green = Convert.ToInt32(allAppSettings["BackGroundColor.G"]);
            int blue = Convert.ToInt32(allAppSettings["BackGroundColor.B"]);
            this.tabMain.BackColor = Color.FromArgb(red, green, blue);;
            this.tabOption.BackColor = Color.FromArgb(red, green, blue);

            //2. Размеры окна.
            this.Height = Convert.ToInt32(allAppSettings["Window.Height"]);
            this.Width = Convert.ToInt32(allAppSettings["Window.Width"]);

            //3. Состояние окна.
            string winState = allAppSettings["Window.State"];

            this.WindowState = (FormWindowState)FormWindowState.Parse(WindowState.GetType(), winState);

            //4. Цвет шрифта
            red = Convert.ToInt32(allAppSettings["ForeColor.R"]);
            green = Convert.ToInt32(allAppSettings["ForeColor.G"]);
            blue = Convert.ToInt32(allAppSettings["ForeColor.B"]);

            this.btnBackgroundColor.ForeColor = Color.FromArgb(red, green, blue);
            this.btnSaveSettings.ForeColor = Color.FromArgb(red, green, blue);
            this.btnStileText.ForeColor = Color.FromArgb(red, green, blue);
            this.btnTextColor.ForeColor = Color.FromArgb(red, green, blue);
            this.labelSetings.ForeColor = Color.FromArgb(red, green, blue);


            //5. Шрифт
            //"[Font: Name=Microsoft YaHei, Size=15,75, Units=3, GdiCharSet=204, GdiVerticalFont=False]"
            //string familyName, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet, bool gdiVerticalFont
            string userFontSet = allAppSettings["Font"];
            //Делю userFontSet на подстроки 
            string[] str = userFontSet.Split(new char[] { '=' });

            //Добываю семейство шрифта
            string familyName = str[1].Substring(0, str[1].IndexOf(","));
          

            //Добываю размер шрифта
            double dubleTemp = Convert.ToDouble(str[2].Substring(0, str[2].LastIndexOf(',')));
            float emSize = (float)dubleTemp;
           

            //Без этого работать не будет
            FontStyle style = 0;
            //Добываю unit 
            dubleTemp = Convert.ToDouble(str[3].Substring(0, str[3].IndexOf(',')));
            GraphicsUnit unit = (GraphicsUnit)dubleTemp;

            //Добываю CharSet
            byte gdiCharSet = Convert.ToByte(str[4].Substring(0, str[4].IndexOf(',')));

            //Добываю VerticalFont
            bool gdiVerticalFont = Convert.ToBoolean(str[5].Substring(0, str[5].IndexOf(']')));

            Font font = new Font(familyName, emSize, style, unit, gdiCharSet, gdiVerticalFont);
            this.btnBackgroundColor.Font = font;
            this.btnSaveSettings.Font = font;
            this.btnStileText.Font = font;
            this.btnTextColor.Font = font;
            this.labelSetings.Font = font;



            this.labelSetings.Location = new System.Drawing.Point(this.Size.Width / 3, this.Size.Height / 3);
            this.btnBackgroundColor.Width = this.Width - 100;
            this.btnSaveSettings.Width = this.Size.Width - 100;
            this.btnStileText.Width = this.Size.Width - 100;
            this.btnTextColor.Width = this.Size.Width - 100;

            return (true);
        }
        void SaveSettings()
        {
            XmlDocument doc = loadConfigDocument();

            XmlNode node = doc.SelectSingleNode("//appSettings");

            string[] keys = new string[] {
                "BackGroundColor.R",
                "BackGroundColor.G",
                "BackGroundColor.B",
                "Font",
                "ForeColor.R",
                "ForeColor.G",
                "ForeColor.B",
                "Window.Height",
                "Window.Width",
                "Window.State"
            };
            string[] values = new string[] {
                tabMain.BackColor.R.ToString(),
                tabMain.BackColor.G.ToString(),
                tabMain.BackColor.B.ToString(),
                labelSetings.Font.ToString(),
                labelSetings.ForeColor.R.ToString(),
                labelSetings.ForeColor.G.ToString(),
                labelSetings.ForeColor.B.ToString(),
                Height.ToString(),
                Width.ToString(),
                WindowState.ToString() 
            };
            for (int i = 0; i < keys.Length; i++)
            {

                XmlElement element = node.SelectSingleNode(string.Format("//add[@key='{0}']", keys[i])) as XmlElement;

                if (element != null) { element.SetAttribute("value", values[i]); }
                else
                {
                    element = doc.CreateElement("add");
                    element.SetAttribute("key", keys[i]);
                    element.SetAttribute("value", values[i]);
                    node.AppendChild(element);
                }
            }
            doc.Save(Assembly.GetExecutingAssembly().Location + ".config");
        }
        private static XmlDocument loadConfigDocument()
        {
            XmlDocument doc = null;
            try
            {
                doc = new XmlDocument();
                doc.Load(Assembly.GetExecutingAssembly().Location + ".config");
                return doc;
            }
            catch (System.IO.FileNotFoundException e)
            {
                throw new Exception("No configuration file found.", e);
            }
        }

        private void OnClickbtnStileText(object sender, EventArgs e)
        { 
            if(chooseFontDialog.ShowDialog() == DialogResult.OK)
            {
                this.btnBackgroundColor.Font = chooseFontDialog.Font;
                this.btnSaveSettings.Font = chooseFontDialog.Font;
                this.btnStileText.Font = chooseFontDialog.Font;
                this.btnTextColor.Font = chooseFontDialog.Font;
                this.labelSetings.Font = chooseFontDialog.Font;
            }
        }
        private void OnClickbtnTextColor(object sender, EventArgs e)
       {
            if (chooseColorDialog.ShowDialog() == DialogResult.OK)
            {
                this.btnBackgroundColor.ForeColor = chooseColorDialog.Color;
                this.btnSaveSettings.ForeColor = chooseColorDialog.Color;
                this.btnStileText.ForeColor = chooseColorDialog.Color;
                this.btnTextColor.ForeColor = chooseColorDialog.Color;
                this.labelSetings.ForeColor = chooseColorDialog.Color;
                
            }
        }

        void OnClickbtnBackgroundColor(object Sender, EventArgs e)
        {
            if (chooseColorDialog.ShowDialog() == DialogResult.OK)
            {
                this.tabMain.BackColor = chooseColorDialog.Color;
                this.tabOption.BackColor = chooseColorDialog.Color;
            }
        }

        private void TabOption_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {

        }

        private void labelMain_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
                        SaveSettings();
        }
    }
}

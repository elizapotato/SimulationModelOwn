using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge1
{   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        float fabric = 1000;
        float Rdye = 100;
        float Bdye = 100;
        float Ydye = 100;
        float Kdye = 100;

        private void startb_Click(object sender, EventArgs e)
        {
            int Amount = (int)nudAmount.Value;
            Colour colour = new ColourWhite();
            Clothes clothes;
            switch (cbColour.SelectedIndex)
            {               
                case 1:
                    {
                        colour = new ColourBlack();
                        break;
                    }
                case 2:
                    {
                        colour = new ColourRed();
                        break;
                    }
                case 3:
                    {
                        colour = new ColourGreen();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            switch (cbClothes.SelectedIndex)
            {
                default:
                    {
                        clothes = new TShirt(colour);
                        break;
                    }
                case 1:
                    {
                        clothes = new Pants(colour);
                        break;
                    }
                case 2:
                    {
                        clothes = new Dress(colour);
                        break;
                    }

            }

            clothes.Produce(ref fabric, ref Rdye,ref Bdye,ref Ydye,ref Kdye,Amount);

            labFabric.Text = "Ткань (кв.м): " + fabric;
            labR.Text = "Красный краситель (г): " + Rdye;
            labB.Text = "Синий краситель (г): " + Bdye;
            labY.Text = "Желтый краситель (г): " + Ydye;
            labK.Text = "Черный краситель (г): " + Kdye;


            logBox.Text = logBox.Text + clothes.Log(Amount);

        }

        private void restartb_Click(object sender, EventArgs e)
        {
            if (fabric != 1000 || Rdye != 100 || Bdye != 100 || Ydye != 100 || Kdye != 100)
            {
                fabric = 1000;
                Rdye = 100;
                Bdye = 100;
                Ydye = 100;
                Kdye = 100;
                labFabric.Text = "Ткань (кв.м): " + fabric;
                labR.Text = "Красный краситель (г): " + Rdye;
                labB.Text = "Синий краситель (г): " + Bdye;
                labY.Text = "Желтый краситель (г): " + Ydye;
                labK.Text = "Черный краситель (г): " + Kdye;
                logBox.Text = logBox.Text + DateTime.Now.ToString() + " Обновление сырья" + Environment.NewLine;
            }
            else MessageBox.Show("Склад заполнен!");
        }
    }

    class Clothes
    {
        protected Colour _imp;
        
        public Clothes(Colour colour)
        {
            this._imp = colour;
        }

        public virtual void Produce(ref float fabric, ref float r, ref float b, ref float y, ref float k, int a)
        {

        }

        public virtual string Log(int a)
        {
            string text="";
            return text;
        }
    }

    class TShirt : Clothes
    {
        public TShirt(Colour colour):base(colour)
        {
            
        }

        public override void Produce(ref float fabric, ref float r, ref float b, ref float y, ref float k, int a)
        {
            if (fabric < 2 * a) MessageBox.Show("Недостаточно ткани");
            else
            {
                float i = (float)(a * 0.75);
                base._imp.Paint(ref r, ref b, ref y, ref k, ref i);
                if (i != 0) fabric = (float)(fabric - (2 * a));
            }
        }

        public override string Log(int a)
        {
            string text = DateTime.Now.ToString() +" Произведено " + base._imp.ColourText() + " футболки " + a + " шт."+ Environment.NewLine;
            return text;
        }


    }

    class Pants : Clothes
    {
        public Pants(Colour colour) : base(colour)
        {

        }

        public override void Produce(ref float fabric, ref float r, ref float b, ref float y, ref float k, int a)
        {
            if (fabric < 4 * a) MessageBox.Show("Недостаточно ткани");
            else
            {
                float i = (float)(a * 1.5);
                base._imp.Paint(ref r, ref b, ref y, ref k, ref i);
                if (i != 0) fabric = (float)(fabric - (4 * a));
            }
        }

        public override string Log(int a)
        {
            string text = DateTime.Now.ToString() + " Произведено " + base._imp.ColourText() + " брюк " + a + " шт." + Environment.NewLine;
            return text;
        }


    }

    class Dress : Clothes
    {
        public Dress(Colour colour) : base(colour)
        {

        }

        public override void Produce(ref float fabric, ref float r, ref float b, ref float y, ref float k, int a)
        {
            if (fabric < 3.5 * a) MessageBox.Show("Недостаточно ткани");
            else
            {                
                float i = (float)(a * 1.25);
                base._imp.Paint(ref r, ref b, ref y, ref k, ref i);
                if (i != 0) fabric = (float)(fabric - (3.5 * a));
            }
        }

        public override string Log(int a)
        {
            string text = DateTime.Now.ToString() + " Произведено " + base._imp.ColourText() + " платьев " + a + " шт." + Environment.NewLine;
            return text;
        }
    }

    interface Colour
    {
        void Paint(ref float r, ref float b, ref float y, ref float k, ref float i);
        string ColourText();
    }

    class ColourWhite : Colour
    {
        public void Paint(ref float r, ref float b, ref float y, ref float k, ref float i)
        {
            
        }

        public string ColourText()
        {
            string text = "бел.";
            return text;
        }
    }

    class ColourBlack : Colour
    {
        public void Paint(ref float r, ref float b, ref float y, ref float k, ref float i)
        {
            if (k < i)
            {
                i = 0;
                MessageBox.Show("Недостаточно черного красителя");
            }
            else k = k - i;
        }

        public string ColourText()
        {
            string text = "черн.";
            return text;
        }
    }

    class ColourRed : Colour
    {
        public void Paint(ref float r, ref float b, ref float y, ref float k, ref float i)
        {
            if (r < i)
            {
                i = 0;
                MessageBox.Show("Недостаточно красного красителя");
            }
            else r = r - i;
        }

        public string ColourText()
        {
            string text = "красн.";
            return text;
        }
    }

    class ColourGreen : Colour
    {
        public void Paint(ref float r, ref float b, ref float y, ref float k, ref float i)
        {
            if (b < i / 2 || y < i / 2)
            {
                i = 0;
                MessageBox.Show("Недостаточно красителей");
            }
            else
            {
                b = b - i / 2;
                y = y - i / 2;
            }
        }

        public string ColourText()
        {
            string text = "зел.";
            return text;
        }
    }
}

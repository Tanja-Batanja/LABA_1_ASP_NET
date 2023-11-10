using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA_2_FORMA
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            string zakaz="";
            int sum = 0;
            string str = " ";
            string foto1 = "";
            

            if (RBamericano.Checked)  { zakaz = "Американо"; sum = 150; foto1 = "Американо"; }
            if (RBcappuccino.Checked) { zakaz = "Капучино"; sum = 130; foto1 = "Капучино"; }
            if (RBespresso.Checked) { zakaz = "Эспрессо"; sum = 140; foto1 = "Эспрессо"; }
            if (RBcacao.Checked) { zakaz = "Какао"; sum = 120; foto1 = "Какао"; }

            IDrink drink = new Coffe(zakaz);
            zakaz = drink.cost();

            label.Text = Convert.ToString(zakaz);
                label2.Text = "Стоимость вашего заказа " + Convert.ToString(sum) + " руб.";
                
                // создание адреса картинки и её вывод на экран
                str = "C:/Users/79045/source/repos/LABA_1_DECORATOR/Иллюстрации/" + foto1 + ".PNG";
                pictureBox1.Image = new Bitmap(str);
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;

            if (CBsugar.Checked & CBmilk.Checked)
            {
                Shell XL = new Milk(new Sugar(drink));
                zakaz = XL.cost();
                label.Text = Convert.ToString(zakaz);
                sum += 70;
                label2.Text = "Стоимость вашего заказа " + Convert.ToString(sum) + " руб.";

                /// создание адреса картинки и её вывод на экран
                str = "C:/Users/79045/source/repos/LABA_1_DECORATOR/Иллюстрации/" + foto1 + ".PNG";
                pictureBox1.Image = new Bitmap(str);
                str = "C:/Users/79045/source/repos/LABA_1_DECORATOR/Иллюстрации/Сахар.PNG";
                pictureBox2.Visible = true;
                pictureBox2.Image = new Bitmap(str);
                str = "C:/Users/79045/source/repos/LABA_1_DECORATOR/Иллюстрации/Молоко.PNG";
                pictureBox3.Visible = true;
                pictureBox3.Image = new Bitmap(str);
            }

            if (CBmilk.Checked & !CBsugar.Checked)
            {  
            Shell milk = new Milk(drink);
            zakaz = milk.cost();
            label.Text = Convert.ToString(zakaz);
                sum += 50;
            label2.Text = "Стоимость вашего заказа " + Convert.ToString(sum) + " руб.";

                // создание адреса картинки и её вывод на экран
                str = "C:/Users/79045/source/repos/LABA_1_DECORATOR/Иллюстрации/" + foto1 + ".PNG";
                pictureBox1.Image = new Bitmap(str);
                str = "C:/Users/79045/source/repos/LABA_1_DECORATOR/Иллюстрации/Молоко.PNG";
                pictureBox2.Visible = true;
                pictureBox2.Image = new Bitmap(str);
                pictureBox3.Visible = false;

            }

            if (CBsugar.Checked & !CBmilk.Checked)
            {
                Shell sugar = new Sugar(drink);
                zakaz = sugar.cost();
                label.Text = Convert.ToString(zakaz);
                sum += 30;
                label2.Text = "Стоимость вашего заказа " + Convert.ToString(sum) + " руб.";
                
                // создание адреса картинки и её вывод на экран
                str = "C:/Users/79045/source/repos/LABA_1_DECORATOR/Иллюстрации/" + foto1 + ".PNG";
                pictureBox1.Image = new Bitmap(str);
                str = "C:/Users/79045/source/repos/LABA_1_DECORATOR/Иллюстрации/Сахар.PNG";
                pictureBox2.Visible = true;
                pictureBox2.Image = new Bitmap(str);
                pictureBox3.Visible = false;
            }
            
        }

        private void RBamericano_CheckedChanged(object sender, EventArgs e)
        {
            butOK.Visible = true;
        }

        private void RBcappuccino_CheckedChanged(object sender, EventArgs e)
        {
            butOK.Visible = true;
        }

        private void RBespresso_CheckedChanged(object sender, EventArgs e)
        {
            butOK.Visible = true;
        }

        private void RBcacao_CheckedChanged(object sender, EventArgs e)
        {
            butOK.Visible = true;
        }
    }
}
interface IDrink
{
    string cost();
}

class Coffe : IDrink
{
    private string data;
    public Coffe(string data) => this.data = data; // конструктор
    public string cost()
    {
        return "Вы заказали " + data;
    }
}
abstract class Shell : IDrink //decorator
{
    protected IDrink processor;
    public Shell(IDrink pr) => processor = pr;   // конструктор
    public virtual string cost() => processor.cost();
}

class Milk : Shell
{
    string zak;
    public Milk(IDrink pr) : base(pr) { } //конструктор
    public override string cost()
    {
        zak=processor.cost();

        return zak + " с молоком";

    }
}

class Sugar : Shell
{
    string zak;
    public Sugar(IDrink pr) : base(pr) { } //конструктор
    public override string cost()
    {
        zak = processor.cost();

        return zak + " с сахаром";


    }
}

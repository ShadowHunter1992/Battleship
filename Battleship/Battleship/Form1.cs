using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Battleship
{
   
    public partial class Form1 : Form
    {
        
        public int longer;
        bool showclikc=false;
        bool hideclick = false;
        bool located = false;
        Dictionary<string, bool> dict = new Dictionary<string, bool>();
        Dictionary<string, bool> etrafi = new Dictionary<string, bool>();
        public Form1()
        {
            InitializeComponent();
        }
        //LOVHEE YARATMAQ 
        public void CreateBoard(int a)
        {
            longer = a;
            for(var i=1;i<=a;i++)
            {
                Label x = new Label();
                x.Text = i.ToString();
                x.Size = new Size(25, 15);
                x.Location = new Point(10, i * 40+10);
                x.ForeColor = Color.Bisque;
                Controls.Add(x);
              
                Label y = new Label();
                y.Text = i.ToString();
                y.Location = new Point(i * 40+10, 10);
                y.Size = new Size(25, 15);
                    y.ForeColor = Color.Bisque;
                Controls.Add(y);
               
                for (var j=1;j<=a;j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(40, 40);
                    btn.Location = new Point(j * 40,i * 40);
                   
                    btn.UseVisualStyleBackColor = true;
                    btn.Name = System.String.Format("{0},{1}", i, j);
                    dict.Add(btn.Name, false);
                    etrafi.Add(btn.Name, false);
                    Controls.Add(btn);
                    
                   
                }
            }
            foreach(var btnlar in dict.Keys)
            {
                Button btn = Controls.Find(btnlar, true).First() as Button;
                btn.Click += new EventHandler(delegate (object sender, EventArgs e)
                 {
                     Button snd = (Button)sender;
                     if(dict[btnlar]==true)
                     {
                         snd.BackColor = Color.Black;
                         MessageBox.Show("ugurlar geminin bir pacasin vurmusan");
                         snd.Enabled = false;
                     }
                     else
                     {
                         snd.BackColor = Color.Red;
                         MessageBox.Show("Teesuf Novbeti Cehdi edin");
                         snd.Enabled = false;
                     }
                     
                 });
            }
        }
        public void vurmaq(object sender, EventArgs e,Ships gemi)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateBoard(10);
           
        }
        //GEMILERI YERLEWDIRMEK(button kliki)
        private void LocateShip_Click(object sender, EventArgs e)
        {

            Ships four = new Ships(4);
            Ships third = new Ships(3);
            Ships third1 = new Ships(3);
            Ships two = new Ships(2);
            Ships two1 = new Ships(2);
            Ships two2 = new Ships(2);
            Ships one = new Ships(1);
            Ships one1 = new Ships(1);
            Ships one2 = new Ships(1);
            Ships one3 = new Ships(1);

            //for (var a = 0; a < Ships.listship.Count; a++)
            //{

                locate(Ships.listship[0]);
                locate(Ships.listship[1]);
                locate(Ships.listship[4]);


            //}
            LocateShip.Enabled = false;
            located = true;
            showship.Enabled = true;
        }
        //GEMILERI YERLEWDIRMEK KOORDINANATLARI
        public void locate(Ships gemi)
        {
           


            Random rndm = new Random();
            Thread.Sleep(10);
            Random rndm1 = new Random();
            int a = rndm.Next(1, 11);
            int b = rndm1.Next(11, 21) -10;
            string x = string.Format("{0},{1}", a, b);
            if (a <= 7 && b <= 7/*&&gemi.size<5)||((a<=8&&b<=8)&&gemi.size<4)|| ((a <= 9 && b <=9) && gemi.size < 3)|| ((a <= 10&& 10 <= 9) && gemi.size < 2)*/)
            {
                if (dict[x] == false)
                {
                    if((a+b)%2==0)
                    {
                        for (var sizee = 0; sizee < gemi.size; sizee++)
                        {
                            x = string.Format("{0},{1}", a, b + sizee);
                            if (dict[x] != true)
                            {
                                dict[x] = true;
                            }
                            else
                            { locate(gemi); }

                        }
                    }
                    else
                    {
                        {
                            for (var sizee = 0; sizee < gemi.size; sizee++)
                            {
                                x = string.Format("{0},{1}", a + sizee, b);
                                if (dict[x] != true)
                                {
                                    dict[x] = true;
                                }
                                else
                                { locate(gemi); }

                            }
                        }
                    }

                }
                else
                {
                    locate(gemi);
                }
            }
            
            else
            {
                locate(gemi);
            }
            located=true;
            if (gemi.bang == gemi.size)
            {
                textBox1.Text = System.String.Format("{0} olculu gemin vuruldu", gemi.size);
            }
        }
        //GEMILERI GOSTER
        private void showship_Click(object sender, EventArgs e)
        {

            if (located == true)
            {
                if (DialogResult.Cancel == MessageBox.Show("Həvəsdən Düşmə Axtar", "Attempt Again", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information))
                {
                    foreach (var x in dict.Keys)
                    {
                        if (dict[x] == true)
                        {
                            Button a = Controls.Find(x, true).First() as Button;
                            a.BackColor = Color.Aqua;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("gemiler yerlewdirilmeyib");
            }
         }
        //GEMILERI GIZLET
        private void hideship_Click(object sender, EventArgs e)
        {
           if(located==true)
            { 
                foreach (var x in dict.Keys)
                {
                    Button a = Controls.Find(x, true).First() as Button;
                    a.UseVisualStyleBackColor = true;
                }
            }
            else
            { MessageBox.Show("Gemi yerlwdirmisen ki gizledesen"); }
           
        }

        private void clear_Click(object sender, EventArgs e)
        {
            LocateShip.Enabled = true;
            for( var a=0;a<dict.Count;a++)
            {
                var x = dict.ElementAt(a);
                var key = x.Key;
                var value = x.Value;
                if (dict[key] == true)
                {
                    dict[key] = false;
                }
               
            }
            foreach (var x in dict.Keys)
            {
                Button a = Controls.Find(x, true).First() as Button;
                a.UseVisualStyleBackColor = true;
            }
          
        }
    }
}

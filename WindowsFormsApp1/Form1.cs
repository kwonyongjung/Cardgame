using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void p1card1_Click(object sender, EventArgs e)
        {
            Win();
            if (turn == 0)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (p1card1name.Text.Equals(create_card[i].get_name()))
                    {
                        p1card1.Visible = this.p1card1.Visible = true;
                        p1card1name.Text = create_card[0].get_name();
                        card.Visible = this.card.Visible = true;
                        try
                        {
                            p1card1.Image = System.Drawing.Image.FromFile(create_card[0].get_image());
                            card.Image = System.Drawing.Image.FromFile(create_card[i].get_image());
                        }
                        catch (Exception)
                        {

                        };
                        if (i > 16 && i < 21)
                        {
                            c_damege = create_card[i].get_attak();
                            p1hp -= t_damege;
                            p1hp += c_damege;
                            t_damege = 0;
                            c_damege = 0;
                            p1hp_label.Text = "HP: " + p1hp;
                            current_damege.Text = c_damege + "";
                            total_damage.Text = t_damege + "";
                            turn++;

                        }
                        else if (i > 20)
                        {
                            if (i == 21)
                            {
                                t_damege = 0;
                                c_damege = 0;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else if (i == 22)
                            {
                                p2hp -= 20;
                                t_damege = 0;
                                c_damege = 0;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else if (i == 23)
                            {
                                p1hp -= t_damege;
                                p2hp = p1hp;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else
                            {
                                p1hp -= t_damege;
                                t_damege = 0;
                                c_damege = 0;

                                int num = 0;
                                Random r = new Random();

                                num = r.Next(1, 25);
                                p2card1.Visible = this.p2card1.Visible = true;
                                try
                                {
                                    p2card1.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card1name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card2.Visible = this.p2card2.Visible = true;
                                try
                                {
                                    p2card2.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card2name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card3.Visible = this.p2card3.Visible = true;
                                try
                                {
                                    p2card3.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card3name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card4.Visible = this.p2card4.Visible = true;
                                try
                                {
                                    p2card4.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                };
                                p2card4name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card5.Visible = this.p2card5.Visible = true;
                                try
                                {
                                    p2card5.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card5name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card6.Visible = this.p2card6.Visible = true;
                                try
                                {
                                    p2card6.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card6name.Text = create_card[num].get_name();

                                p1hp_label.Text = "HP:" + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                        }
                        else
                        {

                            if (c_damege >= create_card[i].get_attak())
                            {
                                p1hp -= t_damege;
                                c_damege = create_card[i].get_attak();
                                t_damege = create_card[i].get_attak();
                                p1hp_label.Text = "HP: " + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else
                            {
                                c_damege = create_card[i].get_attak();
                                t_damege += c_damege;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("당신의 턴이 아닙니다.");
            }
        }

        private void p1card2_Click(object sender, EventArgs e)
        {
            Win();
            if (turn == 0)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (p1card2name.Text.Equals(create_card[i].get_name()))
                    {
                        p1card2.Visible = this.p1card2.Visible = true;
                        p1card2name.Text = create_card[0].get_name();
                        card.Visible = this.card.Visible = true;
                        try
                        {
                            p1card2.Image = System.Drawing.Image.FromFile(create_card[0].get_image());
                            card.Image = System.Drawing.Image.FromFile(create_card[i].get_image());
                        }
                        catch (Exception)
                        {

                        }
                        if (i > 16 && i < 21)
                        {
                            c_damege = create_card[i].get_attak();
                            p1hp -= t_damege;
                            p1hp += c_damege;
                            t_damege = 0;
                            c_damege = 0;
                            p1hp_label.Text = "HP: " + p1hp;
                            current_damege.Text = c_damege + "";
                            total_damage.Text = t_damege + "";
                            turn++;

                        }
                        else if (i > 20)
                        {
                            if (i == 21)
                            {
                                t_damege = 0;
                                c_damege = 0;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else if (i == 22)
                            {
                                p2hp -= 20;
                                t_damege = 0;
                                c_damege = 0;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else if (i == 23)
                            {
                                p1hp -= t_damege;
                                p2hp = p1hp;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else
                            {
                                p1hp -= t_damege;
                                t_damege = 0;
                                c_damege = 0;

                                int num = 0;
                                Random r = new Random();

                                num = r.Next(1, 25);
                                p2card1.Visible = this.p2card1.Visible = true;
                                try
                                {
                                    p2card1.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card1name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card2.Visible = this.p2card2.Visible = true;
                                try
                                {
                                    p2card2.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card2name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card3.Visible = this.p2card3.Visible = true;
                                try
                                {
                                    p2card3.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card3name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card4.Visible = this.p2card4.Visible = true;
                                try
                                {
                                    p2card4.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                };
                                p2card4name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card5.Visible = this.p2card5.Visible = true;
                                try
                                {
                                    p2card5.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card5name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card6.Visible = this.p2card6.Visible = true;
                                try
                                {
                                    p2card6.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card6name.Text = create_card[num].get_name();

                                p1hp_label.Text = "HP:" + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                        }
                        else
                        {
                            if (c_damege >= create_card[i].get_attak())
                            {
                                p1hp -= t_damege;
                                c_damege = create_card[i].get_attak();
                                t_damege = create_card[i].get_attak();
                                p1hp_label.Text = "HP: " + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else
                            {
                                c_damege = create_card[i].get_attak();
                                t_damege += c_damege;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("당신의 턴이 아닙니다.");
            }
        }

        private void p1card3_Click(object sender, EventArgs e)
        {
            Win();
            if (turn == 0)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (p1card3name.Text.Equals(create_card[i].get_name()))
                    {
                        p1card3.Visible = this.p1card3.Visible = true;
                        p1card3name.Text = create_card[0].get_name();
                        card.Visible = this.card.Visible = true;
                        try
                        {
                            p1card3.Image = System.Drawing.Image.FromFile(create_card[0].get_image());
                            card.Image = System.Drawing.Image.FromFile(create_card[i].get_image());
                        }
                        catch (Exception)
                        {

                        }
                        if (i > 16 && i < 21)
                        {
                            c_damege = create_card[i].get_attak();
                            p1hp -= t_damege;
                            p1hp += c_damege;
                            t_damege = 0;
                            c_damege = 0;
                            p1hp_label.Text = "HP: " + p1hp;
                            current_damege.Text = c_damege + "";
                            total_damage.Text = t_damege + "";
                            turn++;

                        }
                        else if (i > 20)
                        {
                            if (i == 21)
                            {
                                t_damege = 0;
                                c_damege = 0;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else if (i == 22)
                            {
                                p2hp -= 20;
                                t_damege = 0;
                                c_damege = 0;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else if (i == 23)
                            {
                                p1hp -= t_damege;
                                p2hp = p1hp;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else
                            {
                                p1hp -= t_damege;
                                t_damege = 0;
                                c_damege = 0;

                                int num = 0;
                                Random r = new Random();

                                num = r.Next(1, 25);
                                p2card1.Visible = this.p2card1.Visible = true;
                                try
                                {
                                    p2card1.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card1name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card2.Visible = this.p2card2.Visible = true;
                                try
                                {
                                    p2card2.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card2name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card3.Visible = this.p2card3.Visible = true;
                                try
                                {
                                    p2card3.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card3name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card4.Visible = this.p2card4.Visible = true;
                                try
                                {
                                    p2card4.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                };
                                p2card4name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card5.Visible = this.p2card5.Visible = true;
                                try
                                {
                                    p2card5.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card5name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card6.Visible = this.p2card6.Visible = true;
                                try
                                {
                                    p2card6.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card6name.Text = create_card[num].get_name();

                                p1hp_label.Text = "HP:" + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                        }
                        else
                        {
                            if (c_damege >= create_card[i].get_attak())
                            {
                                p1hp -= t_damege;
                                c_damege = create_card[i].get_attak();
                                t_damege = create_card[i].get_attak();
                                p1hp_label.Text = "HP: " + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else
                            {
                                c_damege = create_card[i].get_attak();
                                t_damege += c_damege;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("당신의 턴이 아닙니다.");
            }
        }

        private void p1card4_Click(object sender, EventArgs e)
        {
            Win();
            if (turn == 0)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (p1card4name.Text.Equals(create_card[i].get_name()))
                    {
                        p1card4.Visible = this.p1card4.Visible = true;
                        p1card4name.Text = create_card[0].get_name();
                        card.Visible = this.card.Visible = true;
                        try
                        {
                            p1card4.Image = System.Drawing.Image.FromFile(create_card[0].get_image());
                            card.Image = System.Drawing.Image.FromFile(create_card[i].get_image());
                        }
                        catch (Exception)
                        {

                        }
                        if (i > 16 && i < 21)
                        {
                            c_damege = create_card[i].get_attak();
                            p1hp -= t_damege;
                            p1hp += c_damege;
                            t_damege = 0;
                            c_damege = 0;
                            p1hp_label.Text = "HP: " + p1hp;
                            current_damege.Text = c_damege + "";
                            total_damage.Text = t_damege + "";
                            turn++;

                        }
                        else if (i > 20)
                        {
                            if (i == 21)
                            {
                                t_damege = 0;
                                c_damege = 0;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else if (i == 22)
                            {
                                p2hp -= 20;
                                t_damege = 0;
                                c_damege = 0;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else if (i == 23)
                            {
                                p1hp -= t_damege;
                                p2hp = p1hp;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else
                            {
                                p1hp -= t_damege;
                                t_damege = 0;
                                c_damege = 0;

                                int num = 0;
                                Random r = new Random();

                                num = r.Next(1, 25);
                                p2card1.Visible = this.p2card1.Visible = true;
                                try
                                {
                                    p2card1.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card1name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card2.Visible = this.p2card2.Visible = true;
                                try
                                {
                                    p2card2.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card2name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card3.Visible = this.p2card3.Visible = true;
                                try
                                {
                                    p2card3.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card3name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card4.Visible = this.p2card4.Visible = true;
                                try
                                {
                                    p2card4.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                };
                                p2card4name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card5.Visible = this.p2card5.Visible = true;
                                try
                                {
                                    p2card5.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card5name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card6.Visible = this.p2card6.Visible = true;
                                try
                                {
                                    p2card6.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card6name.Text = create_card[num].get_name();

                                p1hp_label.Text = "HP:" + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                        }
                        else
                        {
                            if (c_damege >= create_card[i].get_attak())
                            {
                                p1hp -= t_damege;
                                c_damege = create_card[i].get_attak();
                                t_damege = create_card[i].get_attak();
                                p1hp_label.Text = "HP: " + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else
                            {
                                c_damege = create_card[i].get_attak();
                                t_damege += c_damege;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("당신의 턴이 아닙니다.");
            }
        }

        private void p1card5_Click(object sender, EventArgs e)
        {
            Win();
            if (turn == 0)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (p1card5name.Text.Equals(create_card[i].get_name()))
                    {
                        p1card5.Visible = this.p1card5.Visible = true;
                        p1card5name.Text = create_card[0].get_name();
                        card.Visible = this.card.Visible = true;
                        try
                        {
                            p1card5.Image = System.Drawing.Image.FromFile(create_card[0].get_image());
                            card.Image = System.Drawing.Image.FromFile(create_card[i].get_image());
                        }
                        catch (Exception)
                        {

                        }
                        if (i > 16 && i < 21)
                        {
                            c_damege = create_card[i].get_attak();
                            p1hp -= t_damege;
                            p1hp += c_damege;
                            t_damege = 0;
                            c_damege = 0;
                            p1hp_label.Text = "HP: " + p1hp;
                            current_damege.Text = c_damege + "";
                            total_damage.Text = t_damege + "";
                            turn++;

                        }
                        else if (i > 20)
                        {
                            if (i == 21)
                            {
                                t_damege = 0;
                                c_damege = 0;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else if (i == 22)
                            {
                                p2hp -= 20;
                                t_damege = 0;
                                c_damege = 0;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else if (i == 23)
                            {
                                p1hp -= t_damege;
                                p2hp = p1hp;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else
                            {
                                p1hp -= t_damege;
                                t_damege = 0;
                                c_damege = 0;

                                int num = 0;
                                Random r = new Random();

                                num = r.Next(1, 25);
                                p2card1.Visible = this.p2card1.Visible = true;
                                try
                                {
                                    p2card1.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card1name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card2.Visible = this.p2card2.Visible = true;
                                try
                                {
                                    p2card2.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card2name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card3.Visible = this.p2card3.Visible = true;
                                try
                                {
                                    p2card3.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card3name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card4.Visible = this.p2card4.Visible = true;
                                try
                                {
                                    p2card4.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                };
                                p2card4name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card5.Visible = this.p2card5.Visible = true;
                                try
                                {
                                    p2card5.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card5name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card6.Visible = this.p2card6.Visible = true;
                                try
                                {
                                    p2card6.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card6name.Text = create_card[num].get_name();

                                p1hp_label.Text = "HP:" + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                        }
                        else
                        {
                            if (c_damege >= create_card[i].get_attak())
                            {
                                p1hp -= t_damege;
                                c_damege = create_card[i].get_attak();
                                t_damege = create_card[i].get_attak();
                                p1hp_label.Text = "HP: " + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else
                            {
                                c_damege = create_card[i].get_attak();
                                t_damege += c_damege;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("당신의 턴이 아닙니다.");
            }
        }

        private void p1card6_Click(object sender, EventArgs e)
        {
            Win();
            if (turn == 0)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (p1card6name.Text.Equals(create_card[i].get_name()))
                    {
                        p1card6.Visible = this.p1card6.Visible = true;
                        p1card6name.Text = create_card[0].get_name();
                        card.Visible = this.card.Visible = true;
                        try
                        {
                            p1card6.Image = System.Drawing.Image.FromFile(create_card[0].get_image());
                            card.Image = System.Drawing.Image.FromFile(create_card[i].get_image());
                        }
                        catch (Exception)
                        {

                        }
                        if (i > 16 && i < 21)
                        {
                            c_damege = create_card[i].get_attak();
                            p1hp -= t_damege;
                            p1hp += c_damege;
                            t_damege = 0;
                            c_damege = 0;
                            p1hp_label.Text = "HP: " + p1hp;
                            current_damege.Text = c_damege + "";
                            total_damage.Text = t_damege + "";
                            turn++;

                        }
                        else if (i > 20)
                        {
                            if (i == 21)
                            {
                                t_damege = 0;
                                c_damege = 0;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else if (i == 22)
                            {
                                p2hp -= 20;
                                t_damege = 0;
                                c_damege = 0;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else if (i == 23)
                            {
                                p1hp -= t_damege;
                                p2hp = p1hp;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else
                            {
                                p1hp -= t_damege;
                                t_damege = 0;
                                c_damege = 0;

                                int num = 0;
                                Random r = new Random();

                                num = r.Next(1, 25);
                                p2card1.Visible = this.p2card1.Visible = true;
                                try
                                {
                                    p2card1.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card1name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card2.Visible = this.p2card2.Visible = true;
                                try
                                {
                                    p2card2.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card2name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card3.Visible = this.p2card3.Visible = true;
                                try
                                {
                                    p2card3.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card3name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card4.Visible = this.p2card4.Visible = true;
                                try
                                {
                                    p2card4.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                };
                                p2card4name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card5.Visible = this.p2card5.Visible = true;
                                try
                                {
                                    p2card5.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card5name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p2card6.Visible = this.p2card6.Visible = true;
                                try
                                {
                                    p2card6.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p2card6name.Text = create_card[num].get_name();

                                p1hp_label.Text = "HP:" + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                        }
                        else
                        {
                            if (c_damege >= create_card[i].get_attak())
                            {
                                p1hp -= t_damege;
                                c_damege = create_card[i].get_attak();
                                t_damege = create_card[i].get_attak();
                                p1hp_label.Text = "HP: " + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                            else
                            {
                                c_damege = create_card[i].get_attak();
                                t_damege += c_damege;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn++;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("당신의 턴이 아닙니다.");
            }
        }

        private void p2card1_Click(object sender, EventArgs e)
        {
            Win();
            if (turn == 1)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (p2card1name.Text.Equals(create_card[i].get_name()))
                    {
                        p2card1.Visible = this.p2card1.Visible = true;
                        p2card1name.Text = create_card[0].get_name();
                        card.Visible = this.card.Visible = true;
                        try
                        {
                            p2card1.Image = System.Drawing.Image.FromFile(create_card[0].get_image());
                            card.Image = System.Drawing.Image.FromFile(create_card[i].get_image());
                        }
                        catch (Exception)
                        {

                        }
                        if (i > 16 && i < 21)
                        {
                            c_damege = create_card[i].get_attak();
                            p2hp -= t_damege;
                            p2hp += c_damege;
                            t_damege = 0;
                            c_damege = 0;
                            p2hp_label.Text = "HP: " + p2hp;
                            current_damege.Text = c_damege + "";
                            total_damage.Text = t_damege + "";
                            turn--;

                        }
                        else if (i > 20)
                        {
                            if (i == 21)
                            {
                                t_damege = 0;
                                c_damege = 0;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else if (i == 22)
                            {
                                p1hp -= 20;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else if (i == 23)
                            {
                                p2hp -= t_damege;
                                p1hp = p2hp;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else
                            {
                                p2hp -= t_damege;
                                t_damege = 0;
                                c_damege = 0;

                                int num = 0;
                                Random r = new Random();

                                num = r.Next(1, 25);
                                p1card1.Visible = this.p1card1.Visible = true;
                                try
                                {
                                    p1card1.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card1name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card2.Visible = this.p1card2.Visible = true;
                                try
                                {
                                    p1card2.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card2name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card3.Visible = this.p1card3.Visible = true;
                                try
                                {
                                    p1card3.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card3name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card4.Visible = this.p1card4.Visible = true;
                                try
                                {
                                    p1card4.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card4name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card5.Visible = this.p1card5.Visible = true;
                                try
                                {
                                    p1card5.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card5name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card6.Visible = this.p1card6.Visible = true;
                                try
                                {
                                    p1card6.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card6name.Text = create_card[num].get_name();

                                p2hp_label.Text = "HP:" + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                        }
                        else
                        {
                            if (c_damege >= create_card[i].get_attak())
                            {
                                p2hp -= t_damege;
                                c_damege = create_card[i].get_attak();
                                t_damege = create_card[i].get_attak();
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else
                            {
                                c_damege = create_card[i].get_attak();
                                t_damege += c_damege;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("당신의 턴이 아닙니다.");
            }
        }

        private void p2card2_Click(object sender, EventArgs e)
        {
            Win();
            if (turn == 1)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (p2card2name.Text.Equals(create_card[i].get_name()))
                    {
                        p2card2.Visible = this.p2card2.Visible = true;
                        p2card2name.Text = create_card[0].get_name();
                        card.Visible = this.card.Visible = true;
                        try
                        {
                            p2card2.Image = System.Drawing.Image.FromFile(create_card[0].get_image());
                            card.Image = System.Drawing.Image.FromFile(create_card[i].get_image());
                        }
                        catch (Exception)
                        {

                        }
                        if (i > 16 && i < 21)
                        {
                            c_damege = create_card[i].get_attak();
                            p2hp -= t_damege;
                            p2hp += c_damege;
                            t_damege = 0;
                            c_damege = 0;
                            p2hp_label.Text = "HP: " + p2hp;
                            current_damege.Text = c_damege + "";
                            total_damage.Text = t_damege + "";
                            turn--;

                        }
                        else if (i > 20)
                        {
                            if (i == 21)
                            {
                                t_damege = 0;
                                c_damege = 0;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else if (i == 22)
                            {
                                p1hp -= 20;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else if (i == 23)
                            {
                                p2hp -= t_damege;
                                p1hp = p2hp;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else
                            {
                                p2hp -= t_damege;
                                t_damege = 0;
                                c_damege = 0;

                                int num = 0;
                                Random r = new Random();

                                num = r.Next(1, 25);
                                p1card1.Visible = this.p1card1.Visible = true;
                                try
                                {
                                    p1card1.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card1name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card2.Visible = this.p1card2.Visible = true;
                                try
                                {
                                    p1card2.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card2name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card3.Visible = this.p1card3.Visible = true;
                                try
                                {
                                    p1card3.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card3name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card4.Visible = this.p1card4.Visible = true;
                                try
                                {
                                    p1card4.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card4name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card5.Visible = this.p1card5.Visible = true;
                                try
                                {
                                    p1card5.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card5name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card6.Visible = this.p1card6.Visible = true;
                                try
                                {
                                    p1card6.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card6name.Text = create_card[num].get_name();

                                p2hp_label.Text = "HP:" + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                        }
                        else
                        {
                            if (c_damege >= create_card[i].get_attak())
                            {
                                p2hp -= t_damege;
                                c_damege = create_card[i].get_attak();
                                t_damege = create_card[i].get_attak();
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else
                            {
                                c_damege = create_card[i].get_attak();
                                t_damege += c_damege;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("당신의 턴이 아닙니다.");
            }
        }

        private void p2card3_Click(object sender, EventArgs e)
        {
            Win();
            if (turn == 1)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (p2card3name.Text.Equals(create_card[i].get_name()))
                    {
                        p2card3.Visible = this.p2card3.Visible = true;
                        p2card3name.Text = create_card[0].get_name();
                        card.Visible = this.card.Visible = true;
                        try
                        {
                            p2card3.Image = System.Drawing.Image.FromFile(create_card[0].get_image());
                            card.Image = System.Drawing.Image.FromFile(create_card[i].get_image());
                        }
                        catch (Exception)
                        {

                        }
                        if (i > 16 && i < 21)
                        {
                            c_damege = create_card[i].get_attak();
                            p2hp -= t_damege;
                            p2hp += c_damege;
                            t_damege = 0;
                            c_damege = 0;
                            p2hp_label.Text = "HP: " + p2hp;
                            current_damege.Text = c_damege + "";
                            total_damage.Text = t_damege + "";
                            turn--;

                        }
                        else if (i > 20)
                        {
                            if (i == 21)
                            {
                                t_damege = 0;
                                c_damege = 0;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else if (i == 22)
                            {
                                p1hp -= 20;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else if (i == 23)
                            {
                                p2hp -= t_damege;
                                p1hp = p2hp;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else
                            {
                                p2hp -= t_damege;
                                t_damege = 0;
                                c_damege = 0;

                                int num = 0;
                                Random r = new Random();

                                num = r.Next(1, 25);
                                p1card1.Visible = this.p1card1.Visible = true;
                                try
                                {
                                    p1card1.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card1name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card2.Visible = this.p1card2.Visible = true;
                                try
                                {
                                    p1card2.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card2name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card3.Visible = this.p1card3.Visible = true;
                                try
                                {
                                    p1card3.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card3name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card4.Visible = this.p1card4.Visible = true;
                                try
                                {
                                    p1card4.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card4name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card5.Visible = this.p1card5.Visible = true;
                                try
                                {
                                    p1card5.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card5name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card6.Visible = this.p1card6.Visible = true;
                                try
                                {
                                    p1card6.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card6name.Text = create_card[num].get_name();

                                p2hp_label.Text = "HP:" + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                        }
                        else
                        {
                            if (c_damege >= create_card[i].get_attak())
                            {
                                p2hp -= t_damege;
                                c_damege = create_card[i].get_attak();
                                t_damege = create_card[i].get_attak();
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else
                            {
                                c_damege = create_card[i].get_attak();
                                t_damege += c_damege;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("당신의 턴이 아닙니다.");
            }
        }

        private void p2card4_Click(object sender, EventArgs e)
        {
            Win();
            if (turn == 1)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (p2card4name.Text.Equals(create_card[i].get_name()))
                    {
                        p2card4.Visible = this.p2card4.Visible = true;
                        p2card4name.Text = create_card[0].get_name();
                        card.Visible = this.card.Visible = true;
                        try
                        {
                            p2card4.Image = System.Drawing.Image.FromFile(create_card[0].get_image());
                            card.Image = System.Drawing.Image.FromFile(create_card[i].get_image());
                        }
                        catch (Exception)
                        {

                        }
                        if (i > 16 && i < 21)
                        {
                            c_damege = create_card[i].get_attak();
                            p2hp -= t_damege;
                            p2hp += c_damege;
                            t_damege = 0;
                            c_damege = 0;
                            p2hp_label.Text = "HP: " + p2hp;
                            current_damege.Text = c_damege + "";
                            total_damage.Text = t_damege + "";
                            turn--;

                        }
                        else if (i > 20)
                        {
                            if (i == 21)
                            {
                                t_damege = 0;
                                c_damege = 0;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else if (i == 22)
                            {
                                p1hp -= 20;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else if (i == 23)
                            {
                                p2hp -= t_damege;
                                p1hp = p2hp;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else
                            {
                                p2hp -= t_damege;
                                t_damege = 0;
                                c_damege = 0;

                                int num = 0;
                                Random r = new Random();

                                num = r.Next(1, 25);
                                p1card1.Visible = this.p1card1.Visible = true;
                                try
                                {
                                    p1card1.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card1name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card2.Visible = this.p1card2.Visible = true;
                                try
                                {
                                    p1card2.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card2name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card3.Visible = this.p1card3.Visible = true;
                                try
                                {
                                    p1card3.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card3name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card4.Visible = this.p1card4.Visible = true;
                                try
                                {
                                    p1card4.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card4name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card5.Visible = this.p1card5.Visible = true;
                                try
                                {
                                    p1card5.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card5name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card6.Visible = this.p1card6.Visible = true;
                                try
                                {
                                    p1card6.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card6name.Text = create_card[num].get_name();

                                p2hp_label.Text = "HP:" + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                        }
                        else
                        {
                            if (c_damege >= create_card[i].get_attak())
                            {
                                p2hp -= t_damege;
                                c_damege = create_card[i].get_attak();
                                t_damege = create_card[i].get_attak();
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else
                            {
                                c_damege = create_card[i].get_attak();
                                t_damege += c_damege;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("당신의 턴이 아닙니다.");
            }
        }

        private void p2card5_Click(object sender, EventArgs e)
        {
            Win();
            if (turn == 1)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (p2card5name.Text.Equals(create_card[i].get_name()))
                    {
                        p2card5.Visible = this.p2card5.Visible = true;
                        p2card5name.Text = create_card[0].get_name();
                        card.Visible = this.card.Visible = true;
                        try
                        {
                            p2card5.Image = System.Drawing.Image.FromFile(create_card[0].get_image());
                            card.Image = System.Drawing.Image.FromFile(create_card[i].get_image());
                        }
                        catch (Exception)
                        {

                        }
                        if (i > 16 && i < 21)
                        {
                            c_damege = create_card[i].get_attak();
                            p2hp -= t_damege;
                            p2hp += c_damege;
                            t_damege = 0;
                            c_damege = 0;
                            p2hp_label.Text = "HP: " + p2hp;
                            current_damege.Text = c_damege + "";
                            total_damage.Text = t_damege + "";
                            turn--;

                        }
                        else if (i > 20)
                        {
                            if (i == 21)
                            {
                                t_damege = 0;
                                c_damege = 0;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else if (i == 22)
                            {
                                p1hp -= 20;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else if (i == 23)
                            {
                                p2hp -= t_damege;
                                p1hp = p2hp;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else
                            {
                                p2hp -= t_damege;
                                t_damege = 0;
                                c_damege = 0;

                                int num = 0;
                                Random r = new Random();

                                num = r.Next(1, 25);
                                p1card1.Visible = this.p1card1.Visible = true;
                                try
                                {
                                    p1card1.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card1name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card2.Visible = this.p1card2.Visible = true;
                                try
                                {
                                    p1card2.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card2name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card3.Visible = this.p1card3.Visible = true;
                                try
                                {
                                    p1card3.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card3name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card4.Visible = this.p1card4.Visible = true;
                                try
                                {
                                    p1card4.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card4name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card5.Visible = this.p1card5.Visible = true;
                                try
                                {
                                    p1card5.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card5name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card6.Visible = this.p1card6.Visible = true;
                                try
                                {
                                    p1card6.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card6name.Text = create_card[num].get_name();

                                p2hp_label.Text = "HP:" + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                        }
                        else
                        {
                            if (c_damege >= create_card[i].get_attak())
                            {
                                p2hp -= t_damege;
                                c_damege = create_card[i].get_attak();
                                t_damege = create_card[i].get_attak();
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else
                            {
                                c_damege = create_card[i].get_attak();
                                t_damege += c_damege;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("당신의 턴이 아닙니다.");
            }
        }

        private void p2card6_Click(object sender, EventArgs e)
        {
            Win();
            if (turn == 1)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (p2card6name.Text.Equals(create_card[i].get_name()))
                    {
                        p2card6.Visible = this.p2card6.Visible = true;
                        p2card6name.Text = create_card[0].get_name();
                        card.Visible = this.card.Visible = true;
                        try
                        {
                            p2card6.Image = System.Drawing.Image.FromFile(create_card[0].get_image());
                            card.Image = System.Drawing.Image.FromFile(create_card[i].get_image());
                        }
                        catch (Exception)
                        {

                        }
                        if (i > 16 && i < 21)
                        {
                            c_damege = create_card[i].get_attak();
                            p2hp -= t_damege;
                            p2hp += c_damege;
                            t_damege = 0;
                            c_damege = 0;
                            p2hp_label.Text = "HP: " + p2hp;
                            current_damege.Text = c_damege + "";
                            total_damage.Text = t_damege + "";
                            turn--;

                        }
                        else if (i > 20)
                        {
                            if (i == 21)
                            {
                                t_damege = 0;
                                c_damege = 0;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else if (i == 22)
                            {
                                p1hp -= 20;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else if (i == 23)
                            {
                                p2hp -= t_damege;
                                p1hp = p2hp;
                                t_damege = 0;
                                c_damege = 0;
                                p1hp_label.Text = "HP: " + p1hp;
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else
                            {
                                p2hp -= t_damege;
                                t_damege = 0;
                                c_damege = 0;

                                int num = 0;
                                Random r = new Random();

                                num = r.Next(1, 25);
                                p1card1.Visible = this.p1card1.Visible = true;
                                try
                                {
                                    p1card1.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card1name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card2.Visible = this.p1card2.Visible = true;
                                try
                                {
                                    p1card2.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card2name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card3.Visible = this.p1card3.Visible = true;
                                try
                                {
                                    p1card3.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card3name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card4.Visible = this.p1card4.Visible = true;
                                try
                                {
                                    p1card4.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card4name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card5.Visible = this.p1card5.Visible = true;
                                try
                                {
                                    p1card5.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card5name.Text = create_card[num].get_name();
                                num = r.Next(1, 25);
                                p1card6.Visible = this.p1card6.Visible = true;
                                try
                                {
                                    p1card6.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                                }
                                catch (Exception)
                                {

                                }
                                p1card6name.Text = create_card[num].get_name();

                                p2hp_label.Text = "HP:" + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                        }
                        else
                        {
                            if (c_damege >= create_card[i].get_attak())
                            {
                                p2hp -= t_damege;
                                c_damege = create_card[i].get_attak();
                                t_damege = create_card[i].get_attak();
                                p2hp_label.Text = "HP: " + p2hp;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                            else
                            {
                                c_damege = create_card[i].get_attak();
                                t_damege += c_damege;
                                current_damege.Text = c_damege + "";
                                total_damage.Text = t_damege + "";
                                turn--;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("당신의 턴이 아닙니다.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 25; i++)
                create_card[i] = new card();
            create_card[0].set_card(0, "빈카드", Application.StartupPath + @"/빈카드.png");
            create_card[1].set_card(5, "물의호", Application.StartupPath + @"/물의호.png");
            create_card[2].set_card(5, "바람베기", Application.StartupPath + @"/바람 베기.png");
            create_card[3].set_card(5, "불꽃타격", Application.StartupPath + @"/불꽃 타격.png");
            create_card[4].set_card(10, "흙주먹", Application.StartupPath + @"/흙주먹.png");
            create_card[5].set_card(10, "감전", Application.StartupPath + @"/감전.png");
            create_card[6].set_card(10, "파동선단", Application.StartupPath + @"/파동 선단.png");
            create_card[7].set_card(15, "흙드릴", Application.StartupPath + @"/드릴.png");
            create_card[8].set_card(15, "물대포", Application.StartupPath + @"/물대포.png");
            create_card[9].set_card(15, "연속베기", Application.StartupPath + @"/연속베기.png");
            create_card[10].set_card(15, "천둥", Application.StartupPath + @"/천둥.png");
            create_card[11].set_card(15, "화염구", Application.StartupPath + @"/화염구.png");
            create_card[12].set_card(20, "낙뢰", Application.StartupPath + @"/낙뢰.png");
            create_card[13].set_card(20, "아이스스톰", Application.StartupPath + @"/아이스스톰.png");
            create_card[14].set_card(20, "용의불숨", Application.StartupPath + @"/용의 불숨.png");
            create_card[15].set_card(20, "용의강하", Application.StartupPath + @"/용의강하.png");
            create_card[16].set_card(20, "회오리", Application.StartupPath + @"/회오리.png");
            create_card[17].set_card(20, "나뭇잎", Application.StartupPath + @"/나뭇잎.png");
            create_card[18].set_card(35, "쿠키상자", Application.StartupPath + @"/쿠키상자.png");
            create_card[19].set_card(50, "당근케이크", Application.StartupPath + @"/당근 케이크.png");
            create_card[20].set_card(100, "유니콘꼬리", Application.StartupPath + @"/유니콘 꼬리.png");
            create_card[21].set_card(0, "거울방패", Application.StartupPath + @"/거울방패.png");
            create_card[22].set_card(0, "독성모자", Application.StartupPath + @"/독성 모자.png");
            create_card[23].set_card(0, "어둠의카타나", Application.StartupPath + @"/어둠의카타나.png");
            create_card[24].set_card(0, "파열부적", Application.StartupPath + @"/파열 부적.png");

            Random r = new Random();
            int num = 0;
            //플레이어1의 카드 세팅
            num = r.Next(1, 25);
            p1card1.Visible = this.p1card1.Visible = true;
            try
            {
                p1card1.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
            }
            catch(Exception)
            {

            }
            p1card1name.Text = create_card[num].get_name();
            num = r.Next(1, 25);
            p1card2.Visible = this.p1card2.Visible = true;
            try
            {
                p1card2.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
            }
            catch (Exception)
            {

            }
            p1card2name.Text = create_card[num].get_name();
            num = r.Next(1, 25);
            p1card3.Visible = this.p1card3.Visible = true;
            try
            {
                p1card3.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
            }
            catch (Exception)
            {

            }
            p1card3name.Text = create_card[num].get_name();
            num = r.Next(1, 25);
            p1card4.Visible = this.p1card4.Visible = true;
            try
            {
                p1card4.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
            }
            catch (Exception)
            {

            }
            p1card4name.Text = create_card[num].get_name();
            num = r.Next(1, 25);
            p1card5.Visible = this.p1card5.Visible = true;
            try
            {
                p1card5.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
            }
            catch (Exception)
            {

            }
            p1card5name.Text = create_card[num].get_name();
            num = r.Next(1, 25);
            p1card6.Visible = this.p1card6.Visible = true;
            try
            {
                p1card6.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
            }
            catch (Exception)
            {

            }
            p1card6name.Text = create_card[num].get_name();

            //플레이어2의 카드세팅
            num = r.Next(1, 25);
            p2card1.Visible = this.p2card1.Visible = true;
            try
            {
                p2card1.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
            }
            catch (Exception)
            {

            }
            p2card1name.Text = create_card[num].get_name();
            num = r.Next(1, 25);
            p2card2.Visible = this.p2card2.Visible = true;
            try
            {
                p2card2.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
            }
            catch (Exception)
            {

            }
            p2card2name.Text = create_card[num].get_name();
            num = r.Next(1, 25);
            p2card3.Visible = this.p2card3.Visible = true;
            try
            {
                p2card3.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
            }
            catch (Exception)
            {

            }
            p2card3name.Text = create_card[num].get_name();
            num = r.Next(1, 25);
            p2card4.Visible = this.p2card4.Visible = true;
            try
            {
                p2card4.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
            }
            catch (Exception)
            {

            };
            p2card4name.Text = create_card[num].get_name();
            num = r.Next(1, 25);
            p2card5.Visible = this.p2card5.Visible = true;
            try
            {
                p2card5.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
            }
            catch (Exception)
            {

            }
            p2card5name.Text = create_card[num].get_name();
            num = r.Next(1, 25);
            p2card6.Visible = this.p2card6.Visible = true;
            try
            {
                p2card6.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
            }
            catch (Exception)
            {

            }
            p2card6name.Text = create_card[num].get_name();

            current_damege.Text = c_damege + "";
            total_damage.Text = t_damege + "";
            p1hp_label.Text = "HP:" + p1hp;
            p2hp_label.Text = "HP:" + p2hp;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int num = 0;
            Random r = new Random();
            if (turn == 0)
            {
                p1hp -= t_damege;
                c_damege = 0;
                t_damege = 0;
                current_damege.Text = c_damege + "";
                total_damage.Text = t_damege + "";
                p1hp_label.Text = "HP:" + p1hp;
                if (p1card1name.Text.Equals("빈카드"))
                {
                    num = r.Next(1, 25);
                    p1card1.Visible = this.p1card1.Visible = true;
                    try
                    {
                        p1card1.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                    }
                    catch (Exception)
                    {

                    }
                    p1card1name.Text = create_card[num].get_name();
                    turn++;
                }
                else if (p1card2name.Text.Equals("빈카드"))
                {
                    num = r.Next(1, 25);
                    p1card2.Visible = this.p1card2.Visible = true;
                    try
                    {
                        p1card2.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                    }
                    catch (Exception)
                    {

                    }
                    p1card2name.Text = create_card[num].get_name();
                    turn++;
                }
                else if (p1card3name.Text.Equals("빈카드"))
                {
                    num = r.Next(1, 25);
                    p1card3.Visible = this.p1card3.Visible = true;
                    try
                    {
                        p1card3.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                    }
                    catch (Exception)
                    {

                    }
                    p1card3name.Text = create_card[num].get_name();
                    turn++;
                }
                else if (p1card4name.Text.Equals("빈카드"))
                {
                    num = r.Next(1, 25);
                    p1card4.Visible = this.p1card4.Visible = true;
                    try
                    {
                        p1card4.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                    }
                    catch (Exception)
                    {

                    }
                    p1card4name.Text = create_card[num].get_name();
                    turn++;
                }
                else if (p1card5name.Text.Equals("빈카드"))
                {
                    num = r.Next(1, 25);
                    p1card5.Visible = this.p1card5.Visible = true;
                    try
                    {
                        p1card5.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                    }
                    catch (Exception)
                    {

                    }
                    p1card5name.Text = create_card[num].get_name();
                    turn++;
                }
                else if (p1card6name.Text.Equals("빈카드"))
                {
                    num = r.Next(1, 25);
                    p1card6.Visible = this.p1card6.Visible = true;
                    try
                    {
                        p1card6.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                    }
                    catch (Exception)
                    {

                    }
                    p1card6name.Text = create_card[num].get_name();
                    turn++;
                }
                else
                {
                    MessageBox.Show("6장의 카드가 전부 있습니다.");
                }
            }
            else
            {
                p2hp -= t_damege;
                c_damege = 0;
                t_damege = 0;
                current_damege.Text = c_damege + "";
                total_damage.Text = t_damege + "";
                p2hp_label.Text = "HP:" + p2hp;
                if (p2card1name.Text.Equals("빈카드"))
                {
                    num = r.Next(1, 25);
                    p2card1.Visible = this.p2card1.Visible = true;
                    try
                    {
                        p2card1.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                    }
                    catch (Exception)
                    {

                    }
                    p2card1name.Text = create_card[num].get_name();
                    turn--;
                }
                else if (p2card2name.Text.Equals("빈카드"))
                {
                    num = r.Next(1, 25);
                    p2card2.Visible = this.p2card2.Visible = true;
                    try
                    {
                        p2card2.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                    }
                    catch (Exception)
                    {

                    }
                    p2card2name.Text = create_card[num].get_name();
                    turn--;
                }
                else if (p2card3name.Text.Equals("빈카드"))
                {
                    num = r.Next(1, 25);
                    p2card3.Visible = this.p2card3.Visible = true;
                    try
                    {
                        p2card3.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                    }
                    catch (Exception)
                    {

                    }
                    p2card3name.Text = create_card[num].get_name();
                    turn--;
                }
                else if (p2card4name.Text.Equals("빈카드"))
                {
                    num = r.Next(1, 25);
                    p2card4.Visible = this.p2card4.Visible = true;
                    try
                    {
                        p2card4.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                    }
                    catch (Exception)
                    {

                    }
                    p2card4name.Text = create_card[num].get_name();
                    turn--;
                }
                else if (p2card5name.Text.Equals("빈카드"))
                {
                    num = r.Next(1, 25);
                    p2card5.Visible = this.p2card5.Visible = true;
                    try
                    {
                        p2card5.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                    }
                    catch (Exception)
                    {

                    }
                    p2card5name.Text = create_card[num].get_name();
                    turn--;
                }
                else if (p2card6name.Text.Equals("빈카드"))
                {
                    num = r.Next(1, 25);
                    p2card6.Visible = this.p2card6.Visible = true;
                    try
                    {
                        p2card6.Image = System.Drawing.Image.FromFile(create_card[num].get_image());
                    }
                    catch (Exception)
                    {

                    }
                    p2card6name.Text = create_card[num].get_name();
                    turn--;
                }
                else
                {
                    MessageBox.Show("6장의 카드가 전부 있습니다.");
                }
            }
        }

        void Win()
        {
            if(p1hp <= 0)
                MessageBox.Show("플레이어2의 승리입니다.");
            else if(p2hp <= 0)
                MessageBox.Show("플레이어1의 승리입니다.");
        }
    }
}
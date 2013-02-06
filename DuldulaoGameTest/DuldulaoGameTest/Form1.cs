using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DuldulaoGameTest
{
    public partial class Form1 : Form
    {
        public string Character_Right_Side = "";
        public string Character_Left_Side = "";
        public double attack_Activate = 2;
        public double attack_left_activate = 0;
        public double attack_right_activate = 0;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Left Side
            listBox1.Items.Add("NINJA");
            listBox1.Items.Add("SAMURAI");
            listBox1.Items.Add("BRAWLER");

            //Right Side
            listBox2.Items.Add("NINJA");
            listBox2.Items.Add("SAMURAI");
            listBox2.Items.Add("BRAWLER");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            if (CharacterRightSide.Text == "NINJA")
            {
                NinjaRandomDetails_Right_Side();
            }
            if (CharacterRightSide.Text == "SAMURAI")
            {
                SamuraiRandomDetails_Right_Side();
            }
            if (CharacterRightSide.Text == "BRAWLER")
            {
                BrawlerRandomDetails_Right_Side();
            }

            ColorComparisonEffect();
            RightBrawler_Special_Attribute();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            right_side_attack.Text = "----";
            right_side_defense.Text = "----";
            right_side_evade.Text = "----";
            right_side_health.Text = "----";
            right_side_speed.Text = "----";
            CharacterRightSide.Text = "----";
            right_side_attack.ForeColor = Color.Black;
            right_side_defense.ForeColor = Color.Black;
            right_side_evade.ForeColor = Color.Black;
            right_side_health.ForeColor = Color.Black;
            right_side_speed.ForeColor = Color.Black;
            button3.Text = "Select Random Players";
            button3.Width = 139;
            button3.Enabled = false;

            try
            {
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Character Selected: " + listBox1.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
                Character_Right_Side = listBox1.Text;
                CharacterRightSide.Text = Character_Right_Side.ToString();
                button3.Text = "Select Random Players for >>" + listBox1.Text;
                button3.Width = 300;
                button3.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Select a player");
                Character_Right_Side = "";
                CharacterRightSide.Text = "";
                button3.Text = "Select Random Players";
                button3.Width = 139;
                button3.Enabled = false;
            }
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            left_side_attack.Text = "----";
            left_side_defense.Text = "----";
            left_side_evade.Text = "----";
            left_side_health.Text = "----";
            left_side_speed.Text = "----";
            CharacterLeftSide.Text = "----";
            left_side_attack.ForeColor = Color.Black;
            left_side_defense.ForeColor = Color.Black;
            left_side_evade.ForeColor = Color.Black;
            left_side_health.ForeColor = Color.Black;
            left_side_speed.ForeColor = Color.Black;
            button4.Text = "Select Random Players";
            button4.Width = 139;
            button4.Enabled = false;
            try
            {
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Character Selected: " +  listBox2.Text ,  "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
                Character_Left_Side = listBox2.Text;
                CharacterLeftSide.Text = Character_Left_Side.ToString();
                button4.Text = "Select Random Players for >>" + listBox2.Text;
                button4.Width = 300;
                button4.Enabled = true;    
            }
            catch (Exception)
            {
                MessageBox.Show("Select a player");
                Character_Left_Side = "";
                CharacterLeftSide.Text = "";
                button4.Width = 139;
                button4.Enabled = false;
            }
        }

        public void NinjaRandomDetails_Right_Side()
        {
            Random Ninja_Random = new Random();
            //? Ninja
            //? Health (40-60)
            //? Attack (60-70)
            //? Defence (20-30)
            //? Speed (90-100)
            //? Evade (0.3-0.5)
            //set the Randomized Values by its corresponding RANGE
            int ninja_HEALTH = Ninja_Random.Next(40, 61);
            int ninja_ATTACK = Ninja_Random.Next(60, 71);
            int ninja_DEFENSE = Ninja_Random.Next(20, 31);
            int ninja_SPEED = Ninja_Random.Next(90, 101);
            int ninja_EVADE = Ninja_Random.Next(3,6); // Evade value set as Temporary String Format.
            right_side_health.Text = ninja_HEALTH.ToString();
            right_side_attack.Text = ninja_ATTACK.ToString();
            right_side_defense.Text = ninja_DEFENSE.ToString();
            right_side_speed.Text = ninja_SPEED.ToString();
            right_side_evade.Text = "0." +  ninja_EVADE.ToString();
        }

        public void NinjaRandomDetails_Left_Side()
        {
            Random Ninja_Random = new Random();
            //? Ninja
            //? Health (40-60)
            //? Attack (60-70)
            //? Defence (20-30)
            //? Speed (90-100)
            //? Evade (0.3-0.5)
            //set the Randomized Values by its corresponding RANGE
            int ninja_HEALTH = Ninja_Random.Next(40, 61);
            int ninja_ATTACK = Ninja_Random.Next(60, 71);
            int ninja_DEFENSE = Ninja_Random.Next(20, 31);
            int ninja_SPEED = Ninja_Random.Next(90, 101);
            int ninja_EVADE = Ninja_Random.Next(3, 6); // Evade value set as Temporary String Format.
            left_side_health.Text = ninja_HEALTH.ToString();
            left_side_attack.Text = ninja_ATTACK.ToString();
            left_side_defense.Text = ninja_DEFENSE.ToString();
            left_side_speed.Text = ninja_SPEED.ToString();
            left_side_evade.Text = "0." + ninja_EVADE.ToString();
        }

        public void SamuraiRandomDetails_Right_Side()
        {
            Random Samurai_Random = new Random();
            //? Samurai
            //? Health (60-100)
            //? Attack (75-80)
            //? Defence (35-40)
            //? Speed (60-80)
            //? Evade (0.3-0.4)
            //set the Randomized Values by its corresponding RANGE
            int Samurai_HEALTH = Samurai_Random.Next(60, 101);
            int Samurai_ATTACK = Samurai_Random.Next(75, 81);
            int Samurai_DEFENSE = Samurai_Random.Next(35, 41);
            int Samurai_SPEED = Samurai_Random.Next(60, 81);
            int Samurai_EVADE = Samurai_Random.Next(3, 5);
            right_side_health.Text = Samurai_HEALTH.ToString();
            right_side_attack.Text = Samurai_ATTACK.ToString();
            right_side_defense.Text = Samurai_DEFENSE.ToString();
            right_side_speed.Text = Samurai_SPEED.ToString();
            right_side_evade.Text = "0." + Samurai_EVADE.ToString();
        }

        public void SamuraiRandomDetails_Left_Side()
        {
            Random Samurai_Random = new Random();
            //? Samurai
            //? Health (60-100)
            //? Attack (75-80)
            //? Defence (35-40)
            //? Speed (60-80)
            //? Evade (0.3-0.4)
            //set the Randomized Values by its corresponding RANGE
            int Samurai_HEALTH = Samurai_Random.Next(60, 101);
            int Samurai_ATTACK = Samurai_Random.Next(75, 81);
            int Samurai_DEFENSE = Samurai_Random.Next(35, 41);
            int Samurai_SPEED = Samurai_Random.Next(60, 81);
            int Samurai_EVADE = Samurai_Random.Next(3, 5);
            left_side_health.Text = Samurai_HEALTH.ToString();
            left_side_attack.Text = Samurai_ATTACK.ToString();
            left_side_defense.Text = Samurai_DEFENSE.ToString();
            left_side_speed.Text = Samurai_SPEED.ToString();
            left_side_evade.Text = "0." + Samurai_EVADE.ToString();
        }

        public void BrawlerRandomDetails_Right_Side()
        {
            Random Brawler_Random = new Random();
            //? Brawler
            //? Health (90-100)
            //? Attack (65-75)
            //? Defence (40-50)
            //? Speed (40-65)
            //? Evade (0.3-0.35)
            //set the Randomized Values by its corresponding RANGE
            int Brawler_HEALTH = Brawler_Random.Next(90, 101);
            int Brawler_ATTACK = Brawler_Random.Next(65, 76);
            int Brawler_DEFENSE = Brawler_Random.Next(40, 51);
            int Brawler_SPEED = Brawler_Random.Next(40, 66);
            int Browler_EVADE = Brawler_Random.Next(30, 36);
            right_side_health.Text = Brawler_HEALTH.ToString();
            right_side_attack.Text = Brawler_ATTACK.ToString();
            right_side_defense.Text = Brawler_DEFENSE.ToString();
            right_side_speed.Text = Brawler_SPEED.ToString();
            right_side_evade.Text = "0." + Browler_EVADE.ToString();
        }

        public void BrawlerRandomDetails_Left_Side()
        {
            Random Brawler_Random = new Random();
            //? Brawler
            //? Health (90-100)
            //? Attack (65-75)
            //? Defence (40-50)
            //? Speed (40-65)
            //? Evade (0.3-0.35)
            //set the Randomized Values by its corresponding RANGE
            int Brawler_HEALTH = Brawler_Random.Next(90, 101);
            int Brawler_ATTACK = Brawler_Random.Next(65, 76);
            int Brawler_DEFENSE = Brawler_Random.Next(40, 51);
            int Brawler_SPEED = Brawler_Random.Next(40, 66);
            int Browler_EVADE = Brawler_Random.Next(30, 36);
            left_side_health.Text = Brawler_HEALTH.ToString();
            left_side_attack.Text = Brawler_ATTACK.ToString();
            left_side_defense.Text = Brawler_DEFENSE.ToString();
            left_side_speed.Text = Brawler_SPEED.ToString();
            left_side_evade.Text = "0." + Browler_EVADE.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button9.Enabled = true;
            if (CharacterLeftSide.Text == "NINJA")
            {
                NinjaRandomDetails_Left_Side();
            }
            if (CharacterLeftSide.Text == "SAMURAI")
            {
                SamuraiRandomDetails_Left_Side();
            }
            if (CharacterLeftSide.Text == "BRAWLER")
            {
                BrawlerRandomDetails_Left_Side();
            }
            ColorComparisonEffect();
            LeftBrawler_Special_Attribute();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CharacterRightSide.Text == "NINJA")
            {
                Right_Ninja_Special_Doubling_Attack();
                Turns_Player2();
                Draw();
                button3.Enabled = false;
                ColorComparisonEffect();
                button1.Enabled = false;
                button2.Enabled = true;
                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Red;
                WarriorDefeatedFunction();
            }
            if (CharacterRightSide.Text == "SAMURAI")
            {
                Right_Side_Generate_Attack_Calculation();
                Turns_Player2();
                button3.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = true;
                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Red;
                Draw();
                ColorComparisonEffect();
                WarriorDefeatedFunction();
            }
            if (CharacterRightSide.Text == "BRAWLER")
            {
                Right_Side_Generate_Attack_Calculation();
                Turns_Player2();
                button3.Enabled = false;
                RightBrawler_Special_Attribute_Calculations();
                LeftBrawler_Special_Attribute_Calculations();
                button1.Enabled = false;
                button2.Enabled = true;
                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Red;
                Draw();
                ColorComparisonEffect();
                WarriorDefeatedFunction();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            listBox2.Items.Clear();
            left_side_attack.Text = "----";
            left_side_defense.Text = "----";
            left_side_evade.Text = "----";
            left_side_health.Text = "----";
            left_side_speed.Text = "----";
            CharacterLeftSide.Text = "----";
            left_side_attack.ForeColor = Color.Black;
            left_side_defense.ForeColor = Color.Black;
            left_side_evade.ForeColor = Color.Black;
            left_side_health.ForeColor = Color.Black;
            left_side_speed.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button2.Enabled = false;
            button4.Text = "Select Random Players";
            button4.Width = 139;
            button4.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Items.Add("NINJA");
            listBox2.Items.Add("SAMURAI");
            listBox2.Items.Add("BRAWLER");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("NINJA");
            listBox1.Items.Add("SAMURAI");
            listBox1.Items.Add("BRAWLER");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            listBox1.Items.Clear();
            right_side_attack.Text = "----";
            right_side_defense.Text = "----";
            right_side_evade.Text = "----";
            right_side_health.Text = "----";
            right_side_speed.Text = "----";
            CharacterRightSide.Text = "----";
            right_side_attack.ForeColor = Color.Black;
            right_side_defense.ForeColor = Color.Black;
            right_side_evade.ForeColor = Color.Black;
            right_side_health.ForeColor = Color.Black;
            right_side_speed.ForeColor = Color.Black;
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
            button3.Text = "Select Random Players";
            button3.Width = 139;
            button3.Enabled = false;
        }

        public void ColorComparisonEffect()
        {
            try
            {
                double left_health = double.Parse(left_side_health.Text);
                double left_attack = double.Parse(left_side_attack.Text);
                double left_defense = double.Parse(left_side_defense.Text);
                double left_speed = double.Parse(left_side_speed.Text);
                double left_evade = double.Parse(left_side_evade.Text);
                double right_health = double.Parse(right_side_health.Text);
                double right_attack = double.Parse(right_side_attack.Text);
                double right_defense = double.Parse(right_side_defense.Text);
                double right_speed = double.Parse(right_side_speed.Text);
                double right_evade = double.Parse(right_side_evade.Text);
                // Health Value Comparison -------------------------------------------------
                if (left_health>right_health)
                {
                    left_side_health.ForeColor = Color.Green;
                    right_side_health.ForeColor = Color.Red;
                }
                if (left_health < right_health)
                {
                    right_side_health.ForeColor = Color.Green;
                    left_side_health.ForeColor = Color.Red;
                }
                if (left_health==right_health)
                {
                    right_side_health.ForeColor = Color.Blue;
                    left_side_health.ForeColor = Color.Blue;
                }
                // Attack-------------------------------------------------------------------------
                if (left_attack>right_attack)
                {
                    left_side_attack.ForeColor = Color.Green;
                    right_side_attack.ForeColor = Color.Red;
                }
                if (left_attack < right_attack)
                {
                    right_side_attack.ForeColor = Color.Green;
                    left_side_attack.ForeColor = Color.Red;
                }
                if (left_attack == right_attack)
                {
                    right_side_attack.ForeColor = Color.Blue;
                    left_side_attack.ForeColor = Color.Blue;
                }
                //Defense--------------------------------------------------------------------------------
                if (left_defense > right_defense)
                {
                    left_side_defense.ForeColor = Color.Green;
                    right_side_defense.ForeColor = Color.Red;
                }
                if (left_defense < right_defense)
                {
                    right_side_defense.ForeColor = Color.Green;
                    left_side_defense.ForeColor = Color.Red;
                }
                if (left_defense == right_defense)
                {
                    right_side_defense.ForeColor = Color.Blue;
                    left_side_defense.ForeColor = Color.Blue;
                }
                //Speed----------------------------------------------------------------------------------
                if (left_speed > right_speed)
                {
                    left_side_speed.ForeColor = Color.Green;
                    right_side_speed.ForeColor = Color.Red;
                }
                if (left_speed < right_speed)
                {
                    right_side_speed.ForeColor = Color.Green;
                    left_side_speed.ForeColor = Color.Red;
                }
                if (left_speed == right_speed)
                {
                    right_side_speed.ForeColor = Color.Blue;
                    left_side_speed.ForeColor = Color.Blue;
                }
                //Evade---------------------------------------------------------------------------------
                if (left_evade > right_evade)
                {
                    left_side_evade.ForeColor = Color.Green;
                    right_side_evade.ForeColor = Color.Red;
                }
                if (left_evade < right_evade)
                {
                    right_side_evade.ForeColor = Color.Green;
                    left_side_evade.ForeColor = Color.Red;
                }
                if (left_evade == right_evade)
                {
                    right_side_evade.ForeColor = Color.Blue;
                    left_side_evade.ForeColor = Color.Blue;
                }
            }
            catch (Exception)
            { 
            }
        }

        public void Attack()
        {
            try
            {
                double Player1 = double.Parse(left_side_speed.Text);
                double Player2 = double.Parse(right_side_speed.Text);
                if (Player1>Player2)
                {
                    button2.ForeColor = Color.Red;
                    button1.ForeColor = Color.Black;
                    button2.Enabled = true;
                    button1.Enabled = false;
                }
                if (Player1 < Player2)
                {   
                    button2.Enabled = false;
                    button1.Enabled = true;
                    button1.ForeColor = Color.Red;
                    button2.ForeColor = Color.Black;
                }
                if (Player1==Player2)
                {
                    button2.Enabled = false;
                    button1.Enabled = false;
                    double Player1Defense = double.Parse(left_side_defense.Text);
                    double Player2Defense = double.Parse(right_side_defense.Text);
                    if (Player1Defense<Player2Defense)
                    {
                        button2.ForeColor = Color.Red;
                        button1.ForeColor = Color.Black;
                        button2.Enabled = true;
                        button1.Enabled = false;
                    }
                    if (Player2Defense<Player1Defense)
                    {
                         button2.Enabled = false;
                         button1.Enabled = true;
                         button1.ForeColor = Color.Red;
                         button2.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception)
            {
              
            }
            
        }

        public void Player_1_EvadeBlock_Defense()
        {
            try
            {
                double left_evade = double.Parse(left_side_evade.Text);
                double right_evade = double.Parse(right_side_evade.Text);
                if (left_evade > right_evade)
                {
                    Left_Side_Generate_Attack_Calculation();
                }
                if (left_evade < right_evade)
                {
                    Left_Side_Generate_Attack_Calculation();
                }
                if (left_evade == right_evade)
                {
                    Left_Side_Generate_Attack_Calculation();
                }
            }
            catch (Exception)
            {

            }
        }

        public void Player_2_EvadeBlock_Defense()
        {
            try
            {
                double left_evade = double.Parse(left_side_evade.Text);
                double right_evade = double.Parse(right_side_evade.Text);

                if (left_evade > right_evade)
                {
                    Right_Side_Generate_Attack_Calculation();
                }
                if (left_evade < right_evade)
                {
                    Right_Side_Generate_Attack_Calculation();
                }
                if (left_evade == right_evade)
                {
                    Right_Side_Generate_Attack_Calculation();
                }
            }
            catch (Exception)
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (CharacterLeftSide.Text == "NINJA")
            {
                Left_Ninja_Special_Doubling_Attack(); // for ninja
                Draw();
                ColorComparisonEffect();
                Turns_Player1(); 
                button4.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = true;
                button2.ForeColor = Color.Black;
                button1.ForeColor = Color.Red;
                WarriorDefeatedFunction();
            }
            if (CharacterLeftSide.Text == "SAMURAI")
            {
                Left_Side_Generate_Attack_Calculation();
                Draw();
                ColorComparisonEffect();
                Turns_Player1();
                button4.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = true;
                button2.ForeColor = Color.Black;
                button1.ForeColor = Color.Red;
                WarriorDefeatedFunction();
            }
            if (CharacterLeftSide.Text == "BRAWLER")
            {
                Left_Side_Generate_Attack_Calculation();
                LeftBrawler_Special_Attribute_Calculations();
                RightBrawler_Special_Attribute_Calculations();
                Draw();
                ColorComparisonEffect();
                Turns_Player1();
                button4.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = true;
                button2.ForeColor = Color.Black;
                button1.ForeColor = Color.Red;
                WarriorDefeatedFunction();
            }
        }

        public void Turns_Player1()
        {
            try
            {
                int turnlabel = int.Parse(player1remaining_turn.Text);
                int result = 1 + int.Parse(turnlabel.ToString());
                player1remaining_turn.Text = result.ToString();
                if (int.Parse(player1remaining_turn.Text) == 30)
                {
                    button2.Enabled = false;
                }
            }
            catch (Exception)
            {

            }
        }

        public void Turns_Player2()
        {
            try
            {
                int turnlabel = int.Parse(player2remaining_turn.Text);
                int result = 1 + int.Parse(turnlabel.ToString());
                player2remaining_turn.Text = result.ToString();
                if (int.Parse(player2remaining_turn.Text) == 30)
                {
                    button1.Enabled = false;
                }
            }
            catch (Exception)
            {

            }
        }

        public void Draw()
        {
            try
            {
                //The max amount of turns is 30 per player
                int Turns_for_player1 = int.Parse(player1remaining_turn.Text);
                int Turns_for_player2 = int.Parse(player2remaining_turn.Text);
                if ((Turns_for_player1==30)&&(Turns_for_player2==30))
                {
                    MessageBox.Show("The Game is DRAW!");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button13.Visible = true;
                }
            }
            catch (Exception)
            { 

            }
        }

        public void WarriorDefeatedFunction() 
        {
            try
            {
                double LEFT_health = double.Parse(left_side_health.Text);
                double RIGHT_health = double.Parse(right_side_health.Text);
                if (LEFT_health <= 0)
                {
                    MessageBox.Show("Congratulations [PLAYER 2] -- You WON!");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button13.Visible = true;
                }
                if (RIGHT_health <= 0)
                {
                    MessageBox.Show("Congratulations [PLAYER 1] -- You WON!");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button13.Visible = true;
                }
            }
            catch (Exception)
            {

            }
           
        }

        //Special attributes of warriors:--------------------------------------------------------------------
        public void Right_Samurai_Special_by_Evade()
        {
            //When a samurai evades an attack there is a 10% chance of regaining 10 health. or 1 health
            if (CharacterRightSide.Text == "SAMURAI")
            {
                try
                {
                    double left_side_evade_get = double.Parse(left_side_evade.Text);
                    double right_side_evade_get = double.Parse(right_side_evade.Text);
                    if (left_side_evade_get<right_side_evade_get)
                    {
                        //evade for rightside plAYER 2   health
                        double right_health = double.Parse(right_side_health.Text);
                        double newhealth_result = 1 + right_health;
                        right_side_health.Text = newhealth_result.ToString();
                    }
                }
                catch (Exception)
                {
                    
                   //throw;
                }
            }

        }
        public void Left_Samurai_Special_by_Evade()
        {
            //When a samurai evades an attack there is a 10% chance of regaining 10 health. or 1 health
            if (CharacterRightSide.Text == "SAMURAI")
            {
                try
                {
                    double left_side_evade_get = double.Parse(left_side_evade.Text);
                    double right_side_evade_get = double.Parse(right_side_evade.Text);
                    if (left_side_evade_get > right_side_evade_get)
                    {
                        //evade for rightside plAYER 1   health
                        double left_health = double.Parse(left_side_health.Text);
                        double newhealth_result = 1 + left_health;
                        left_side_health.Text = newhealth_result.ToString();
                    }
                }
                catch (Exception)
                {

                    //throw;
                }
            }

        }
        public void Left_Ninja_Special_Doubling_Attack()
        {
            if (CharacterLeftSide.Text == "NINJA")
            {
                try
                {
                    //With each attack there is a 5% chance of doubling the attack strength.
                    double left_attack_strength = double.Parse(left_side_attack.Text);
                    double twice_attack = ((left_attack_strength) * .05) + left_attack_strength;
                    MessageBox.Show("NINJA ATTACK FROM: " + left_attack_strength.ToString() + "\nNINJA ATTACK Became: " + twice_attack.ToString());
                    Left_New_Attack_Ninja.Text = twice_attack.ToString();
                    Left_Side_Generate_Attack_Calculation();
                }
                catch (Exception)
                {

                }
            }
        }
        public void Right_Ninja_Special_Doubling_Attack()
        {
            if (CharacterRightSide.Text == "NINJA")
            {
                try
                {
                    //With each attack there is a 5% chance of doubling the attack strength.
                    double right_attack_strength = double.Parse(right_side_attack.Text);
                    double twice_attack = ((right_attack_strength) * .05) + right_attack_strength;
                    MessageBox.Show("NINJA ATTACK FROM: " + right_attack_strength.ToString() + "\nNINJA ATTACK Became: " + twice_attack.ToString());
                    Right_New_Attack_Ninja.Text = twice_attack.ToString();
                    Right_Side_Generate_Attack_Calculation();
                }
                catch (Exception)
                {

                }
            }
        }
        public void RightBrawler_Special_Attribute()
        {
             //When a brawler’s health falls to less than 20% their defence increases by 10.
            try
            {
                if (CharacterRightSide.Text == "BRAWLER")
                {
                    Original_Health.Text = right_side_health.Text;
                }
            }
            catch (Exception)
            {

            }

        }
        public void LeftBrawler_Special_Attribute()
        {
            //When a brawler’s health falls to less than 20% their defence increases by 10.
            try
            {
                if (CharacterLeftSide.Text == "BRAWLER")
                {
                    Left_Original_Health.Text = left_side_health.Text;
                }
            }
            catch (Exception)
            {

            }

        }

        public void RightBrawler_Special_Attribute_Calculations()
        {
            try
            {
                if (CharacterRightSide.Text == "BRAWLER")
                {
                    //+Brawler ? When a brawler’s health falls to less than 20% their defence increases by 10.
                    double dbl = 0.20D;
                    decimal dec = (decimal)dbl;
                    double OriginalHealth = double.Parse(Original_Health.Text);
                    decimal decs = (decimal)OriginalHealth;
                    decimal result = decs * dec;
                    decimal LessThan_Original = decs - result;
                    Brawler_MinimumHealth.Text = LessThan_Original.ToString();
                    if (double.Parse(right_side_health.Text) < double.Parse(Brawler_MinimumHealth.Text))
                    {
                        try
                        {
                            MessageBox.Show("Player 2 [Defense] Increases by 10!");
                            double Original_Defense = double.Parse(right_side_defense.Text);
                            double AdditionalDefense = 10 + Original_Defense;
                            right_side_defense.Text = AdditionalDefense.ToString();
                            Original_Health.Text = right_side_health.Text;
                            string health_another_percentage = Original_Health.Text;
                            double cdbl = 0.20D;
                            decimal cdec = (decimal)cdbl;
                            double cOriginalHealth = double.Parse(health_another_percentage.ToString());
                            decimal cdecs = (decimal)cOriginalHealth;
                            decimal cresult = cdecs * cdec;
                            decimal cLessThan_Original = cdecs - cresult;
                            Brawler_MinimumHealth.Text = cLessThan_Original.ToString();
                            ColorComparisonEffect();
                        }
                        catch (Exception)
                        {
                           
                        }
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        public void LeftBrawler_Special_Attribute_Calculations()
        {
            try
            {
                if (CharacterLeftSide.Text == "BRAWLER")
                {
                    //+Brawler ? When a brawler’s health falls to less than 20% their defence increases by 10.
                    double dbl = 0.20D;
                    decimal dec = (decimal)dbl;
                    double OriginalHealth = double.Parse(Left_Original_Health.Text);
                    decimal decs = (decimal)OriginalHealth;
                    decimal result = decs * dec;
                    decimal LessThan_Original = decs - result;
                    Brawler_MinimumHealth_Left.Text = LessThan_Original.ToString();
                    if (double.Parse(left_side_health.Text) < double.Parse(Brawler_MinimumHealth_Left.Text))
                    {
                        try
                        {
                            MessageBox.Show("Player 1 [Defense] Increases by 10!");
                            double Original_Defense = double.Parse(left_side_defense.Text);
                            double AdditionalDefense = 10 + Original_Defense;
                            left_side_defense.Text = AdditionalDefense.ToString();
                            Left_Original_Health.Text = left_side_health.Text;
                            string chealth_another_percentage = Left_Original_Health.Text;
                            double cdbl = 0.20D;
                            decimal cdec = (decimal)cdbl;
                            double cOriginalHealth = double.Parse(chealth_another_percentage.ToString());
                            decimal cdecs = (decimal)cOriginalHealth;
                            decimal cresult = cdecs * cdec;
                            decimal cLessThan_Original = cdecs - cresult;
                            Brawler_MinimumHealth_Left.Text = cLessThan_Original.ToString();
                            ColorComparisonEffect();
                        }
                        catch (Exception)
                        {

                        }
                    }

                }
            }
            catch (Exception)
            {

            }
        }
        public void FirstAttack()
        {
            try
            {
                double Player1 = double.Parse(left_side_speed.Text);
                double Player2 = double.Parse(right_side_speed.Text);
                if (Player1 > Player2)
                {
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Player 1 takes the first attack!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                   
                }
                if (Player1 < Player2)
                {
                    DialogResult okay = new DialogResult();
                    okay = MessageBox.Show("Player 2 takes the first attack! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (okay == DialogResult.OK)
                    {
                        Application.DoEvents();
                    }
                   
                }
                if (Player1 == Player2)
                {
                    double Player1Defense = double.Parse(left_side_defense.Text);
                    double Player2Defense = double.Parse(right_side_defense.Text);
                    if (Player1Defense < Player2Defense)
                    {
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("Player 1 takes the first attack! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
                        }
                    }
                    if (Player2Defense < Player1Defense)
                    {
                        DialogResult okay = new DialogResult();
                        okay = MessageBox.Show("Player 2 takes the first attack! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (okay == DialogResult.OK)
                        {
                            Application.DoEvents();
                        }
                    }
                   
                }
            }
            catch (Exception)
            {

            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            listBox1.Enabled = false;
            button10.Enabled = false;
            Right_Attack_Activate_First();
            Activate_Generate();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button9.Enabled = false;
            listBox2.Enabled = false;
            Left_Attack_Activate_First();
            Activate_Generate();
            

        }
        public void Right_Attack_Activate_First()
        {
            try
            {
                attack_right_activate = 1;
            }
            catch (Exception)
            {
                
            }
        }
        public void Left_Attack_Activate_First()
        {
            try
            {
                attack_left_activate = 1;
            }
            catch (Exception)
            {

            }
        }
        public void Activate_Generate()
        {
            try
            {
                double genarate = attack_left_activate + attack_right_activate;
                if (genarate == attack_Activate)
                {
                    FirstAttack();
                    Attack();
                }
            }
            catch (Exception)
            {

            }
        }
        public void Left_Side_Generate_Attack_Calculation()
        {
            if (CharacterLeftSide.Text != "NINJA")
            {
                try
                {
                    double lhealth = double.Parse(left_side_health.Text);
                    double lattack = double.Parse(left_side_attack.Text);
                    double ldefense = double.Parse(left_side_defense.Text);
                    double lspeed = double.Parse(left_side_speed.Text);
                    double levade = double.Parse(left_side_evade.Text);

                    double rhealth = double.Parse(right_side_health.Text);
                    double rattack = double.Parse(right_side_attack.Text);
                    double rdefense = double.Parse(right_side_defense.Text);
                    double rspeed = double.Parse(right_side_speed.Text);
                    double revade = double.Parse(right_side_evade.Text);

                    //Calculations here --------------------------------------
                    //logic
                    //Damage = (ATTACK - oppositions DEFENCE);
                    //Oppositions New Health = (Oppositions health - Damage);

                    double Opposition_Damage = (lattack - rdefense) * revade;
                    double Oppositions_New_Health = rhealth - Opposition_Damage;
                    MessageBox.Show("Oppositions Health: " + rhealth.ToString() + "\nDamage to Health: " + Opposition_Damage.ToString() + "\n" + "Remaining Health: " + Oppositions_New_Health.ToString());
                    right_side_health.Text = Oppositions_New_Health.ToString();

                }
                catch (Exception)
                {

                }
            }
            if (CharacterLeftSide.Text == "NINJA")
            {
                try
                {

                    double lhealth = double.Parse(left_side_health.Text);
                    double lattack = double.Parse(left_side_attack.Text);
                    double new_lattack = double.Parse(Left_New_Attack_Ninja.Text);
                    double ldefense = double.Parse(left_side_defense.Text);
                    double lspeed = double.Parse(left_side_speed.Text);
                    double levade = double.Parse(left_side_evade.Text);

                    double rhealth = double.Parse(right_side_health.Text);
                    double rattack = double.Parse(right_side_attack.Text);
                    double rdefense = double.Parse(right_side_defense.Text);
                    double rspeed = double.Parse(right_side_speed.Text);
                    double revade = double.Parse(right_side_evade.Text);

                    //Calculations here --------------------------------------
                    //logic
                    //Damage = (ATTACK - oppositions DEFENCE);
                    //Oppositions New Health = (Oppositions health - Damage);

                    double Opposition_Damage = (new_lattack - rdefense) * revade;
                    double Oppositions_New_Health = rhealth - Opposition_Damage;
                    MessageBox.Show("Oppositions Health: " + rhealth.ToString() + "\nDamage to Health: " + Opposition_Damage.ToString() + "\n" + "Remaining Health: " + Oppositions_New_Health.ToString());
                    right_side_health.Text = Oppositions_New_Health.ToString();

                }
                catch (Exception)
                {
                    
                }
            }
        }

        public void Right_Side_Generate_Attack_Calculation()
        {
            if (CharacterRightSide.Text != "NINJA")
            {
                try
                {
                    double lhealth = double.Parse(left_side_health.Text);
                    double lattack = double.Parse(left_side_attack.Text);
                    double ldefense = double.Parse(left_side_defense.Text);
                    double lspeed = double.Parse(left_side_speed.Text);
                    double levade = double.Parse(left_side_evade.Text);

                    double rhealth = double.Parse(right_side_health.Text);
                    double rattack = double.Parse(right_side_attack.Text);
                    double rdefense = double.Parse(right_side_defense.Text);
                    double rspeed = double.Parse(right_side_speed.Text);
                    double revade = double.Parse(right_side_evade.Text);

                    //Calculations here --------------------------------------
                    //logic
                    //Damage = (ATTACK - oppositions DEFENCE);
                    //Oppositions New Health = (Oppositions health - Damage);

                    double Opposition_Damage = (rattack - ldefense) * levade;
                    double Oppositions_New_Health = lhealth - Opposition_Damage;
                    MessageBox.Show("Oppositions Health: " + lhealth.ToString() + "\nDamage to Health: " + Opposition_Damage.ToString() + "\n" + "Remaining Health: " + Oppositions_New_Health.ToString());
                    left_side_health.Text = Oppositions_New_Health.ToString();



                }
                catch (Exception)
                {

                }
            }
            if (CharacterRightSide.Text == "NINJA")
            {
                try
                {
                    double lhealth = double.Parse(left_side_health.Text);
                    double lattack = double.Parse(left_side_attack.Text);
                    double ldefense = double.Parse(left_side_defense.Text);
                    double lspeed = double.Parse(left_side_speed.Text);
                    double levade = double.Parse(left_side_evade.Text);

                    double rhealth = double.Parse(right_side_health.Text);
                    double rattack = double.Parse(right_side_attack.Text);
                    double new_rattack = double.Parse(Right_New_Attack_Ninja.Text); // use as default attack for Ninja
                    double rdefense = double.Parse(right_side_defense.Text);
                    double rspeed = double.Parse(right_side_speed.Text);
                    double revade = double.Parse(right_side_evade.Text);

                    //Calculations here --------------------------------------
                    //logic
                    //Damage = (ATTACK - oppositions DEFENCE);
                    //Oppositions New Health = (Oppositions health - Damage);

                    double Opposition_Damage = (new_rattack - ldefense) * levade;
                    double Oppositions_New_Health = lhealth - Opposition_Damage;
                    MessageBox.Show("Oppositions Health: " + lhealth.ToString() + "\nDamage to Health: " + Opposition_Damage.ToString() + "\n" + "Remaining Health: " + Oppositions_New_Health.ToString());
                    left_side_health.Text = Oppositions_New_Health.ToString();

                }
                catch (Exception)
                {
                    
                }
            }

        }
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(right_side_health.Text);
                double res = x - 1;
                right_side_health.Text = res.ToString();
            }
            catch (Exception)
            { 

            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(left_side_health.Text);
                double res = x - 1;
                left_side_health.Text = res.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void CharacterLeftSide_Click(object sender, EventArgs e)
        {

        }

    }
}

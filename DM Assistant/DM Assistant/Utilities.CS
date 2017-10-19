using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using DM_Assistant.Entities;
using System.Reflection;

namespace DM_Assistant
{
    public static class Utilities
    {
        public static void SaveFile(Player newPlayer)
        {
            try
            {
                SaveFileDialog SaveLocation = new SaveFileDialog();
                SaveLocation.ShowDialog();
                if (SaveLocation.FileName != "")
                {
                    //Number of skills
                    int CONSKILLSNUM = 24;
                    //makes the file and sets the save line order
                    StreamWriter PlayerSheet = new StreamWriter(SaveLocation.FileName);

                    PropertyInfo[] playerInfo = typeof(Player).GetProperties();
                    foreach (PropertyInfo property in playerInfo)
                    {
                        MessageBox.Show(property.Name + ": " + property.GetValue(newPlayer).ToString());
                    }
                    PlayerSheet.WriteLine(newPlayer.Name);
                    PlayerSheet.WriteLine(newPlayer.EXP);
                    PlayerSheet.WriteLine(newPlayer.Race);
                    PlayerSheet.WriteLine(newPlayer.Class);
                    PlayerSheet.WriteLine(newPlayer.Background);
                    PlayerSheet.WriteLine(newPlayer.Alignment);
                    PlayerSheet.WriteLine(newPlayer.STR);
                    PlayerSheet.WriteLine(newPlayer.DEX);
                    PlayerSheet.WriteLine(newPlayer.CON);
                    PlayerSheet.WriteLine(newPlayer.INT);
                    PlayerSheet.WriteLine(newPlayer.WIS);
                    PlayerSheet.WriteLine(newPlayer.CHA);
                    PlayerSheet.WriteLine(newPlayer.Speed);
                    PlayerSheet.WriteLine(newPlayer.AC);
                    PlayerSheet.WriteLine(newPlayer.HP);
                    PlayerSheet.WriteLine(newPlayer.Feats);
                    PlayerSheet.WriteLine(newPlayer.Traits);
                    PlayerSheet.WriteLine(newPlayer.Proficiencies);
                    PlayerSheet.WriteLine(newPlayer.Languages);
                    PlayerSheet.WriteLine(newPlayer.PersonalityTraits);
                    PlayerSheet.WriteLine(newPlayer.Ideals);
                    PlayerSheet.WriteLine(newPlayer.Bonds);
                    PlayerSheet.WriteLine(newPlayer.Flaws);
                    PlayerSheet.WriteLine(newPlayer.Weapons);
                    PlayerSheet.WriteLine(newPlayer.Currency);
                    PlayerSheet.WriteLine(newPlayer.Treasures);
                    PlayerSheet.WriteLine(newPlayer.Armor);
                    PlayerSheet.WriteLine(newPlayer.Ammunition);
                    PlayerSheet.WriteLine(newPlayer.Other);
                    PlayerSheet.WriteLine(newPlayer.Maker);
                    //Saves the Skill list
                    for (int I = 0; I < CONSKILLSNUM; I++)
                    {
                        PlayerSheet.WriteLine(newPlayer.GetSkillArray(I) ? "True" : "False");
                    }
                    PlayerSheet.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

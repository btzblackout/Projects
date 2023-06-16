using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace HeroMaker
{
    public class SuperHero
    {
        //Declare variables.
        private string name;
        private string sex;
        private string movement;
        private string headquarters;
        private int speed;
        private int stamina;
        private int strength;
        private int darkSide;
        private int yearsExperience;
        private DateTime birthDate;
        private List<string> attributes;
        private Bitmap heroPortrait;
        private Color capeColor;

        //Constructor.
        public SuperHero(string name, List<string> attributes, string sex, string movement, string headquarters, Bitmap heroPortrait, Color capeColor, int speed, int stamina, int strength, int darkSide, DateTime birthDate, int yearsExperience)
        {
            this.name = name;
            this.attributes = attributes;
            this.sex = sex;
            this.movement = movement;
            this.headquarters = headquarters;
            this.heroPortrait = heroPortrait;
            this.capeColor = capeColor;
            this.speed = speed;
            this.stamina = stamina;
            this.strength = strength;
            this.darkSide = darkSide;
            this.birthDate = birthDate;
            this.yearsExperience = yearsExperience;
        }

        //Public getters 
        public string getName()
        {
            return this.name;
        }
        public List<string> getAttributes()
        {
            return this.attributes;
        }
        public string getSex()
        {
            return this.sex;
        }
        public string getMovement()
        {
            return movement;
        }
        public string getHeadquarters()
        {
            return headquarters;
        }
        public Bitmap getHeroPortrait()
        {
            return this.heroPortrait;
        }
        public Color getCapeColor()
        {
            return this.capeColor;
        }

        //To string method for printing the object.
        public string toString()
        {
            string att = "";
            //Take an empty string, parse through the list of attributes and add all of them to a string with a ", " inbetween.
            foreach(string attribute in attributes)
            {
                att = att + attribute + ", ";
            }
            //The above foreach adds a ", " to the end of the string so these two remove it.
            att = att.Remove(att.Length - 1);
            att = att.Remove(att.Length - 1);
            //Check for if male vs female
            if (sex == "Male")
            {
                return (name + "'s powers are: " + att + ". His hero headquarters is at: " +
                    headquarters + ". His movement style is: " + movement + ". His speed is: " + 
                    speed + ", stamina is: " + stamina + ", and strength is: " + strength +
                    ". His dark side propensity is: " + darkSide + ". His birthdate is: " + birthDate + 
                    ". He has " + yearsExperience + " years of experience being a super hero.");
            }
            else
            {
                return (name + "'s powers are: " + att + ". Her hero headquarters is at: " +
                    headquarters + ". Her movement style is: " + movement + ". Her speed is: " +
                    speed + ", stamina is: " + stamina + ", and strength is: " + strength + 
                    ". Her dark side propensity is: " + darkSide + ". Her birthdate is: " + birthDate + 
                    ". She has " + yearsExperience + " years of experience being a super hero.");
            }
            
        }
        

    }
}

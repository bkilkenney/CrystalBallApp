using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalBallApp.Models
{
    public class CrystalBall
    {


        //create an array of strings for responses
        //Get random number

        public string getResponse()
        {
            string[] responses = { "Indians will win the World Series", "Cavs will win backt-to-back titles", "Browns will win the SuperBowl", "Browns will never win the SuperBowl" };
            //get random number object
            Random rando = new Random();   //Creating the object of random class
            int num = rando.Next(0, responses.Length);  //0 is starting position in the array, after comma is how far you want to go
            return responses[num];



        }




    }
}
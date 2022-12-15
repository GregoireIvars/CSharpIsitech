using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApi.Context;


namespace MyApi { 

    public class Entity //  la class mère 
							
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int healthPoint { get; set; }
        public int minDamage { get; set; }
        public int maxDamage { get; set; }

        public  Entity( string name)
        {
            this.ID = ID;
            this.name = name;
            this.healthPoint = healthPoint;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
        }
    }
}
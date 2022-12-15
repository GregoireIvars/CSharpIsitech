using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApi.Context;
namespace MyApi { 

    
    public class Player : Entity //Player hérite de la class Entity
    {
        public string name { get; set; }
        public int lvl { get; set; }
        public int exp { get; set; }
        public int nbrKill { get; set; }
        


        public Player( string name) : base(name) 
        {
            
            this.name = "Player";
            this.lvl = lvl;
            this.exp = exp;
            this.nbrKill= nbrKill;
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApi.Context;
namespace MyApi 
{
    public class Monster : Entity
    {
        public int idMonster{ get; set; }
        public string name { get; set; }

        public Monster(string name ) : base(name)
        {
            this.idMonster = ID;
            this.name = "Bear";
        }
    }
}  

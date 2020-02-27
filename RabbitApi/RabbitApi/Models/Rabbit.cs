using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace RabbitApi.Models
{
    public class Rabbit
    {
        public enum FurColors
        {
            White=1, 
            Brown=2 ,
            Black=3,
            Grey=4
        }

        public enum EyeColors
        {
            Blue=1,
            Black=2,
            Red=3
        }

        public enum Genders
        {
            Male=1,
            Female=2
        }

        [Required]
        [MinLength(2, ErrorMessage = "Name must be at least 2 chars long.")]
        [MaxLength(10, ErrorMessage = "Name can't have more than 10 chars.")]

        public string Name { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Rabbit must be at least 1 year old.")]
        public int Age { get; private set; }

        [Required]
        [EnumDataType(typeof(FurColors))]
        public FurColors FurColor { get; private set; }


        [Required]
        [EnumDataType(typeof(EyeColors))]
        public EyeColors EyeColor { get; private set; }


        [Required]
        [EnumDataType(typeof(Genders))]
        public Genders Gender { get; private set; }
        public int Id { get; private set; }

        static Random randomNumber = new Random(1000);
        public Rabbit(string name, int age, FurColors furcolor, EyeColors eyecolor, Genders gender)
        {
            Name = name;
            Age = age;
            FurColor = furcolor;
            EyeColor = eyecolor;
            Gender = gender;
            Id = Convert.ToInt32(randomNumber.Next());

        }
    }
}



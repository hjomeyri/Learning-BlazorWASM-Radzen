using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Tools;
using Resources;

namespace Models.Base
{
    public abstract class Entity : object
    {
        public Entity()
        {
            Id = Guid.NewGuid();
            InsertDateTime = Utility.Now;
        }

        // **********
        [Key]
        [DatabaseGenerated
            (DatabaseGeneratedOption.None)]
        [Display
        (ResourceType = typeof(DataDictionary),
            Name = nameof(DataDictionary.Id))]
        public Guid Id { get; set; }
        // **********

        // **********
        [Display
        (ResourceType = typeof(DataDictionary),
            Name = nameof(DataDictionary.InsertDateTime))]
        public DateTime InsertDateTime { get; set; }

        // **********
    }
}
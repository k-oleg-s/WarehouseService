using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseService.Data;
[Table("ItemGroup")]
public  class ItemGroup
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Column, StringLength(50)]
    public string GroupName { get; set; }


    // Для получения списка
    //[InverseProperty(nameof(Item.itemGroup))]
    //public virtual ICollection<Item> Items { get; set; } = new HashSet<Item>();
}

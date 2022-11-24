using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseService.Data;
[Table("Item")]
public  class Item
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column,StringLength(50)]
    public string ItemCode { get; set; }

    [Column(TypeName ="nvarchar(128)")]
    public string Description { get; set; }

    [ForeignKey(nameof(itemGroup))]
    public Guid ItemGroupId { get; set; }

    public ItemGroup itemGroup { get; set; }

    // Для получения списка
    //public virtual ICollection<Item> Items { get; set; } = new HashSet<Item>();

}

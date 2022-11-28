using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseService.Data;
[Table("Stock")]
public  class Stock
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }


    [ForeignKey(nameof(item))]
    public int ItemId { get; set; }
    public Item item {get; set; }

    [ForeignKey(nameof(location))]
    public int LocationId { get; set; }
    public Location location {get; set; }


    [Column(TypeName ="int")]
    public int Qty { get; set; }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Models;

// Generic programlama
public abstract class EntityBase<TId>
{
    // Guid
    public TId Id { get; set; }
}

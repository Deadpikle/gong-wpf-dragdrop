using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongSolutions.Wpf.DragDrop
{
    /// <summary>
    /// Interface for objects that sort an IEnumerable of drag drop items
    /// </summary>
    public interface IDragEnumerableSorter
    {
        /// <summary>
        /// Sort the IEnumerable of items
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        IEnumerable SortDragDropItems(IEnumerable items);
    }
}
